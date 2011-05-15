open System
open Microsoft.FSharp.Text.Lexing

open FSExternHelper.HeaderSyntax
open FSExternHelper.Lexer
open FSExternHelper.Parser

let llvmDLLName = "LLVM-2.9.dll"
let llvmCPrefix = "LLVM"

let toFSharpFunName (cFunName : string) =
    if cFunName.StartsWith llvmCPrefix then
        let baseName = cFunName.Substring llvmCPrefix.Length
        let fstChar = (baseName.Substring (0, 1)).ToLower ()
        fstChar + baseName.Substring 1
    else
        failwith ("unexpected function name: " + cFunName)

let toFSharpDataName (cDataName : string) =
    if cDataName.StartsWith llvmCPrefix then
        cDataName.Substring llvmCPrefix.Length
    else
        failwith ("unexpected data name: " + cDataName)

// indented fprintf
let inline ifprintf depth out fmt =
    for i = 0 to depth - 1 do
        fprintf out "    "
    fprintf out fmt

// indented fprintfn
let inline ifprintfn depth out fmt =
    for i = 0 to depth - 1 do
        fprintf out "    "
    fprintfn out fmt

let toFSharpSource (moduleName : string) (out : System.IO.TextWriter) (defs : CDef list) =

    let rec go (structRefs : Set<string>) (enums : Set<string>) (defs : CDef list) =
        match defs with
        | [] -> ()
        | def :: defTail ->
            match def with
            | CFuncDef (retType, fName, fArgs) ->
                let typeToStr (cType : CFullType) =
                    let pointerAdjust ptrDepth typeStr =
                        match ptrDepth with
                        | 0 -> typeStr
                        | 1 -> typeStr + "*"
                        | _ -> failwith (sprintf "don't know how to deal with %i pointer depth" ptrDepth)
                    let defPtrAdj = pointerAdjust cType.pointerDepth
                    
                    match cType.baseType with
                    | GeneralType "LLVMBool" -> defPtrAdj "bool"
                    | GeneralType typeName ->
                        if enums.Contains typeName then
                            defPtrAdj (sprintf "int (* %s *)" (cType.ToString ()))
                        elif typeName.EndsWith "Ref" then
                            sprintf "void* (* %s *)" (cType.ToString ()) // TODO
                        else
                            failwith (sprintf "don't know how to deal with: %s" typeName)
                    | StructType typeName -> failwith "this should never happen"
                    | IntType -> defPtrAdj "int"
                    | VoidType -> defPtrAdj "void"
                    | CharType ->
                        if cType.pointerDepth = 0 then
                            "char"
                        elif cType.pointerDepth = 1 then
                            pointerAdjust (cType.pointerDepth - 1) "string"
                        else
                            "void*"
                    | UnsignedIntType -> defPtrAdj "uint32"
                    | UnsignedLongLongType -> defPtrAdj "uint64"
                    | LongLongType -> defPtrAdj "int64"
                    | UnsignedByteType -> defPtrAdj "uint8"
                    | DoubleType -> defPtrAdj "double"

                // the native function def
                fprintfn out "[<DllImport(\"%s\", EntryPoint=\"%s\")>]" llvmDLLName fName
                fprintf out "extern %s private %sNative(" (typeToStr retType) (toFSharpFunName fName)
                let fArgs =
                    Array.ofList fArgs
                    |> Array.mapi (fun i a -> (fst a, match snd a with Some x -> x | None -> sprintf "arg%i" i))
                if fArgs.Length >= 1 then
                    out.WriteLine ()
                    for i = 0 to fArgs.Length - 2 do
                        let cType, name = fArgs.[i]
                        ifprintfn 1 out "%s %s," (typeToStr cType) name
                    let cType, name = fArgs.[fArgs.Length - 1]
                    ifprintfn 1 out "%s %s)" (typeToStr cType) name
                else
                    out.WriteLine ')'

                // the more F# friendly function def
                if fArgs.Length >= 1 then
                    fprintf out "let %s " (toFSharpFunName fName)
                    for i = 0 to fArgs.Length - 2 do
                        fprintf out "_%s " (snd fArgs.[i])
                    fprintfn out "_%s =" (snd fArgs.[fArgs.Length - 1])
                else
                    fprintfn out "let %s () =" (toFSharpFunName fName)
                let toNativeParam (arg : CFullType * string) =
                    let cType, name = arg
                    let name = "_" + name
                    if cType.pointerDepth = 0 then
                        match cType.baseType with
                        | GeneralType "LLVMBool" -> name
                        | GeneralType typeName ->
                            if enums.Contains typeName then
                                //sprintf "(enum<%s> %s)" (toFSharpDataName typeName) name
                                sprintf "(int (%s : %s))" name (toFSharpDataName typeName)
                            elif typeName.EndsWith "Ref" then
                                sprintf "(match %s with %s ptr -> ptr)" name (toFSharpDataName typeName)
                            else
                                failwith (sprintf "don't know how to deal with: %s" typeName)
                        | _ -> name
                    else
                        name
                let nativeFunCall () =
                    if fArgs.Length >= 1 then
                        fprintf out "%sNative (" (toFSharpFunName fName)
                        for i = 0 to fArgs.Length - 2 do
                            fprintf out "%s, " (toNativeParam fArgs.[i])
                        fprintf out "%s)" (toNativeParam fArgs.[fArgs.Length - 1])
                    else
                        fprintf out "%sNative ()" (toFSharpFunName fName)
                if retType.pointerDepth = 0 then
                    match retType.baseType with
                    | GeneralType "LLVMBool" ->
                        ifprintf 1 out ""
                        nativeFunCall ()
                    | GeneralType typeName ->
                        if enums.Contains typeName then
                            ifprintf 1 out "enum<%s> (" (toFSharpDataName typeName)
                            nativeFunCall ()
                            fprintf out ")"
                        elif typeName.EndsWith "Ref" then
                            ifprintf 1 out "%s (" (toFSharpDataName typeName)
                            nativeFunCall ()
                            fprintf out ")"
                        else
                            failwith (sprintf "don't know how to deal with: %s" typeName)
                    | _ ->
                        ifprintf 1 out ""
                        nativeFunCall ()
                else
                    ifprintf 1 out ""
                    nativeFunCall ()
                
                out.WriteLine ()
                out.WriteLine ()
                
                go structRefs enums defTail
            
            | CEnumDef (enumName, enumVals) ->
                fprintfn out "type %s =" (toFSharpDataName enumName)
                let mutable nextEnumVal = 0
                for eValName, maybeEnumVal in enumVals do
                    match maybeEnumVal with
                    | Some enumVal -> nextEnumVal <- enumVal
                    | None -> ()
                    
                    ifprintfn 1 out "| %s = %i" (toFSharpDataName eValName) nextEnumVal
                    nextEnumVal <- nextEnumVal + 1
                out.WriteLine ()
                
                go structRefs (enums.Add enumName) defTail

            | CTypeAlias ({CFullType.baseType = StructType _; CFullType.pointerDepth = 1}, name) ->
                let dataName = toFSharpDataName name
                fprintfn out "type %s = %s of nativeint" dataName dataName
                out.WriteLine ()
                
                go (structRefs.Add name) enums defTail

            | _ -> go structRefs enums defTail

    fprintfn out "module %s" moduleName
    out.WriteLine ()
    fprintfn out "open System.Runtime.InteropServices"
    out.WriteLine ()
    
    go Set.empty Set.empty defs

[<EntryPoint>]
let main (args : string array) =
    let lexbuf = LexBuffer<_>.FromTextReader stdin
    let parseResult = start tokenize lexbuf
    toFSharpSource "LLVM.NativeInterface.Core" stdout parseResult
    
    // Exit code
    0

