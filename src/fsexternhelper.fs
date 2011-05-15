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

// indented fprintfn
let ifprintfn depth out fmt =
    for i = 0 to depth - 1 do
        fprintf out "    "
    
    fprintfn out fmt

let toFSharpSource (moduleName : string) (out : System.IO.TextWriter) (defs : CDef list) =

    let rec go (enums : Set<string>) (defs : CDef list) =
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
                            defPtrAdj "int"
                        elif typeName.EndsWith "Ref" then
                            "void*" // TODO
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
                
                let argsToStr args =
                    let argToStr argIndex = function
                        | (cType, Some name) ->
                            sprintf "%s %s" (typeToStr cType) name
                        | (cType, None) ->
                            sprintf "%s arg%i" (typeToStr cType) argIndex
                    let argStrs = List.mapi argToStr args
                    String.Join (", ", Array.ofList argStrs)
                
                fprintfn out "[<DllImport(\"%s\", EntryPoint=\"%s\")>]" llvmDLLName fName
                fprintfn out "extern %s %s(%s)" (typeToStr retType) (toFSharpFunName fName) (argsToStr fArgs)
                out.WriteLine ()
                
                go enums defTail
            
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
                
                go (enums.Add enumName) defTail

            | _ -> go enums defTail

    fprintfn out "module %s" moduleName
    out.WriteLine ()
    fprintfn out "open System.Runtime.InteropServices"
    out.WriteLine ()
    
    go Set.empty defs

[<EntryPoint>]
let main (args : string array) =
    let lexbuf = LexBuffer<_>.FromTextReader stdin
    let parseResult = start tokenize lexbuf
    toFSharpSource "LLVM.NativeInterface.Core" stdout parseResult
    
    // Exit code
    0

