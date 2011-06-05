module LLVM.FFIUtil

open System.Runtime.InteropServices
open System.Threading
open LLVM.Generated.Core

type NativePtrs(managedPtrs : nativeint array) =
    [<VolatileField>]
    let mutable disposed = 0
    let ptrs = Marshal.AllocHGlobal (sizeof<nativeint> * managedPtrs.Length)
    do Marshal.Copy (managedPtrs, 0, ptrs, managedPtrs.Length)
    
    member x.Ptrs = ptrs
    
    interface System.IDisposable with
        member x.Dispose () =
            if Interlocked.CompareExchange(&disposed, 1, 0) = 0 then
                Marshal.FreeHGlobal ptrs

