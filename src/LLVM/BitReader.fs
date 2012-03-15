module LLVM.BitReader

open System.Runtime.InteropServices

open LLVM.Generated.Core
open LLVM.Generated.BitReader

let parseBitcode (memBuf : MemoryBufferRef) =
    let modRefPtr = Marshal.AllocHGlobal sizeof<nativeint>
    let msgStrPtr = Marshal.AllocHGlobal sizeof<nativeint>
    try
        // TODO mem leaks!!!
        if parseBitcodeNative(memBuf.Ptr, modRefPtr, msgStrPtr) then
            // TODO use msgStrPtr
            failwith "failed to parse bitcode"
        else
            new ModuleRef(Marshal.ReadIntPtr(modRefPtr))
    finally
        Marshal.FreeHGlobal modRefPtr
        Marshal.FreeHGlobal msgStrPtr
