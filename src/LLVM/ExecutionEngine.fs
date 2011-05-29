module LLVM.ExecutionEngine

open System.Runtime.InteropServices

open LLVM.Generated.Core
open LLVM.Generated.ExecutionEngine
open LLVM.FFIUtil

#nowarn "9"

let runFunction
        (ExecutionEngineRef eePtr)
        (ValueRef funcPtr)
        (args : GenericValueRef array) =
    use argPtrs = new NativePtrs(Array.map (fun (GenericValueRef ptr) -> ptr) args)
    let retValPtr = runFunctionNative (eePtr, funcPtr, uint32 args.Length, argPtrs.Ptrs)
    GenericValueRef retValPtr

let private createEngineForModuleFromNativeFunc
        (nativeFunc : (nativeint * nativeint * nativeint) -> bool)
        (ModuleRef modulePtr) =
    
    let mutable outEnginePtr = (NativeInterop.NativePtr.stackalloc sizeof<nativeint> : nativeptr<nativeint>)
    let mutable outErrPtr = (NativeInterop.NativePtr.stackalloc sizeof<nativeint> : nativeptr<nativeint>)
    let createFailed =
            nativeFunc (
                NativeInterop.NativePtr.toNativeInt outEnginePtr,
                modulePtr,
                NativeInterop.NativePtr.toNativeInt outErrPtr)
    if createFailed then
        // TODO don't know if it's better to go with failwith or Choice for errors
        let errStr = Marshal.PtrToStringAuto (NativeInterop.NativePtr.toNativeInt outErrPtr)
        Marshal.FreeHGlobal (NativeInterop.NativePtr.toNativeInt outErrPtr)
        failwith errStr
    else
        ExecutionEngineRef (NativeInterop.NativePtr.toNativeInt outEnginePtr)

let createExecutionEngineForModule =
    createEngineForModuleFromNativeFunc createExecutionEngineForModuleNative

let createInterpreterForModule =
    createEngineForModuleFromNativeFunc createInterpreterForModuleNative

let createJITCompilerForModule (modRef : ModuleRef) (optLvl : uint32) =
    let f (engPtr, modPtr, outErrPtr) =
        createJITCompilerForModuleNative (engPtr, modPtr, optLvl, outErrPtr)
    
    createEngineForModuleFromNativeFunc f modRef

