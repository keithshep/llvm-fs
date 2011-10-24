module LLVM.FFIUtil

open System.Runtime.InteropServices
open System.Threading

type ILLVMRef = abstract Ptr : nativeint with get

type NativePtrs(managedPtrs : nativeint array) =
    [<VolatileField>]
    let mutable disposed = 0
    let ptrs = Marshal.AllocHGlobal (sizeof<nativeint> * managedPtrs.Length)
    do Marshal.Copy (managedPtrs, 0, ptrs, managedPtrs.Length)

    member x.Ptrs = ptrs

    member x.PtrArr =
        let len = managedPtrs.Length
        [|for i in 0 .. len - 1 -> Marshal.ReadIntPtr (ptrs, i)|]
    
    interface System.IDisposable with
        member x.Dispose () =
            if Interlocked.CompareExchange(&disposed, 1, 0) = 0 then
                Marshal.FreeHGlobal ptrs

