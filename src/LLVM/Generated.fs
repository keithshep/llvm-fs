// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices

    module Core =

        type ContextRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ModuleRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type TypeRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ValueRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type BasicBlockRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type BuilderRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ModuleProviderRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type MemoryBufferRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type PassManagerRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type PassRegistryRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type UseRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type Attribute =
            | ZExtAttribute = 1
            | SExtAttribute = 2
            | NoReturnAttribute = 4
            | InRegAttribute = 8
            | StructRetAttribute = 16
            | NoUnwindAttribute = 32
            | NoAliasAttribute = 64
            | ByValAttribute = 128
            | NestAttribute = 256
            | ReadNoneAttribute = 512
            | ReadOnlyAttribute = 1024
            | NoInlineAttribute = 2048
            | AlwaysInlineAttribute = 4096
            | OptimizeForSizeAttribute = 8192
            | StackProtectAttribute = 16384
            | StackProtectReqAttribute = 32768
            | Alignment = 2031616
            | NoCaptureAttribute = 2097152
            | NoRedZoneAttribute = 4194304
            | NoImplicitFloatAttribute = 8388608
            | NakedAttribute = 16777216
            | InlineHintAttribute = 33554432
            | StackAlignment = 469762048
            | ReturnsTwice = 536870912
            | UWTable = 1073741824
            | NonLazyBind = -2147483648

        type Opcode =
            | Ret = 1
            | Br = 2
            | Switch = 3
            | IndirectBr = 4
            | Invoke = 5
            | Unreachable = 7
            | Add = 8
            | FAdd = 9
            | Sub = 10
            | FSub = 11
            | Mul = 12
            | FMul = 13
            | UDiv = 14
            | SDiv = 15
            | FDiv = 16
            | URem = 17
            | SRem = 18
            | FRem = 19
            | Shl = 20
            | LShr = 21
            | AShr = 22
            | And = 23
            | Or = 24
            | Xor = 25
            | Alloca = 26
            | Load = 27
            | Store = 28
            | GetElementPtr = 29
            | Trunc = 30
            | ZExt = 31
            | SExt = 32
            | FPToUI = 33
            | FPToSI = 34
            | UIToFP = 35
            | SIToFP = 36
            | FPTrunc = 37
            | FPExt = 38
            | PtrToInt = 39
            | IntToPtr = 40
            | BitCast = 41
            | ICmp = 42
            | FCmp = 43
            | PHI = 44
            | Call = 45
            | Select = 46
            | UserOp1 = 47
            | UserOp2 = 48
            | VAArg = 49
            | ExtractElement = 50
            | InsertElement = 51
            | ShuffleVector = 52
            | ExtractValue = 53
            | InsertValue = 54
            | Fence = 55
            | AtomicCmpXchg = 56
            | AtomicRMW = 57
            | Resume = 58
            | LandingPad = 59

        type TypeKind =
            | VoidTypeKind = 0
            | HalfTypeKind = 1
            | FloatTypeKind = 2
            | DoubleTypeKind = 3
            | X86_FP80TypeKind = 4
            | FP128TypeKind = 5
            | PPC_FP128TypeKind = 6
            | LabelTypeKind = 7
            | IntegerTypeKind = 8
            | FunctionTypeKind = 9
            | StructTypeKind = 10
            | ArrayTypeKind = 11
            | PointerTypeKind = 12
            | VectorTypeKind = 13
            | MetadataTypeKind = 14
            | X86_MMXTypeKind = 15

        type Linkage =
            | ExternalLinkage = 0
            | AvailableExternallyLinkage = 1
            | LinkOnceAnyLinkage = 2
            | LinkOnceODRLinkage = 3
            | WeakAnyLinkage = 4
            | WeakODRLinkage = 5
            | AppendingLinkage = 6
            | InternalLinkage = 7
            | PrivateLinkage = 8
            | DLLImportLinkage = 9
            | DLLExportLinkage = 10
            | ExternalWeakLinkage = 11
            | GhostLinkage = 12
            | CommonLinkage = 13
            | LinkerPrivateLinkage = 14
            | LinkerPrivateWeakLinkage = 15
            | LinkerPrivateWeakDefAutoLinkage = 16

        type Visibility =
            | DefaultVisibility = 0
            | HiddenVisibility = 1
            | ProtectedVisibility = 2

        type CallConv =
            | CCallConv = 0
            | FastCallConv = 8
            | ColdCallConv = 9
            | X86StdcallCallConv = 64
            | X86FastcallCallConv = 65

        type IntPredicate =
            | IntEQ = 32
            | IntNE = 33
            | IntUGT = 34
            | IntUGE = 35
            | IntULT = 36
            | IntULE = 37
            | IntSGT = 38
            | IntSGE = 39
            | IntSLT = 40
            | IntSLE = 41

        type RealPredicate =
            | RealPredicateFalse = 0
            | RealOEQ = 1
            | RealOGT = 2
            | RealOGE = 3
            | RealOLT = 4
            | RealOLE = 5
            | RealONE = 6
            | RealORD = 7
            | RealUNO = 8
            | RealUEQ = 9
            | RealUGT = 10
            | RealUGE = 11
            | RealULT = 12
            | RealULE = 13
            | RealUNE = 14
            | RealPredicateTrue = 15

        type LandingPadClauseTy =
            | LandingPadCatch = 0
            | LandingPadFilter = 1

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInitializeCore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void initializeCoreNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeCore _R =
            initializeCoreNative ((_R : PassRegistryRef).Ptr)

        // LLVMDisposeMessage is blacklisted by the binding generator

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMContextCreate",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) contextCreateNative()
        let contextCreate () =
            new ContextRef (contextCreateNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetGlobalContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) getGlobalContextNative()
        let getGlobalContext () =
            new ContextRef (getGlobalContextNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMContextDispose",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void contextDisposeNative(
            void* (* LLVMContextRef *) C)
        let contextDispose _C =
            contextDisposeNative ((_C : ContextRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetMDKindIDInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getMDKindIDInContextNative(
            void* (* LLVMContextRef *) C,
            string Name,
            uint32 SLen)
        let getMDKindIDInContext _C _Name _SLen =
            getMDKindIDInContextNative ((_C : ContextRef).Ptr, _Name, _SLen)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetMDKindID",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getMDKindIDNative(
            string Name,
            uint32 SLen)
        let getMDKindID _Name _SLen =
            getMDKindIDNative (_Name, _SLen)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMModuleCreateWithName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) moduleCreateWithNameNative(
            string ModuleID)
        let moduleCreateWithName _ModuleID =
            new ModuleRef (moduleCreateWithNameNative (_ModuleID))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMModuleCreateWithNameInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) moduleCreateWithNameInContextNative(
            string ModuleID,
            void* (* LLVMContextRef *) C)
        let moduleCreateWithNameInContext _ModuleID _C =
            new ModuleRef (moduleCreateWithNameInContextNative (_ModuleID, (_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeModuleNative(
            void* (* LLVMModuleRef *) M)
        let disposeModule _M =
            disposeModuleNative ((_M : ModuleRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetDataLayout",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getDataLayoutNative(
            void* (* LLVMModuleRef *) M)
        let getDataLayout _M =
            Marshal.PtrToStringAuto (getDataLayoutNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetDataLayout",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setDataLayoutNative(
            void* (* LLVMModuleRef *) M,
            string Triple)
        let setDataLayout _M _Triple =
            setDataLayoutNative ((_M : ModuleRef).Ptr, _Triple)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getTargetNative(
            void* (* LLVMModuleRef *) M)
        let getTarget _M =
            Marshal.PtrToStringAuto (getTargetNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetTarget",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setTargetNative(
            void* (* LLVMModuleRef *) M,
            string Triple)
        let setTarget _M _Triple =
            setTargetNative ((_M : ModuleRef).Ptr, _Triple)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDumpModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void dumpModuleNative(
            void* (* LLVMModuleRef *) M)
        let dumpModule _M =
            dumpModuleNative ((_M : ModuleRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetModuleInlineAsm",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setModuleInlineAsmNative(
            void* (* LLVMModuleRef *) M,
            string Asm)
        let setModuleInlineAsm _M _Asm =
            setModuleInlineAsmNative ((_M : ModuleRef).Ptr, _Asm)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetModuleContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) getModuleContextNative(
            void* (* LLVMModuleRef *) M)
        let getModuleContext _M =
            new ContextRef (getModuleContextNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetTypeByName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) getTypeByNameNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getTypeByName _M _Name =
            new TypeRef (getTypeByNameNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNamedMetadataNumOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getNamedMetadataNumOperandsNative(
            void* (* LLVMModuleRef *) M,
            string name)
        let getNamedMetadataNumOperands _M _name =
            getNamedMetadataNumOperandsNative ((_M : ModuleRef).Ptr, _name)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNamedMetadataOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getNamedMetadataOperandsNative(
            void* (* LLVMModuleRef *) M,
            string name,
            void* (* LLVMValueRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetNamedMetadataOperands

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddNamedMetadataOperand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addNamedMetadataOperandNative(
            void* (* LLVMModuleRef *) M,
            string name,
            void* (* LLVMValueRef *) Val)
        let addNamedMetadataOperand _M _name _Val =
            addNamedMetadataOperandNative ((_M : ModuleRef).Ptr, _name, (_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addFunctionNative(
            void* (* LLVMModuleRef *) M,
            string Name,
            void* (* LLVMTypeRef *) FunctionTy)
        let addFunction _M _Name _FunctionTy =
            new ValueRef (addFunctionNative ((_M : ModuleRef).Ptr, _Name, (_FunctionTy : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNamedFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNamedFunctionNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getNamedFunction _M _Name =
            new ValueRef (getNamedFunctionNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFirstFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstFunctionNative(
            void* (* LLVMModuleRef *) M)
        let getFirstFunction _M =
            new ValueRef (getFirstFunctionNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetLastFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastFunctionNative(
            void* (* LLVMModuleRef *) M)
        let getLastFunction _M =
            new ValueRef (getLastFunctionNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNextFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let getNextFunction _Fn =
            new ValueRef (getNextFunctionNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPreviousFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let getPreviousFunction _Fn =
            new ValueRef (getPreviousFunctionNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetTypeKind",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMTypeKind *) getTypeKindNative(
            void* (* LLVMTypeRef *) Ty)
        let getTypeKind _Ty =
            enum<TypeKind> (getTypeKindNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMTypeIsSized",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool typeIsSizedNative(
            void* (* LLVMTypeRef *) Ty)
        let typeIsSized _Ty =
            typeIsSizedNative ((_Ty : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetTypeContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMContextRef *) getTypeContextNative(
            void* (* LLVMTypeRef *) Ty)
        let getTypeContext _Ty =
            new ContextRef (getTypeContextNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt1TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int1TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int1TypeInContext _C =
            new TypeRef (int1TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt8TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int8TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int8TypeInContext _C =
            new TypeRef (int8TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt16TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int16TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int16TypeInContext _C =
            new TypeRef (int16TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt32TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int32TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int32TypeInContext _C =
            new TypeRef (int32TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt64TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int64TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int64TypeInContext _C =
            new TypeRef (int64TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIntTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intTypeInContextNative(
            void* (* LLVMContextRef *) C,
            uint32 NumBits)
        let intTypeInContext _C _NumBits =
            new TypeRef (intTypeInContextNative ((_C : ContextRef).Ptr, _NumBits))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt1Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int1TypeNative()
        let int1Type () =
            new TypeRef (int1TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt8Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int8TypeNative()
        let int8Type () =
            new TypeRef (int8TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt16Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int16TypeNative()
        let int16Type () =
            new TypeRef (int16TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt32Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int32TypeNative()
        let int32Type () =
            new TypeRef (int32TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInt64Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) int64TypeNative()
        let int64Type () =
            new TypeRef (int64TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIntType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intTypeNative(
            uint32 NumBits)
        let intType _NumBits =
            new TypeRef (intTypeNative (_NumBits))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetIntTypeWidth",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getIntTypeWidthNative(
            void* (* LLVMTypeRef *) IntegerTy)
        let getIntTypeWidth _IntegerTy =
            getIntTypeWidthNative ((_IntegerTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMHalfTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) halfTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let halfTypeInContext _C =
            new TypeRef (halfTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFloatTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) floatTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let floatTypeInContext _C =
            new TypeRef (floatTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDoubleTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) doubleTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let doubleTypeInContext _C =
            new TypeRef (doubleTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMX86FP80TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86FP80TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let x86FP80TypeInContext _C =
            new TypeRef (x86FP80TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFP128TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) fP128TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let fP128TypeInContext _C =
            new TypeRef (fP128TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPPCFP128TypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) pPCFP128TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let pPCFP128TypeInContext _C =
            new TypeRef (pPCFP128TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMHalfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) halfTypeNative()
        let halfType () =
            new TypeRef (halfTypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFloatType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) floatTypeNative()
        let floatType () =
            new TypeRef (floatTypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDoubleType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) doubleTypeNative()
        let doubleType () =
            new TypeRef (doubleTypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMX86FP80Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86FP80TypeNative()
        let x86FP80Type () =
            new TypeRef (x86FP80TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFP128Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) fP128TypeNative()
        let fP128Type () =
            new TypeRef (fP128TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPPCFP128Type",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) pPCFP128TypeNative()
        let pPCFP128Type () =
            new TypeRef (pPCFP128TypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFunctionType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) functionTypeNative(
            void* (* LLVMTypeRef *) ReturnType,
            void* (* LLVMTypeRef* *) ParamTypes,
            uint32 ParamCount,
            bool IsVarArg)
        // I don't know how to generate an "F# friendly" version of LLVMFunctionType

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsFunctionVarArg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isFunctionVarArgNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let isFunctionVarArg _FunctionTy =
            isFunctionVarArgNative ((_FunctionTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetReturnType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) getReturnTypeNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let getReturnType _FunctionTy =
            new TypeRef (getReturnTypeNative ((_FunctionTy : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCountParamTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countParamTypesNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let countParamTypes _FunctionTy =
            countParamTypesNative ((_FunctionTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetParamTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getParamTypesNative(
            void* (* LLVMTypeRef *) FunctionTy,
            void* (* LLVMTypeRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetParamTypes

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMStructTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) structTypeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructTypeInContext

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMStructType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) structTypeNative(
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructType

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMStructCreateNamed",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) structCreateNamedNative(
            void* (* LLVMContextRef *) C,
            string Name)
        let structCreateNamed _C _Name =
            new TypeRef (structCreateNamedNative ((_C : ContextRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetStructName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getStructNameNative(
            void* (* LLVMTypeRef *) Ty)
        let getStructName _Ty =
            Marshal.PtrToStringAuto (getStructNameNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMStructSetBody",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void structSetBodyNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructSetBody

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCountStructElementTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countStructElementTypesNative(
            void* (* LLVMTypeRef *) StructTy)
        let countStructElementTypes _StructTy =
            countStructElementTypesNative ((_StructTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetStructElementTypes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getStructElementTypesNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMTypeRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetStructElementTypes

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsPackedStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isPackedStructNative(
            void* (* LLVMTypeRef *) StructTy)
        let isPackedStruct _StructTy =
            isPackedStructNative ((_StructTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsOpaqueStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isOpaqueStructNative(
            void* (* LLVMTypeRef *) StructTy)
        let isOpaqueStruct _StructTy =
            isOpaqueStructNative ((_StructTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetElementType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) getElementTypeNative(
            void* (* LLVMTypeRef *) Ty)
        let getElementType _Ty =
            new TypeRef (getElementTypeNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMArrayType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) arrayTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 ElementCount)
        let arrayType _ElementType _ElementCount =
            new TypeRef (arrayTypeNative ((_ElementType : TypeRef).Ptr, _ElementCount))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetArrayLength",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getArrayLengthNative(
            void* (* LLVMTypeRef *) ArrayTy)
        let getArrayLength _ArrayTy =
            getArrayLengthNative ((_ArrayTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPointerType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) pointerTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 AddressSpace)
        let pointerType _ElementType _AddressSpace =
            new TypeRef (pointerTypeNative ((_ElementType : TypeRef).Ptr, _AddressSpace))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPointerAddressSpace",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getPointerAddressSpaceNative(
            void* (* LLVMTypeRef *) PointerTy)
        let getPointerAddressSpace _PointerTy =
            getPointerAddressSpaceNative ((_PointerTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMVectorType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) vectorTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 ElementCount)
        let vectorType _ElementType _ElementCount =
            new TypeRef (vectorTypeNative ((_ElementType : TypeRef).Ptr, _ElementCount))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetVectorSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getVectorSizeNative(
            void* (* LLVMTypeRef *) VectorTy)
        let getVectorSize _VectorTy =
            getVectorSizeNative ((_VectorTy : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMVoidTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) voidTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let voidTypeInContext _C =
            new TypeRef (voidTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMLabelTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) labelTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let labelTypeInContext _C =
            new TypeRef (labelTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMX86MMXTypeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86MMXTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let x86MMXTypeInContext _C =
            new TypeRef (x86MMXTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMVoidType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) voidTypeNative()
        let voidType () =
            new TypeRef (voidTypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMLabelType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) labelTypeNative()
        let labelType () =
            new TypeRef (labelTypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMX86MMXType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) x86MMXTypeNative()
        let x86MMXType () =
            new TypeRef (x86MMXTypeNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMTypeOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) typeOfNative(
            void* (* LLVMValueRef *) Val)
        let typeOf _Val =
            new TypeRef (typeOfNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetValueName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getValueNameNative(
            void* (* LLVMValueRef *) Val)
        let getValueName _Val =
            Marshal.PtrToStringAuto (getValueNameNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetValueName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setValueNameNative(
            void* (* LLVMValueRef *) Val,
            string Name)
        let setValueName _Val _Name =
            setValueNameNative ((_Val : ValueRef).Ptr, _Name)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDumpValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void dumpValueNative(
            void* (* LLVMValueRef *) Val)
        let dumpValue _Val =
            dumpValueNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMReplaceAllUsesWith",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void replaceAllUsesWithNative(
            void* (* LLVMValueRef *) OldVal,
            void* (* LLVMValueRef *) NewVal)
        let replaceAllUsesWith _OldVal _NewVal =
            replaceAllUsesWithNative ((_OldVal : ValueRef).Ptr, (_NewVal : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isConstantNative(
            void* (* LLVMValueRef *) Val)
        let isConstant _Val =
            isConstantNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsUndef",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isUndefNative(
            void* (* LLVMValueRef *) Val)
        let isUndef _Val =
            isUndefNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFirstUse",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMUseRef *) getFirstUseNative(
            void* (* LLVMValueRef *) Val)
        let getFirstUse _Val =
            new UseRef (getFirstUseNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNextUse",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMUseRef *) getNextUseNative(
            void* (* LLVMUseRef *) U)
        let getNextUse _U =
            new UseRef (getNextUseNative ((_U : UseRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetUser",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getUserNative(
            void* (* LLVMUseRef *) U)
        let getUser _U =
            new ValueRef (getUserNative ((_U : UseRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetUsedValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getUsedValueNative(
            void* (* LLVMUseRef *) U)
        let getUsedValue _U =
            new ValueRef (getUsedValueNative ((_U : UseRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetOperand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getOperandNative(
            void* (* LLVMValueRef *) Val,
            uint32 Index)
        let getOperand _Val _Index =
            new ValueRef (getOperandNative ((_Val : ValueRef).Ptr, _Index))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetOperand",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setOperandNative(
            void* (* LLVMValueRef *) User,
            uint32 Index,
            void* (* LLVMValueRef *) Val)
        let setOperand _User _Index _Val =
            setOperandNative ((_User : ValueRef).Ptr, _Index, (_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNumOperands",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int getNumOperandsNative(
            void* (* LLVMValueRef *) Val)
        let getNumOperands _Val =
            getNumOperandsNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNullNative(
            void* (* LLVMTypeRef *) Ty)
        let constNull _Ty =
            new ValueRef (constNullNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstAllOnes",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAllOnesNative(
            void* (* LLVMTypeRef *) Ty)
        let constAllOnes _Ty =
            new ValueRef (constAllOnesNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetUndef",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getUndefNative(
            void* (* LLVMTypeRef *) Ty)
        let getUndef _Ty =
            new ValueRef (getUndefNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isNullNative(
            void* (* LLVMValueRef *) Val)
        let isNull _Val =
            isNullNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstPointerNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constPointerNullNative(
            void* (* LLVMTypeRef *) Ty)
        let constPointerNull _Ty =
            new ValueRef (constPointerNullNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntNative(
            void* (* LLVMTypeRef *) IntTy,
            uint64 N,
            bool SignExtend)
        let constInt _IntTy _N _SignExtend =
            new ValueRef (constIntNative ((_IntTy : TypeRef).Ptr, _N, _SignExtend))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntOfArbitraryPrecision",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntOfArbitraryPrecisionNative(
            void* (* LLVMTypeRef *) IntTy,
            uint32 NumWords,
            uint64* Words)
        // I don't know how to generate an "F# friendly" version of LLVMConstIntOfArbitraryPrecision

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntOfString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntOfStringNative(
            void* (* LLVMTypeRef *) IntTy,
            string Text,
            uint8 Radix)
        let constIntOfString _IntTy _Text _Radix =
            new ValueRef (constIntOfStringNative ((_IntTy : TypeRef).Ptr, _Text, _Radix))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntOfStringAndSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntOfStringAndSizeNative(
            void* (* LLVMTypeRef *) IntTy,
            string Text,
            uint32 SLen,
            uint8 Radix)
        let constIntOfStringAndSize _IntTy _Text _SLen _Radix =
            new ValueRef (constIntOfStringAndSizeNative ((_IntTy : TypeRef).Ptr, _Text, _SLen, _Radix))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstReal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constRealNative(
            void* (* LLVMTypeRef *) RealTy,
            double N)
        let constReal _RealTy _N =
            new ValueRef (constRealNative ((_RealTy : TypeRef).Ptr, _N))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstRealOfString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constRealOfStringNative(
            void* (* LLVMTypeRef *) RealTy,
            string Text)
        let constRealOfString _RealTy _Text =
            new ValueRef (constRealOfStringNative ((_RealTy : TypeRef).Ptr, _Text))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstRealOfStringAndSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constRealOfStringAndSizeNative(
            void* (* LLVMTypeRef *) RealTy,
            string Text,
            uint32 SLen)
        let constRealOfStringAndSize _RealTy _Text _SLen =
            new ValueRef (constRealOfStringAndSizeNative ((_RealTy : TypeRef).Ptr, _Text, _SLen))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntGetZExtValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 constIntGetZExtValueNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constIntGetZExtValue _ConstantVal =
            constIntGetZExtValueNative ((_ConstantVal : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntGetSExtValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int64 constIntGetSExtValueNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constIntGetSExtValue _ConstantVal =
            constIntGetSExtValueNative ((_ConstantVal : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstStringInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStringInContextNative(
            void* (* LLVMContextRef *) C,
            string Str,
            uint32 Length,
            bool DontNullTerminate)
        let constStringInContext _C _Str _Length _DontNullTerminate =
            new ValueRef (constStringInContextNative ((_C : ContextRef).Ptr, _Str, _Length, _DontNullTerminate))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStringNative(
            string Str,
            uint32 Length,
            bool DontNullTerminate)
        let constString _Str _Length _DontNullTerminate =
            new ValueRef (constStringNative (_Str, _Length, _DontNullTerminate))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstStructInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStructInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMConstStructInContext

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constStructNative(
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMConstStruct

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstArray",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constArrayNative(
            void* (* LLVMTypeRef *) ElementTy,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Length)
        // I don't know how to generate an "F# friendly" version of LLVMConstArray

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNamedStruct",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNamedStructNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMConstNamedStruct

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstVector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constVectorNative(
            void* (* LLVMValueRef* *) ScalarConstantVals,
            uint32 Size)
        // I don't know how to generate an "F# friendly" version of LLVMConstVector

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetConstOpcode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMOpcode *) getConstOpcodeNative(
            void* (* LLVMValueRef *) ConstantVal)
        let getConstOpcode _ConstantVal =
            enum<Opcode> (getConstOpcodeNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAlignOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) alignOfNative(
            void* (* LLVMTypeRef *) Ty)
        let alignOf _Ty =
            new ValueRef (alignOfNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSizeOf",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) sizeOfNative(
            void* (* LLVMTypeRef *) Ty)
        let sizeOf _Ty =
            new ValueRef (sizeOfNative ((_Ty : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNeg _ConstantVal =
            new ValueRef (constNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNSWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNSWNeg _ConstantVal =
            new ValueRef (constNSWNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNUWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNUWNeg _ConstantVal =
            new ValueRef (constNUWNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constFNeg _ConstantVal =
            new ValueRef (constFNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNot",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNotNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNot _ConstantVal =
            new ValueRef (constNotNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAdd _LHSConstant _RHSConstant =
            new ValueRef (constAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNSWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWAdd _LHSConstant _RHSConstant =
            new ValueRef (constNSWAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNUWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWAdd _LHSConstant _RHSConstant =
            new ValueRef (constNUWAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFAdd _LHSConstant _RHSConstant =
            new ValueRef (constFAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSub _LHSConstant _RHSConstant =
            new ValueRef (constSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNSWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWSub _LHSConstant _RHSConstant =
            new ValueRef (constNSWSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNUWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWSub _LHSConstant _RHSConstant =
            new ValueRef (constNUWSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFSub _LHSConstant _RHSConstant =
            new ValueRef (constFSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constMul _LHSConstant _RHSConstant =
            new ValueRef (constMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNSWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNSWMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWMul _LHSConstant _RHSConstant =
            new ValueRef (constNSWMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstNUWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constNUWMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWMul _LHSConstant _RHSConstant =
            new ValueRef (constNUWMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFMul _LHSConstant _RHSConstant =
            new ValueRef (constFMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstUDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constUDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constUDiv _LHSConstant _RHSConstant =
            new ValueRef (constUDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSDiv _LHSConstant _RHSConstant =
            new ValueRef (constSDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstExactSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constExactSDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constExactSDiv _LHSConstant _RHSConstant =
            new ValueRef (constExactSDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFDiv _LHSConstant _RHSConstant =
            new ValueRef (constFDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstURem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constURemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constURem _LHSConstant _RHSConstant =
            new ValueRef (constURemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSRemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSRem _LHSConstant _RHSConstant =
            new ValueRef (constSRemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFRemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFRem _LHSConstant _RHSConstant =
            new ValueRef (constFRemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstAnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAndNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAnd _LHSConstant _RHSConstant =
            new ValueRef (constAndNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstOr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constOrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constOr _LHSConstant _RHSConstant =
            new ValueRef (constOrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstXor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constXorNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constXor _LHSConstant _RHSConstant =
            new ValueRef (constXorNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstICmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constICmpNative(
            int (* LLVMIntPredicate *) Predicate,
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constICmp _Predicate _LHSConstant _RHSConstant =
            new ValueRef (constICmpNative ((int (_Predicate : IntPredicate)), (_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFCmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFCmpNative(
            int (* LLVMRealPredicate *) Predicate,
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFCmp _Predicate _LHSConstant _RHSConstant =
            new ValueRef (constFCmpNative ((int (_Predicate : RealPredicate)), (_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstShl",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constShlNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constShl _LHSConstant _RHSConstant =
            new ValueRef (constShlNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstLShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constLShrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constLShr _LHSConstant _RHSConstant =
            new ValueRef (constLShrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstAShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constAShrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAShr _LHSConstant _RHSConstant =
            new ValueRef (constAShrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constGEPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMValueRef* *) ConstantIndices,
            uint32 NumIndices)
        // I don't know how to generate an "F# friendly" version of LLVMConstGEP

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstInBoundsGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInBoundsGEPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMValueRef* *) ConstantIndices,
            uint32 NumIndices)
        // I don't know how to generate an "F# friendly" version of LLVMConstInBoundsGEP

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constTruncNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constTrunc _ConstantVal _ToType =
            new ValueRef (constTruncNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSExt _ConstantVal _ToType =
            new ValueRef (constSExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstZExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constZExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constZExt _ConstantVal _ToType =
            new ValueRef (constZExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFPTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPTruncNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPTrunc _ConstantVal _ToType =
            new ValueRef (constFPTruncNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFPExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPExt _ConstantVal _ToType =
            new ValueRef (constFPExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstUIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constUIToFPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constUIToFP _ConstantVal _ToType =
            new ValueRef (constUIToFPNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSIToFPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSIToFP _ConstantVal _ToType =
            new ValueRef (constSIToFPNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFPToUI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPToUINative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPToUI _ConstantVal _ToType =
            new ValueRef (constFPToUINative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFPToSI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPToSINative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPToSI _ConstantVal _ToType =
            new ValueRef (constFPToSINative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstPtrToInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constPtrToIntNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constPtrToInt _ConstantVal _ToType =
            new ValueRef (constPtrToIntNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntToPtr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntToPtrNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constIntToPtr _ConstantVal _ToType =
            new ValueRef (constIntToPtrNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constBitCast _ConstantVal _ToType =
            new ValueRef (constBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstZExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constZExtOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constZExtOrBitCast _ConstantVal _ToType =
            new ValueRef (constZExtOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSExtOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSExtOrBitCast _ConstantVal _ToType =
            new ValueRef (constSExtOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstTruncOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constTruncOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constTruncOrBitCast _ConstantVal _ToType =
            new ValueRef (constTruncOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstPointerCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constPointerCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constPointerCast _ConstantVal _ToType =
            new ValueRef (constPointerCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstIntCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constIntCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType,
            bool isSigned)
        let constIntCast _ConstantVal _ToType _isSigned =
            new ValueRef (constIntCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr, _isSigned))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstFPCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constFPCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPCast _ConstantVal _ToType =
            new ValueRef (constFPCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstSelect",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constSelectNative(
            void* (* LLVMValueRef *) ConstantCondition,
            void* (* LLVMValueRef *) ConstantIfTrue,
            void* (* LLVMValueRef *) ConstantIfFalse)
        let constSelect _ConstantCondition _ConstantIfTrue _ConstantIfFalse =
            new ValueRef (constSelectNative ((_ConstantCondition : ValueRef).Ptr, (_ConstantIfTrue : ValueRef).Ptr, (_ConstantIfFalse : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstExtractElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constExtractElementNative(
            void* (* LLVMValueRef *) VectorConstant,
            void* (* LLVMValueRef *) IndexConstant)
        let constExtractElement _VectorConstant _IndexConstant =
            new ValueRef (constExtractElementNative ((_VectorConstant : ValueRef).Ptr, (_IndexConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstInsertElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInsertElementNative(
            void* (* LLVMValueRef *) VectorConstant,
            void* (* LLVMValueRef *) ElementValueConstant,
            void* (* LLVMValueRef *) IndexConstant)
        let constInsertElement _VectorConstant _ElementValueConstant _IndexConstant =
            new ValueRef (constInsertElementNative ((_VectorConstant : ValueRef).Ptr, (_ElementValueConstant : ValueRef).Ptr, (_IndexConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstShuffleVector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constShuffleVectorNative(
            void* (* LLVMValueRef *) VectorAConstant,
            void* (* LLVMValueRef *) VectorBConstant,
            void* (* LLVMValueRef *) MaskConstant)
        let constShuffleVector _VectorAConstant _VectorBConstant _MaskConstant =
            new ValueRef (constShuffleVectorNative ((_VectorAConstant : ValueRef).Ptr, (_VectorBConstant : ValueRef).Ptr, (_MaskConstant : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstExtractValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constExtractValueNative(
            void* (* LLVMValueRef *) AggConstant,
            uint32* IdxList,
            uint32 NumIdx)
        // I don't know how to generate an "F# friendly" version of LLVMConstExtractValue

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstInsertValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInsertValueNative(
            void* (* LLVMValueRef *) AggConstant,
            void* (* LLVMValueRef *) ElementValueConstant,
            uint32* IdxList,
            uint32 NumIdx)
        // I don't know how to generate an "F# friendly" version of LLVMConstInsertValue

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMConstInlineAsm",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) constInlineAsmNative(
            void* (* LLVMTypeRef *) Ty,
            string AsmString,
            string Constraints,
            bool HasSideEffects,
            bool IsAlignStack)
        let constInlineAsm _Ty _AsmString _Constraints _HasSideEffects _IsAlignStack =
            new ValueRef (constInlineAsmNative ((_Ty : TypeRef).Ptr, _AsmString, _Constraints, _HasSideEffects, _IsAlignStack))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBlockAddress",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) blockAddressNative(
            void* (* LLVMValueRef *) F,
            void* (* LLVMBasicBlockRef *) BB)
        let blockAddress _F _BB =
            new ValueRef (blockAddressNative ((_F : ValueRef).Ptr, (_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetGlobalParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleRef *) getGlobalParentNative(
            void* (* LLVMValueRef *) Global)
        let getGlobalParent _Global =
            new ModuleRef (getGlobalParentNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsDeclaration",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isDeclarationNative(
            void* (* LLVMValueRef *) Global)
        let isDeclaration _Global =
            isDeclarationNative ((_Global : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetLinkage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMLinkage *) getLinkageNative(
            void* (* LLVMValueRef *) Global)
        let getLinkage _Global =
            enum<Linkage> (getLinkageNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetLinkage",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setLinkageNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMLinkage *) Linkage)
        let setLinkage _Global _Linkage =
            setLinkageNative ((_Global : ValueRef).Ptr, (int (_Linkage : Linkage)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetSection",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getSectionNative(
            void* (* LLVMValueRef *) Global)
        let getSection _Global =
            Marshal.PtrToStringAuto (getSectionNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetSection",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setSectionNative(
            void* (* LLVMValueRef *) Global,
            string Section)
        let setSection _Global _Section =
            setSectionNative ((_Global : ValueRef).Ptr, _Section)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetVisibility",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMVisibility *) getVisibilityNative(
            void* (* LLVMValueRef *) Global)
        let getVisibility _Global =
            enum<Visibility> (getVisibilityNative ((_Global : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetVisibility",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setVisibilityNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMVisibility *) Viz)
        let setVisibility _Global _Viz =
            setVisibilityNative ((_Global : ValueRef).Ptr, (int (_Viz : Visibility)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getAlignmentNative(
            void* (* LLVMValueRef *) Global)
        let getAlignment _Global =
            getAlignmentNative ((_Global : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setAlignmentNative(
            void* (* LLVMValueRef *) Global,
            uint32 Bytes)
        let setAlignment _Global _Bytes =
            setAlignmentNative ((_Global : ValueRef).Ptr, _Bytes)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addGlobalNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let addGlobal _M _Ty _Name =
            new ValueRef (addGlobalNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddGlobalInAddressSpace",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addGlobalInAddressSpaceNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            string Name,
            uint32 AddressSpace)
        let addGlobalInAddressSpace _M _Ty _Name _AddressSpace =
            new ValueRef (addGlobalInAddressSpaceNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, _Name, _AddressSpace))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNamedGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNamedGlobalNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getNamedGlobal _M _Name =
            new ValueRef (getNamedGlobalNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFirstGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstGlobalNative(
            void* (* LLVMModuleRef *) M)
        let getFirstGlobal _M =
            new ValueRef (getFirstGlobalNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetLastGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastGlobalNative(
            void* (* LLVMModuleRef *) M)
        let getLastGlobal _M =
            new ValueRef (getLastGlobalNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNextGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getNextGlobal _GlobalVar =
            new ValueRef (getNextGlobalNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPreviousGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getPreviousGlobal _GlobalVar =
            new ValueRef (getPreviousGlobalNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDeleteGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void deleteGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let deleteGlobal _GlobalVar =
            deleteGlobalNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetInitializer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getInitializerNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getInitializer _GlobalVar =
            new ValueRef (getInitializerNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetInitializer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInitializerNative(
            void* (* LLVMValueRef *) GlobalVar,
            void* (* LLVMValueRef *) ConstantVal)
        let setInitializer _GlobalVar _ConstantVal =
            setInitializerNative ((_GlobalVar : ValueRef).Ptr, (_ConstantVal : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsThreadLocal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isThreadLocalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isThreadLocal _GlobalVar =
            isThreadLocalNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetThreadLocal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setThreadLocalNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsThreadLocal)
        let setThreadLocal _GlobalVar _IsThreadLocal =
            setThreadLocalNative ((_GlobalVar : ValueRef).Ptr, _IsThreadLocal)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsGlobalConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isGlobalConstantNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isGlobalConstant _GlobalVar =
            isGlobalConstantNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetGlobalConstant",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setGlobalConstantNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsConstant)
        let setGlobalConstant _GlobalVar _IsConstant =
            setGlobalConstantNative ((_GlobalVar : ValueRef).Ptr, _IsConstant)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddAlias",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) addAliasNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Aliasee,
            string Name)
        let addAlias _M _Ty _Aliasee _Name =
            new ValueRef (addAliasNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, (_Aliasee : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDeleteFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void deleteFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let deleteFunction _Fn =
            deleteFunctionNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetIntrinsicID",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getIntrinsicIDNative(
            void* (* LLVMValueRef *) Fn)
        let getIntrinsicID _Fn =
            getIntrinsicIDNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFunctionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getFunctionCallConvNative(
            void* (* LLVMValueRef *) Fn)
        let getFunctionCallConv _Fn =
            getFunctionCallConvNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetFunctionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setFunctionCallConvNative(
            void* (* LLVMValueRef *) Fn,
            uint32 CC)
        let setFunctionCallConv _Fn _CC =
            setFunctionCallConvNative ((_Fn : ValueRef).Ptr, _CC)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetGC",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getGCNative(
            void* (* LLVMValueRef *) Fn)
        let getGC _Fn =
            Marshal.PtrToStringAuto (getGCNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetGC",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setGCNative(
            void* (* LLVMValueRef *) Fn,
            string Name)
        let setGC _Fn _Name =
            setGCNative ((_Fn : ValueRef).Ptr, _Name)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMAttribute *) PA)
        let addFunctionAttr _Fn _PA =
            addFunctionAttrNative ((_Fn : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMAttribute *) getFunctionAttrNative(
            void* (* LLVMValueRef *) Fn)
        let getFunctionAttr _Fn =
            enum<Attribute> (getFunctionAttrNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRemoveFunctionAttr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMAttribute *) PA)
        let removeFunctionAttr _Fn _PA =
            removeFunctionAttrNative ((_Fn : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCountParams",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countParamsNative(
            void* (* LLVMValueRef *) Fn)
        let countParams _Fn =
            countParamsNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetParams",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getParamsNative(
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Params)
        // I don't know how to generate an "F# friendly" version of LLVMGetParams

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getParamNative(
            void* (* LLVMValueRef *) Fn,
            uint32 Index)
        let getParam _Fn _Index =
            new ValueRef (getParamNative ((_Fn : ValueRef).Ptr, _Index))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetParamParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getParamParentNative(
            void* (* LLVMValueRef *) Inst)
        let getParamParent _Inst =
            new ValueRef (getParamParentNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFirstParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstParamNative(
            void* (* LLVMValueRef *) Fn)
        let getFirstParam _Fn =
            new ValueRef (getFirstParamNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetLastParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastParamNative(
            void* (* LLVMValueRef *) Fn)
        let getLastParam _Fn =
            new ValueRef (getLastParamNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNextParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextParamNative(
            void* (* LLVMValueRef *) Arg)
        let getNextParam _Arg =
            new ValueRef (getNextParamNative ((_Arg : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPreviousParam",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousParamNative(
            void* (* LLVMValueRef *) Arg)
        let getPreviousParam _Arg =
            new ValueRef (getPreviousParamNative ((_Arg : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAttributeNative(
            void* (* LLVMValueRef *) Arg,
            int (* LLVMAttribute *) PA)
        let addAttribute _Arg _PA =
            addAttributeNative ((_Arg : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRemoveAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeAttributeNative(
            void* (* LLVMValueRef *) Arg,
            int (* LLVMAttribute *) PA)
        let removeAttribute _Arg _PA =
            removeAttributeNative ((_Arg : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMAttribute *) getAttributeNative(
            void* (* LLVMValueRef *) Arg)
        let getAttribute _Arg =
            enum<Attribute> (getAttributeNative ((_Arg : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetParamAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setParamAlignmentNative(
            void* (* LLVMValueRef *) Arg,
            uint32 align)
        let setParamAlignment _Arg _align =
            setParamAlignmentNative ((_Arg : ValueRef).Ptr, _align)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMMDStringInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDStringInContextNative(
            void* (* LLVMContextRef *) C,
            string Str,
            uint32 SLen)
        let mDStringInContext _C _Str _SLen =
            new ValueRef (mDStringInContextNative ((_C : ContextRef).Ptr, _Str, _SLen))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMMDString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDStringNative(
            string Str,
            uint32 SLen)
        let mDString _Str _SLen =
            new ValueRef (mDStringNative (_Str, _SLen))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMMDNodeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDNodeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef* *) Vals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMMDNodeInContext

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMMDNode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) mDNodeNative(
            void* (* LLVMValueRef* *) Vals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMMDNode

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetMDString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getMDStringNative(
            void* (* LLVMValueRef *) V,
            uint32* Len)
        // I don't know how to generate an "F# friendly" version of LLVMGetMDString

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBasicBlockAsValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) basicBlockAsValueNative(
            void* (* LLVMBasicBlockRef *) BB)
        let basicBlockAsValue _BB =
            new ValueRef (basicBlockAsValueNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMValueIsBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool valueIsBasicBlockNative(
            void* (* LLVMValueRef *) Val)
        let valueIsBasicBlock _Val =
            valueIsBasicBlockNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMValueAsBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) valueAsBasicBlockNative(
            void* (* LLVMValueRef *) Val)
        let valueAsBasicBlock _Val =
            new BasicBlockRef (valueAsBasicBlockNative ((_Val : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBasicBlockParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getBasicBlockParentNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getBasicBlockParent _BB =
            new ValueRef (getBasicBlockParentNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBasicBlockTerminator",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getBasicBlockTerminatorNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getBasicBlockTerminator _BB =
            new ValueRef (getBasicBlockTerminatorNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCountBasicBlocks",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countBasicBlocksNative(
            void* (* LLVMValueRef *) Fn)
        let countBasicBlocks _Fn =
            countBasicBlocksNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBasicBlocks",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void getBasicBlocksNative(
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMBasicBlockRef* *) BasicBlocks)
        // I don't know how to generate an "F# friendly" version of LLVMGetBasicBlocks

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFirstBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getFirstBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getFirstBasicBlock _Fn =
            new BasicBlockRef (getFirstBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetLastBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getLastBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getLastBasicBlock _Fn =
            new BasicBlockRef (getLastBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNextBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getNextBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getNextBasicBlock _BB =
            new BasicBlockRef (getNextBasicBlockNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPreviousBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getPreviousBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getPreviousBasicBlock _BB =
            new BasicBlockRef (getPreviousBasicBlockNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetEntryBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getEntryBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getEntryBasicBlock _Fn =
            new BasicBlockRef (getEntryBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAppendBasicBlockInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) appendBasicBlockInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef *) Fn,
            string Name)
        let appendBasicBlockInContext _C _Fn _Name =
            new BasicBlockRef (appendBasicBlockInContextNative ((_C : ContextRef).Ptr, (_Fn : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAppendBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) appendBasicBlockNative(
            void* (* LLVMValueRef *) Fn,
            string Name)
        let appendBasicBlock _Fn _Name =
            new BasicBlockRef (appendBasicBlockNative ((_Fn : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInsertBasicBlockInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) insertBasicBlockInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMBasicBlockRef *) BB,
            string Name)
        let insertBasicBlockInContext _C _BB _Name =
            new BasicBlockRef (insertBasicBlockInContextNative ((_C : ContextRef).Ptr, (_BB : BasicBlockRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInsertBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) insertBasicBlockNative(
            void* (* LLVMBasicBlockRef *) InsertBeforeBB,
            string Name)
        let insertBasicBlock _InsertBeforeBB _Name =
            new BasicBlockRef (insertBasicBlockNative ((_InsertBeforeBB : BasicBlockRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDeleteBasicBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void deleteBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let deleteBasicBlock _BB =
            deleteBasicBlockNative ((_BB : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRemoveBasicBlockFromParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeBasicBlockFromParentNative(
            void* (* LLVMBasicBlockRef *) BB)
        let removeBasicBlockFromParent _BB =
            removeBasicBlockFromParentNative ((_BB : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMMoveBasicBlockBefore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveBasicBlockBeforeNative(
            void* (* LLVMBasicBlockRef *) BB,
            void* (* LLVMBasicBlockRef *) MovePos)
        let moveBasicBlockBefore _BB _MovePos =
            moveBasicBlockBeforeNative ((_BB : BasicBlockRef).Ptr, (_MovePos : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMMoveBasicBlockAfter",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void moveBasicBlockAfterNative(
            void* (* LLVMBasicBlockRef *) BB,
            void* (* LLVMBasicBlockRef *) MovePos)
        let moveBasicBlockAfter _BB _MovePos =
            moveBasicBlockAfterNative ((_BB : BasicBlockRef).Ptr, (_MovePos : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetFirstInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getFirstInstructionNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getFirstInstruction _BB =
            new ValueRef (getFirstInstructionNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetLastInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getLastInstructionNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getLastInstruction _BB =
            new ValueRef (getLastInstructionNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMHasMetadata",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int hasMetadataNative(
            void* (* LLVMValueRef *) Val)
        let hasMetadata _Val =
            hasMetadataNative ((_Val : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetMetadata",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getMetadataNative(
            void* (* LLVMValueRef *) Val,
            uint32 KindID)
        let getMetadata _Val _KindID =
            new ValueRef (getMetadataNative ((_Val : ValueRef).Ptr, _KindID))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetMetadata",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setMetadataNative(
            void* (* LLVMValueRef *) Val,
            uint32 KindID,
            void* (* LLVMValueRef *) Node)
        let setMetadata _Val _KindID _Node =
            setMetadataNative ((_Val : ValueRef).Ptr, _KindID, (_Node : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetInstructionParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getInstructionParentNative(
            void* (* LLVMValueRef *) Inst)
        let getInstructionParent _Inst =
            new BasicBlockRef (getInstructionParentNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetNextInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getNextInstructionNative(
            void* (* LLVMValueRef *) Inst)
        let getNextInstruction _Inst =
            new ValueRef (getNextInstructionNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPreviousInstruction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getPreviousInstructionNative(
            void* (* LLVMValueRef *) Inst)
        let getPreviousInstruction _Inst =
            new ValueRef (getPreviousInstructionNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInstructionEraseFromParent",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void instructionEraseFromParentNative(
            void* (* LLVMValueRef *) Inst)
        let instructionEraseFromParent _Inst =
            instructionEraseFromParentNative ((_Inst : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetInstructionOpcode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMOpcode *) getInstructionOpcodeNative(
            void* (* LLVMValueRef *) Inst)
        let getInstructionOpcode _Inst =
            enum<Opcode> (getInstructionOpcodeNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetICmpPredicate",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMIntPredicate *) getICmpPredicateNative(
            void* (* LLVMValueRef *) Inst)
        let getICmpPredicate _Inst =
            enum<IntPredicate> (getICmpPredicateNative ((_Inst : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetInstructionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInstructionCallConvNative(
            void* (* LLVMValueRef *) Instr,
            uint32 CC)
        let setInstructionCallConv _Instr _CC =
            setInstructionCallConvNative ((_Instr : ValueRef).Ptr, _CC)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetInstructionCallConv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 getInstructionCallConvNative(
            void* (* LLVMValueRef *) Instr)
        let getInstructionCallConv _Instr =
            getInstructionCallConvNative ((_Instr : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddInstrAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addInstrAttributeNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            int (* LLVMAttribute *) arg2)
        let addInstrAttribute _Instr _index _arg2 =
            addInstrAttributeNative ((_Instr : ValueRef).Ptr, _index, (int (_arg2 : Attribute)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRemoveInstrAttribute",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void removeInstrAttributeNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            int (* LLVMAttribute *) arg2)
        let removeInstrAttribute _Instr _index _arg2 =
            removeInstrAttributeNative ((_Instr : ValueRef).Ptr, _index, (int (_arg2 : Attribute)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetInstrParamAlignment",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInstrParamAlignmentNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            uint32 align)
        let setInstrParamAlignment _Instr _index _align =
            setInstrParamAlignmentNative ((_Instr : ValueRef).Ptr, _index, _align)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIsTailCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool isTailCallNative(
            void* (* LLVMValueRef *) CallInst)
        let isTailCall _CallInst =
            isTailCallNative ((_CallInst : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetTailCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setTailCallNative(
            void* (* LLVMValueRef *) CallInst,
            bool IsTailCall)
        let setTailCall _CallInst _IsTailCall =
            setTailCallNative ((_CallInst : ValueRef).Ptr, _IsTailCall)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetSwitchDefaultDest",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getSwitchDefaultDestNative(
            void* (* LLVMValueRef *) SwitchInstr)
        let getSwitchDefaultDest _SwitchInstr =
            new BasicBlockRef (getSwitchDefaultDestNative ((_SwitchInstr : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddIncoming",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIncomingNative(
            void* (* LLVMValueRef *) PhiNode,
            void* (* LLVMValueRef* *) IncomingValues,
            void* (* LLVMBasicBlockRef* *) IncomingBlocks,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMAddIncoming

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCountIncoming",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 countIncomingNative(
            void* (* LLVMValueRef *) PhiNode)
        let countIncoming _PhiNode =
            countIncomingNative ((_PhiNode : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetIncomingValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getIncomingValueNative(
            void* (* LLVMValueRef *) PhiNode,
            uint32 Index)
        let getIncomingValue _PhiNode _Index =
            new ValueRef (getIncomingValueNative ((_PhiNode : ValueRef).Ptr, _Index))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetIncomingBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getIncomingBlockNative(
            void* (* LLVMValueRef *) PhiNode,
            uint32 Index)
        let getIncomingBlock _PhiNode _Index =
            new BasicBlockRef (getIncomingBlockNative ((_PhiNode : ValueRef).Ptr, _Index))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateBuilderInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBuilderRef *) createBuilderInContextNative(
            void* (* LLVMContextRef *) C)
        let createBuilderInContext _C =
            new BuilderRef (createBuilderInContextNative ((_C : ContextRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBuilderRef *) createBuilderNative()
        let createBuilder () =
            new BuilderRef (createBuilderNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPositionBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void positionBuilderNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMBasicBlockRef *) Block,
            void* (* LLVMValueRef *) Instr)
        let positionBuilder _Builder _Block _Instr =
            positionBuilderNative ((_Builder : BuilderRef).Ptr, (_Block : BasicBlockRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPositionBuilderBefore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void positionBuilderBeforeNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr)
        let positionBuilderBefore _Builder _Instr =
            positionBuilderBeforeNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPositionBuilderAtEnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void positionBuilderAtEndNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMBasicBlockRef *) Block)
        let positionBuilderAtEnd _Builder _Block =
            positionBuilderAtEndNative ((_Builder : BuilderRef).Ptr, (_Block : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetInsertBlock",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMBasicBlockRef *) getInsertBlockNative(
            void* (* LLVMBuilderRef *) Builder)
        let getInsertBlock _Builder =
            new BasicBlockRef (getInsertBlockNative ((_Builder : BuilderRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMClearInsertionPosition",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void clearInsertionPositionNative(
            void* (* LLVMBuilderRef *) Builder)
        let clearInsertionPosition _Builder =
            clearInsertionPositionNative ((_Builder : BuilderRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInsertIntoBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void insertIntoBuilderNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr)
        let insertIntoBuilder _Builder _Instr =
            insertIntoBuilderNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInsertIntoBuilderWithName",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void insertIntoBuilderWithNameNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr,
            string Name)
        let insertIntoBuilderWithName _Builder _Instr _Name =
            insertIntoBuilderWithNameNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr, _Name)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeBuilder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeBuilderNative(
            void* (* LLVMBuilderRef *) Builder)
        let disposeBuilder _Builder =
            disposeBuilderNative ((_Builder : BuilderRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetCurrentDebugLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setCurrentDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) L)
        let setCurrentDebugLocation _Builder _L =
            setCurrentDebugLocationNative ((_Builder : BuilderRef).Ptr, (_L : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetCurrentDebugLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) getCurrentDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder)
        let getCurrentDebugLocation _Builder =
            new ValueRef (getCurrentDebugLocationNative ((_Builder : BuilderRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetInstDebugLocation",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setInstDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Inst)
        let setInstDebugLocation _Builder _Inst =
            setInstDebugLocationNative ((_Builder : BuilderRef).Ptr, (_Inst : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildRetVoid",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildRetVoidNative(
            void* (* LLVMBuilderRef *) arg0)
        let buildRetVoid _arg0 =
            new ValueRef (buildRetVoidNative ((_arg0 : BuilderRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildRet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildRetNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V)
        let buildRet _arg0 _V =
            new ValueRef (buildRetNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildAggregateRet",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAggregateRetNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef* *) RetVals,
            uint32 N)
        // I don't know how to generate an "F# friendly" version of LLVMBuildAggregateRet

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildBr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildBrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMBasicBlockRef *) Dest)
        let buildBr _arg0 _Dest =
            new ValueRef (buildBrNative ((_arg0 : BuilderRef).Ptr, (_Dest : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildCondBr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildCondBrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) If,
            void* (* LLVMBasicBlockRef *) Then,
            void* (* LLVMBasicBlockRef *) Else)
        let buildCondBr _arg0 _If _Then _Else =
            new ValueRef (buildCondBrNative ((_arg0 : BuilderRef).Ptr, (_If : ValueRef).Ptr, (_Then : BasicBlockRef).Ptr, (_Else : BasicBlockRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSwitch",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSwitchNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            void* (* LLVMBasicBlockRef *) Else,
            uint32 NumCases)
        let buildSwitch _arg0 _V _Else _NumCases =
            new ValueRef (buildSwitchNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, (_Else : BasicBlockRef).Ptr, _NumCases))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildIndirectBr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIndirectBrNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Addr,
            uint32 NumDests)
        let buildIndirectBr _B _Addr _NumDests =
            new ValueRef (buildIndirectBrNative ((_B : BuilderRef).Ptr, (_Addr : ValueRef).Ptr, _NumDests))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildInvoke",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInvokeNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Args,
            uint32 NumArgs,
            void* (* LLVMBasicBlockRef *) Then,
            void* (* LLVMBasicBlockRef *) Catch,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildInvoke

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildLandingPad",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildLandingPadNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) PersFn,
            uint32 NumClauses,
            string Name)
        let buildLandingPad _B _Ty _PersFn _NumClauses _Name =
            new ValueRef (buildLandingPadNative ((_B : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_PersFn : ValueRef).Ptr, _NumClauses, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildResume",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildResumeNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Exn)
        let buildResume _B _Exn =
            new ValueRef (buildResumeNative ((_B : BuilderRef).Ptr, (_Exn : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildUnreachable",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildUnreachableNative(
            void* (* LLVMBuilderRef *) arg0)
        let buildUnreachable _arg0 =
            new ValueRef (buildUnreachableNative ((_arg0 : BuilderRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddCase",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addCaseNative(
            void* (* LLVMValueRef *) Switch,
            void* (* LLVMValueRef *) OnVal,
            void* (* LLVMBasicBlockRef *) Dest)
        let addCase _Switch _OnVal _Dest =
            addCaseNative ((_Switch : ValueRef).Ptr, (_OnVal : ValueRef).Ptr, (_Dest : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddDestination",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDestinationNative(
            void* (* LLVMValueRef *) IndirectBr,
            void* (* LLVMBasicBlockRef *) Dest)
        let addDestination _IndirectBr _Dest =
            addDestinationNative ((_IndirectBr : ValueRef).Ptr, (_Dest : BasicBlockRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddClause",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addClauseNative(
            void* (* LLVMValueRef *) LandingPad,
            void* (* LLVMValueRef *) ClauseVal)
        let addClause _LandingPad _ClauseVal =
            addClauseNative ((_LandingPad : ValueRef).Ptr, (_ClauseVal : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetCleanup",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setCleanupNative(
            void* (* LLVMValueRef *) LandingPad,
            bool Val)
        let setCleanup _LandingPad _Val =
            setCleanupNative ((_LandingPad : ValueRef).Ptr, _Val)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNSWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNUWAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFAdd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildFAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNSWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNUWSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFSub",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildFSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNSWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNUWMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFMul",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildFMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildUDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildUDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildUDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildUDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildSDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildExactSDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildExactSDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildExactSDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildExactSDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFDiv",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildFDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildURem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildURemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildURem _arg0 _LHS _RHS _Name =
            new ValueRef (buildURemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSRemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSRem _arg0 _LHS _RHS _Name =
            new ValueRef (buildSRemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFRem",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFRemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFRem _arg0 _LHS _RHS _Name =
            new ValueRef (buildFRemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildShl",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildShlNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildShl _arg0 _LHS _RHS _Name =
            new ValueRef (buildShlNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildLShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildLShrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildLShr _arg0 _LHS _RHS _Name =
            new ValueRef (buildLShrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildAShr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAShrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAShr _arg0 _LHS _RHS _Name =
            new ValueRef (buildAShrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildAnd",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAndNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAnd _arg0 _LHS _RHS _Name =
            new ValueRef (buildAndNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildOr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildOrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildOr _arg0 _LHS _RHS _Name =
            new ValueRef (buildOrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildXor",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildXorNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildXor _arg0 _LHS _RHS _Name =
            new ValueRef (buildXorNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildBinOp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildBinOpNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMOpcode *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildBinOp _B _Op _LHS _RHS _Name =
            new ValueRef (buildBinOpNative ((_B : BuilderRef).Ptr, (int (_Op : Opcode)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNegNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNeg _arg0 _V _Name =
            new ValueRef (buildNegNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNSWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNSWNegNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNSWNeg _B _V _Name =
            new ValueRef (buildNSWNegNative ((_B : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNUWNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNUWNegNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNUWNeg _B _V _Name =
            new ValueRef (buildNUWNegNative ((_B : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFNeg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFNegNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildFNeg _arg0 _V _Name =
            new ValueRef (buildFNegNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildNot",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildNotNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNot _arg0 _V _Name =
            new ValueRef (buildNotNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildMalloc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildMallocNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildMalloc _arg0 _Ty _Name =
            new ValueRef (buildMallocNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildArrayMalloc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildArrayMallocNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildArrayMalloc _arg0 _Ty _Val _Name =
            new ValueRef (buildArrayMallocNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildAlloca",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildAllocaNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildAlloca _arg0 _Ty _Name =
            new ValueRef (buildAllocaNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildArrayAlloca",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildArrayAllocaNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildArrayAlloca _arg0 _Ty _Val _Name =
            new ValueRef (buildArrayAllocaNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFree",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFreeNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) PointerVal)
        let buildFree _arg0 _PointerVal =
            new ValueRef (buildFreeNative ((_arg0 : BuilderRef).Ptr, (_PointerVal : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildLoad",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildLoadNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) PointerVal,
            string Name)
        let buildLoad _arg0 _PointerVal _Name =
            new ValueRef (buildLoadNative ((_arg0 : BuilderRef).Ptr, (_PointerVal : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildStore",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildStoreNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMValueRef *) Ptr)
        let buildStore _arg0 _Val _Ptr =
            new ValueRef (buildStoreNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_Ptr : ValueRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            void* (* LLVMValueRef* *) Indices,
            uint32 NumIndices,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildGEP

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildInBoundsGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInBoundsGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            void* (* LLVMValueRef* *) Indices,
            uint32 NumIndices,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildInBoundsGEP

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildStructGEP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildStructGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            uint32 Idx,
            string Name)
        let buildStructGEP _B _Pointer _Idx _Name =
            new ValueRef (buildStructGEPNative ((_B : BuilderRef).Ptr, (_Pointer : ValueRef).Ptr, _Idx, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildGlobalString",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildGlobalStringNative(
            void* (* LLVMBuilderRef *) B,
            string Str,
            string Name)
        let buildGlobalString _B _Str _Name =
            new ValueRef (buildGlobalStringNative ((_B : BuilderRef).Ptr, _Str, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildGlobalStringPtr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildGlobalStringPtrNative(
            void* (* LLVMBuilderRef *) B,
            string Str,
            string Name)
        let buildGlobalStringPtr _B _Str _Name =
            new ValueRef (buildGlobalStringPtrNative ((_B : BuilderRef).Ptr, _Str, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetVolatile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getVolatileNative(
            void* (* LLVMValueRef *) MemoryAccessInst)
        let getVolatile _MemoryAccessInst =
            getVolatileNative ((_MemoryAccessInst : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSetVolatile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void setVolatileNative(
            void* (* LLVMValueRef *) MemoryAccessInst,
            bool IsVolatile)
        let setVolatile _MemoryAccessInst _IsVolatile =
            setVolatileNative ((_MemoryAccessInst : ValueRef).Ptr, _IsVolatile)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildTruncNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildTrunc _arg0 _Val _DestTy _Name =
            new ValueRef (buildTruncNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildZExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildZExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildZExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildZExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildSExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFPToUI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPToUINative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPToUI _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPToUINative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFPToSI",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPToSINative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPToSI _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPToSINative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildUIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildUIToFPNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildUIToFP _arg0 _Val _DestTy _Name =
            new ValueRef (buildUIToFPNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSIToFP",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSIToFPNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSIToFP _arg0 _Val _DestTy _Name =
            new ValueRef (buildSIToFPNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFPTrunc",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPTruncNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPTrunc _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPTruncNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFPExt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildPtrToInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPtrToIntNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildPtrToInt _arg0 _Val _DestTy _Name =
            new ValueRef (buildPtrToIntNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildIntToPtr",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIntToPtrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildIntToPtr _arg0 _Val _DestTy _Name =
            new ValueRef (buildIntToPtrNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildZExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildZExtOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildZExtOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildZExtOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSExtOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSExtOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSExtOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildSExtOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildTruncOrBitCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildTruncOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildTruncOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildTruncOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildCastNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMOpcode *) Op,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildCast _B _Op _Val _DestTy _Name =
            new ValueRef (buildCastNative ((_B : BuilderRef).Ptr, (int (_Op : Opcode)), (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildPointerCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPointerCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildPointerCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildPointerCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildIntCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIntCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildIntCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildIntCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFPCast",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFPCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildICmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildICmpNative(
            void* (* LLVMBuilderRef *) arg0,
            int (* LLVMIntPredicate *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildICmp _arg0 _Op _LHS _RHS _Name =
            new ValueRef (buildICmpNative ((_arg0 : BuilderRef).Ptr, (int (_Op : IntPredicate)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildFCmp",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildFCmpNative(
            void* (* LLVMBuilderRef *) arg0,
            int (* LLVMRealPredicate *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFCmp _arg0 _Op _LHS _RHS _Name =
            new ValueRef (buildFCmpNative ((_arg0 : BuilderRef).Ptr, (int (_Op : RealPredicate)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildPhi",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPhiNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildPhi _arg0 _Ty _Name =
            new ValueRef (buildPhiNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildCall",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildCallNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Args,
            uint32 NumArgs,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildCall

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildSelect",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildSelectNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) If,
            void* (* LLVMValueRef *) Then,
            void* (* LLVMValueRef *) Else,
            string Name)
        let buildSelect _arg0 _If _Then _Else _Name =
            new ValueRef (buildSelectNative ((_arg0 : BuilderRef).Ptr, (_If : ValueRef).Ptr, (_Then : ValueRef).Ptr, (_Else : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildVAArg",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildVAArgNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) List,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildVAArg _arg0 _List _Ty _Name =
            new ValueRef (buildVAArgNative ((_arg0 : BuilderRef).Ptr, (_List : ValueRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildExtractElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildExtractElementNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) VecVal,
            void* (* LLVMValueRef *) Index,
            string Name)
        let buildExtractElement _arg0 _VecVal _Index _Name =
            new ValueRef (buildExtractElementNative ((_arg0 : BuilderRef).Ptr, (_VecVal : ValueRef).Ptr, (_Index : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildInsertElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInsertElementNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) VecVal,
            void* (* LLVMValueRef *) EltVal,
            void* (* LLVMValueRef *) Index,
            string Name)
        let buildInsertElement _arg0 _VecVal _EltVal _Index _Name =
            new ValueRef (buildInsertElementNative ((_arg0 : BuilderRef).Ptr, (_VecVal : ValueRef).Ptr, (_EltVal : ValueRef).Ptr, (_Index : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildShuffleVector",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildShuffleVectorNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V1,
            void* (* LLVMValueRef *) V2,
            void* (* LLVMValueRef *) Mask,
            string Name)
        let buildShuffleVector _arg0 _V1 _V2 _Mask _Name =
            new ValueRef (buildShuffleVectorNative ((_arg0 : BuilderRef).Ptr, (_V1 : ValueRef).Ptr, (_V2 : ValueRef).Ptr, (_Mask : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildExtractValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildExtractValueNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) AggVal,
            uint32 Index,
            string Name)
        let buildExtractValue _arg0 _AggVal _Index _Name =
            new ValueRef (buildExtractValueNative ((_arg0 : BuilderRef).Ptr, (_AggVal : ValueRef).Ptr, _Index, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildInsertValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildInsertValueNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) AggVal,
            void* (* LLVMValueRef *) EltVal,
            uint32 Index,
            string Name)
        let buildInsertValue _arg0 _AggVal _EltVal _Index _Name =
            new ValueRef (buildInsertValueNative ((_arg0 : BuilderRef).Ptr, (_AggVal : ValueRef).Ptr, (_EltVal : ValueRef).Ptr, _Index, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildIsNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIsNullNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildIsNull _arg0 _Val _Name =
            new ValueRef (buildIsNullNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildIsNotNull",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildIsNotNullNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildIsNotNull _arg0 _Val _Name =
            new ValueRef (buildIsNotNullNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMBuildPtrDiff",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMValueRef *) buildPtrDiffNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildPtrDiff _arg0 _LHS _RHS _Name =
            new ValueRef (buildPtrDiffNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateModuleProviderForExistingModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMModuleProviderRef *) createModuleProviderForExistingModuleNative(
            void* (* LLVMModuleRef *) M)
        let createModuleProviderForExistingModule _M =
            new ModuleProviderRef (createModuleProviderForExistingModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeModuleProviderNative(
            void* (* LLVMModuleProviderRef *) M)
        let disposeModuleProvider _M =
            disposeModuleProviderNative ((_M : ModuleProviderRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateMemoryBufferWithContentsOfFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createMemoryBufferWithContentsOfFileNative(
            string Path,
            void* (* LLVMMemoryBufferRef* *) OutMemBuf,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMemoryBufferWithContentsOfFile

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateMemoryBufferWithSTDIN",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createMemoryBufferWithSTDINNative(
            void* (* LLVMMemoryBufferRef* *) OutMemBuf,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMemoryBufferWithSTDIN

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeMemoryBuffer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeMemoryBufferNative(
            void* (* LLVMMemoryBufferRef *) MemBuf)
        let disposeMemoryBuffer _MemBuf =
            disposeMemoryBufferNative ((_MemBuf : MemoryBufferRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetGlobalPassRegistry",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassRegistryRef *) getGlobalPassRegistryNative()
        let getGlobalPassRegistry () =
            new PassRegistryRef (getGlobalPassRegistryNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreatePassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassManagerRef *) createPassManagerNative()
        let createPassManager () =
            new PassManagerRef (createPassManagerNative ())

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateFunctionPassManagerForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassManagerRef *) createFunctionPassManagerForModuleNative(
            void* (* LLVMModuleRef *) M)
        let createFunctionPassManagerForModule _M =
            new PassManagerRef (createFunctionPassManagerForModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMPassManagerRef *) createFunctionPassManagerNative(
            void* (* LLVMModuleProviderRef *) MP)
        let createFunctionPassManager _MP =
            new PassManagerRef (createFunctionPassManagerNative ((_MP : ModuleProviderRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRunPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool runPassManagerNative(
            void* (* LLVMPassManagerRef *) PM,
            void* (* LLVMModuleRef *) M)
        let runPassManager _PM _M =
            runPassManagerNative ((_PM : PassManagerRef).Ptr, (_M : ModuleRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMInitializeFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool initializeFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM)
        let initializeFunctionPassManager _FPM =
            initializeFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRunFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool runFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM,
            void* (* LLVMValueRef *) F)
        let runFunctionPassManager _FPM _F =
            runFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr, (_F : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFinalizeFunctionPassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool finalizeFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM)
        let finalizeFunctionPassManager _FPM =
            finalizeFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposePassManager",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposePassManagerNative(
            void* (* LLVMPassManagerRef *) PM)
        let disposePassManager _PM =
            disposePassManagerNative ((_PM : PassManagerRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module BitReader =

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMParseBitcode",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool parseBitcodeNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutModule,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMParseBitcode

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMParseBitcodeInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool parseBitcodeInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutModule,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMParseBitcodeInContext

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBitcodeModuleInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutM,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleInContext

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBitcodeModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutM,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModule

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBitcodeModuleProviderInContext",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleProviderInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleProviderRef* *) OutMP,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleProviderInContext

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetBitcodeModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool getBitcodeModuleProviderNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleProviderRef* *) OutMP,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleProvider

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module BitWriter =

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMWriteBitcodeToFile",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int writeBitcodeToFileNative(
            void* (* LLVMModuleRef *) M,
            string Path)
        let writeBitcodeToFile _M _Path =
            writeBitcodeToFileNative ((_M : ModuleRef).Ptr, _Path)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMWriteBitcodeToFD",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int writeBitcodeToFDNative(
            void* (* LLVMModuleRef *) M,
            int FD,
            int ShouldClose,
            int Unbuffered)
        let writeBitcodeToFD _M _FD _ShouldClose _Unbuffered =
            writeBitcodeToFDNative ((_M : ModuleRef).Ptr, _FD, _ShouldClose, _Unbuffered)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMWriteBitcodeToFileHandle",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int writeBitcodeToFileHandleNative(
            void* (* LLVMModuleRef *) M,
            int Handle)
        let writeBitcodeToFileHandle _M _Handle =
            writeBitcodeToFileHandleNative ((_M : ModuleRef).Ptr, _Handle)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Target =

        type ByteOrdering =
            | BigEndian = 0
            | LittleEndian = 1

        type TargetDataRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type TargetLibraryInfoRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type StructLayoutRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetDataRef *) createTargetDataNative(
            string StringRep)
        let createTargetData _StringRep =
            new TargetDataRef (createTargetDataNative (_StringRep))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTargetDataNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMPassManagerRef *) arg1)
        let addTargetData _arg0 _arg1 =
            addTargetDataNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddTargetLibraryInfo",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTargetLibraryInfoNative(
            void* (* LLVMTargetLibraryInfoRef *) arg0,
            void* (* LLVMPassManagerRef *) arg1)
        let addTargetLibraryInfo _arg0 _arg1 =
            addTargetLibraryInfoNative ((_arg0 : TargetLibraryInfoRef).Ptr, (_arg1 : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCopyStringRepOfTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* copyStringRepOfTargetDataNative(
            void* (* LLVMTargetDataRef *) arg0)
        let copyStringRepOfTargetData _arg0 =
            Marshal.PtrToStringAuto (copyStringRepOfTargetDataNative ((_arg0 : TargetDataRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMByteOrder",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int (* LLVMByteOrdering *) byteOrderNative(
            void* (* LLVMTargetDataRef *) arg0)
        let byteOrder _arg0 =
            enum<ByteOrdering> (byteOrderNative ((_arg0 : TargetDataRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPointerSize",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 pointerSizeNative(
            void* (* LLVMTargetDataRef *) arg0)
        let pointerSize _arg0 =
            pointerSizeNative ((_arg0 : TargetDataRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMIntPtrType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTypeRef *) intPtrTypeNative(
            void* (* LLVMTargetDataRef *) arg0)
        let intPtrType _arg0 =
            new TypeRef (intPtrTypeNative ((_arg0 : TargetDataRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMSizeOfTypeInBits",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 sizeOfTypeInBitsNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let sizeOfTypeInBits _arg0 _arg1 =
            sizeOfTypeInBitsNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMStoreSizeOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 storeSizeOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let storeSizeOfType _arg0 _arg1 =
            storeSizeOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMABISizeOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 aBISizeOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let aBISizeOfType _arg0 _arg1 =
            aBISizeOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMABIAlignmentOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 aBIAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let aBIAlignmentOfType _arg0 _arg1 =
            aBIAlignmentOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCallFrameAlignmentOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 callFrameAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let callFrameAlignmentOfType _arg0 _arg1 =
            callFrameAlignmentOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPreferredAlignmentOfType",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 preferredAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let preferredAlignmentOfType _arg0 _arg1 =
            preferredAlignmentOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMPreferredAlignmentOfGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 preferredAlignmentOfGlobalNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMValueRef *) GlobalVar)
        let preferredAlignmentOfGlobal _arg0 _GlobalVar =
            preferredAlignmentOfGlobalNative ((_arg0 : TargetDataRef).Ptr, (_GlobalVar : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMElementAtOffset",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 elementAtOffsetNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) StructTy,
            uint64 Offset)
        let elementAtOffset _arg0 _StructTy _Offset =
            elementAtOffsetNative ((_arg0 : TargetDataRef).Ptr, (_StructTy : TypeRef).Ptr, _Offset)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMOffsetOfElement",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 offsetOfElementNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) StructTy,
            uint32 Element)
        let offsetOfElement _arg0 _StructTy _Element =
            offsetOfElementNative ((_arg0 : TargetDataRef).Ptr, (_StructTy : TypeRef).Ptr, _Element)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeTargetDataNative(
            void* (* LLVMTargetDataRef *) arg0)
        let disposeTargetData _arg0 =
            disposeTargetDataNative ((_arg0 : TargetDataRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core
    open LLVM.Generated.Target

    module ExecutionEngine =

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMLinkInJIT",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void linkInJITNative()
        let linkInJIT () =
            linkInJITNative ()

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMLinkInInterpreter",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void linkInInterpreterNative()
        let linkInInterpreter () =
            linkInInterpreterNative ()

        type GenericValueRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        type ExecutionEngineRef (thePtr : nativeint) =
            member x.Ptr = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr = thePtr

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateGenericValueOfInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfIntNative(
            void* (* LLVMTypeRef *) Ty,
            uint64 N,
            bool IsSigned)
        let createGenericValueOfInt _Ty _N _IsSigned =
            new GenericValueRef (createGenericValueOfIntNative ((_Ty : TypeRef).Ptr, _N, _IsSigned))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateGenericValueOfPointer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfPointerNative(
            void* P)
        // I don't know how to generate an "F# friendly" version of LLVMCreateGenericValueOfPointer

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateGenericValueOfFloat",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfFloatNative(
            void* (* LLVMTypeRef *) Ty,
            double N)
        let createGenericValueOfFloat _Ty _N =
            new GenericValueRef (createGenericValueOfFloatNative ((_Ty : TypeRef).Ptr, _N))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGenericValueIntWidth",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint32 genericValueIntWidthNative(
            void* (* LLVMGenericValueRef *) GenValRef)
        let genericValueIntWidth _GenValRef =
            genericValueIntWidthNative ((_GenValRef : GenericValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGenericValueToInt",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern uint64 genericValueToIntNative(
            void* (* LLVMGenericValueRef *) GenVal,
            bool IsSigned)
        let genericValueToInt _GenVal _IsSigned =
            genericValueToIntNative ((_GenVal : GenericValueRef).Ptr, _IsSigned)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGenericValueToPointer",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* genericValueToPointerNative(
            void* (* LLVMGenericValueRef *) GenVal)
        // I don't know how to generate an "F# friendly" version of LLVMGenericValueToPointer

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGenericValueToFloat",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern double genericValueToFloatNative(
            void* (* LLVMTypeRef *) TyRef,
            void* (* LLVMGenericValueRef *) GenVal)
        let genericValueToFloat _TyRef _GenVal =
            genericValueToFloatNative ((_TyRef : TypeRef).Ptr, (_GenVal : GenericValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeGenericValue",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeGenericValueNative(
            void* (* LLVMGenericValueRef *) GenVal)
        let disposeGenericValue _GenVal =
            disposeGenericValueNative ((_GenVal : GenericValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateExecutionEngineForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createExecutionEngineForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutEE,
            void* (* LLVMModuleRef *) M,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateExecutionEngineForModule

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateInterpreterForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createInterpreterForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutInterp,
            void* (* LLVMModuleRef *) M,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateInterpreterForModule

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateJITCompilerForModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createJITCompilerForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleRef *) M,
            uint32 OptLevel,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateJITCompilerForModule

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateExecutionEngine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createExecutionEngineNative(
            void* (* LLVMExecutionEngineRef* *) OutEE,
            void* (* LLVMModuleProviderRef *) MP,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateExecutionEngine

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateInterpreter",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createInterpreterNative(
            void* (* LLVMExecutionEngineRef* *) OutInterp,
            void* (* LLVMModuleProviderRef *) MP,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateInterpreter

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMCreateJITCompiler",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool createJITCompilerNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleProviderRef *) MP,
            uint32 OptLevel,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateJITCompiler

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMDisposeExecutionEngine",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void disposeExecutionEngineNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let disposeExecutionEngine _EE =
            disposeExecutionEngineNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRunStaticConstructors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void runStaticConstructorsNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let runStaticConstructors _EE =
            runStaticConstructorsNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRunStaticDestructors",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void runStaticDestructorsNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let runStaticDestructors _EE =
            runStaticDestructorsNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRunFunctionAsMain",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern int runFunctionAsMainNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F,
            uint32 ArgC,
            void* ArgV,
            void* EnvP)
        // I don't know how to generate an "F# friendly" version of LLVMRunFunctionAsMain

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRunFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMGenericValueRef *) runFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F,
            uint32 NumArgs,
            void* (* LLVMGenericValueRef* *) Args)
        // I don't know how to generate an "F# friendly" version of LLVMRunFunction

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFreeMachineCodeForFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void freeMachineCodeForFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F)
        let freeMachineCodeForFunction _EE _F =
            freeMachineCodeForFunctionNative ((_EE : ExecutionEngineRef).Ptr, (_F : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addModuleNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleRef *) M)
        let addModule _EE _M =
            addModuleNative ((_EE : ExecutionEngineRef).Ptr, (_M : ModuleRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addModuleProviderNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleProviderRef *) MP)
        let addModuleProvider _EE _MP =
            addModuleProviderNative ((_EE : ExecutionEngineRef).Ptr, (_MP : ModuleProviderRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRemoveModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool removeModuleNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleRef *) M,
            void* (* LLVMModuleRef* *) OutMod,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMRemoveModule

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRemoveModuleProvider",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool removeModuleProviderNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleProviderRef *) MP,
            void* (* LLVMModuleRef* *) OutMod,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMRemoveModuleProvider

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMFindFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool findFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            string Name,
            void* (* LLVMValueRef* *) OutFn)
        // I don't know how to generate an "F# friendly" version of LLVMFindFunction

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMRecompileAndRelinkFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* recompileAndRelinkFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Fn)
        // I don't know how to generate an "F# friendly" version of LLVMRecompileAndRelinkFunction

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetExecutionEngineTargetData",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* (* LLVMTargetDataRef *) getExecutionEngineTargetDataNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let getExecutionEngineTargetData _EE =
            new TargetDataRef (getExecutionEngineTargetDataNative ((_EE : ExecutionEngineRef).Ptr))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddGlobalMapping",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGlobalMappingNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Global,
            void* Addr)
        // I don't know how to generate an "F# friendly" version of LLVMAddGlobalMapping

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMGetPointerToGlobal",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void* getPointerToGlobalNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Global)
        // I don't know how to generate an "F# friendly" version of LLVMGetPointerToGlobal

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Analysis =

        type VerifierFailureAction =
            | AbortProcessAction = 0
            | PrintMessageAction = 1
            | ReturnStatusAction = 2

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMVerifyModule",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool verifyModuleNative(
            void* (* LLVMModuleRef *) M,
            int (* LLVMVerifierFailureAction *) Action,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMVerifyModule

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMVerifyFunction",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern bool verifyFunctionNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMVerifierFailureAction *) Action)
        let verifyFunction _Fn _Action =
            verifyFunctionNative ((_Fn : ValueRef).Ptr, (int (_Action : VerifierFailureAction)))

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMViewFunctionCFG",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void viewFunctionCFGNative(
            void* (* LLVMValueRef *) Fn)
        let viewFunctionCFG _Fn =
            viewFunctionCFGNative ((_Fn : ValueRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMViewFunctionCFGOnly",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void viewFunctionCFGOnlyNative(
            void* (* LLVMValueRef *) Fn)
        let viewFunctionCFGOnly _Fn =
            viewFunctionCFGOnlyNative ((_Fn : ValueRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated.Transforms

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module Scalar =

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddAggressiveDCEPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAggressiveDCEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAggressiveDCEPass _PM =
            addAggressiveDCEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddCFGSimplificationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addCFGSimplificationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addCFGSimplificationPass _PM =
            addCFGSimplificationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddDeadStoreEliminationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDeadStoreEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDeadStoreEliminationPass _PM =
            addDeadStoreEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddGVNPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGVNPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGVNPass _PM =
            addGVNPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddIndVarSimplifyPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIndVarSimplifyPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIndVarSimplifyPass _PM =
            addIndVarSimplifyPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddInstructionCombiningPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addInstructionCombiningPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addInstructionCombiningPass _PM =
            addInstructionCombiningPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddJumpThreadingPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addJumpThreadingPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addJumpThreadingPass _PM =
            addJumpThreadingPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLICMPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLICMPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLICMPass _PM =
            addLICMPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLoopDeletionPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopDeletionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopDeletionPass _PM =
            addLoopDeletionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLoopIdiomPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopIdiomPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopIdiomPass _PM =
            addLoopIdiomPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLoopRotatePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopRotatePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopRotatePass _PM =
            addLoopRotatePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLoopUnrollPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopUnrollPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopUnrollPass _PM =
            addLoopUnrollPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLoopUnswitchPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLoopUnswitchPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopUnswitchPass _PM =
            addLoopUnswitchPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddMemCpyOptPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addMemCpyOptPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addMemCpyOptPass _PM =
            addMemCpyOptPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddPromoteMemoryToRegisterPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addPromoteMemoryToRegisterPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPromoteMemoryToRegisterPass _PM =
            addPromoteMemoryToRegisterPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddReassociatePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addReassociatePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addReassociatePass _PM =
            addReassociatePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddSCCPPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addSCCPPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addSCCPPass _PM =
            addSCCPPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddScalarReplAggregatesPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarReplAggregatesPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarReplAggregatesPass _PM =
            addScalarReplAggregatesPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddScalarReplAggregatesPassSSA",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarReplAggregatesPassSSANative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarReplAggregatesPassSSA _PM =
            addScalarReplAggregatesPassSSANative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddScalarReplAggregatesPassWithThreshold",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addScalarReplAggregatesPassWithThresholdNative(
            void* (* LLVMPassManagerRef *) PM,
            int Threshold)
        let addScalarReplAggregatesPassWithThreshold _PM _Threshold =
            addScalarReplAggregatesPassWithThresholdNative ((_PM : PassManagerRef).Ptr, _Threshold)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddSimplifyLibCallsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addSimplifyLibCallsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addSimplifyLibCallsPass _PM =
            addSimplifyLibCallsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddTailCallEliminationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTailCallEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addTailCallEliminationPass _PM =
            addTailCallEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddConstantPropagationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addConstantPropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addConstantPropagationPass _PM =
            addConstantPropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddDemoteMemoryToRegisterPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDemoteMemoryToRegisterPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDemoteMemoryToRegisterPass _PM =
            addDemoteMemoryToRegisterPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddVerifierPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addVerifierPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addVerifierPass _PM =
            addVerifierPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddCorrelatedValuePropagationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addCorrelatedValuePropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addCorrelatedValuePropagationPass _PM =
            addCorrelatedValuePropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddEarlyCSEPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addEarlyCSEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addEarlyCSEPass _PM =
            addEarlyCSEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddLowerExpectIntrinsicPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addLowerExpectIntrinsicPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLowerExpectIntrinsicPass _PM =
            addLowerExpectIntrinsicPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddTypeBasedAliasAnalysisPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addTypeBasedAliasAnalysisPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addTypeBasedAliasAnalysisPass _PM =
            addTypeBasedAliasAnalysisPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddBasicAliasAnalysisPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addBasicAliasAnalysisPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addBasicAliasAnalysisPass _PM =
            addBasicAliasAnalysisPassNative ((_PM : PassManagerRef).Ptr)

// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated.Transforms

    open LLVM.FFIUtil
    open System.Runtime.InteropServices
    open LLVM.Generated.Core

    module IPO =

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddArgumentPromotionPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addArgumentPromotionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addArgumentPromotionPass _PM =
            addArgumentPromotionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddConstantMergePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addConstantMergePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addConstantMergePass _PM =
            addConstantMergePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddDeadArgEliminationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addDeadArgEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDeadArgEliminationPass _PM =
            addDeadArgEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddFunctionAttrsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addFunctionAttrsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addFunctionAttrsPass _PM =
            addFunctionAttrsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddFunctionInliningPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addFunctionInliningPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addFunctionInliningPass _PM =
            addFunctionInliningPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddAlwaysInlinerPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addAlwaysInlinerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAlwaysInlinerPass _PM =
            addAlwaysInlinerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddGlobalDCEPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGlobalDCEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGlobalDCEPass _PM =
            addGlobalDCEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddGlobalOptimizerPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addGlobalOptimizerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGlobalOptimizerPass _PM =
            addGlobalOptimizerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddIPConstantPropagationPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIPConstantPropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIPConstantPropagationPass _PM =
            addIPConstantPropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddPruneEHPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addPruneEHPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPruneEHPass _PM =
            addPruneEHPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddIPSCCPPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addIPSCCPPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIPSCCPPass _PM =
            addIPSCCPPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddInternalizePass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addInternalizePassNative(
            void* (* LLVMPassManagerRef *) arg0,
            uint32 AllButMain)
        let addInternalizePass _arg0 _AllButMain =
            addInternalizePassNative ((_arg0 : PassManagerRef).Ptr, _AllButMain)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddStripDeadPrototypesPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addStripDeadPrototypesPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addStripDeadPrototypesPass _PM =
            addStripDeadPrototypesPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport(
            "LLVM-3.1.dll",
            EntryPoint="LLVMAddStripSymbolsPass",
            CallingConvention=CallingConvention.Cdecl,
            CharSet=CharSet.Ansi)>]
        extern void addStripSymbolsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addStripSymbolsPass _PM =
            addStripSymbolsPassNative ((_PM : PassManagerRef).Ptr)

