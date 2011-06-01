module LLVM.ExecutionEngine

open System.Runtime.InteropServices

open LLVM.Generated.Core
open LLVM.Generated.ExecutionEngine
open LLVM.FFIUtil

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
    
    use outEnginePtr = new NativePtrs([|0n|])
    use outErrPtr = new NativePtrs([|0n|])
    let createFailed =
            nativeFunc (
                outEnginePtr.Ptrs,
                modulePtr,
                outErrPtr.Ptrs)
    if createFailed then
        let errStr = Marshal.PtrToStringAuto (Marshal.ReadIntPtr outErrPtr.Ptrs)
        Marshal.FreeHGlobal (Marshal.ReadIntPtr outErrPtr.Ptrs)
        failwith errStr
    else
        ExecutionEngineRef (Marshal.ReadIntPtr outEnginePtr.Ptrs)

let createExecutionEngineForModule =
    createEngineForModuleFromNativeFunc createExecutionEngineForModuleNative

let createInterpreterForModule =
    createEngineForModuleFromNativeFunc createInterpreterForModuleNative

let createJITCompilerForModule (modRef : ModuleRef) (optLvl : uint32) =
    let f (engPtr, modPtr, outErrPtr) =
        createJITCompilerForModuleNative (engPtr, modPtr, optLvl, outErrPtr)
    
    createEngineForModuleFromNativeFunc f modRef

