module LLVM.Extra

open LLVM.Generated.Core
open LLVM.Core

let rec private typeToStringBuilder (modRef : ModuleRef) (tyRef : TypeRef) =
    let newStrBldr (s : string) = new System.Text.StringBuilder(s)
    let withElemTySB (s : string) =
        let sb = newStrBldr s
        sb.Append '<' |> ignore
        let elemTySb = typeToStringBuilder modRef (getElementType tyRef)
        sb.Append (elemTySb : System.Text.StringBuilder) |> ignore
        sb.Append '>'

    match getTypeKind tyRef with
    | TypeKind.VoidTypeKind      -> newStrBldr "void"
    | TypeKind.FloatTypeKind     -> newStrBldr "float"
    | TypeKind.DoubleTypeKind    -> newStrBldr "double"
    | TypeKind.X86_FP80TypeKind  -> newStrBldr "X86 FP80"
    | TypeKind.FP128TypeKind     -> newStrBldr "FP 128"
    | TypeKind.PPC_FP128TypeKind -> newStrBldr "PPC FP 128"
    | TypeKind.LabelTypeKind     -> newStrBldr "Label"
    | TypeKind.IntegerTypeKind   ->
        newStrBldr("int").Append(getIntTypeWidth tyRef)
    | TypeKind.FunctionTypeKind  ->
        let sb = newStrBldr "(fun "
        let argTys = getParamTypes tyRef
        for i = 0 to argTys.Length - 1 do
            if i >= 1 then
                sb.Append(", ") |> ignore
            sb.Append(typeToStringBuilder modRef argTys.[i]) |> ignore
        sb.Append "->" |> ignore
        sb.Append(typeToStringBuilder modRef (getReturnType tyRef)).Append(")")
    | TypeKind.MetadataTypeKind  -> newStrBldr "Metadata"
    | TypeKind.X86_MMXTypeKind   -> newStrBldr "X86 MMX"
    | TypeKind.ArrayTypeKind     -> withElemTySB "Array"
    | TypeKind.PointerTypeKind   -> withElemTySB "Pointer"
    | TypeKind.VectorTypeKind    -> withElemTySB "Vector"
    | TypeKind.StructTypeKind    ->
        match getStructName tyRef with
        | null | "" ->
            let sb = newStrBldr "struct {"
            let structElemTys = getStructElementTypes tyRef
            for i in 0 .. structElemTys.Length - 1 do
                sb.Append (typeToStringBuilder modRef structElemTys.[i]) |> ignore
                sb.Append ';' |> ignore
                let isLastElem = i = structElemTys.Length - 1
                if not isLastElem then
                    sb.Append ' ' |> ignore
            sb.Append '}'
        | name -> new System.Text.StringBuilder(name)
    | tk ->
        failwithf "unhandled type kind: %A" tk

let typeToString (modRef : ModuleRef) (tyRef : TypeRef) =
    (typeToStringBuilder modRef tyRef).ToString ()

let buildCopy
        (moduleRef : ModuleRef)
        (bldr : BuilderRef)
        (dest : ValueRef)
        (src : ValueRef)
        (isVolatile : bool)
        : unit =

    let destTy = typeOf dest
    let srcTy = typeOf src
    match getTypeKind destTy, getTypeKind srcTy with
    | TypeKind.PointerTypeKind, TypeKind.PointerTypeKind ->
        // we must declare the memcpy intrinsic as:
        // declare void @llvm.memcpy.p0i8.p0i8.i64(
        //    i8* <dest>, i8* <src>, i64 <len>, i32 <align>, i1 <isvolatile>)
        let bytePtr = pointerType (int8Type()) 0u
        let memcpyFuncTy = functionType (voidType()) [|bytePtr; bytePtr; int64Type(); int32Type(); int1Type()|]
        let memcpy = addFunction moduleRef "llvm.memcpy.p0i8.p0i8.i64" memcpyFuncTy
        removeFunctionAttr memcpy Attribute.NoUnwindAttribute

        // how many bytes need to be copied from source to dest
        let numBytes = sizeOf (getElementType srcTy)

        // both source and dest need to be cast to i8*
        let destArg = buildBitCast bldr dest bytePtr "dest"
        let srcArg = buildBitCast bldr src bytePtr "src"

        buildCall bldr memcpy [|destArg; srcArg; numBytes; constInt32 1; constInt1 isVolatile|] "" |> ignore
    | destTK, srcTK ->
        failwithf "unexpected types in buildCopy (dest=%A, src=%A)" destTK srcTK
