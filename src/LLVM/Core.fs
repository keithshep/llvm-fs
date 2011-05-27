module LLVM.Core

open System.Runtime.InteropServices
open System.Threading
open LLVM.Generated.Core

type NativePtrs(managedPtrs : nativeint array) =
    let mutable disposed = 0
    let ptrs = Marshal.AllocHGlobal (sizeof<nativeint> * managedPtrs.Length)
    do Marshal.Copy (managedPtrs, 0, ptrs, managedPtrs.Length)
    
    member x.Ptrs = ptrs
    
    interface System.IDisposable with
        member x.Dispose () =
            if Interlocked.CompareExchange(&disposed, 1, 0) = 0 then
                Marshal.FreeHGlobal ptrs

let functionType (retTy : TypeRef) (paramTys : TypeRef []) =
    let (TypeRef retTyPtr) = retTy
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

let buildCall (builder : BuilderRef) (func : ValueRef) (args : ValueRef array) (name : string) =
    let (BuilderRef bldPtr) = builder
    let (ValueRef funcPtr) = func
    use argPtrs = new NativePtrs(Array.map (fun (ValueRef ptr) -> ptr) args)
    let argCount = uint32 args.Length
    
    ValueRef (buildCallNative (bldPtr, funcPtr, argPtrs.Ptrs, argCount, name))

let addIncoming (phi : ValueRef) (incoming : (ValueRef * BasicBlockRef) array) =
    let (ValueRef phiPtr) = phi
    let (incVals, incBlocks) = Array.unzip incoming
    use incValPtrs = new NativePtrs(Array.map (fun (ValueRef ptr) -> ptr) incVals)
    use incBlockPtrs = new NativePtrs(Array.map (fun (BasicBlockRef ptr) -> ptr) incBlocks)
    let incCount = uint32 incoming.Length

    addIncomingNative (phiPtr, incValPtrs.Ptrs, incBlockPtrs.Ptrs, incCount)

let getNamedFunction _M _Name =
    ValueRef (getNamedFunctionNative ((match _M with ModuleRef ptr -> ptr), _Name))

let optValueRef = function
    | ValueRef 0n -> None
    | vr -> Some vr

let tryGetNamedFunction (modRef : ModuleRef) (name : string) =
    optValueRef (getNamedFunction modRef name)

let getParams (func : ValueRef) =
    let paramCount = int (countParams func)
    [|for i in 0 .. paramCount - 1 -> getParam func (uint32 i)|]

