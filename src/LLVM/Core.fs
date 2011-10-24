module LLVM.Core

open System.Threading

open LLVM.Generated.Core
open LLVM.FFIUtil

/// Extends BuilderRef. This version implements IDisposable and will call
/// disposeBuilder on itself automatically
type Builder(builderRef : BuilderRef) =
    inherit BuilderRef(builderRef.Ptr)
    
    [<VolatileField>]
    let mutable disposed = 0

    new() = new Builder(createBuilder ())

    new(ctxt : ContextRef) = new Builder(createBuilderInContext ctxt)
    
    new(bb : BasicBlockRef) as x =
        new Builder(createBuilder ()) then
        positionBuilderAtEnd x bb
    
    interface System.IDisposable with
        member x.Dispose () =
            if Interlocked.CompareExchange(&disposed, 1, 0) = 0 then
                disposeBuilder x

let varArgFunctionType (retTy : TypeRef) (paramTys : TypeRef array) =
    use paramPtrs = new NativePtrs([|for pt in paramTys -> pt.Ptr|])
    let paramCount = uint32 paramTys.Length
    
    TypeRef (functionTypeNative (retTy.Ptr, paramPtrs.Ptrs, paramCount, true))

let functionType (retTy : TypeRef) (paramTys : TypeRef array) =
    use paramPtrs = new NativePtrs([|for pt in paramTys -> pt.Ptr|])
    let paramCount = uint32 paramTys.Length
    
    TypeRef (functionTypeNative (retTy.Ptr, paramPtrs.Ptrs, paramCount, false))

let getBasicBlocks (f : ValueRef) =
    let bbCount = countBasicBlocks f
    if bbCount >= 1u then
        let rec goNext i bb =
            if i < bbCount then
                let nextBB = getNextBasicBlock bb
                bb :: goNext (i + 1u) nextBB
            else
                [bb]
        goNext 1u (getFirstBasicBlock f)
    else
        []

let buildCall (bld : BuilderRef) (func : ValueRef) (args : ValueRef array) (name : string) =
    use argPtrs = new NativePtrs([|for vr in args -> vr.Ptr|])
    let argCount = uint32 args.Length
    
    ValueRef (buildCallNative (bld.Ptr, func.Ptr, argPtrs.Ptrs, argCount, name))

let addIncoming (phi : ValueRef) (incoming : (ValueRef * BasicBlockRef) array) =
    let (incVals, incBlocks) = Array.unzip incoming
    use incValPtrs = new NativePtrs([|for vr in incVals -> vr.Ptr|])
    use incBlockPtrs = new NativePtrs([|for br in incBlocks -> br.Ptr|])
    let incCount = uint32 incoming.Length

    addIncomingNative (phi.Ptr, incValPtrs.Ptrs, incBlockPtrs.Ptrs, incCount)

let getNamedFunction (modRef : ModuleRef) (name : string) =
    ValueRef (getNamedFunctionNative (modRef.Ptr, name))

let optValueRef (vr : ValueRef) =
    match vr.Ptr with
    | 0n -> None
    | _ -> Some vr

let tryGetNamedFunction (modRef : ModuleRef) (name : string) =
    optValueRef (getNamedFunction modRef name)

let getParams (func : ValueRef) =
    let paramCount = int (countParams func)
    [|for i in 0 .. paramCount - 1 -> getParam func (uint32 i)|]

let buildSwitchWithCases
        (bldr : BuilderRef)
        (testVal : ValueRef)
        (cases : (ValueRef * BasicBlockRef) array)
        (defaultCase : BasicBlockRef) =

    let switchVal = buildSwitch bldr testVal defaultCase (uint32 cases.Length)
    for caseVal, caseBlock in cases do
        addCase switchVal caseVal caseBlock

let structTypeInContext (ctxt : ContextRef) (elemTys : TypeRef array) (packed : bool) =
    use elemTyPtrs = new NativePtrs([|for t in elemTys -> t.Ptr|])
    TypeRef (structTypeInContextNative (ctxt.Ptr, elemTyPtrs.Ptrs, uint32 elemTys.Length, packed))

let structType (elemTys : TypeRef array) (packed : bool) =
    use elemTyPtrs = new NativePtrs([|for t in elemTys -> t.Ptr|])
    TypeRef (structTypeNative (elemTyPtrs.Ptrs, uint32 elemTys.Length, packed))

let buildGEP (bldr : BuilderRef) (ptr : ValueRef) (indices : ValueRef array) (name : string) =
    use indexPtrs = new NativePtrs([|for i in indices -> i.Ptr|])
    ValueRef (buildGEPNative (bldr.Ptr, ptr.Ptr, indexPtrs.Ptrs, uint32 indices.Length, name))

let getStructElementTypes (structTy : TypeRef) =
    let elemCount = countStructElementTypes structTy
    use nativeElemTyPtrs = new NativePtrs([|for _ in 0u .. elemCount - 1u -> 0n|])
    getStructElementTypesNative (structTy.Ptr, nativeElemTyPtrs.Ptrs)

    [|for ptr in nativeElemTyPtrs.PtrArr -> new TypeRef (ptr)|]

let rec private typeToStringBuilder (modRef : ModuleRef) (tyRef : TypeRef) =
    let newStrBldr (s : string) = new System.Text.StringBuilder(s)
    let withElemTySB (s : string) =
        let sb = newStrBldr s
        sb.Append '<' |> ignore
        let elemTySb = typeToStringBuilder modRef (getElementType tyRef)
        sb.Append (elemTySb : System.Text.StringBuilder) |> ignore
        sb.Append '>'

    match getTypeName modRef tyRef with
    | null | "" ->
        match getTypeKind tyRef with
        | TypeKind.VoidTypeKind      -> newStrBldr "void"
        | TypeKind.FloatTypeKind     -> newStrBldr "float"
        | TypeKind.DoubleTypeKind    -> newStrBldr "double"
        | TypeKind.X86_FP80TypeKind  -> newStrBldr "X86 FP80"
        | TypeKind.FP128TypeKind     -> newStrBldr "FP 128"
        | TypeKind.PPC_FP128TypeKind -> newStrBldr "PPC FP 128"
        | TypeKind.LabelTypeKind     -> newStrBldr "Label"
        | TypeKind.IntegerTypeKind   -> newStrBldr "int"
        | TypeKind.FunctionTypeKind  -> newStrBldr "function"
        | TypeKind.OpaqueTypeKind    -> newStrBldr "Opaque"
        | TypeKind.MetadataTypeKind  -> newStrBldr "Metadata"
        | TypeKind.X86_MMXTypeKind   -> newStrBldr "X86 MMX"
        | TypeKind.ArrayTypeKind     -> withElemTySB "Array"
        | TypeKind.PointerTypeKind   -> withElemTySB "Pointer"
        | TypeKind.VectorTypeKind    -> withElemTySB "Vector"
        | TypeKind.StructTypeKind    ->
            let sb = newStrBldr "struct {"
            let structElemTys = getStructElementTypes tyRef
            for i in 0 .. structElemTys.Length - 1 do
                sb.Append (typeToStringBuilder modRef structElemTys.[i]) |> ignore
                sb.Append ';' |> ignore
                let isLastElem = i = structElemTys.Length - 1
                if not isLastElem then
                    sb.Append ' ' |> ignore
            sb.Append '}'
        | tk ->
            failwithf "unhandled type kind: %A" tk
    | name -> new System.Text.StringBuilder(name)

let typeToString (modRef : ModuleRef) (tyRef : TypeRef) =
    (typeToStringBuilder modRef tyRef).ToString ()