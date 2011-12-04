// This file should not be edited. It is automatically generated from a C header file
namespace LLVM.Generated

    open LLVM.FFIUtil
    open System.Runtime.InteropServices

    module Core =

        type ContextRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type ModuleRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type TypeRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type ValueRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type BasicBlockRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type BuilderRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type ModuleProviderRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type MemoryBufferRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type PassManagerRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type PassRegistryRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type UseRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

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
            | Unwind = 60

        type TypeKind =
            | VoidTypeKind = 0
            | FloatTypeKind = 1
            | DoubleTypeKind = 2
            | X86_FP80TypeKind = 3
            | FP128TypeKind = 4
            | PPC_FP128TypeKind = 5
            | LabelTypeKind = 6
            | IntegerTypeKind = 7
            | FunctionTypeKind = 8
            | StructTypeKind = 9
            | ArrayTypeKind = 10
            | PointerTypeKind = 11
            | VectorTypeKind = 12
            | MetadataTypeKind = 13
            | X86_MMXTypeKind = 14

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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInitializeCore")>]
        extern void initializeCoreNative(
            void* (* LLVMPassRegistryRef *) R)
        let initializeCore _R =
            initializeCoreNative ((_R : PassRegistryRef).Ptr)

        // LLVMDisposeMessage is blacklisted by the binding generator

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMContextCreate")>]
        extern void* (* LLVMContextRef *) contextCreateNative()
        let contextCreate () =
            new ContextRef (contextCreateNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetGlobalContext")>]
        extern void* (* LLVMContextRef *) getGlobalContextNative()
        let getGlobalContext () =
            new ContextRef (getGlobalContextNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMContextDispose")>]
        extern void contextDisposeNative(
            void* (* LLVMContextRef *) C)
        let contextDispose _C =
            contextDisposeNative ((_C : ContextRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetMDKindIDInContext")>]
        extern uint32 getMDKindIDInContextNative(
            void* (* LLVMContextRef *) C,
            string Name,
            uint32 SLen)
        let getMDKindIDInContext _C _Name _SLen =
            getMDKindIDInContextNative ((_C : ContextRef).Ptr, _Name, _SLen)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetMDKindID")>]
        extern uint32 getMDKindIDNative(
            string Name,
            uint32 SLen)
        let getMDKindID _Name _SLen =
            getMDKindIDNative (_Name, _SLen)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMModuleCreateWithName")>]
        extern void* (* LLVMModuleRef *) moduleCreateWithNameNative(
            string ModuleID)
        let moduleCreateWithName _ModuleID =
            new ModuleRef (moduleCreateWithNameNative (_ModuleID))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMModuleCreateWithNameInContext")>]
        extern void* (* LLVMModuleRef *) moduleCreateWithNameInContextNative(
            string ModuleID,
            void* (* LLVMContextRef *) C)
        let moduleCreateWithNameInContext _ModuleID _C =
            new ModuleRef (moduleCreateWithNameInContextNative (_ModuleID, (_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeModule")>]
        extern void disposeModuleNative(
            void* (* LLVMModuleRef *) M)
        let disposeModule _M =
            disposeModuleNative ((_M : ModuleRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetDataLayout")>]
        extern void* getDataLayoutNative(
            void* (* LLVMModuleRef *) M)
        let getDataLayout _M =
            Marshal.PtrToStringAuto (getDataLayoutNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetDataLayout")>]
        extern void setDataLayoutNative(
            void* (* LLVMModuleRef *) M,
            string Triple)
        let setDataLayout _M _Triple =
            setDataLayoutNative ((_M : ModuleRef).Ptr, _Triple)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetTarget")>]
        extern void* getTargetNative(
            void* (* LLVMModuleRef *) M)
        let getTarget _M =
            Marshal.PtrToStringAuto (getTargetNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetTarget")>]
        extern void setTargetNative(
            void* (* LLVMModuleRef *) M,
            string Triple)
        let setTarget _M _Triple =
            setTargetNative ((_M : ModuleRef).Ptr, _Triple)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDumpModule")>]
        extern void dumpModuleNative(
            void* (* LLVMModuleRef *) M)
        let dumpModule _M =
            dumpModuleNative ((_M : ModuleRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetModuleInlineAsm")>]
        extern void setModuleInlineAsmNative(
            void* (* LLVMModuleRef *) M,
            string Asm)
        let setModuleInlineAsm _M _Asm =
            setModuleInlineAsmNative ((_M : ModuleRef).Ptr, _Asm)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetModuleContext")>]
        extern void* (* LLVMContextRef *) getModuleContextNative(
            void* (* LLVMModuleRef *) M)
        let getModuleContext _M =
            new ContextRef (getModuleContextNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetTypeKind")>]
        extern int (* LLVMTypeKind *) getTypeKindNative(
            void* (* LLVMTypeRef *) Ty)
        let getTypeKind _Ty =
            enum<TypeKind> (getTypeKindNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMTypeIsSized")>]
        extern bool typeIsSizedNative(
            void* (* LLVMTypeRef *) Ty)
        let typeIsSized _Ty =
            typeIsSizedNative ((_Ty : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetTypeContext")>]
        extern void* (* LLVMContextRef *) getTypeContextNative(
            void* (* LLVMTypeRef *) Ty)
        let getTypeContext _Ty =
            new ContextRef (getTypeContextNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt1TypeInContext")>]
        extern void* (* LLVMTypeRef *) int1TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int1TypeInContext _C =
            new TypeRef (int1TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt8TypeInContext")>]
        extern void* (* LLVMTypeRef *) int8TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int8TypeInContext _C =
            new TypeRef (int8TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt16TypeInContext")>]
        extern void* (* LLVMTypeRef *) int16TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int16TypeInContext _C =
            new TypeRef (int16TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt32TypeInContext")>]
        extern void* (* LLVMTypeRef *) int32TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int32TypeInContext _C =
            new TypeRef (int32TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt64TypeInContext")>]
        extern void* (* LLVMTypeRef *) int64TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let int64TypeInContext _C =
            new TypeRef (int64TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIntTypeInContext")>]
        extern void* (* LLVMTypeRef *) intTypeInContextNative(
            void* (* LLVMContextRef *) C,
            uint32 NumBits)
        let intTypeInContext _C _NumBits =
            new TypeRef (intTypeInContextNative ((_C : ContextRef).Ptr, _NumBits))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt1Type")>]
        extern void* (* LLVMTypeRef *) int1TypeNative()
        let int1Type () =
            new TypeRef (int1TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt8Type")>]
        extern void* (* LLVMTypeRef *) int8TypeNative()
        let int8Type () =
            new TypeRef (int8TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt16Type")>]
        extern void* (* LLVMTypeRef *) int16TypeNative()
        let int16Type () =
            new TypeRef (int16TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt32Type")>]
        extern void* (* LLVMTypeRef *) int32TypeNative()
        let int32Type () =
            new TypeRef (int32TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInt64Type")>]
        extern void* (* LLVMTypeRef *) int64TypeNative()
        let int64Type () =
            new TypeRef (int64TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIntType")>]
        extern void* (* LLVMTypeRef *) intTypeNative(
            uint32 NumBits)
        let intType _NumBits =
            new TypeRef (intTypeNative (_NumBits))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetIntTypeWidth")>]
        extern uint32 getIntTypeWidthNative(
            void* (* LLVMTypeRef *) IntegerTy)
        let getIntTypeWidth _IntegerTy =
            getIntTypeWidthNative ((_IntegerTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFloatTypeInContext")>]
        extern void* (* LLVMTypeRef *) floatTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let floatTypeInContext _C =
            new TypeRef (floatTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDoubleTypeInContext")>]
        extern void* (* LLVMTypeRef *) doubleTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let doubleTypeInContext _C =
            new TypeRef (doubleTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMX86FP80TypeInContext")>]
        extern void* (* LLVMTypeRef *) x86FP80TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let x86FP80TypeInContext _C =
            new TypeRef (x86FP80TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFP128TypeInContext")>]
        extern void* (* LLVMTypeRef *) fP128TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let fP128TypeInContext _C =
            new TypeRef (fP128TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPPCFP128TypeInContext")>]
        extern void* (* LLVMTypeRef *) pPCFP128TypeInContextNative(
            void* (* LLVMContextRef *) C)
        let pPCFP128TypeInContext _C =
            new TypeRef (pPCFP128TypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFloatType")>]
        extern void* (* LLVMTypeRef *) floatTypeNative()
        let floatType () =
            new TypeRef (floatTypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDoubleType")>]
        extern void* (* LLVMTypeRef *) doubleTypeNative()
        let doubleType () =
            new TypeRef (doubleTypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMX86FP80Type")>]
        extern void* (* LLVMTypeRef *) x86FP80TypeNative()
        let x86FP80Type () =
            new TypeRef (x86FP80TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFP128Type")>]
        extern void* (* LLVMTypeRef *) fP128TypeNative()
        let fP128Type () =
            new TypeRef (fP128TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPPCFP128Type")>]
        extern void* (* LLVMTypeRef *) pPCFP128TypeNative()
        let pPCFP128Type () =
            new TypeRef (pPCFP128TypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFunctionType")>]
        extern void* (* LLVMTypeRef *) functionTypeNative(
            void* (* LLVMTypeRef *) ReturnType,
            void* (* LLVMTypeRef* *) ParamTypes,
            uint32 ParamCount,
            bool IsVarArg)
        // I don't know how to generate an "F# friendly" version of LLVMFunctionType

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsFunctionVarArg")>]
        extern bool isFunctionVarArgNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let isFunctionVarArg _FunctionTy =
            isFunctionVarArgNative ((_FunctionTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetReturnType")>]
        extern void* (* LLVMTypeRef *) getReturnTypeNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let getReturnType _FunctionTy =
            new TypeRef (getReturnTypeNative ((_FunctionTy : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCountParamTypes")>]
        extern uint32 countParamTypesNative(
            void* (* LLVMTypeRef *) FunctionTy)
        let countParamTypes _FunctionTy =
            countParamTypesNative ((_FunctionTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetParamTypes")>]
        extern void getParamTypesNative(
            void* (* LLVMTypeRef *) FunctionTy,
            void* (* LLVMTypeRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetParamTypes

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMStructTypeInContext")>]
        extern void* (* LLVMTypeRef *) structTypeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructTypeInContext

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMStructType")>]
        extern void* (* LLVMTypeRef *) structTypeNative(
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructType

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMStructCreateNamed")>]
        extern void* (* LLVMTypeRef *) structCreateNamedNative(
            void* (* LLVMContextRef *) C,
            string Name)
        let structCreateNamed _C _Name =
            new TypeRef (structCreateNamedNative ((_C : ContextRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetStructName")>]
        extern void* getStructNameNative(
            void* (* LLVMTypeRef *) Ty)
        let getStructName _Ty =
            Marshal.PtrToStringAuto (getStructNameNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMStructSetBody")>]
        extern void structSetBodyNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMTypeRef* *) ElementTypes,
            uint32 ElementCount,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMStructSetBody

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCountStructElementTypes")>]
        extern uint32 countStructElementTypesNative(
            void* (* LLVMTypeRef *) StructTy)
        let countStructElementTypes _StructTy =
            countStructElementTypesNative ((_StructTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetStructElementTypes")>]
        extern void getStructElementTypesNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMTypeRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetStructElementTypes

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsPackedStruct")>]
        extern bool isPackedStructNative(
            void* (* LLVMTypeRef *) StructTy)
        let isPackedStruct _StructTy =
            isPackedStructNative ((_StructTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsOpaqueStruct")>]
        extern bool isOpaqueStructNative(
            void* (* LLVMTypeRef *) StructTy)
        let isOpaqueStruct _StructTy =
            isOpaqueStructNative ((_StructTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetTypeByName")>]
        extern void* (* LLVMTypeRef *) getTypeByNameNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getTypeByName _M _Name =
            new TypeRef (getTypeByNameNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMArrayType")>]
        extern void* (* LLVMTypeRef *) arrayTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 ElementCount)
        let arrayType _ElementType _ElementCount =
            new TypeRef (arrayTypeNative ((_ElementType : TypeRef).Ptr, _ElementCount))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPointerType")>]
        extern void* (* LLVMTypeRef *) pointerTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 AddressSpace)
        let pointerType _ElementType _AddressSpace =
            new TypeRef (pointerTypeNative ((_ElementType : TypeRef).Ptr, _AddressSpace))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMVectorType")>]
        extern void* (* LLVMTypeRef *) vectorTypeNative(
            void* (* LLVMTypeRef *) ElementType,
            uint32 ElementCount)
        let vectorType _ElementType _ElementCount =
            new TypeRef (vectorTypeNative ((_ElementType : TypeRef).Ptr, _ElementCount))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetElementType")>]
        extern void* (* LLVMTypeRef *) getElementTypeNative(
            void* (* LLVMTypeRef *) Ty)
        let getElementType _Ty =
            new TypeRef (getElementTypeNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetArrayLength")>]
        extern uint32 getArrayLengthNative(
            void* (* LLVMTypeRef *) ArrayTy)
        let getArrayLength _ArrayTy =
            getArrayLengthNative ((_ArrayTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPointerAddressSpace")>]
        extern uint32 getPointerAddressSpaceNative(
            void* (* LLVMTypeRef *) PointerTy)
        let getPointerAddressSpace _PointerTy =
            getPointerAddressSpaceNative ((_PointerTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetVectorSize")>]
        extern uint32 getVectorSizeNative(
            void* (* LLVMTypeRef *) VectorTy)
        let getVectorSize _VectorTy =
            getVectorSizeNative ((_VectorTy : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMVoidTypeInContext")>]
        extern void* (* LLVMTypeRef *) voidTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let voidTypeInContext _C =
            new TypeRef (voidTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMLabelTypeInContext")>]
        extern void* (* LLVMTypeRef *) labelTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let labelTypeInContext _C =
            new TypeRef (labelTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMX86MMXTypeInContext")>]
        extern void* (* LLVMTypeRef *) x86MMXTypeInContextNative(
            void* (* LLVMContextRef *) C)
        let x86MMXTypeInContext _C =
            new TypeRef (x86MMXTypeInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMVoidType")>]
        extern void* (* LLVMTypeRef *) voidTypeNative()
        let voidType () =
            new TypeRef (voidTypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMLabelType")>]
        extern void* (* LLVMTypeRef *) labelTypeNative()
        let labelType () =
            new TypeRef (labelTypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMX86MMXType")>]
        extern void* (* LLVMTypeRef *) x86MMXTypeNative()
        let x86MMXType () =
            new TypeRef (x86MMXTypeNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMTypeOf")>]
        extern void* (* LLVMTypeRef *) typeOfNative(
            void* (* LLVMValueRef *) Val)
        let typeOf _Val =
            new TypeRef (typeOfNative ((_Val : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetValueName")>]
        extern void* getValueNameNative(
            void* (* LLVMValueRef *) Val)
        let getValueName _Val =
            Marshal.PtrToStringAuto (getValueNameNative ((_Val : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetValueName")>]
        extern void setValueNameNative(
            void* (* LLVMValueRef *) Val,
            string Name)
        let setValueName _Val _Name =
            setValueNameNative ((_Val : ValueRef).Ptr, _Name)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDumpValue")>]
        extern void dumpValueNative(
            void* (* LLVMValueRef *) Val)
        let dumpValue _Val =
            dumpValueNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMReplaceAllUsesWith")>]
        extern void replaceAllUsesWithNative(
            void* (* LLVMValueRef *) OldVal,
            void* (* LLVMValueRef *) NewVal)
        let replaceAllUsesWith _OldVal _NewVal =
            replaceAllUsesWithNative ((_OldVal : ValueRef).Ptr, (_NewVal : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMHasMetadata")>]
        extern int hasMetadataNative(
            void* (* LLVMValueRef *) Val)
        let hasMetadata _Val =
            hasMetadataNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetMetadata")>]
        extern void* (* LLVMValueRef *) getMetadataNative(
            void* (* LLVMValueRef *) Val,
            uint32 KindID)
        let getMetadata _Val _KindID =
            new ValueRef (getMetadataNative ((_Val : ValueRef).Ptr, _KindID))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetMetadata")>]
        extern void setMetadataNative(
            void* (* LLVMValueRef *) Val,
            uint32 KindID,
            void* (* LLVMValueRef *) Node)
        let setMetadata _Val _KindID _Node =
            setMetadataNative ((_Val : ValueRef).Ptr, _KindID, (_Node : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFirstUse")>]
        extern void* (* LLVMUseRef *) getFirstUseNative(
            void* (* LLVMValueRef *) Val)
        let getFirstUse _Val =
            new UseRef (getFirstUseNative ((_Val : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNextUse")>]
        extern void* (* LLVMUseRef *) getNextUseNative(
            void* (* LLVMUseRef *) U)
        let getNextUse _U =
            new UseRef (getNextUseNative ((_U : UseRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetUser")>]
        extern void* (* LLVMValueRef *) getUserNative(
            void* (* LLVMUseRef *) U)
        let getUser _U =
            new ValueRef (getUserNative ((_U : UseRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetUsedValue")>]
        extern void* (* LLVMValueRef *) getUsedValueNative(
            void* (* LLVMUseRef *) U)
        let getUsedValue _U =
            new ValueRef (getUsedValueNative ((_U : UseRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetOperand")>]
        extern void* (* LLVMValueRef *) getOperandNative(
            void* (* LLVMValueRef *) Val,
            uint32 Index)
        let getOperand _Val _Index =
            new ValueRef (getOperandNative ((_Val : ValueRef).Ptr, _Index))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetOperand")>]
        extern void setOperandNative(
            void* (* LLVMValueRef *) User,
            uint32 Index,
            void* (* LLVMValueRef *) Val)
        let setOperand _User _Index _Val =
            setOperandNative ((_User : ValueRef).Ptr, _Index, (_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNumOperands")>]
        extern int getNumOperandsNative(
            void* (* LLVMValueRef *) Val)
        let getNumOperands _Val =
            getNumOperandsNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNull")>]
        extern void* (* LLVMValueRef *) constNullNative(
            void* (* LLVMTypeRef *) Ty)
        let constNull _Ty =
            new ValueRef (constNullNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstAllOnes")>]
        extern void* (* LLVMValueRef *) constAllOnesNative(
            void* (* LLVMTypeRef *) Ty)
        let constAllOnes _Ty =
            new ValueRef (constAllOnesNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetUndef")>]
        extern void* (* LLVMValueRef *) getUndefNative(
            void* (* LLVMTypeRef *) Ty)
        let getUndef _Ty =
            new ValueRef (getUndefNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsConstant")>]
        extern bool isConstantNative(
            void* (* LLVMValueRef *) Val)
        let isConstant _Val =
            isConstantNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsNull")>]
        extern bool isNullNative(
            void* (* LLVMValueRef *) Val)
        let isNull _Val =
            isNullNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsUndef")>]
        extern bool isUndefNative(
            void* (* LLVMValueRef *) Val)
        let isUndef _Val =
            isUndefNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstPointerNull")>]
        extern void* (* LLVMValueRef *) constPointerNullNative(
            void* (* LLVMTypeRef *) Ty)
        let constPointerNull _Ty =
            new ValueRef (constPointerNullNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMMDStringInContext")>]
        extern void* (* LLVMValueRef *) mDStringInContextNative(
            void* (* LLVMContextRef *) C,
            string Str,
            uint32 SLen)
        let mDStringInContext _C _Str _SLen =
            new ValueRef (mDStringInContextNative ((_C : ContextRef).Ptr, _Str, _SLen))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMMDString")>]
        extern void* (* LLVMValueRef *) mDStringNative(
            string Str,
            uint32 SLen)
        let mDString _Str _SLen =
            new ValueRef (mDStringNative (_Str, _SLen))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMMDNodeInContext")>]
        extern void* (* LLVMValueRef *) mDNodeInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef* *) Vals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMMDNodeInContext

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMMDNode")>]
        extern void* (* LLVMValueRef *) mDNodeNative(
            void* (* LLVMValueRef* *) Vals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMMDNode

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetMDString")>]
        extern void* getMDStringNative(
            void* (* LLVMValueRef *) V,
            uint32* Len)
        // I don't know how to generate an "F# friendly" version of LLVMGetMDString

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetMDNodeNumOperands")>]
        extern int getMDNodeNumOperandsNative(
            void* (* LLVMValueRef *) V)
        let getMDNodeNumOperands _V =
            getMDNodeNumOperandsNative ((_V : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetMDNodeOperand")>]
        extern void* (* LLVMValueRef* *) getMDNodeOperandNative(
            void* (* LLVMValueRef *) V,
            uint32 i)
        // I don't know how to generate an "F# friendly" version of LLVMGetMDNodeOperand

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNamedMetadataNumOperands")>]
        extern uint32 getNamedMetadataNumOperandsNative(
            void* (* LLVMModuleRef *) M,
            string name)
        let getNamedMetadataNumOperands _M _name =
            getNamedMetadataNumOperandsNative ((_M : ModuleRef).Ptr, _name)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNamedMetadataOperands")>]
        extern void getNamedMetadataOperandsNative(
            void* (* LLVMModuleRef *) M,
            string name,
            void* (* LLVMValueRef* *) Dest)
        // I don't know how to generate an "F# friendly" version of LLVMGetNamedMetadataOperands

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstInt")>]
        extern void* (* LLVMValueRef *) constIntNative(
            void* (* LLVMTypeRef *) IntTy,
            uint64 N,
            bool SignExtend)
        let constInt _IntTy _N _SignExtend =
            new ValueRef (constIntNative ((_IntTy : TypeRef).Ptr, _N, _SignExtend))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntOfArbitraryPrecision")>]
        extern void* (* LLVMValueRef *) constIntOfArbitraryPrecisionNative(
            void* (* LLVMTypeRef *) IntTy,
            uint32 NumWords,
            uint64* Words)
        // I don't know how to generate an "F# friendly" version of LLVMConstIntOfArbitraryPrecision

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntOfString")>]
        extern void* (* LLVMValueRef *) constIntOfStringNative(
            void* (* LLVMTypeRef *) IntTy,
            string Text,
            uint8 Radix)
        let constIntOfString _IntTy _Text _Radix =
            new ValueRef (constIntOfStringNative ((_IntTy : TypeRef).Ptr, _Text, _Radix))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntOfStringAndSize")>]
        extern void* (* LLVMValueRef *) constIntOfStringAndSizeNative(
            void* (* LLVMTypeRef *) IntTy,
            string Text,
            uint32 SLen,
            uint8 Radix)
        let constIntOfStringAndSize _IntTy _Text _SLen _Radix =
            new ValueRef (constIntOfStringAndSizeNative ((_IntTy : TypeRef).Ptr, _Text, _SLen, _Radix))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstReal")>]
        extern void* (* LLVMValueRef *) constRealNative(
            void* (* LLVMTypeRef *) RealTy,
            double N)
        let constReal _RealTy _N =
            new ValueRef (constRealNative ((_RealTy : TypeRef).Ptr, _N))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstRealOfString")>]
        extern void* (* LLVMValueRef *) constRealOfStringNative(
            void* (* LLVMTypeRef *) RealTy,
            string Text)
        let constRealOfString _RealTy _Text =
            new ValueRef (constRealOfStringNative ((_RealTy : TypeRef).Ptr, _Text))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstRealOfStringAndSize")>]
        extern void* (* LLVMValueRef *) constRealOfStringAndSizeNative(
            void* (* LLVMTypeRef *) RealTy,
            string Text,
            uint32 SLen)
        let constRealOfStringAndSize _RealTy _Text _SLen =
            new ValueRef (constRealOfStringAndSizeNative ((_RealTy : TypeRef).Ptr, _Text, _SLen))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntGetZExtValue")>]
        extern uint64 constIntGetZExtValueNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constIntGetZExtValue _ConstantVal =
            constIntGetZExtValueNative ((_ConstantVal : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntGetSExtValue")>]
        extern int64 constIntGetSExtValueNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constIntGetSExtValue _ConstantVal =
            constIntGetSExtValueNative ((_ConstantVal : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstStringInContext")>]
        extern void* (* LLVMValueRef *) constStringInContextNative(
            void* (* LLVMContextRef *) C,
            string Str,
            uint32 Length,
            bool DontNullTerminate)
        let constStringInContext _C _Str _Length _DontNullTerminate =
            new ValueRef (constStringInContextNative ((_C : ContextRef).Ptr, _Str, _Length, _DontNullTerminate))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstStructInContext")>]
        extern void* (* LLVMValueRef *) constStructInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMConstStructInContext

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstString")>]
        extern void* (* LLVMValueRef *) constStringNative(
            string Str,
            uint32 Length,
            bool DontNullTerminate)
        let constString _Str _Length _DontNullTerminate =
            new ValueRef (constStringNative (_Str, _Length, _DontNullTerminate))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstArray")>]
        extern void* (* LLVMValueRef *) constArrayNative(
            void* (* LLVMTypeRef *) ElementTy,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Length)
        // I don't know how to generate an "F# friendly" version of LLVMConstArray

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstStruct")>]
        extern void* (* LLVMValueRef *) constStructNative(
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count,
            bool Packed)
        // I don't know how to generate an "F# friendly" version of LLVMConstStruct

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNamedStruct")>]
        extern void* (* LLVMValueRef *) constNamedStructNative(
            void* (* LLVMTypeRef *) StructTy,
            void* (* LLVMValueRef* *) ConstantVals,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMConstNamedStruct

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstVector")>]
        extern void* (* LLVMValueRef *) constVectorNative(
            void* (* LLVMValueRef* *) ScalarConstantVals,
            uint32 Size)
        // I don't know how to generate an "F# friendly" version of LLVMConstVector

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetConstOpcode")>]
        extern int (* LLVMOpcode *) getConstOpcodeNative(
            void* (* LLVMValueRef *) ConstantVal)
        let getConstOpcode _ConstantVal =
            enum<Opcode> (getConstOpcodeNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAlignOf")>]
        extern void* (* LLVMValueRef *) alignOfNative(
            void* (* LLVMTypeRef *) Ty)
        let alignOf _Ty =
            new ValueRef (alignOfNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSizeOf")>]
        extern void* (* LLVMValueRef *) sizeOfNative(
            void* (* LLVMTypeRef *) Ty)
        let sizeOf _Ty =
            new ValueRef (sizeOfNative ((_Ty : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNeg")>]
        extern void* (* LLVMValueRef *) constNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNeg _ConstantVal =
            new ValueRef (constNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNSWNeg")>]
        extern void* (* LLVMValueRef *) constNSWNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNSWNeg _ConstantVal =
            new ValueRef (constNSWNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNUWNeg")>]
        extern void* (* LLVMValueRef *) constNUWNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNUWNeg _ConstantVal =
            new ValueRef (constNUWNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFNeg")>]
        extern void* (* LLVMValueRef *) constFNegNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constFNeg _ConstantVal =
            new ValueRef (constFNegNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNot")>]
        extern void* (* LLVMValueRef *) constNotNative(
            void* (* LLVMValueRef *) ConstantVal)
        let constNot _ConstantVal =
            new ValueRef (constNotNative ((_ConstantVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstAdd")>]
        extern void* (* LLVMValueRef *) constAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAdd _LHSConstant _RHSConstant =
            new ValueRef (constAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNSWAdd")>]
        extern void* (* LLVMValueRef *) constNSWAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWAdd _LHSConstant _RHSConstant =
            new ValueRef (constNSWAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNUWAdd")>]
        extern void* (* LLVMValueRef *) constNUWAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWAdd _LHSConstant _RHSConstant =
            new ValueRef (constNUWAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFAdd")>]
        extern void* (* LLVMValueRef *) constFAddNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFAdd _LHSConstant _RHSConstant =
            new ValueRef (constFAddNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSub")>]
        extern void* (* LLVMValueRef *) constSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSub _LHSConstant _RHSConstant =
            new ValueRef (constSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNSWSub")>]
        extern void* (* LLVMValueRef *) constNSWSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWSub _LHSConstant _RHSConstant =
            new ValueRef (constNSWSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNUWSub")>]
        extern void* (* LLVMValueRef *) constNUWSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWSub _LHSConstant _RHSConstant =
            new ValueRef (constNUWSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFSub")>]
        extern void* (* LLVMValueRef *) constFSubNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFSub _LHSConstant _RHSConstant =
            new ValueRef (constFSubNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstMul")>]
        extern void* (* LLVMValueRef *) constMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constMul _LHSConstant _RHSConstant =
            new ValueRef (constMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNSWMul")>]
        extern void* (* LLVMValueRef *) constNSWMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNSWMul _LHSConstant _RHSConstant =
            new ValueRef (constNSWMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstNUWMul")>]
        extern void* (* LLVMValueRef *) constNUWMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constNUWMul _LHSConstant _RHSConstant =
            new ValueRef (constNUWMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFMul")>]
        extern void* (* LLVMValueRef *) constFMulNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFMul _LHSConstant _RHSConstant =
            new ValueRef (constFMulNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstUDiv")>]
        extern void* (* LLVMValueRef *) constUDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constUDiv _LHSConstant _RHSConstant =
            new ValueRef (constUDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSDiv")>]
        extern void* (* LLVMValueRef *) constSDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSDiv _LHSConstant _RHSConstant =
            new ValueRef (constSDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstExactSDiv")>]
        extern void* (* LLVMValueRef *) constExactSDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constExactSDiv _LHSConstant _RHSConstant =
            new ValueRef (constExactSDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFDiv")>]
        extern void* (* LLVMValueRef *) constFDivNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFDiv _LHSConstant _RHSConstant =
            new ValueRef (constFDivNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstURem")>]
        extern void* (* LLVMValueRef *) constURemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constURem _LHSConstant _RHSConstant =
            new ValueRef (constURemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSRem")>]
        extern void* (* LLVMValueRef *) constSRemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constSRem _LHSConstant _RHSConstant =
            new ValueRef (constSRemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFRem")>]
        extern void* (* LLVMValueRef *) constFRemNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFRem _LHSConstant _RHSConstant =
            new ValueRef (constFRemNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstAnd")>]
        extern void* (* LLVMValueRef *) constAndNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAnd _LHSConstant _RHSConstant =
            new ValueRef (constAndNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstOr")>]
        extern void* (* LLVMValueRef *) constOrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constOr _LHSConstant _RHSConstant =
            new ValueRef (constOrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstXor")>]
        extern void* (* LLVMValueRef *) constXorNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constXor _LHSConstant _RHSConstant =
            new ValueRef (constXorNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstICmp")>]
        extern void* (* LLVMValueRef *) constICmpNative(
            int (* LLVMIntPredicate *) Predicate,
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constICmp _Predicate _LHSConstant _RHSConstant =
            new ValueRef (constICmpNative ((int (_Predicate : IntPredicate)), (_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFCmp")>]
        extern void* (* LLVMValueRef *) constFCmpNative(
            int (* LLVMRealPredicate *) Predicate,
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constFCmp _Predicate _LHSConstant _RHSConstant =
            new ValueRef (constFCmpNative ((int (_Predicate : RealPredicate)), (_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstShl")>]
        extern void* (* LLVMValueRef *) constShlNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constShl _LHSConstant _RHSConstant =
            new ValueRef (constShlNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstLShr")>]
        extern void* (* LLVMValueRef *) constLShrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constLShr _LHSConstant _RHSConstant =
            new ValueRef (constLShrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstAShr")>]
        extern void* (* LLVMValueRef *) constAShrNative(
            void* (* LLVMValueRef *) LHSConstant,
            void* (* LLVMValueRef *) RHSConstant)
        let constAShr _LHSConstant _RHSConstant =
            new ValueRef (constAShrNative ((_LHSConstant : ValueRef).Ptr, (_RHSConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstGEP")>]
        extern void* (* LLVMValueRef *) constGEPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMValueRef* *) ConstantIndices,
            uint32 NumIndices)
        // I don't know how to generate an "F# friendly" version of LLVMConstGEP

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstInBoundsGEP")>]
        extern void* (* LLVMValueRef *) constInBoundsGEPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMValueRef* *) ConstantIndices,
            uint32 NumIndices)
        // I don't know how to generate an "F# friendly" version of LLVMConstInBoundsGEP

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstTrunc")>]
        extern void* (* LLVMValueRef *) constTruncNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constTrunc _ConstantVal _ToType =
            new ValueRef (constTruncNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSExt")>]
        extern void* (* LLVMValueRef *) constSExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSExt _ConstantVal _ToType =
            new ValueRef (constSExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstZExt")>]
        extern void* (* LLVMValueRef *) constZExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constZExt _ConstantVal _ToType =
            new ValueRef (constZExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFPTrunc")>]
        extern void* (* LLVMValueRef *) constFPTruncNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPTrunc _ConstantVal _ToType =
            new ValueRef (constFPTruncNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFPExt")>]
        extern void* (* LLVMValueRef *) constFPExtNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPExt _ConstantVal _ToType =
            new ValueRef (constFPExtNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstUIToFP")>]
        extern void* (* LLVMValueRef *) constUIToFPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constUIToFP _ConstantVal _ToType =
            new ValueRef (constUIToFPNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSIToFP")>]
        extern void* (* LLVMValueRef *) constSIToFPNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSIToFP _ConstantVal _ToType =
            new ValueRef (constSIToFPNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFPToUI")>]
        extern void* (* LLVMValueRef *) constFPToUINative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPToUI _ConstantVal _ToType =
            new ValueRef (constFPToUINative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFPToSI")>]
        extern void* (* LLVMValueRef *) constFPToSINative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPToSI _ConstantVal _ToType =
            new ValueRef (constFPToSINative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstPtrToInt")>]
        extern void* (* LLVMValueRef *) constPtrToIntNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constPtrToInt _ConstantVal _ToType =
            new ValueRef (constPtrToIntNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntToPtr")>]
        extern void* (* LLVMValueRef *) constIntToPtrNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constIntToPtr _ConstantVal _ToType =
            new ValueRef (constIntToPtrNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstBitCast")>]
        extern void* (* LLVMValueRef *) constBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constBitCast _ConstantVal _ToType =
            new ValueRef (constBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstZExtOrBitCast")>]
        extern void* (* LLVMValueRef *) constZExtOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constZExtOrBitCast _ConstantVal _ToType =
            new ValueRef (constZExtOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSExtOrBitCast")>]
        extern void* (* LLVMValueRef *) constSExtOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constSExtOrBitCast _ConstantVal _ToType =
            new ValueRef (constSExtOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstTruncOrBitCast")>]
        extern void* (* LLVMValueRef *) constTruncOrBitCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constTruncOrBitCast _ConstantVal _ToType =
            new ValueRef (constTruncOrBitCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstPointerCast")>]
        extern void* (* LLVMValueRef *) constPointerCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constPointerCast _ConstantVal _ToType =
            new ValueRef (constPointerCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstIntCast")>]
        extern void* (* LLVMValueRef *) constIntCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType,
            bool isSigned)
        let constIntCast _ConstantVal _ToType _isSigned =
            new ValueRef (constIntCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr, _isSigned))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstFPCast")>]
        extern void* (* LLVMValueRef *) constFPCastNative(
            void* (* LLVMValueRef *) ConstantVal,
            void* (* LLVMTypeRef *) ToType)
        let constFPCast _ConstantVal _ToType =
            new ValueRef (constFPCastNative ((_ConstantVal : ValueRef).Ptr, (_ToType : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstSelect")>]
        extern void* (* LLVMValueRef *) constSelectNative(
            void* (* LLVMValueRef *) ConstantCondition,
            void* (* LLVMValueRef *) ConstantIfTrue,
            void* (* LLVMValueRef *) ConstantIfFalse)
        let constSelect _ConstantCondition _ConstantIfTrue _ConstantIfFalse =
            new ValueRef (constSelectNative ((_ConstantCondition : ValueRef).Ptr, (_ConstantIfTrue : ValueRef).Ptr, (_ConstantIfFalse : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstExtractElement")>]
        extern void* (* LLVMValueRef *) constExtractElementNative(
            void* (* LLVMValueRef *) VectorConstant,
            void* (* LLVMValueRef *) IndexConstant)
        let constExtractElement _VectorConstant _IndexConstant =
            new ValueRef (constExtractElementNative ((_VectorConstant : ValueRef).Ptr, (_IndexConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstInsertElement")>]
        extern void* (* LLVMValueRef *) constInsertElementNative(
            void* (* LLVMValueRef *) VectorConstant,
            void* (* LLVMValueRef *) ElementValueConstant,
            void* (* LLVMValueRef *) IndexConstant)
        let constInsertElement _VectorConstant _ElementValueConstant _IndexConstant =
            new ValueRef (constInsertElementNative ((_VectorConstant : ValueRef).Ptr, (_ElementValueConstant : ValueRef).Ptr, (_IndexConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstShuffleVector")>]
        extern void* (* LLVMValueRef *) constShuffleVectorNative(
            void* (* LLVMValueRef *) VectorAConstant,
            void* (* LLVMValueRef *) VectorBConstant,
            void* (* LLVMValueRef *) MaskConstant)
        let constShuffleVector _VectorAConstant _VectorBConstant _MaskConstant =
            new ValueRef (constShuffleVectorNative ((_VectorAConstant : ValueRef).Ptr, (_VectorBConstant : ValueRef).Ptr, (_MaskConstant : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstExtractValue")>]
        extern void* (* LLVMValueRef *) constExtractValueNative(
            void* (* LLVMValueRef *) AggConstant,
            uint32* IdxList,
            uint32 NumIdx)
        // I don't know how to generate an "F# friendly" version of LLVMConstExtractValue

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstInsertValue")>]
        extern void* (* LLVMValueRef *) constInsertValueNative(
            void* (* LLVMValueRef *) AggConstant,
            void* (* LLVMValueRef *) ElementValueConstant,
            uint32* IdxList,
            uint32 NumIdx)
        // I don't know how to generate an "F# friendly" version of LLVMConstInsertValue

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMConstInlineAsm")>]
        extern void* (* LLVMValueRef *) constInlineAsmNative(
            void* (* LLVMTypeRef *) Ty,
            string AsmString,
            string Constraints,
            bool HasSideEffects,
            bool IsAlignStack)
        let constInlineAsm _Ty _AsmString _Constraints _HasSideEffects _IsAlignStack =
            new ValueRef (constInlineAsmNative ((_Ty : TypeRef).Ptr, _AsmString, _Constraints, _HasSideEffects, _IsAlignStack))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBlockAddress")>]
        extern void* (* LLVMValueRef *) blockAddressNative(
            void* (* LLVMValueRef *) F,
            void* (* LLVMBasicBlockRef *) BB)
        let blockAddress _F _BB =
            new ValueRef (blockAddressNative ((_F : ValueRef).Ptr, (_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetGlobalParent")>]
        extern void* (* LLVMModuleRef *) getGlobalParentNative(
            void* (* LLVMValueRef *) Global)
        let getGlobalParent _Global =
            new ModuleRef (getGlobalParentNative ((_Global : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsDeclaration")>]
        extern bool isDeclarationNative(
            void* (* LLVMValueRef *) Global)
        let isDeclaration _Global =
            isDeclarationNative ((_Global : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetLinkage")>]
        extern int (* LLVMLinkage *) getLinkageNative(
            void* (* LLVMValueRef *) Global)
        let getLinkage _Global =
            enum<Linkage> (getLinkageNative ((_Global : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetLinkage")>]
        extern void setLinkageNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMLinkage *) Linkage)
        let setLinkage _Global _Linkage =
            setLinkageNative ((_Global : ValueRef).Ptr, (int (_Linkage : Linkage)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetSection")>]
        extern void* getSectionNative(
            void* (* LLVMValueRef *) Global)
        let getSection _Global =
            Marshal.PtrToStringAuto (getSectionNative ((_Global : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetSection")>]
        extern void setSectionNative(
            void* (* LLVMValueRef *) Global,
            string Section)
        let setSection _Global _Section =
            setSectionNative ((_Global : ValueRef).Ptr, _Section)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetVisibility")>]
        extern int (* LLVMVisibility *) getVisibilityNative(
            void* (* LLVMValueRef *) Global)
        let getVisibility _Global =
            enum<Visibility> (getVisibilityNative ((_Global : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetVisibility")>]
        extern void setVisibilityNative(
            void* (* LLVMValueRef *) Global,
            int (* LLVMVisibility *) Viz)
        let setVisibility _Global _Viz =
            setVisibilityNative ((_Global : ValueRef).Ptr, (int (_Viz : Visibility)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetAlignment")>]
        extern uint32 getAlignmentNative(
            void* (* LLVMValueRef *) Global)
        let getAlignment _Global =
            getAlignmentNative ((_Global : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetAlignment")>]
        extern void setAlignmentNative(
            void* (* LLVMValueRef *) Global,
            uint32 Bytes)
        let setAlignment _Global _Bytes =
            setAlignmentNative ((_Global : ValueRef).Ptr, _Bytes)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddGlobal")>]
        extern void* (* LLVMValueRef *) addGlobalNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let addGlobal _M _Ty _Name =
            new ValueRef (addGlobalNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddGlobalInAddressSpace")>]
        extern void* (* LLVMValueRef *) addGlobalInAddressSpaceNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            string Name,
            uint32 AddressSpace)
        let addGlobalInAddressSpace _M _Ty _Name _AddressSpace =
            new ValueRef (addGlobalInAddressSpaceNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, _Name, _AddressSpace))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNamedGlobal")>]
        extern void* (* LLVMValueRef *) getNamedGlobalNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getNamedGlobal _M _Name =
            new ValueRef (getNamedGlobalNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFirstGlobal")>]
        extern void* (* LLVMValueRef *) getFirstGlobalNative(
            void* (* LLVMModuleRef *) M)
        let getFirstGlobal _M =
            new ValueRef (getFirstGlobalNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetLastGlobal")>]
        extern void* (* LLVMValueRef *) getLastGlobalNative(
            void* (* LLVMModuleRef *) M)
        let getLastGlobal _M =
            new ValueRef (getLastGlobalNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNextGlobal")>]
        extern void* (* LLVMValueRef *) getNextGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getNextGlobal _GlobalVar =
            new ValueRef (getNextGlobalNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPreviousGlobal")>]
        extern void* (* LLVMValueRef *) getPreviousGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getPreviousGlobal _GlobalVar =
            new ValueRef (getPreviousGlobalNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDeleteGlobal")>]
        extern void deleteGlobalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let deleteGlobal _GlobalVar =
            deleteGlobalNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetInitializer")>]
        extern void* (* LLVMValueRef *) getInitializerNative(
            void* (* LLVMValueRef *) GlobalVar)
        let getInitializer _GlobalVar =
            new ValueRef (getInitializerNative ((_GlobalVar : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetInitializer")>]
        extern void setInitializerNative(
            void* (* LLVMValueRef *) GlobalVar,
            void* (* LLVMValueRef *) ConstantVal)
        let setInitializer _GlobalVar _ConstantVal =
            setInitializerNative ((_GlobalVar : ValueRef).Ptr, (_ConstantVal : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsThreadLocal")>]
        extern bool isThreadLocalNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isThreadLocal _GlobalVar =
            isThreadLocalNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetThreadLocal")>]
        extern void setThreadLocalNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsThreadLocal)
        let setThreadLocal _GlobalVar _IsThreadLocal =
            setThreadLocalNative ((_GlobalVar : ValueRef).Ptr, _IsThreadLocal)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsGlobalConstant")>]
        extern bool isGlobalConstantNative(
            void* (* LLVMValueRef *) GlobalVar)
        let isGlobalConstant _GlobalVar =
            isGlobalConstantNative ((_GlobalVar : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetGlobalConstant")>]
        extern void setGlobalConstantNative(
            void* (* LLVMValueRef *) GlobalVar,
            bool IsConstant)
        let setGlobalConstant _GlobalVar _IsConstant =
            setGlobalConstantNative ((_GlobalVar : ValueRef).Ptr, _IsConstant)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddAlias")>]
        extern void* (* LLVMValueRef *) addAliasNative(
            void* (* LLVMModuleRef *) M,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Aliasee,
            string Name)
        let addAlias _M _Ty _Aliasee _Name =
            new ValueRef (addAliasNative ((_M : ModuleRef).Ptr, (_Ty : TypeRef).Ptr, (_Aliasee : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddFunction")>]
        extern void* (* LLVMValueRef *) addFunctionNative(
            void* (* LLVMModuleRef *) M,
            string Name,
            void* (* LLVMTypeRef *) FunctionTy)
        let addFunction _M _Name _FunctionTy =
            new ValueRef (addFunctionNative ((_M : ModuleRef).Ptr, _Name, (_FunctionTy : TypeRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNamedFunction")>]
        extern void* (* LLVMValueRef *) getNamedFunctionNative(
            void* (* LLVMModuleRef *) M,
            string Name)
        let getNamedFunction _M _Name =
            new ValueRef (getNamedFunctionNative ((_M : ModuleRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFirstFunction")>]
        extern void* (* LLVMValueRef *) getFirstFunctionNative(
            void* (* LLVMModuleRef *) M)
        let getFirstFunction _M =
            new ValueRef (getFirstFunctionNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetLastFunction")>]
        extern void* (* LLVMValueRef *) getLastFunctionNative(
            void* (* LLVMModuleRef *) M)
        let getLastFunction _M =
            new ValueRef (getLastFunctionNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNextFunction")>]
        extern void* (* LLVMValueRef *) getNextFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let getNextFunction _Fn =
            new ValueRef (getNextFunctionNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPreviousFunction")>]
        extern void* (* LLVMValueRef *) getPreviousFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let getPreviousFunction _Fn =
            new ValueRef (getPreviousFunctionNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDeleteFunction")>]
        extern void deleteFunctionNative(
            void* (* LLVMValueRef *) Fn)
        let deleteFunction _Fn =
            deleteFunctionNative ((_Fn : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetIntrinsicID")>]
        extern uint32 getIntrinsicIDNative(
            void* (* LLVMValueRef *) Fn)
        let getIntrinsicID _Fn =
            getIntrinsicIDNative ((_Fn : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFunctionCallConv")>]
        extern uint32 getFunctionCallConvNative(
            void* (* LLVMValueRef *) Fn)
        let getFunctionCallConv _Fn =
            getFunctionCallConvNative ((_Fn : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetFunctionCallConv")>]
        extern void setFunctionCallConvNative(
            void* (* LLVMValueRef *) Fn,
            uint32 CC)
        let setFunctionCallConv _Fn _CC =
            setFunctionCallConvNative ((_Fn : ValueRef).Ptr, _CC)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetGC")>]
        extern void* getGCNative(
            void* (* LLVMValueRef *) Fn)
        let getGC _Fn =
            Marshal.PtrToStringAuto (getGCNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetGC")>]
        extern void setGCNative(
            void* (* LLVMValueRef *) Fn,
            string Name)
        let setGC _Fn _Name =
            setGCNative ((_Fn : ValueRef).Ptr, _Name)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddFunctionAttr")>]
        extern void addFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMAttribute *) PA)
        let addFunctionAttr _Fn _PA =
            addFunctionAttrNative ((_Fn : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFunctionAttr")>]
        extern int (* LLVMAttribute *) getFunctionAttrNative(
            void* (* LLVMValueRef *) Fn)
        let getFunctionAttr _Fn =
            enum<Attribute> (getFunctionAttrNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRemoveFunctionAttr")>]
        extern void removeFunctionAttrNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMAttribute *) PA)
        let removeFunctionAttr _Fn _PA =
            removeFunctionAttrNative ((_Fn : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCountParams")>]
        extern uint32 countParamsNative(
            void* (* LLVMValueRef *) Fn)
        let countParams _Fn =
            countParamsNative ((_Fn : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetParams")>]
        extern void getParamsNative(
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Params)
        // I don't know how to generate an "F# friendly" version of LLVMGetParams

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetParam")>]
        extern void* (* LLVMValueRef *) getParamNative(
            void* (* LLVMValueRef *) Fn,
            uint32 Index)
        let getParam _Fn _Index =
            new ValueRef (getParamNative ((_Fn : ValueRef).Ptr, _Index))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetParamParent")>]
        extern void* (* LLVMValueRef *) getParamParentNative(
            void* (* LLVMValueRef *) Inst)
        let getParamParent _Inst =
            new ValueRef (getParamParentNative ((_Inst : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFirstParam")>]
        extern void* (* LLVMValueRef *) getFirstParamNative(
            void* (* LLVMValueRef *) Fn)
        let getFirstParam _Fn =
            new ValueRef (getFirstParamNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetLastParam")>]
        extern void* (* LLVMValueRef *) getLastParamNative(
            void* (* LLVMValueRef *) Fn)
        let getLastParam _Fn =
            new ValueRef (getLastParamNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNextParam")>]
        extern void* (* LLVMValueRef *) getNextParamNative(
            void* (* LLVMValueRef *) Arg)
        let getNextParam _Arg =
            new ValueRef (getNextParamNative ((_Arg : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPreviousParam")>]
        extern void* (* LLVMValueRef *) getPreviousParamNative(
            void* (* LLVMValueRef *) Arg)
        let getPreviousParam _Arg =
            new ValueRef (getPreviousParamNative ((_Arg : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddAttribute")>]
        extern void addAttributeNative(
            void* (* LLVMValueRef *) Arg,
            int (* LLVMAttribute *) PA)
        let addAttribute _Arg _PA =
            addAttributeNative ((_Arg : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRemoveAttribute")>]
        extern void removeAttributeNative(
            void* (* LLVMValueRef *) Arg,
            int (* LLVMAttribute *) PA)
        let removeAttribute _Arg _PA =
            removeAttributeNative ((_Arg : ValueRef).Ptr, (int (_PA : Attribute)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetAttribute")>]
        extern int (* LLVMAttribute *) getAttributeNative(
            void* (* LLVMValueRef *) Arg)
        let getAttribute _Arg =
            enum<Attribute> (getAttributeNative ((_Arg : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetParamAlignment")>]
        extern void setParamAlignmentNative(
            void* (* LLVMValueRef *) Arg,
            uint32 align)
        let setParamAlignment _Arg _align =
            setParamAlignmentNative ((_Arg : ValueRef).Ptr, _align)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBasicBlockAsValue")>]
        extern void* (* LLVMValueRef *) basicBlockAsValueNative(
            void* (* LLVMBasicBlockRef *) BB)
        let basicBlockAsValue _BB =
            new ValueRef (basicBlockAsValueNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMValueIsBasicBlock")>]
        extern bool valueIsBasicBlockNative(
            void* (* LLVMValueRef *) Val)
        let valueIsBasicBlock _Val =
            valueIsBasicBlockNative ((_Val : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMValueAsBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) valueAsBasicBlockNative(
            void* (* LLVMValueRef *) Val)
        let valueAsBasicBlock _Val =
            new BasicBlockRef (valueAsBasicBlockNative ((_Val : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBasicBlockParent")>]
        extern void* (* LLVMValueRef *) getBasicBlockParentNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getBasicBlockParent _BB =
            new ValueRef (getBasicBlockParentNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBasicBlockTerminator")>]
        extern void* (* LLVMValueRef *) getBasicBlockTerminatorNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getBasicBlockTerminator _BB =
            new ValueRef (getBasicBlockTerminatorNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCountBasicBlocks")>]
        extern uint32 countBasicBlocksNative(
            void* (* LLVMValueRef *) Fn)
        let countBasicBlocks _Fn =
            countBasicBlocksNative ((_Fn : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBasicBlocks")>]
        extern void getBasicBlocksNative(
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMBasicBlockRef* *) BasicBlocks)
        // I don't know how to generate an "F# friendly" version of LLVMGetBasicBlocks

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFirstBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) getFirstBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getFirstBasicBlock _Fn =
            new BasicBlockRef (getFirstBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetLastBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) getLastBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getLastBasicBlock _Fn =
            new BasicBlockRef (getLastBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNextBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) getNextBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getNextBasicBlock _BB =
            new BasicBlockRef (getNextBasicBlockNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPreviousBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) getPreviousBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getPreviousBasicBlock _BB =
            new BasicBlockRef (getPreviousBasicBlockNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetEntryBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) getEntryBasicBlockNative(
            void* (* LLVMValueRef *) Fn)
        let getEntryBasicBlock _Fn =
            new BasicBlockRef (getEntryBasicBlockNative ((_Fn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAppendBasicBlockInContext")>]
        extern void* (* LLVMBasicBlockRef *) appendBasicBlockInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMValueRef *) Fn,
            string Name)
        let appendBasicBlockInContext _C _Fn _Name =
            new BasicBlockRef (appendBasicBlockInContextNative ((_C : ContextRef).Ptr, (_Fn : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInsertBasicBlockInContext")>]
        extern void* (* LLVMBasicBlockRef *) insertBasicBlockInContextNative(
            void* (* LLVMContextRef *) C,
            void* (* LLVMBasicBlockRef *) BB,
            string Name)
        let insertBasicBlockInContext _C _BB _Name =
            new BasicBlockRef (insertBasicBlockInContextNative ((_C : ContextRef).Ptr, (_BB : BasicBlockRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAppendBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) appendBasicBlockNative(
            void* (* LLVMValueRef *) Fn,
            string Name)
        let appendBasicBlock _Fn _Name =
            new BasicBlockRef (appendBasicBlockNative ((_Fn : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInsertBasicBlock")>]
        extern void* (* LLVMBasicBlockRef *) insertBasicBlockNative(
            void* (* LLVMBasicBlockRef *) InsertBeforeBB,
            string Name)
        let insertBasicBlock _InsertBeforeBB _Name =
            new BasicBlockRef (insertBasicBlockNative ((_InsertBeforeBB : BasicBlockRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDeleteBasicBlock")>]
        extern void deleteBasicBlockNative(
            void* (* LLVMBasicBlockRef *) BB)
        let deleteBasicBlock _BB =
            deleteBasicBlockNative ((_BB : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRemoveBasicBlockFromParent")>]
        extern void removeBasicBlockFromParentNative(
            void* (* LLVMBasicBlockRef *) BB)
        let removeBasicBlockFromParent _BB =
            removeBasicBlockFromParentNative ((_BB : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMMoveBasicBlockBefore")>]
        extern void moveBasicBlockBeforeNative(
            void* (* LLVMBasicBlockRef *) BB,
            void* (* LLVMBasicBlockRef *) MovePos)
        let moveBasicBlockBefore _BB _MovePos =
            moveBasicBlockBeforeNative ((_BB : BasicBlockRef).Ptr, (_MovePos : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMMoveBasicBlockAfter")>]
        extern void moveBasicBlockAfterNative(
            void* (* LLVMBasicBlockRef *) BB,
            void* (* LLVMBasicBlockRef *) MovePos)
        let moveBasicBlockAfter _BB _MovePos =
            moveBasicBlockAfterNative ((_BB : BasicBlockRef).Ptr, (_MovePos : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetFirstInstruction")>]
        extern void* (* LLVMValueRef *) getFirstInstructionNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getFirstInstruction _BB =
            new ValueRef (getFirstInstructionNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetLastInstruction")>]
        extern void* (* LLVMValueRef *) getLastInstructionNative(
            void* (* LLVMBasicBlockRef *) BB)
        let getLastInstruction _BB =
            new ValueRef (getLastInstructionNative ((_BB : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetInstructionParent")>]
        extern void* (* LLVMBasicBlockRef *) getInstructionParentNative(
            void* (* LLVMValueRef *) Inst)
        let getInstructionParent _Inst =
            new BasicBlockRef (getInstructionParentNative ((_Inst : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetNextInstruction")>]
        extern void* (* LLVMValueRef *) getNextInstructionNative(
            void* (* LLVMValueRef *) Inst)
        let getNextInstruction _Inst =
            new ValueRef (getNextInstructionNative ((_Inst : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPreviousInstruction")>]
        extern void* (* LLVMValueRef *) getPreviousInstructionNative(
            void* (* LLVMValueRef *) Inst)
        let getPreviousInstruction _Inst =
            new ValueRef (getPreviousInstructionNative ((_Inst : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInstructionEraseFromParent")>]
        extern void instructionEraseFromParentNative(
            void* (* LLVMValueRef *) Inst)
        let instructionEraseFromParent _Inst =
            instructionEraseFromParentNative ((_Inst : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetInstructionOpcode")>]
        extern int (* LLVMOpcode *) getInstructionOpcodeNative(
            void* (* LLVMValueRef *) Inst)
        let getInstructionOpcode _Inst =
            enum<Opcode> (getInstructionOpcodeNative ((_Inst : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetICmpPredicate")>]
        extern int (* LLVMIntPredicate *) getICmpPredicateNative(
            void* (* LLVMValueRef *) Inst)
        let getICmpPredicate _Inst =
            enum<IntPredicate> (getICmpPredicateNative ((_Inst : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetInstructionCallConv")>]
        extern void setInstructionCallConvNative(
            void* (* LLVMValueRef *) Instr,
            uint32 CC)
        let setInstructionCallConv _Instr _CC =
            setInstructionCallConvNative ((_Instr : ValueRef).Ptr, _CC)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetInstructionCallConv")>]
        extern uint32 getInstructionCallConvNative(
            void* (* LLVMValueRef *) Instr)
        let getInstructionCallConv _Instr =
            getInstructionCallConvNative ((_Instr : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddInstrAttribute")>]
        extern void addInstrAttributeNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            int (* LLVMAttribute *) arg2)
        let addInstrAttribute _Instr _index _arg2 =
            addInstrAttributeNative ((_Instr : ValueRef).Ptr, _index, (int (_arg2 : Attribute)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRemoveInstrAttribute")>]
        extern void removeInstrAttributeNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            int (* LLVMAttribute *) arg2)
        let removeInstrAttribute _Instr _index _arg2 =
            removeInstrAttributeNative ((_Instr : ValueRef).Ptr, _index, (int (_arg2 : Attribute)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetInstrParamAlignment")>]
        extern void setInstrParamAlignmentNative(
            void* (* LLVMValueRef *) Instr,
            uint32 index,
            uint32 align)
        let setInstrParamAlignment _Instr _index _align =
            setInstrParamAlignmentNative ((_Instr : ValueRef).Ptr, _index, _align)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIsTailCall")>]
        extern bool isTailCallNative(
            void* (* LLVMValueRef *) CallInst)
        let isTailCall _CallInst =
            isTailCallNative ((_CallInst : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetTailCall")>]
        extern void setTailCallNative(
            void* (* LLVMValueRef *) CallInst,
            bool IsTailCall)
        let setTailCall _CallInst _IsTailCall =
            setTailCallNative ((_CallInst : ValueRef).Ptr, _IsTailCall)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetSwitchDefaultDest")>]
        extern void* (* LLVMBasicBlockRef *) getSwitchDefaultDestNative(
            void* (* LLVMValueRef *) SwitchInstr)
        let getSwitchDefaultDest _SwitchInstr =
            new BasicBlockRef (getSwitchDefaultDestNative ((_SwitchInstr : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddIncoming")>]
        extern void addIncomingNative(
            void* (* LLVMValueRef *) PhiNode,
            void* (* LLVMValueRef* *) IncomingValues,
            void* (* LLVMBasicBlockRef* *) IncomingBlocks,
            uint32 Count)
        // I don't know how to generate an "F# friendly" version of LLVMAddIncoming

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCountIncoming")>]
        extern uint32 countIncomingNative(
            void* (* LLVMValueRef *) PhiNode)
        let countIncoming _PhiNode =
            countIncomingNative ((_PhiNode : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetIncomingValue")>]
        extern void* (* LLVMValueRef *) getIncomingValueNative(
            void* (* LLVMValueRef *) PhiNode,
            uint32 Index)
        let getIncomingValue _PhiNode _Index =
            new ValueRef (getIncomingValueNative ((_PhiNode : ValueRef).Ptr, _Index))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetIncomingBlock")>]
        extern void* (* LLVMBasicBlockRef *) getIncomingBlockNative(
            void* (* LLVMValueRef *) PhiNode,
            uint32 Index)
        let getIncomingBlock _PhiNode _Index =
            new BasicBlockRef (getIncomingBlockNative ((_PhiNode : ValueRef).Ptr, _Index))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateBuilderInContext")>]
        extern void* (* LLVMBuilderRef *) createBuilderInContextNative(
            void* (* LLVMContextRef *) C)
        let createBuilderInContext _C =
            new BuilderRef (createBuilderInContextNative ((_C : ContextRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateBuilder")>]
        extern void* (* LLVMBuilderRef *) createBuilderNative()
        let createBuilder () =
            new BuilderRef (createBuilderNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPositionBuilder")>]
        extern void positionBuilderNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMBasicBlockRef *) Block,
            void* (* LLVMValueRef *) Instr)
        let positionBuilder _Builder _Block _Instr =
            positionBuilderNative ((_Builder : BuilderRef).Ptr, (_Block : BasicBlockRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPositionBuilderBefore")>]
        extern void positionBuilderBeforeNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr)
        let positionBuilderBefore _Builder _Instr =
            positionBuilderBeforeNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPositionBuilderAtEnd")>]
        extern void positionBuilderAtEndNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMBasicBlockRef *) Block)
        let positionBuilderAtEnd _Builder _Block =
            positionBuilderAtEndNative ((_Builder : BuilderRef).Ptr, (_Block : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetInsertBlock")>]
        extern void* (* LLVMBasicBlockRef *) getInsertBlockNative(
            void* (* LLVMBuilderRef *) Builder)
        let getInsertBlock _Builder =
            new BasicBlockRef (getInsertBlockNative ((_Builder : BuilderRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMClearInsertionPosition")>]
        extern void clearInsertionPositionNative(
            void* (* LLVMBuilderRef *) Builder)
        let clearInsertionPosition _Builder =
            clearInsertionPositionNative ((_Builder : BuilderRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInsertIntoBuilder")>]
        extern void insertIntoBuilderNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr)
        let insertIntoBuilder _Builder _Instr =
            insertIntoBuilderNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInsertIntoBuilderWithName")>]
        extern void insertIntoBuilderWithNameNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Instr,
            string Name)
        let insertIntoBuilderWithName _Builder _Instr _Name =
            insertIntoBuilderWithNameNative ((_Builder : BuilderRef).Ptr, (_Instr : ValueRef).Ptr, _Name)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeBuilder")>]
        extern void disposeBuilderNative(
            void* (* LLVMBuilderRef *) Builder)
        let disposeBuilder _Builder =
            disposeBuilderNative ((_Builder : BuilderRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetCurrentDebugLocation")>]
        extern void setCurrentDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) L)
        let setCurrentDebugLocation _Builder _L =
            setCurrentDebugLocationNative ((_Builder : BuilderRef).Ptr, (_L : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetCurrentDebugLocation")>]
        extern void* (* LLVMValueRef *) getCurrentDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder)
        let getCurrentDebugLocation _Builder =
            new ValueRef (getCurrentDebugLocationNative ((_Builder : BuilderRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetInstDebugLocation")>]
        extern void setInstDebugLocationNative(
            void* (* LLVMBuilderRef *) Builder,
            void* (* LLVMValueRef *) Inst)
        let setInstDebugLocation _Builder _Inst =
            setInstDebugLocationNative ((_Builder : BuilderRef).Ptr, (_Inst : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildRetVoid")>]
        extern void* (* LLVMValueRef *) buildRetVoidNative(
            void* (* LLVMBuilderRef *) arg0)
        let buildRetVoid _arg0 =
            new ValueRef (buildRetVoidNative ((_arg0 : BuilderRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildRet")>]
        extern void* (* LLVMValueRef *) buildRetNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V)
        let buildRet _arg0 _V =
            new ValueRef (buildRetNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildAggregateRet")>]
        extern void* (* LLVMValueRef *) buildAggregateRetNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef* *) RetVals,
            uint32 N)
        // I don't know how to generate an "F# friendly" version of LLVMBuildAggregateRet

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildBr")>]
        extern void* (* LLVMValueRef *) buildBrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMBasicBlockRef *) Dest)
        let buildBr _arg0 _Dest =
            new ValueRef (buildBrNative ((_arg0 : BuilderRef).Ptr, (_Dest : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildCondBr")>]
        extern void* (* LLVMValueRef *) buildCondBrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) If,
            void* (* LLVMBasicBlockRef *) Then,
            void* (* LLVMBasicBlockRef *) Else)
        let buildCondBr _arg0 _If _Then _Else =
            new ValueRef (buildCondBrNative ((_arg0 : BuilderRef).Ptr, (_If : ValueRef).Ptr, (_Then : BasicBlockRef).Ptr, (_Else : BasicBlockRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSwitch")>]
        extern void* (* LLVMValueRef *) buildSwitchNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            void* (* LLVMBasicBlockRef *) Else,
            uint32 NumCases)
        let buildSwitch _arg0 _V _Else _NumCases =
            new ValueRef (buildSwitchNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, (_Else : BasicBlockRef).Ptr, _NumCases))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildIndirectBr")>]
        extern void* (* LLVMValueRef *) buildIndirectBrNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Addr,
            uint32 NumDests)
        let buildIndirectBr _B _Addr _NumDests =
            new ValueRef (buildIndirectBrNative ((_B : BuilderRef).Ptr, (_Addr : ValueRef).Ptr, _NumDests))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildInvoke")>]
        extern void* (* LLVMValueRef *) buildInvokeNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Args,
            uint32 NumArgs,
            void* (* LLVMBasicBlockRef *) Then,
            void* (* LLVMBasicBlockRef *) Catch,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildInvoke

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildLandingPad")>]
        extern void* (* LLVMValueRef *) buildLandingPadNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) PersFn,
            uint32 NumClauses,
            string Name)
        let buildLandingPad _B _Ty _PersFn _NumClauses _Name =
            new ValueRef (buildLandingPadNative ((_B : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_PersFn : ValueRef).Ptr, _NumClauses, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildResume")>]
        extern void* (* LLVMValueRef *) buildResumeNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Exn)
        let buildResume _B _Exn =
            new ValueRef (buildResumeNative ((_B : BuilderRef).Ptr, (_Exn : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildUnreachable")>]
        extern void* (* LLVMValueRef *) buildUnreachableNative(
            void* (* LLVMBuilderRef *) arg0)
        let buildUnreachable _arg0 =
            new ValueRef (buildUnreachableNative ((_arg0 : BuilderRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddCase")>]
        extern void addCaseNative(
            void* (* LLVMValueRef *) Switch,
            void* (* LLVMValueRef *) OnVal,
            void* (* LLVMBasicBlockRef *) Dest)
        let addCase _Switch _OnVal _Dest =
            addCaseNative ((_Switch : ValueRef).Ptr, (_OnVal : ValueRef).Ptr, (_Dest : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddDestination")>]
        extern void addDestinationNative(
            void* (* LLVMValueRef *) IndirectBr,
            void* (* LLVMBasicBlockRef *) Dest)
        let addDestination _IndirectBr _Dest =
            addDestinationNative ((_IndirectBr : ValueRef).Ptr, (_Dest : BasicBlockRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddClause")>]
        extern void addClauseNative(
            void* (* LLVMValueRef *) LandingPad,
            void* (* LLVMValueRef *) ClauseVal)
        let addClause _LandingPad _ClauseVal =
            addClauseNative ((_LandingPad : ValueRef).Ptr, (_ClauseVal : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSetCleanup")>]
        extern void setCleanupNative(
            void* (* LLVMValueRef *) LandingPad,
            bool Val)
        let setCleanup _LandingPad _Val =
            setCleanupNative ((_LandingPad : ValueRef).Ptr, _Val)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildAdd")>]
        extern void* (* LLVMValueRef *) buildAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNSWAdd")>]
        extern void* (* LLVMValueRef *) buildNSWAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNUWAdd")>]
        extern void* (* LLVMValueRef *) buildNUWAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFAdd")>]
        extern void* (* LLVMValueRef *) buildFAddNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFAdd _arg0 _LHS _RHS _Name =
            new ValueRef (buildFAddNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSub")>]
        extern void* (* LLVMValueRef *) buildSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNSWSub")>]
        extern void* (* LLVMValueRef *) buildNSWSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNUWSub")>]
        extern void* (* LLVMValueRef *) buildNUWSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFSub")>]
        extern void* (* LLVMValueRef *) buildFSubNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFSub _arg0 _LHS _RHS _Name =
            new ValueRef (buildFSubNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildMul")>]
        extern void* (* LLVMValueRef *) buildMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNSWMul")>]
        extern void* (* LLVMValueRef *) buildNSWMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNSWMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildNSWMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNUWMul")>]
        extern void* (* LLVMValueRef *) buildNUWMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildNUWMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildNUWMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFMul")>]
        extern void* (* LLVMValueRef *) buildFMulNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFMul _arg0 _LHS _RHS _Name =
            new ValueRef (buildFMulNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildUDiv")>]
        extern void* (* LLVMValueRef *) buildUDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildUDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildUDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSDiv")>]
        extern void* (* LLVMValueRef *) buildSDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildSDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildExactSDiv")>]
        extern void* (* LLVMValueRef *) buildExactSDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildExactSDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildExactSDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFDiv")>]
        extern void* (* LLVMValueRef *) buildFDivNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFDiv _arg0 _LHS _RHS _Name =
            new ValueRef (buildFDivNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildURem")>]
        extern void* (* LLVMValueRef *) buildURemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildURem _arg0 _LHS _RHS _Name =
            new ValueRef (buildURemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSRem")>]
        extern void* (* LLVMValueRef *) buildSRemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildSRem _arg0 _LHS _RHS _Name =
            new ValueRef (buildSRemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFRem")>]
        extern void* (* LLVMValueRef *) buildFRemNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFRem _arg0 _LHS _RHS _Name =
            new ValueRef (buildFRemNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildShl")>]
        extern void* (* LLVMValueRef *) buildShlNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildShl _arg0 _LHS _RHS _Name =
            new ValueRef (buildShlNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildLShr")>]
        extern void* (* LLVMValueRef *) buildLShrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildLShr _arg0 _LHS _RHS _Name =
            new ValueRef (buildLShrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildAShr")>]
        extern void* (* LLVMValueRef *) buildAShrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAShr _arg0 _LHS _RHS _Name =
            new ValueRef (buildAShrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildAnd")>]
        extern void* (* LLVMValueRef *) buildAndNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildAnd _arg0 _LHS _RHS _Name =
            new ValueRef (buildAndNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildOr")>]
        extern void* (* LLVMValueRef *) buildOrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildOr _arg0 _LHS _RHS _Name =
            new ValueRef (buildOrNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildXor")>]
        extern void* (* LLVMValueRef *) buildXorNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildXor _arg0 _LHS _RHS _Name =
            new ValueRef (buildXorNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildBinOp")>]
        extern void* (* LLVMValueRef *) buildBinOpNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMOpcode *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildBinOp _B _Op _LHS _RHS _Name =
            new ValueRef (buildBinOpNative ((_B : BuilderRef).Ptr, (int (_Op : Opcode)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNeg")>]
        extern void* (* LLVMValueRef *) buildNegNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNeg _arg0 _V _Name =
            new ValueRef (buildNegNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNSWNeg")>]
        extern void* (* LLVMValueRef *) buildNSWNegNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNSWNeg _B _V _Name =
            new ValueRef (buildNSWNegNative ((_B : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNUWNeg")>]
        extern void* (* LLVMValueRef *) buildNUWNegNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNUWNeg _B _V _Name =
            new ValueRef (buildNUWNegNative ((_B : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFNeg")>]
        extern void* (* LLVMValueRef *) buildFNegNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildFNeg _arg0 _V _Name =
            new ValueRef (buildFNegNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildNot")>]
        extern void* (* LLVMValueRef *) buildNotNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V,
            string Name)
        let buildNot _arg0 _V _Name =
            new ValueRef (buildNotNative ((_arg0 : BuilderRef).Ptr, (_V : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildMalloc")>]
        extern void* (* LLVMValueRef *) buildMallocNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildMalloc _arg0 _Ty _Name =
            new ValueRef (buildMallocNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildArrayMalloc")>]
        extern void* (* LLVMValueRef *) buildArrayMallocNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildArrayMalloc _arg0 _Ty _Val _Name =
            new ValueRef (buildArrayMallocNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildAlloca")>]
        extern void* (* LLVMValueRef *) buildAllocaNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildAlloca _arg0 _Ty _Name =
            new ValueRef (buildAllocaNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildArrayAlloca")>]
        extern void* (* LLVMValueRef *) buildArrayAllocaNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildArrayAlloca _arg0 _Ty _Val _Name =
            new ValueRef (buildArrayAllocaNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFree")>]
        extern void* (* LLVMValueRef *) buildFreeNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) PointerVal)
        let buildFree _arg0 _PointerVal =
            new ValueRef (buildFreeNative ((_arg0 : BuilderRef).Ptr, (_PointerVal : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildLoad")>]
        extern void* (* LLVMValueRef *) buildLoadNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) PointerVal,
            string Name)
        let buildLoad _arg0 _PointerVal _Name =
            new ValueRef (buildLoadNative ((_arg0 : BuilderRef).Ptr, (_PointerVal : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildStore")>]
        extern void* (* LLVMValueRef *) buildStoreNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMValueRef *) Ptr)
        let buildStore _arg0 _Val _Ptr =
            new ValueRef (buildStoreNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_Ptr : ValueRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildGEP")>]
        extern void* (* LLVMValueRef *) buildGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            void* (* LLVMValueRef* *) Indices,
            uint32 NumIndices,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildGEP

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildInBoundsGEP")>]
        extern void* (* LLVMValueRef *) buildInBoundsGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            void* (* LLVMValueRef* *) Indices,
            uint32 NumIndices,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildInBoundsGEP

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildStructGEP")>]
        extern void* (* LLVMValueRef *) buildStructGEPNative(
            void* (* LLVMBuilderRef *) B,
            void* (* LLVMValueRef *) Pointer,
            uint32 Idx,
            string Name)
        let buildStructGEP _B _Pointer _Idx _Name =
            new ValueRef (buildStructGEPNative ((_B : BuilderRef).Ptr, (_Pointer : ValueRef).Ptr, _Idx, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildGlobalString")>]
        extern void* (* LLVMValueRef *) buildGlobalStringNative(
            void* (* LLVMBuilderRef *) B,
            string Str,
            string Name)
        let buildGlobalString _B _Str _Name =
            new ValueRef (buildGlobalStringNative ((_B : BuilderRef).Ptr, _Str, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildGlobalStringPtr")>]
        extern void* (* LLVMValueRef *) buildGlobalStringPtrNative(
            void* (* LLVMBuilderRef *) B,
            string Str,
            string Name)
        let buildGlobalStringPtr _B _Str _Name =
            new ValueRef (buildGlobalStringPtrNative ((_B : BuilderRef).Ptr, _Str, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildTrunc")>]
        extern void* (* LLVMValueRef *) buildTruncNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildTrunc _arg0 _Val _DestTy _Name =
            new ValueRef (buildTruncNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildZExt")>]
        extern void* (* LLVMValueRef *) buildZExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildZExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildZExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSExt")>]
        extern void* (* LLVMValueRef *) buildSExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildSExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFPToUI")>]
        extern void* (* LLVMValueRef *) buildFPToUINative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPToUI _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPToUINative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFPToSI")>]
        extern void* (* LLVMValueRef *) buildFPToSINative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPToSI _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPToSINative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildUIToFP")>]
        extern void* (* LLVMValueRef *) buildUIToFPNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildUIToFP _arg0 _Val _DestTy _Name =
            new ValueRef (buildUIToFPNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSIToFP")>]
        extern void* (* LLVMValueRef *) buildSIToFPNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSIToFP _arg0 _Val _DestTy _Name =
            new ValueRef (buildSIToFPNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFPTrunc")>]
        extern void* (* LLVMValueRef *) buildFPTruncNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPTrunc _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPTruncNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFPExt")>]
        extern void* (* LLVMValueRef *) buildFPExtNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPExt _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPExtNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildPtrToInt")>]
        extern void* (* LLVMValueRef *) buildPtrToIntNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildPtrToInt _arg0 _Val _DestTy _Name =
            new ValueRef (buildPtrToIntNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildIntToPtr")>]
        extern void* (* LLVMValueRef *) buildIntToPtrNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildIntToPtr _arg0 _Val _DestTy _Name =
            new ValueRef (buildIntToPtrNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildBitCast")>]
        extern void* (* LLVMValueRef *) buildBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildZExtOrBitCast")>]
        extern void* (* LLVMValueRef *) buildZExtOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildZExtOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildZExtOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSExtOrBitCast")>]
        extern void* (* LLVMValueRef *) buildSExtOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildSExtOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildSExtOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildTruncOrBitCast")>]
        extern void* (* LLVMValueRef *) buildTruncOrBitCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildTruncOrBitCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildTruncOrBitCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildCast")>]
        extern void* (* LLVMValueRef *) buildCastNative(
            void* (* LLVMBuilderRef *) B,
            int (* LLVMOpcode *) Op,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildCast _B _Op _Val _DestTy _Name =
            new ValueRef (buildCastNative ((_B : BuilderRef).Ptr, (int (_Op : Opcode)), (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildPointerCast")>]
        extern void* (* LLVMValueRef *) buildPointerCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildPointerCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildPointerCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildIntCast")>]
        extern void* (* LLVMValueRef *) buildIntCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildIntCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildIntCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFPCast")>]
        extern void* (* LLVMValueRef *) buildFPCastNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            void* (* LLVMTypeRef *) DestTy,
            string Name)
        let buildFPCast _arg0 _Val _DestTy _Name =
            new ValueRef (buildFPCastNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, (_DestTy : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildICmp")>]
        extern void* (* LLVMValueRef *) buildICmpNative(
            void* (* LLVMBuilderRef *) arg0,
            int (* LLVMIntPredicate *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildICmp _arg0 _Op _LHS _RHS _Name =
            new ValueRef (buildICmpNative ((_arg0 : BuilderRef).Ptr, (int (_Op : IntPredicate)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildFCmp")>]
        extern void* (* LLVMValueRef *) buildFCmpNative(
            void* (* LLVMBuilderRef *) arg0,
            int (* LLVMRealPredicate *) Op,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildFCmp _arg0 _Op _LHS _RHS _Name =
            new ValueRef (buildFCmpNative ((_arg0 : BuilderRef).Ptr, (int (_Op : RealPredicate)), (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildPhi")>]
        extern void* (* LLVMValueRef *) buildPhiNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildPhi _arg0 _Ty _Name =
            new ValueRef (buildPhiNative ((_arg0 : BuilderRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildCall")>]
        extern void* (* LLVMValueRef *) buildCallNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Fn,
            void* (* LLVMValueRef* *) Args,
            uint32 NumArgs,
            string Name)
        // I don't know how to generate an "F# friendly" version of LLVMBuildCall

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildSelect")>]
        extern void* (* LLVMValueRef *) buildSelectNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) If,
            void* (* LLVMValueRef *) Then,
            void* (* LLVMValueRef *) Else,
            string Name)
        let buildSelect _arg0 _If _Then _Else _Name =
            new ValueRef (buildSelectNative ((_arg0 : BuilderRef).Ptr, (_If : ValueRef).Ptr, (_Then : ValueRef).Ptr, (_Else : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildVAArg")>]
        extern void* (* LLVMValueRef *) buildVAArgNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) List,
            void* (* LLVMTypeRef *) Ty,
            string Name)
        let buildVAArg _arg0 _List _Ty _Name =
            new ValueRef (buildVAArgNative ((_arg0 : BuilderRef).Ptr, (_List : ValueRef).Ptr, (_Ty : TypeRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildExtractElement")>]
        extern void* (* LLVMValueRef *) buildExtractElementNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) VecVal,
            void* (* LLVMValueRef *) Index,
            string Name)
        let buildExtractElement _arg0 _VecVal _Index _Name =
            new ValueRef (buildExtractElementNative ((_arg0 : BuilderRef).Ptr, (_VecVal : ValueRef).Ptr, (_Index : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildInsertElement")>]
        extern void* (* LLVMValueRef *) buildInsertElementNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) VecVal,
            void* (* LLVMValueRef *) EltVal,
            void* (* LLVMValueRef *) Index,
            string Name)
        let buildInsertElement _arg0 _VecVal _EltVal _Index _Name =
            new ValueRef (buildInsertElementNative ((_arg0 : BuilderRef).Ptr, (_VecVal : ValueRef).Ptr, (_EltVal : ValueRef).Ptr, (_Index : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildShuffleVector")>]
        extern void* (* LLVMValueRef *) buildShuffleVectorNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) V1,
            void* (* LLVMValueRef *) V2,
            void* (* LLVMValueRef *) Mask,
            string Name)
        let buildShuffleVector _arg0 _V1 _V2 _Mask _Name =
            new ValueRef (buildShuffleVectorNative ((_arg0 : BuilderRef).Ptr, (_V1 : ValueRef).Ptr, (_V2 : ValueRef).Ptr, (_Mask : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildExtractValue")>]
        extern void* (* LLVMValueRef *) buildExtractValueNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) AggVal,
            uint32 Index,
            string Name)
        let buildExtractValue _arg0 _AggVal _Index _Name =
            new ValueRef (buildExtractValueNative ((_arg0 : BuilderRef).Ptr, (_AggVal : ValueRef).Ptr, _Index, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildInsertValue")>]
        extern void* (* LLVMValueRef *) buildInsertValueNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) AggVal,
            void* (* LLVMValueRef *) EltVal,
            uint32 Index,
            string Name)
        let buildInsertValue _arg0 _AggVal _EltVal _Index _Name =
            new ValueRef (buildInsertValueNative ((_arg0 : BuilderRef).Ptr, (_AggVal : ValueRef).Ptr, (_EltVal : ValueRef).Ptr, _Index, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildIsNull")>]
        extern void* (* LLVMValueRef *) buildIsNullNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildIsNull _arg0 _Val _Name =
            new ValueRef (buildIsNullNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildIsNotNull")>]
        extern void* (* LLVMValueRef *) buildIsNotNullNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) Val,
            string Name)
        let buildIsNotNull _arg0 _Val _Name =
            new ValueRef (buildIsNotNullNative ((_arg0 : BuilderRef).Ptr, (_Val : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMBuildPtrDiff")>]
        extern void* (* LLVMValueRef *) buildPtrDiffNative(
            void* (* LLVMBuilderRef *) arg0,
            void* (* LLVMValueRef *) LHS,
            void* (* LLVMValueRef *) RHS,
            string Name)
        let buildPtrDiff _arg0 _LHS _RHS _Name =
            new ValueRef (buildPtrDiffNative ((_arg0 : BuilderRef).Ptr, (_LHS : ValueRef).Ptr, (_RHS : ValueRef).Ptr, _Name))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateModuleProviderForExistingModule")>]
        extern void* (* LLVMModuleProviderRef *) createModuleProviderForExistingModuleNative(
            void* (* LLVMModuleRef *) M)
        let createModuleProviderForExistingModule _M =
            new ModuleProviderRef (createModuleProviderForExistingModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeModuleProvider")>]
        extern void disposeModuleProviderNative(
            void* (* LLVMModuleProviderRef *) M)
        let disposeModuleProvider _M =
            disposeModuleProviderNative ((_M : ModuleProviderRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateMemoryBufferWithContentsOfFile")>]
        extern bool createMemoryBufferWithContentsOfFileNative(
            string Path,
            void* (* LLVMMemoryBufferRef* *) OutMemBuf,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMemoryBufferWithContentsOfFile

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateMemoryBufferWithSTDIN")>]
        extern bool createMemoryBufferWithSTDINNative(
            void* (* LLVMMemoryBufferRef* *) OutMemBuf,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMCreateMemoryBufferWithSTDIN

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeMemoryBuffer")>]
        extern void disposeMemoryBufferNative(
            void* (* LLVMMemoryBufferRef *) MemBuf)
        let disposeMemoryBuffer _MemBuf =
            disposeMemoryBufferNative ((_MemBuf : MemoryBufferRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetGlobalPassRegistry")>]
        extern void* (* LLVMPassRegistryRef *) getGlobalPassRegistryNative()
        let getGlobalPassRegistry () =
            new PassRegistryRef (getGlobalPassRegistryNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreatePassManager")>]
        extern void* (* LLVMPassManagerRef *) createPassManagerNative()
        let createPassManager () =
            new PassManagerRef (createPassManagerNative ())

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateFunctionPassManagerForModule")>]
        extern void* (* LLVMPassManagerRef *) createFunctionPassManagerForModuleNative(
            void* (* LLVMModuleRef *) M)
        let createFunctionPassManagerForModule _M =
            new PassManagerRef (createFunctionPassManagerForModuleNative ((_M : ModuleRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateFunctionPassManager")>]
        extern void* (* LLVMPassManagerRef *) createFunctionPassManagerNative(
            void* (* LLVMModuleProviderRef *) MP)
        let createFunctionPassManager _MP =
            new PassManagerRef (createFunctionPassManagerNative ((_MP : ModuleProviderRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRunPassManager")>]
        extern bool runPassManagerNative(
            void* (* LLVMPassManagerRef *) PM,
            void* (* LLVMModuleRef *) M)
        let runPassManager _PM _M =
            runPassManagerNative ((_PM : PassManagerRef).Ptr, (_M : ModuleRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInitializeFunctionPassManager")>]
        extern bool initializeFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM)
        let initializeFunctionPassManager _FPM =
            initializeFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRunFunctionPassManager")>]
        extern bool runFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM,
            void* (* LLVMValueRef *) F)
        let runFunctionPassManager _FPM _F =
            runFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr, (_F : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFinalizeFunctionPassManager")>]
        extern bool finalizeFunctionPassManagerNative(
            void* (* LLVMPassManagerRef *) FPM)
        let finalizeFunctionPassManager _FPM =
            finalizeFunctionPassManagerNative ((_FPM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposePassManager")>]
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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMParseBitcode")>]
        extern bool parseBitcodeNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutModule,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMParseBitcode

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMParseBitcodeInContext")>]
        extern bool parseBitcodeInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutModule,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMParseBitcodeInContext

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBitcodeModuleInContext")>]
        extern bool getBitcodeModuleInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutM,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleInContext

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBitcodeModule")>]
        extern bool getBitcodeModuleNative(
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleRef* *) OutM,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModule

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBitcodeModuleProviderInContext")>]
        extern bool getBitcodeModuleProviderInContextNative(
            void* (* LLVMContextRef *) ContextRef,
            void* (* LLVMMemoryBufferRef *) MemBuf,
            void* (* LLVMModuleProviderRef* *) OutMP,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMGetBitcodeModuleProviderInContext

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetBitcodeModuleProvider")>]
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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMWriteBitcodeToFile")>]
        extern int writeBitcodeToFileNative(
            void* (* LLVMModuleRef *) M,
            string Path)
        let writeBitcodeToFile _M _Path =
            writeBitcodeToFileNative ((_M : ModuleRef).Ptr, _Path)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMWriteBitcodeToFD")>]
        extern int writeBitcodeToFDNative(
            void* (* LLVMModuleRef *) M,
            int FD,
            int ShouldClose,
            int Unbuffered)
        let writeBitcodeToFD _M _FD _ShouldClose _Unbuffered =
            writeBitcodeToFDNative ((_M : ModuleRef).Ptr, _FD, _ShouldClose, _Unbuffered)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMWriteBitcodeToFileHandle")>]
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
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type TargetLibraryInfoRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type StructLayoutRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateTargetData")>]
        extern void* (* LLVMTargetDataRef *) createTargetDataNative(
            string StringRep)
        let createTargetData _StringRep =
            new TargetDataRef (createTargetDataNative (_StringRep))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddTargetData")>]
        extern void addTargetDataNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMPassManagerRef *) arg1)
        let addTargetData _arg0 _arg1 =
            addTargetDataNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddTargetLibraryInfo")>]
        extern void addTargetLibraryInfoNative(
            void* (* LLVMTargetLibraryInfoRef *) arg0,
            void* (* LLVMPassManagerRef *) arg1)
        let addTargetLibraryInfo _arg0 _arg1 =
            addTargetLibraryInfoNative ((_arg0 : TargetLibraryInfoRef).Ptr, (_arg1 : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCopyStringRepOfTargetData")>]
        extern void* copyStringRepOfTargetDataNative(
            void* (* LLVMTargetDataRef *) arg0)
        let copyStringRepOfTargetData _arg0 =
            Marshal.PtrToStringAuto (copyStringRepOfTargetDataNative ((_arg0 : TargetDataRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMByteOrder")>]
        extern int (* LLVMByteOrdering *) byteOrderNative(
            void* (* LLVMTargetDataRef *) arg0)
        let byteOrder _arg0 =
            enum<ByteOrdering> (byteOrderNative ((_arg0 : TargetDataRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPointerSize")>]
        extern uint32 pointerSizeNative(
            void* (* LLVMTargetDataRef *) arg0)
        let pointerSize _arg0 =
            pointerSizeNative ((_arg0 : TargetDataRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMIntPtrType")>]
        extern void* (* LLVMTypeRef *) intPtrTypeNative(
            void* (* LLVMTargetDataRef *) arg0)
        let intPtrType _arg0 =
            new TypeRef (intPtrTypeNative ((_arg0 : TargetDataRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMSizeOfTypeInBits")>]
        extern uint64 sizeOfTypeInBitsNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let sizeOfTypeInBits _arg0 _arg1 =
            sizeOfTypeInBitsNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMStoreSizeOfType")>]
        extern uint64 storeSizeOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let storeSizeOfType _arg0 _arg1 =
            storeSizeOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMABISizeOfType")>]
        extern uint64 aBISizeOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let aBISizeOfType _arg0 _arg1 =
            aBISizeOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMABIAlignmentOfType")>]
        extern uint32 aBIAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let aBIAlignmentOfType _arg0 _arg1 =
            aBIAlignmentOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCallFrameAlignmentOfType")>]
        extern uint32 callFrameAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let callFrameAlignmentOfType _arg0 _arg1 =
            callFrameAlignmentOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPreferredAlignmentOfType")>]
        extern uint32 preferredAlignmentOfTypeNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) arg1)
        let preferredAlignmentOfType _arg0 _arg1 =
            preferredAlignmentOfTypeNative ((_arg0 : TargetDataRef).Ptr, (_arg1 : TypeRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMPreferredAlignmentOfGlobal")>]
        extern uint32 preferredAlignmentOfGlobalNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMValueRef *) GlobalVar)
        let preferredAlignmentOfGlobal _arg0 _GlobalVar =
            preferredAlignmentOfGlobalNative ((_arg0 : TargetDataRef).Ptr, (_GlobalVar : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMElementAtOffset")>]
        extern uint32 elementAtOffsetNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) StructTy,
            uint64 Offset)
        let elementAtOffset _arg0 _StructTy _Offset =
            elementAtOffsetNative ((_arg0 : TargetDataRef).Ptr, (_StructTy : TypeRef).Ptr, _Offset)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMOffsetOfElement")>]
        extern uint64 offsetOfElementNative(
            void* (* LLVMTargetDataRef *) arg0,
            void* (* LLVMTypeRef *) StructTy,
            uint32 Element)
        let offsetOfElement _arg0 _StructTy _Element =
            offsetOfElementNative ((_arg0 : TargetDataRef).Ptr, (_StructTy : TypeRef).Ptr, _Element)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeTargetData")>]
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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMLinkInJIT")>]
        extern void linkInJITNative()
        let linkInJIT () =
            linkInJITNative ()

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMLinkInInterpreter")>]
        extern void linkInInterpreterNative()
        let linkInInterpreter () =
            linkInInterpreterNative ()

        type GenericValueRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        type ExecutionEngineRef (thePtr : nativeint) =
            member x.Ptr with get() = (x :> ILLVMRef).Ptr
            interface ILLVMRef with member x.Ptr with get() = thePtr

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateGenericValueOfInt")>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfIntNative(
            void* (* LLVMTypeRef *) Ty,
            uint64 N,
            bool IsSigned)
        let createGenericValueOfInt _Ty _N _IsSigned =
            new GenericValueRef (createGenericValueOfIntNative ((_Ty : TypeRef).Ptr, _N, _IsSigned))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateGenericValueOfPointer")>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfPointerNative(
            void* P)
        // I don't know how to generate an "F# friendly" version of LLVMCreateGenericValueOfPointer

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateGenericValueOfFloat")>]
        extern void* (* LLVMGenericValueRef *) createGenericValueOfFloatNative(
            void* (* LLVMTypeRef *) Ty,
            double N)
        let createGenericValueOfFloat _Ty _N =
            new GenericValueRef (createGenericValueOfFloatNative ((_Ty : TypeRef).Ptr, _N))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGenericValueIntWidth")>]
        extern uint32 genericValueIntWidthNative(
            void* (* LLVMGenericValueRef *) GenValRef)
        let genericValueIntWidth _GenValRef =
            genericValueIntWidthNative ((_GenValRef : GenericValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGenericValueToInt")>]
        extern uint64 genericValueToIntNative(
            void* (* LLVMGenericValueRef *) GenVal,
            bool IsSigned)
        let genericValueToInt _GenVal _IsSigned =
            genericValueToIntNative ((_GenVal : GenericValueRef).Ptr, _IsSigned)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGenericValueToPointer")>]
        extern void* genericValueToPointerNative(
            void* (* LLVMGenericValueRef *) GenVal)
        // I don't know how to generate an "F# friendly" version of LLVMGenericValueToPointer

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGenericValueToFloat")>]
        extern double genericValueToFloatNative(
            void* (* LLVMTypeRef *) TyRef,
            void* (* LLVMGenericValueRef *) GenVal)
        let genericValueToFloat _TyRef _GenVal =
            genericValueToFloatNative ((_TyRef : TypeRef).Ptr, (_GenVal : GenericValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeGenericValue")>]
        extern void disposeGenericValueNative(
            void* (* LLVMGenericValueRef *) GenVal)
        let disposeGenericValue _GenVal =
            disposeGenericValueNative ((_GenVal : GenericValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateExecutionEngineForModule")>]
        extern bool createExecutionEngineForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutEE,
            void* (* LLVMModuleRef *) M,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateExecutionEngineForModule

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateInterpreterForModule")>]
        extern bool createInterpreterForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutInterp,
            void* (* LLVMModuleRef *) M,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateInterpreterForModule

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateJITCompilerForModule")>]
        extern bool createJITCompilerForModuleNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleRef *) M,
            uint32 OptLevel,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateJITCompilerForModule

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateExecutionEngine")>]
        extern bool createExecutionEngineNative(
            void* (* LLVMExecutionEngineRef* *) OutEE,
            void* (* LLVMModuleProviderRef *) MP,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateExecutionEngine

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateInterpreter")>]
        extern bool createInterpreterNative(
            void* (* LLVMExecutionEngineRef* *) OutInterp,
            void* (* LLVMModuleProviderRef *) MP,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateInterpreter

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMCreateJITCompiler")>]
        extern bool createJITCompilerNative(
            void* (* LLVMExecutionEngineRef* *) OutJIT,
            void* (* LLVMModuleProviderRef *) MP,
            uint32 OptLevel,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMCreateJITCompiler

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMDisposeExecutionEngine")>]
        extern void disposeExecutionEngineNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let disposeExecutionEngine _EE =
            disposeExecutionEngineNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRunStaticConstructors")>]
        extern void runStaticConstructorsNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let runStaticConstructors _EE =
            runStaticConstructorsNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRunStaticDestructors")>]
        extern void runStaticDestructorsNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let runStaticDestructors _EE =
            runStaticDestructorsNative ((_EE : ExecutionEngineRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRunFunctionAsMain")>]
        extern int runFunctionAsMainNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F,
            uint32 ArgC,
            void* ArgV,
            void* EnvP)
        // I don't know how to generate an "F# friendly" version of LLVMRunFunctionAsMain

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRunFunction")>]
        extern void* (* LLVMGenericValueRef *) runFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F,
            uint32 NumArgs,
            void* (* LLVMGenericValueRef* *) Args)
        // I don't know how to generate an "F# friendly" version of LLVMRunFunction

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFreeMachineCodeForFunction")>]
        extern void freeMachineCodeForFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) F)
        let freeMachineCodeForFunction _EE _F =
            freeMachineCodeForFunctionNative ((_EE : ExecutionEngineRef).Ptr, (_F : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddModule")>]
        extern void addModuleNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleRef *) M)
        let addModule _EE _M =
            addModuleNative ((_EE : ExecutionEngineRef).Ptr, (_M : ModuleRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddModuleProvider")>]
        extern void addModuleProviderNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleProviderRef *) MP)
        let addModuleProvider _EE _MP =
            addModuleProviderNative ((_EE : ExecutionEngineRef).Ptr, (_MP : ModuleProviderRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRemoveModule")>]
        extern bool removeModuleNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleRef *) M,
            void* (* LLVMModuleRef* *) OutMod,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMRemoveModule

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRemoveModuleProvider")>]
        extern bool removeModuleProviderNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMModuleProviderRef *) MP,
            void* (* LLVMModuleRef* *) OutMod,
            void* OutError)
        // I don't know how to generate an "F# friendly" version of LLVMRemoveModuleProvider

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMFindFunction")>]
        extern bool findFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            string Name,
            void* (* LLVMValueRef* *) OutFn)
        // I don't know how to generate an "F# friendly" version of LLVMFindFunction

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMRecompileAndRelinkFunction")>]
        extern void* recompileAndRelinkFunctionNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Fn)
        // I don't know how to generate an "F# friendly" version of LLVMRecompileAndRelinkFunction

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetExecutionEngineTargetData")>]
        extern void* (* LLVMTargetDataRef *) getExecutionEngineTargetDataNative(
            void* (* LLVMExecutionEngineRef *) EE)
        let getExecutionEngineTargetData _EE =
            new TargetDataRef (getExecutionEngineTargetDataNative ((_EE : ExecutionEngineRef).Ptr))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddGlobalMapping")>]
        extern void addGlobalMappingNative(
            void* (* LLVMExecutionEngineRef *) EE,
            void* (* LLVMValueRef *) Global,
            void* Addr)
        // I don't know how to generate an "F# friendly" version of LLVMAddGlobalMapping

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMGetPointerToGlobal")>]
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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMVerifyModule")>]
        extern bool verifyModuleNative(
            void* (* LLVMModuleRef *) M,
            int (* LLVMVerifierFailureAction *) Action,
            void* OutMessage)
        // I don't know how to generate an "F# friendly" version of LLVMVerifyModule

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMVerifyFunction")>]
        extern bool verifyFunctionNative(
            void* (* LLVMValueRef *) Fn,
            int (* LLVMVerifierFailureAction *) Action)
        let verifyFunction _Fn _Action =
            verifyFunctionNative ((_Fn : ValueRef).Ptr, (int (_Action : VerifierFailureAction)))

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMViewFunctionCFG")>]
        extern void viewFunctionCFGNative(
            void* (* LLVMValueRef *) Fn)
        let viewFunctionCFG _Fn =
            viewFunctionCFGNative ((_Fn : ValueRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMViewFunctionCFGOnly")>]
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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddAggressiveDCEPass")>]
        extern void addAggressiveDCEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAggressiveDCEPass _PM =
            addAggressiveDCEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddCFGSimplificationPass")>]
        extern void addCFGSimplificationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addCFGSimplificationPass _PM =
            addCFGSimplificationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddDeadStoreEliminationPass")>]
        extern void addDeadStoreEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDeadStoreEliminationPass _PM =
            addDeadStoreEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddGVNPass")>]
        extern void addGVNPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGVNPass _PM =
            addGVNPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddIndVarSimplifyPass")>]
        extern void addIndVarSimplifyPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIndVarSimplifyPass _PM =
            addIndVarSimplifyPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddInstructionCombiningPass")>]
        extern void addInstructionCombiningPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addInstructionCombiningPass _PM =
            addInstructionCombiningPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddJumpThreadingPass")>]
        extern void addJumpThreadingPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addJumpThreadingPass _PM =
            addJumpThreadingPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLICMPass")>]
        extern void addLICMPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLICMPass _PM =
            addLICMPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLoopDeletionPass")>]
        extern void addLoopDeletionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopDeletionPass _PM =
            addLoopDeletionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLoopIdiomPass")>]
        extern void addLoopIdiomPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopIdiomPass _PM =
            addLoopIdiomPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLoopRotatePass")>]
        extern void addLoopRotatePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopRotatePass _PM =
            addLoopRotatePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLoopUnrollPass")>]
        extern void addLoopUnrollPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopUnrollPass _PM =
            addLoopUnrollPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLoopUnswitchPass")>]
        extern void addLoopUnswitchPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLoopUnswitchPass _PM =
            addLoopUnswitchPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddMemCpyOptPass")>]
        extern void addMemCpyOptPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addMemCpyOptPass _PM =
            addMemCpyOptPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddPromoteMemoryToRegisterPass")>]
        extern void addPromoteMemoryToRegisterPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPromoteMemoryToRegisterPass _PM =
            addPromoteMemoryToRegisterPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddReassociatePass")>]
        extern void addReassociatePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addReassociatePass _PM =
            addReassociatePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddSCCPPass")>]
        extern void addSCCPPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addSCCPPass _PM =
            addSCCPPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddScalarReplAggregatesPass")>]
        extern void addScalarReplAggregatesPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarReplAggregatesPass _PM =
            addScalarReplAggregatesPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddScalarReplAggregatesPassSSA")>]
        extern void addScalarReplAggregatesPassSSANative(
            void* (* LLVMPassManagerRef *) PM)
        let addScalarReplAggregatesPassSSA _PM =
            addScalarReplAggregatesPassSSANative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddScalarReplAggregatesPassWithThreshold")>]
        extern void addScalarReplAggregatesPassWithThresholdNative(
            void* (* LLVMPassManagerRef *) PM,
            int Threshold)
        let addScalarReplAggregatesPassWithThreshold _PM _Threshold =
            addScalarReplAggregatesPassWithThresholdNative ((_PM : PassManagerRef).Ptr, _Threshold)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddSimplifyLibCallsPass")>]
        extern void addSimplifyLibCallsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addSimplifyLibCallsPass _PM =
            addSimplifyLibCallsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddTailCallEliminationPass")>]
        extern void addTailCallEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addTailCallEliminationPass _PM =
            addTailCallEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddConstantPropagationPass")>]
        extern void addConstantPropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addConstantPropagationPass _PM =
            addConstantPropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddDemoteMemoryToRegisterPass")>]
        extern void addDemoteMemoryToRegisterPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDemoteMemoryToRegisterPass _PM =
            addDemoteMemoryToRegisterPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddVerifierPass")>]
        extern void addVerifierPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addVerifierPass _PM =
            addVerifierPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddCorrelatedValuePropagationPass")>]
        extern void addCorrelatedValuePropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addCorrelatedValuePropagationPass _PM =
            addCorrelatedValuePropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddEarlyCSEPass")>]
        extern void addEarlyCSEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addEarlyCSEPass _PM =
            addEarlyCSEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddLowerExpectIntrinsicPass")>]
        extern void addLowerExpectIntrinsicPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addLowerExpectIntrinsicPass _PM =
            addLowerExpectIntrinsicPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddTypeBasedAliasAnalysisPass")>]
        extern void addTypeBasedAliasAnalysisPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addTypeBasedAliasAnalysisPass _PM =
            addTypeBasedAliasAnalysisPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddBasicAliasAnalysisPass")>]
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

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddArgumentPromotionPass")>]
        extern void addArgumentPromotionPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addArgumentPromotionPass _PM =
            addArgumentPromotionPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddConstantMergePass")>]
        extern void addConstantMergePassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addConstantMergePass _PM =
            addConstantMergePassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddDeadArgEliminationPass")>]
        extern void addDeadArgEliminationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addDeadArgEliminationPass _PM =
            addDeadArgEliminationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddFunctionAttrsPass")>]
        extern void addFunctionAttrsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addFunctionAttrsPass _PM =
            addFunctionAttrsPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddFunctionInliningPass")>]
        extern void addFunctionInliningPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addFunctionInliningPass _PM =
            addFunctionInliningPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddAlwaysInlinerPass")>]
        extern void addAlwaysInlinerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addAlwaysInlinerPass _PM =
            addAlwaysInlinerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddGlobalDCEPass")>]
        extern void addGlobalDCEPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGlobalDCEPass _PM =
            addGlobalDCEPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddGlobalOptimizerPass")>]
        extern void addGlobalOptimizerPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addGlobalOptimizerPass _PM =
            addGlobalOptimizerPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddIPConstantPropagationPass")>]
        extern void addIPConstantPropagationPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIPConstantPropagationPass _PM =
            addIPConstantPropagationPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddPruneEHPass")>]
        extern void addPruneEHPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addPruneEHPass _PM =
            addPruneEHPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddIPSCCPPass")>]
        extern void addIPSCCPPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addIPSCCPPass _PM =
            addIPSCCPPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddInternalizePass")>]
        extern void addInternalizePassNative(
            void* (* LLVMPassManagerRef *) arg0,
            uint32 AllButMain)
        let addInternalizePass _arg0 _AllButMain =
            addInternalizePassNative ((_arg0 : PassManagerRef).Ptr, _AllButMain)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddStripDeadPrototypesPass")>]
        extern void addStripDeadPrototypesPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addStripDeadPrototypesPass _PM =
            addStripDeadPrototypesPassNative ((_PM : PassManagerRef).Ptr)

        [<DllImport("LLVM-3.0.dll", EntryPoint="LLVMAddStripSymbolsPass")>]
        extern void addStripSymbolsPassNative(
            void* (* LLVMPassManagerRef *) PM)
        let addStripSymbolsPass _PM =
            addStripSymbolsPassNative ((_PM : PassManagerRef).Ptr)

