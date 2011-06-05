module LLVM.ExecutionEngine

open System.Runtime.InteropServices

open LLVM.Generated.Core
open LLVM.Generated.ExecutionEngine
open LLVM.FFIUtil

let runFunction
        (ee : ExecutionEngineRef)
        (func : ValueRef)
        (args : GenericValueRef array) =
    use argPtrs = new NativePtrs(Array.map (fun (gv : GenericValueRef) -> gv.Ptr) args)
    let retValPtr = runFunctionNative (ee.Ptr, func.Ptr, uint32 args.Length, argPtrs.Ptrs)
    GenericValueRef retValPtr

let private createEngineForModuleFromNativeFunc
        (nativeFunc : (nativeint * nativeint * nativeint) -> bool)
        (moduleRef : ModuleRef) =
    
    use outEnginePtr = new NativePtrs([|0n|])
    use outErrPtr = new NativePtrs([|0n|])
    let createFailed =
            nativeFunc (
                outEnginePtr.Ptrs,
                moduleRef.Ptr,
                outErrPtr.Ptrs)
    if createFailed then
        let errStr = Marshal.PtrToStringAuto (Marshal.ReadIntPtr outErrPtr.Ptrs)
        Marshal.FreeHGlobal (Marshal.ReadIntPtr outErrPtr.Ptrs)
        failwith errStr
    else
        ExecutionEngineRef (Marshal.ReadIntPtr outEnginePtr.Ptrs)

let createExecutionEngineForModule (modRef : ModuleRef) =
    createEngineForModuleFromNativeFunc createExecutionEngineForModuleNative modRef

let createInterpreterForModule (modRef : ModuleRef) =
    createEngineForModuleFromNativeFunc createInterpreterForModuleNative modRef

let createJITCompilerForModule (modRef : ModuleRef) (optLvl : uint32) =
    let f (engPtr, modPtr, outErrPtr) =
        createJITCompilerForModuleNative (engPtr, modPtr, optLvl, outErrPtr)
    
    createEngineForModuleFromNativeFunc f modRef

