module LLVM.Core

open System.Threading

open LLVM.Generated.Core
open LLVM.FFIUtil

type Builder(builderRef : BuilderRef) =
    [<VolatileField>]
    let mutable disposed = 0

    new(ctxt : ContextRef) = new Builder(createBuilderInContext ctxt)
    
    new(bb : BasicBlockRef) as x =
        new Builder(createBuilder ()) then
        positionBuilderAtEnd x.Ref bb
    
    member x.Ref = builderRef
    
    interface System.IDisposable with
        member x.Dispose () =
            if Interlocked.CompareExchange(&disposed, 1, 0) = 0 then
                disposeBuilder x.Ref

let optValueRef = function
    | ValueRef 0n -> None
    | vr -> Some vr

let functionType (TypeRef retTyPtr) (paramTys : TypeRef []) =
    use paramPtrs = new NativePtrs(Array.map (fun (TypeRef ptr) -> ptr) paramTys)
    let paramCount = uint32 paramTys.Length
    
    TypeRef (functionTypeNative (retTyPtr, paramPtrs.Ptrs, paramCount, false))

let getBasicBlocks f =
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

let buildCall (BuilderRef bldPtr) (ValueRef funcPtr) (args : ValueRef array) (name : string) =
    use argPtrs = new NativePtrs(Array.map (fun (ValueRef ptr) -> ptr) args)
    let argCount = uint32 args.Length
    
    ValueRef (buildCallNative (bldPtr, funcPtr, argPtrs.Ptrs, argCount, name))

let addIncoming (ValueRef phiPtr) (incoming : (ValueRef * BasicBlockRef) array) =
    let (incVals, incBlocks) = Array.unzip incoming
    use incValPtrs = new NativePtrs(Array.map (fun (ValueRef ptr) -> ptr) incVals)
    use incBlockPtrs = new NativePtrs(Array.map (fun (BasicBlockRef ptr) -> ptr) incBlocks)
    let incCount = uint32 incoming.Length

    addIncomingNative (phiPtr, incValPtrs.Ptrs, incBlockPtrs.Ptrs, incCount)

let getNamedFunction (ModuleRef modPtr) (name : string) =
    ValueRef (getNamedFunctionNative (modPtr, name))

let tryGetNamedFunction (modRef : ModuleRef) (name : string) =
    optValueRef (getNamedFunction modRef name)

let getParams (func : ValueRef) =
    let paramCount = int (countParams func)
    [|for i in 0 .. paramCount - 1 -> getParam func (uint32 i)|]

