module LLVM.Target

open System.Runtime.InteropServices

// Using LLVMInitializeX86Target in this way is kind of a hack. Ideally we would
// just be using LLVMInitializeNativeTarget but unfortunately the symbol for
// LLVMInitializeNativeTarget never makes it into the LLVM shared library since
// it is declared static. See:
// http://llvm.org/docs/doxygen/html/Target_8h_source.html#l00133
[<DllImport(LLVM.FFIUtil.llvmAssemblyName, EntryPoint="LLVMInitializeX86TargetInfo", CallingConvention=CallingConvention.Cdecl)>]
extern void private initializeX86TargetInfoNative()
[<DllImport(LLVM.FFIUtil.llvmAssemblyName, EntryPoint="LLVMInitializeX86Target", CallingConvention=CallingConvention.Cdecl)>]
extern void private initializeX86TargetNative()
[<DllImport(LLVM.FFIUtil.llvmAssemblyName, EntryPoint="LLVMInitializeX86TargetMC", CallingConvention=CallingConvention.Cdecl)>]
extern void private initializeX86TargetMCNative()

let initializeX86Target() =
    initializeX86TargetInfoNative()
    initializeX86TargetNative()
    initializeX86TargetMCNative()
