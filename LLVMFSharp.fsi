namespace LLVM
  module FFIUtil = begin
    type ILLVMRef =
      interface
        abstract member Ptr : nativeint
      end
    type NativePtrs =
      class
        interface System.IDisposable
        new : managedPtrs:nativeint array -> NativePtrs
        member PtrArr : nativeint []
        member Ptrs : nativeint
      end
  end

namespace LLVM.Generated
  module Core = begin
    type ContextRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> ContextRef
        member Ptr : nativeint
      end
    type ModuleRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> ModuleRef
        member Ptr : nativeint
      end
    type TypeRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> TypeRef
        member Ptr : nativeint
      end
    type ValueRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> ValueRef
        member Ptr : nativeint
      end
    type BasicBlockRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> BasicBlockRef
        member Ptr : nativeint
      end
    type BuilderRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> BuilderRef
        member Ptr : nativeint
      end
    type ModuleProviderRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> ModuleProviderRef
        member Ptr : nativeint
      end
    type MemoryBufferRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> MemoryBufferRef
        member Ptr : nativeint
      end
    type PassManagerRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> PassManagerRef
        member Ptr : nativeint
      end
    type PassRegistryRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> PassRegistryRef
        member Ptr : nativeint
      end
    type UseRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> UseRef
        member Ptr : nativeint
      end
    type Attribute =
      |  ZExtAttribute  =  1
      |  SExtAttribute  =  2
      |  NoReturnAttribute  =  4
      |  InRegAttribute  =  8
      |  StructRetAttribute  =  16
      |  NoUnwindAttribute  =  32
      |  NoAliasAttribute  =  64
      |  ByValAttribute  =  128
      |  NestAttribute  =  256
      |  ReadNoneAttribute  =  512
      |  ReadOnlyAttribute  =  1024
      |  NoInlineAttribute  =  2048
      |  AlwaysInlineAttribute  =  4096
      |  OptimizeForSizeAttribute  =  8192
      |  StackProtectAttribute  =  16384
      |  StackProtectReqAttribute  =  32768
      |  Alignment  =  2031616
      |  NoCaptureAttribute  =  2097152
      |  NoRedZoneAttribute  =  4194304
      |  NoImplicitFloatAttribute  =  8388608
      |  NakedAttribute  =  16777216
      |  InlineHintAttribute  =  33554432
      |  StackAlignment  =  469762048
      |  ReturnsTwice  =  536870912
      |  UWTable  =  1073741824
      |  NonLazyBind  =  -2147483648
    type Opcode =
      |  Ret  =  1
      |  Br  =  2
      |  Switch  =  3
      |  IndirectBr  =  4
      |  Invoke  =  5
      |  Unreachable  =  7
      |  Add  =  8
      |  FAdd  =  9
      |  Sub  =  10
      |  FSub  =  11
      |  Mul  =  12
      |  FMul  =  13
      |  UDiv  =  14
      |  SDiv  =  15
      |  FDiv  =  16
      |  URem  =  17
      |  SRem  =  18
      |  FRem  =  19
      |  Shl  =  20
      |  LShr  =  21
      |  AShr  =  22
      |  And  =  23
      |  Or  =  24
      |  Xor  =  25
      |  Alloca  =  26
      |  Load  =  27
      |  Store  =  28
      |  GetElementPtr  =  29
      |  Trunc  =  30
      |  ZExt  =  31
      |  SExt  =  32
      |  FPToUI  =  33
      |  FPToSI  =  34
      |  UIToFP  =  35
      |  SIToFP  =  36
      |  FPTrunc  =  37
      |  FPExt  =  38
      |  PtrToInt  =  39
      |  IntToPtr  =  40
      |  BitCast  =  41
      |  ICmp  =  42
      |  FCmp  =  43
      |  PHI  =  44
      |  Call  =  45
      |  Select  =  46
      |  UserOp1  =  47
      |  UserOp2  =  48
      |  VAArg  =  49
      |  ExtractElement  =  50
      |  InsertElement  =  51
      |  ShuffleVector  =  52
      |  ExtractValue  =  53
      |  InsertValue  =  54
      |  Fence  =  55
      |  AtomicCmpXchg  =  56
      |  AtomicRMW  =  57
      |  Resume  =  58
      |  LandingPad  =  59
    type TypeKind =
      |  VoidTypeKind  =  0
      |  HalfTypeKind  =  1
      |  FloatTypeKind  =  2
      |  DoubleTypeKind  =  3
      |  X86_FP80TypeKind  =  4
      |  FP128TypeKind  =  5
      |  PPC_FP128TypeKind  =  6
      |  LabelTypeKind  =  7
      |  IntegerTypeKind  =  8
      |  FunctionTypeKind  =  9
      |  StructTypeKind  =  10
      |  ArrayTypeKind  =  11
      |  PointerTypeKind  =  12
      |  VectorTypeKind  =  13
      |  MetadataTypeKind  =  14
      |  X86_MMXTypeKind  =  15
    type Linkage =
      |  ExternalLinkage  =  0
      |  AvailableExternallyLinkage  =  1
      |  LinkOnceAnyLinkage  =  2
      |  LinkOnceODRLinkage  =  3
      |  WeakAnyLinkage  =  4
      |  WeakODRLinkage  =  5
      |  AppendingLinkage  =  6
      |  InternalLinkage  =  7
      |  PrivateLinkage  =  8
      |  DLLImportLinkage  =  9
      |  DLLExportLinkage  =  10
      |  ExternalWeakLinkage  =  11
      |  GhostLinkage  =  12
      |  CommonLinkage  =  13
      |  LinkerPrivateLinkage  =  14
      |  LinkerPrivateWeakLinkage  =  15
      |  LinkerPrivateWeakDefAutoLinkage  =  16
    type Visibility =
      |  DefaultVisibility  =  0
      |  HiddenVisibility  =  1
      |  ProtectedVisibility  =  2
    type CallConv =
      |  CCallConv  =  0
      |  FastCallConv  =  8
      |  ColdCallConv  =  9
      |  X86StdcallCallConv  =  64
      |  X86FastcallCallConv  =  65
    type IntPredicate =
      |  IntEQ  =  32
      |  IntNE  =  33
      |  IntUGT  =  34
      |  IntUGE  =  35
      |  IntULT  =  36
      |  IntULE  =  37
      |  IntSGT  =  38
      |  IntSGE  =  39
      |  IntSLT  =  40
      |  IntSLE  =  41
    type RealPredicate =
      |  RealPredicateFalse  =  0
      |  RealOEQ  =  1
      |  RealOGT  =  2
      |  RealOGE  =  3
      |  RealOLT  =  4
      |  RealOLE  =  5
      |  RealONE  =  6
      |  RealORD  =  7
      |  RealUNO  =  8
      |  RealUEQ  =  9
      |  RealUGT  =  10
      |  RealUGE  =  11
      |  RealULT  =  12
      |  RealULE  =  13
      |  RealUNE  =  14
      |  RealPredicateTrue  =  15
    type LandingPadClauseTy =
      |  LandingPadCatch  =  0
      |  LandingPadFilter  =  1
    val initializeCoreNative : nativeint -> unit
    val initializeCore : PassRegistryRef -> unit
    val contextCreateNative : unit -> nativeint
    val contextCreate : unit -> ContextRef
    val getGlobalContextNative : unit -> nativeint
    val getGlobalContext : unit -> ContextRef
    val contextDisposeNative : nativeint -> unit
    val contextDispose : ContextRef -> unit
    val getMDKindIDInContextNative : nativeint * string * uint32 -> uint32
    val getMDKindIDInContext : ContextRef -> string -> uint32 -> uint32
    val getMDKindIDNative : string * uint32 -> uint32
    val getMDKindID : string -> uint32 -> uint32
    val moduleCreateWithNameNative : string -> nativeint
    val moduleCreateWithName : string -> ModuleRef
    val moduleCreateWithNameInContextNative : string * nativeint -> nativeint
    val moduleCreateWithNameInContext : string -> ContextRef -> ModuleRef
    val disposeModuleNative : nativeint -> unit
    val disposeModule : ModuleRef -> unit
    val getDataLayoutNative : nativeint -> nativeint
    val getDataLayout : ModuleRef -> string
    val setDataLayoutNative : nativeint * string -> unit
    val setDataLayout : ModuleRef -> string -> unit
    val getTargetNative : nativeint -> nativeint
    val getTarget : ModuleRef -> string
    val setTargetNative : nativeint * string -> unit
    val setTarget : ModuleRef -> string -> unit
    val dumpModuleNative : nativeint -> unit
    val dumpModule : ModuleRef -> unit
    val setModuleInlineAsmNative : nativeint * string -> unit
    val setModuleInlineAsm : ModuleRef -> string -> unit
    val getModuleContextNative : nativeint -> nativeint
    val getModuleContext : ModuleRef -> ContextRef
    val getTypeByNameNative : nativeint * string -> nativeint
    val getTypeByName : ModuleRef -> string -> TypeRef
    val getNamedMetadataNumOperandsNative : nativeint * string -> uint32
    val getNamedMetadataNumOperands : ModuleRef -> string -> uint32
    val getNamedMetadataOperandsNative : nativeint * string * nativeint -> unit
    val addNamedMetadataOperandNative : nativeint * string * nativeint -> unit
    val addNamedMetadataOperand : ModuleRef -> string -> ValueRef -> unit
    val addFunctionNative : nativeint * string * nativeint -> nativeint
    val addFunction : ModuleRef -> string -> TypeRef -> ValueRef
    val getNamedFunctionNative : nativeint * string -> nativeint
    val getNamedFunction : ModuleRef -> string -> ValueRef
    val getFirstFunctionNative : nativeint -> nativeint
    val getFirstFunction : ModuleRef -> ValueRef
    val getLastFunctionNative : nativeint -> nativeint
    val getLastFunction : ModuleRef -> ValueRef
    val getNextFunctionNative : nativeint -> nativeint
    val getNextFunction : ValueRef -> ValueRef
    val getPreviousFunctionNative : nativeint -> nativeint
    val getPreviousFunction : ValueRef -> ValueRef
    val getTypeKindNative : nativeint -> int
    val getTypeKind : TypeRef -> TypeKind
    val typeIsSizedNative : nativeint -> bool
    val typeIsSized : TypeRef -> bool
    val getTypeContextNative : nativeint -> nativeint
    val getTypeContext : TypeRef -> ContextRef
    val int1TypeInContextNative : nativeint -> nativeint
    val int1TypeInContext : ContextRef -> TypeRef
    val int8TypeInContextNative : nativeint -> nativeint
    val int8TypeInContext : ContextRef -> TypeRef
    val int16TypeInContextNative : nativeint -> nativeint
    val int16TypeInContext : ContextRef -> TypeRef
    val int32TypeInContextNative : nativeint -> nativeint
    val int32TypeInContext : ContextRef -> TypeRef
    val int64TypeInContextNative : nativeint -> nativeint
    val int64TypeInContext : ContextRef -> TypeRef
    val intTypeInContextNative : nativeint * uint32 -> nativeint
    val intTypeInContext : ContextRef -> uint32 -> TypeRef
    val int1TypeNative : unit -> nativeint
    val int1Type : unit -> TypeRef
    val int8TypeNative : unit -> nativeint
    val int8Type : unit -> TypeRef
    val int16TypeNative : unit -> nativeint
    val int16Type : unit -> TypeRef
    val int32TypeNative : unit -> nativeint
    val int32Type : unit -> TypeRef
    val int64TypeNative : unit -> nativeint
    val int64Type : unit -> TypeRef
    val intTypeNative : uint32 -> nativeint
    val intType : uint32 -> TypeRef
    val getIntTypeWidthNative : nativeint -> uint32
    val getIntTypeWidth : TypeRef -> uint32
    val halfTypeInContextNative : nativeint -> nativeint
    val halfTypeInContext : ContextRef -> TypeRef
    val floatTypeInContextNative : nativeint -> nativeint
    val floatTypeInContext : ContextRef -> TypeRef
    val doubleTypeInContextNative : nativeint -> nativeint
    val doubleTypeInContext : ContextRef -> TypeRef
    val x86FP80TypeInContextNative : nativeint -> nativeint
    val x86FP80TypeInContext : ContextRef -> TypeRef
    val fP128TypeInContextNative : nativeint -> nativeint
    val fP128TypeInContext : ContextRef -> TypeRef
    val pPCFP128TypeInContextNative : nativeint -> nativeint
    val pPCFP128TypeInContext : ContextRef -> TypeRef
    val halfTypeNative : unit -> nativeint
    val halfType : unit -> TypeRef
    val floatTypeNative : unit -> nativeint
    val floatType : unit -> TypeRef
    val doubleTypeNative : unit -> nativeint
    val doubleType : unit -> TypeRef
    val x86FP80TypeNative : unit -> nativeint
    val x86FP80Type : unit -> TypeRef
    val fP128TypeNative : unit -> nativeint
    val fP128Type : unit -> TypeRef
    val pPCFP128TypeNative : unit -> nativeint
    val pPCFP128Type : unit -> TypeRef
    val functionTypeNative : nativeint * nativeint * uint32 * bool -> nativeint
    val isFunctionVarArgNative : nativeint -> bool
    val isFunctionVarArg : TypeRef -> bool
    val getReturnTypeNative : nativeint -> nativeint
    val getReturnType : TypeRef -> TypeRef
    val countParamTypesNative : nativeint -> uint32
    val countParamTypes : TypeRef -> uint32
    val getParamTypesNative : nativeint * nativeint -> unit
    val structTypeInContextNative :
      nativeint * nativeint * uint32 * bool -> nativeint
    val structTypeNative : nativeint * uint32 * bool -> nativeint
    val structCreateNamedNative : nativeint * string -> nativeint
    val structCreateNamed : ContextRef -> string -> TypeRef
    val getStructNameNative : nativeint -> nativeint
    val getStructName : TypeRef -> string
    val structSetBodyNative : nativeint * nativeint * uint32 * bool -> unit
    val countStructElementTypesNative : nativeint -> uint32
    val countStructElementTypes : TypeRef -> uint32
    val getStructElementTypesNative : nativeint * nativeint -> unit
    val isPackedStructNative : nativeint -> bool
    val isPackedStruct : TypeRef -> bool
    val isOpaqueStructNative : nativeint -> bool
    val isOpaqueStruct : TypeRef -> bool
    val getElementTypeNative : nativeint -> nativeint
    val getElementType : TypeRef -> TypeRef
    val arrayTypeNative : nativeint * uint32 -> nativeint
    val arrayType : TypeRef -> uint32 -> TypeRef
    val getArrayLengthNative : nativeint -> uint32
    val getArrayLength : TypeRef -> uint32
    val pointerTypeNative : nativeint * uint32 -> nativeint
    val pointerType : TypeRef -> uint32 -> TypeRef
    val getPointerAddressSpaceNative : nativeint -> uint32
    val getPointerAddressSpace : TypeRef -> uint32
    val vectorTypeNative : nativeint * uint32 -> nativeint
    val vectorType : TypeRef -> uint32 -> TypeRef
    val getVectorSizeNative : nativeint -> uint32
    val getVectorSize : TypeRef -> uint32
    val voidTypeInContextNative : nativeint -> nativeint
    val voidTypeInContext : ContextRef -> TypeRef
    val labelTypeInContextNative : nativeint -> nativeint
    val labelTypeInContext : ContextRef -> TypeRef
    val x86MMXTypeInContextNative : nativeint -> nativeint
    val x86MMXTypeInContext : ContextRef -> TypeRef
    val voidTypeNative : unit -> nativeint
    val voidType : unit -> TypeRef
    val labelTypeNative : unit -> nativeint
    val labelType : unit -> TypeRef
    val x86MMXTypeNative : unit -> nativeint
    val x86MMXType : unit -> TypeRef
    val typeOfNative : nativeint -> nativeint
    val typeOf : ValueRef -> TypeRef
    val getValueNameNative : nativeint -> nativeint
    val getValueName : ValueRef -> string
    val setValueNameNative : nativeint * string -> unit
    val setValueName : ValueRef -> string -> unit
    val dumpValueNative : nativeint -> unit
    val dumpValue : ValueRef -> unit
    val replaceAllUsesWithNative : nativeint * nativeint -> unit
    val replaceAllUsesWith : ValueRef -> ValueRef -> unit
    val isConstantNative : nativeint -> bool
    val isConstant : ValueRef -> bool
    val isUndefNative : nativeint -> bool
    val isUndef : ValueRef -> bool
    val getFirstUseNative : nativeint -> nativeint
    val getFirstUse : ValueRef -> UseRef
    val getNextUseNative : nativeint -> nativeint
    val getNextUse : UseRef -> UseRef
    val getUserNative : nativeint -> nativeint
    val getUser : UseRef -> ValueRef
    val getUsedValueNative : nativeint -> nativeint
    val getUsedValue : UseRef -> ValueRef
    val getOperandNative : nativeint * uint32 -> nativeint
    val getOperand : ValueRef -> uint32 -> ValueRef
    val setOperandNative : nativeint * uint32 * nativeint -> unit
    val setOperand : ValueRef -> uint32 -> ValueRef -> unit
    val getNumOperandsNative : nativeint -> int
    val getNumOperands : ValueRef -> int
    val constNullNative : nativeint -> nativeint
    val constNull : TypeRef -> ValueRef
    val constAllOnesNative : nativeint -> nativeint
    val constAllOnes : TypeRef -> ValueRef
    val getUndefNative : nativeint -> nativeint
    val getUndef : TypeRef -> ValueRef
    val isNullNative : nativeint -> bool
    val isNull : ValueRef -> bool
    val constPointerNullNative : nativeint -> nativeint
    val constPointerNull : TypeRef -> ValueRef
    val constIntNative : nativeint * uint64 * bool -> nativeint
    val constInt : TypeRef -> uint64 -> bool -> ValueRef
    val constIntOfArbitraryPrecisionNative :
      nativeint * uint32 * nativeptr<uint64> -> nativeint
    val constIntOfStringNative : nativeint * string * uint8 -> nativeint
    val constIntOfString : TypeRef -> string -> uint8 -> ValueRef
    val constIntOfStringAndSizeNative :
      nativeint * string * uint32 * uint8 -> nativeint
    val constIntOfStringAndSize :
      TypeRef -> string -> uint32 -> uint8 -> ValueRef
    val constRealNative : nativeint * double -> nativeint
    val constReal : TypeRef -> double -> ValueRef
    val constRealOfStringNative : nativeint * string -> nativeint
    val constRealOfString : TypeRef -> string -> ValueRef
    val constRealOfStringAndSizeNative :
      nativeint * string * uint32 -> nativeint
    val constRealOfStringAndSize : TypeRef -> string -> uint32 -> ValueRef
    val constIntGetZExtValueNative : nativeint -> uint64
    val constIntGetZExtValue : ValueRef -> uint64
    val constIntGetSExtValueNative : nativeint -> int64
    val constIntGetSExtValue : ValueRef -> int64
    val constStringInContextNative :
      nativeint * string * uint32 * bool -> nativeint
    val constStringInContext :
      ContextRef -> string -> uint32 -> bool -> ValueRef
    val constStringNative : string * uint32 * bool -> nativeint
    val constString : string -> uint32 -> bool -> ValueRef
    val constStructInContextNative :
      nativeint * nativeint * uint32 * bool -> nativeint
    val constStructNative : nativeint * uint32 * bool -> nativeint
    val constArrayNative : nativeint * nativeint * uint32 -> nativeint
    val constNamedStructNative : nativeint * nativeint * uint32 -> nativeint
    val constVectorNative : nativeint * uint32 -> nativeint
    val getConstOpcodeNative : nativeint -> int
    val getConstOpcode : ValueRef -> Opcode
    val alignOfNative : nativeint -> nativeint
    val alignOf : TypeRef -> ValueRef
    val sizeOfNative : nativeint -> nativeint
    val sizeOf : TypeRef -> ValueRef
    val constNegNative : nativeint -> nativeint
    val constNeg : ValueRef -> ValueRef
    val constNSWNegNative : nativeint -> nativeint
    val constNSWNeg : ValueRef -> ValueRef
    val constNUWNegNative : nativeint -> nativeint
    val constNUWNeg : ValueRef -> ValueRef
    val constFNegNative : nativeint -> nativeint
    val constFNeg : ValueRef -> ValueRef
    val constNotNative : nativeint -> nativeint
    val constNot : ValueRef -> ValueRef
    val constAddNative : nativeint * nativeint -> nativeint
    val constAdd : ValueRef -> ValueRef -> ValueRef
    val constNSWAddNative : nativeint * nativeint -> nativeint
    val constNSWAdd : ValueRef -> ValueRef -> ValueRef
    val constNUWAddNative : nativeint * nativeint -> nativeint
    val constNUWAdd : ValueRef -> ValueRef -> ValueRef
    val constFAddNative : nativeint * nativeint -> nativeint
    val constFAdd : ValueRef -> ValueRef -> ValueRef
    val constSubNative : nativeint * nativeint -> nativeint
    val constSub : ValueRef -> ValueRef -> ValueRef
    val constNSWSubNative : nativeint * nativeint -> nativeint
    val constNSWSub : ValueRef -> ValueRef -> ValueRef
    val constNUWSubNative : nativeint * nativeint -> nativeint
    val constNUWSub : ValueRef -> ValueRef -> ValueRef
    val constFSubNative : nativeint * nativeint -> nativeint
    val constFSub : ValueRef -> ValueRef -> ValueRef
    val constMulNative : nativeint * nativeint -> nativeint
    val constMul : ValueRef -> ValueRef -> ValueRef
    val constNSWMulNative : nativeint * nativeint -> nativeint
    val constNSWMul : ValueRef -> ValueRef -> ValueRef
    val constNUWMulNative : nativeint * nativeint -> nativeint
    val constNUWMul : ValueRef -> ValueRef -> ValueRef
    val constFMulNative : nativeint * nativeint -> nativeint
    val constFMul : ValueRef -> ValueRef -> ValueRef
    val constUDivNative : nativeint * nativeint -> nativeint
    val constUDiv : ValueRef -> ValueRef -> ValueRef
    val constSDivNative : nativeint * nativeint -> nativeint
    val constSDiv : ValueRef -> ValueRef -> ValueRef
    val constExactSDivNative : nativeint * nativeint -> nativeint
    val constExactSDiv : ValueRef -> ValueRef -> ValueRef
    val constFDivNative : nativeint * nativeint -> nativeint
    val constFDiv : ValueRef -> ValueRef -> ValueRef
    val constURemNative : nativeint * nativeint -> nativeint
    val constURem : ValueRef -> ValueRef -> ValueRef
    val constSRemNative : nativeint * nativeint -> nativeint
    val constSRem : ValueRef -> ValueRef -> ValueRef
    val constFRemNative : nativeint * nativeint -> nativeint
    val constFRem : ValueRef -> ValueRef -> ValueRef
    val constAndNative : nativeint * nativeint -> nativeint
    val constAnd : ValueRef -> ValueRef -> ValueRef
    val constOrNative : nativeint * nativeint -> nativeint
    val constOr : ValueRef -> ValueRef -> ValueRef
    val constXorNative : nativeint * nativeint -> nativeint
    val constXor : ValueRef -> ValueRef -> ValueRef
    val constICmpNative : int * nativeint * nativeint -> nativeint
    val constICmp : IntPredicate -> ValueRef -> ValueRef -> ValueRef
    val constFCmpNative : int * nativeint * nativeint -> nativeint
    val constFCmp : RealPredicate -> ValueRef -> ValueRef -> ValueRef
    val constShlNative : nativeint * nativeint -> nativeint
    val constShl : ValueRef -> ValueRef -> ValueRef
    val constLShrNative : nativeint * nativeint -> nativeint
    val constLShr : ValueRef -> ValueRef -> ValueRef
    val constAShrNative : nativeint * nativeint -> nativeint
    val constAShr : ValueRef -> ValueRef -> ValueRef
    val constGEPNative : nativeint * nativeint * uint32 -> nativeint
    val constInBoundsGEPNative : nativeint * nativeint * uint32 -> nativeint
    val constTruncNative : nativeint * nativeint -> nativeint
    val constTrunc : ValueRef -> TypeRef -> ValueRef
    val constSExtNative : nativeint * nativeint -> nativeint
    val constSExt : ValueRef -> TypeRef -> ValueRef
    val constZExtNative : nativeint * nativeint -> nativeint
    val constZExt : ValueRef -> TypeRef -> ValueRef
    val constFPTruncNative : nativeint * nativeint -> nativeint
    val constFPTrunc : ValueRef -> TypeRef -> ValueRef
    val constFPExtNative : nativeint * nativeint -> nativeint
    val constFPExt : ValueRef -> TypeRef -> ValueRef
    val constUIToFPNative : nativeint * nativeint -> nativeint
    val constUIToFP : ValueRef -> TypeRef -> ValueRef
    val constSIToFPNative : nativeint * nativeint -> nativeint
    val constSIToFP : ValueRef -> TypeRef -> ValueRef
    val constFPToUINative : nativeint * nativeint -> nativeint
    val constFPToUI : ValueRef -> TypeRef -> ValueRef
    val constFPToSINative : nativeint * nativeint -> nativeint
    val constFPToSI : ValueRef -> TypeRef -> ValueRef
    val constPtrToIntNative : nativeint * nativeint -> nativeint
    val constPtrToInt : ValueRef -> TypeRef -> ValueRef
    val constIntToPtrNative : nativeint * nativeint -> nativeint
    val constIntToPtr : ValueRef -> TypeRef -> ValueRef
    val constBitCastNative : nativeint * nativeint -> nativeint
    val constBitCast : ValueRef -> TypeRef -> ValueRef
    val constZExtOrBitCastNative : nativeint * nativeint -> nativeint
    val constZExtOrBitCast : ValueRef -> TypeRef -> ValueRef
    val constSExtOrBitCastNative : nativeint * nativeint -> nativeint
    val constSExtOrBitCast : ValueRef -> TypeRef -> ValueRef
    val constTruncOrBitCastNative : nativeint * nativeint -> nativeint
    val constTruncOrBitCast : ValueRef -> TypeRef -> ValueRef
    val constPointerCastNative : nativeint * nativeint -> nativeint
    val constPointerCast : ValueRef -> TypeRef -> ValueRef
    val constIntCastNative : nativeint * nativeint * bool -> nativeint
    val constIntCast : ValueRef -> TypeRef -> bool -> ValueRef
    val constFPCastNative : nativeint * nativeint -> nativeint
    val constFPCast : ValueRef -> TypeRef -> ValueRef
    val constSelectNative : nativeint * nativeint * nativeint -> nativeint
    val constSelect : ValueRef -> ValueRef -> ValueRef -> ValueRef
    val constExtractElementNative : nativeint * nativeint -> nativeint
    val constExtractElement : ValueRef -> ValueRef -> ValueRef
    val constInsertElementNative :
      nativeint * nativeint * nativeint -> nativeint
    val constInsertElement : ValueRef -> ValueRef -> ValueRef -> ValueRef
    val constShuffleVectorNative :
      nativeint * nativeint * nativeint -> nativeint
    val constShuffleVector : ValueRef -> ValueRef -> ValueRef -> ValueRef
    val constExtractValueNative :
      nativeint * nativeptr<uint32> * uint32 -> nativeint
    val constInsertValueNative :
      nativeint * nativeint * nativeptr<uint32> * uint32 -> nativeint
    val constInlineAsmNative :
      nativeint * string * string * bool * bool -> nativeint
    val constInlineAsm : TypeRef -> string -> string -> bool -> bool -> ValueRef
    val blockAddressNative : nativeint * nativeint -> nativeint
    val blockAddress : ValueRef -> BasicBlockRef -> ValueRef
    val getGlobalParentNative : nativeint -> nativeint
    val getGlobalParent : ValueRef -> ModuleRef
    val isDeclarationNative : nativeint -> bool
    val isDeclaration : ValueRef -> bool
    val getLinkageNative : nativeint -> int
    val getLinkage : ValueRef -> Linkage
    val setLinkageNative : nativeint * int -> unit
    val setLinkage : ValueRef -> Linkage -> unit
    val getSectionNative : nativeint -> nativeint
    val getSection : ValueRef -> string
    val setSectionNative : nativeint * string -> unit
    val setSection : ValueRef -> string -> unit
    val getVisibilityNative : nativeint -> int
    val getVisibility : ValueRef -> Visibility
    val setVisibilityNative : nativeint * int -> unit
    val setVisibility : ValueRef -> Visibility -> unit
    val getAlignmentNative : nativeint -> uint32
    val getAlignment : ValueRef -> uint32
    val setAlignmentNative : nativeint * uint32 -> unit
    val setAlignment : ValueRef -> uint32 -> unit
    val addGlobalNative : nativeint * nativeint * string -> nativeint
    val addGlobal : ModuleRef -> TypeRef -> string -> ValueRef
    val addGlobalInAddressSpaceNative :
      nativeint * nativeint * string * uint32 -> nativeint
    val addGlobalInAddressSpace :
      ModuleRef -> TypeRef -> string -> uint32 -> ValueRef
    val getNamedGlobalNative : nativeint * string -> nativeint
    val getNamedGlobal : ModuleRef -> string -> ValueRef
    val getFirstGlobalNative : nativeint -> nativeint
    val getFirstGlobal : ModuleRef -> ValueRef
    val getLastGlobalNative : nativeint -> nativeint
    val getLastGlobal : ModuleRef -> ValueRef
    val getNextGlobalNative : nativeint -> nativeint
    val getNextGlobal : ValueRef -> ValueRef
    val getPreviousGlobalNative : nativeint -> nativeint
    val getPreviousGlobal : ValueRef -> ValueRef
    val deleteGlobalNative : nativeint -> unit
    val deleteGlobal : ValueRef -> unit
    val getInitializerNative : nativeint -> nativeint
    val getInitializer : ValueRef -> ValueRef
    val setInitializerNative : nativeint * nativeint -> unit
    val setInitializer : ValueRef -> ValueRef -> unit
    val isThreadLocalNative : nativeint -> bool
    val isThreadLocal : ValueRef -> bool
    val setThreadLocalNative : nativeint * bool -> unit
    val setThreadLocal : ValueRef -> bool -> unit
    val isGlobalConstantNative : nativeint -> bool
    val isGlobalConstant : ValueRef -> bool
    val setGlobalConstantNative : nativeint * bool -> unit
    val setGlobalConstant : ValueRef -> bool -> unit
    val addAliasNative : nativeint * nativeint * nativeint * string -> nativeint
    val addAlias : ModuleRef -> TypeRef -> ValueRef -> string -> ValueRef
    val deleteFunctionNative : nativeint -> unit
    val deleteFunction : ValueRef -> unit
    val getIntrinsicIDNative : nativeint -> uint32
    val getIntrinsicID : ValueRef -> uint32
    val getFunctionCallConvNative : nativeint -> uint32
    val getFunctionCallConv : ValueRef -> uint32
    val setFunctionCallConvNative : nativeint * uint32 -> unit
    val setFunctionCallConv : ValueRef -> uint32 -> unit
    val getGCNative : nativeint -> nativeint
    val getGC : ValueRef -> string
    val setGCNative : nativeint * string -> unit
    val setGC : ValueRef -> string -> unit
    val addFunctionAttrNative : nativeint * int -> unit
    val addFunctionAttr : ValueRef -> Attribute -> unit
    val getFunctionAttrNative : nativeint -> int
    val getFunctionAttr : ValueRef -> Attribute
    val removeFunctionAttrNative : nativeint * int -> unit
    val removeFunctionAttr : ValueRef -> Attribute -> unit
    val countParamsNative : nativeint -> uint32
    val countParams : ValueRef -> uint32
    val getParamsNative : nativeint * nativeint -> unit
    val getParamNative : nativeint * uint32 -> nativeint
    val getParam : ValueRef -> uint32 -> ValueRef
    val getParamParentNative : nativeint -> nativeint
    val getParamParent : ValueRef -> ValueRef
    val getFirstParamNative : nativeint -> nativeint
    val getFirstParam : ValueRef -> ValueRef
    val getLastParamNative : nativeint -> nativeint
    val getLastParam : ValueRef -> ValueRef
    val getNextParamNative : nativeint -> nativeint
    val getNextParam : ValueRef -> ValueRef
    val getPreviousParamNative : nativeint -> nativeint
    val getPreviousParam : ValueRef -> ValueRef
    val addAttributeNative : nativeint * int -> unit
    val addAttribute : ValueRef -> Attribute -> unit
    val removeAttributeNative : nativeint * int -> unit
    val removeAttribute : ValueRef -> Attribute -> unit
    val getAttributeNative : nativeint -> int
    val getAttribute : ValueRef -> Attribute
    val setParamAlignmentNative : nativeint * uint32 -> unit
    val setParamAlignment : ValueRef -> uint32 -> unit
    val mDStringInContextNative : nativeint * string * uint32 -> nativeint
    val mDStringInContext : ContextRef -> string -> uint32 -> ValueRef
    val mDStringNative : string * uint32 -> nativeint
    val mDString : string -> uint32 -> ValueRef
    val mDNodeInContextNative : nativeint * nativeint * uint32 -> nativeint
    val mDNodeNative : nativeint * uint32 -> nativeint
    val getMDStringNative : nativeint * nativeptr<uint32> -> nativeint
    val basicBlockAsValueNative : nativeint -> nativeint
    val basicBlockAsValue : BasicBlockRef -> ValueRef
    val valueIsBasicBlockNative : nativeint -> bool
    val valueIsBasicBlock : ValueRef -> bool
    val valueAsBasicBlockNative : nativeint -> nativeint
    val valueAsBasicBlock : ValueRef -> BasicBlockRef
    val getBasicBlockParentNative : nativeint -> nativeint
    val getBasicBlockParent : BasicBlockRef -> ValueRef
    val getBasicBlockTerminatorNative : nativeint -> nativeint
    val getBasicBlockTerminator : BasicBlockRef -> ValueRef
    val countBasicBlocksNative : nativeint -> uint32
    val countBasicBlocks : ValueRef -> uint32
    val getBasicBlocksNative : nativeint * nativeint -> unit
    val getFirstBasicBlockNative : nativeint -> nativeint
    val getFirstBasicBlock : ValueRef -> BasicBlockRef
    val getLastBasicBlockNative : nativeint -> nativeint
    val getLastBasicBlock : ValueRef -> BasicBlockRef
    val getNextBasicBlockNative : nativeint -> nativeint
    val getNextBasicBlock : BasicBlockRef -> BasicBlockRef
    val getPreviousBasicBlockNative : nativeint -> nativeint
    val getPreviousBasicBlock : BasicBlockRef -> BasicBlockRef
    val getEntryBasicBlockNative : nativeint -> nativeint
    val getEntryBasicBlock : ValueRef -> BasicBlockRef
    val appendBasicBlockInContextNative :
      nativeint * nativeint * string -> nativeint
    val appendBasicBlockInContext :
      ContextRef -> ValueRef -> string -> BasicBlockRef
    val appendBasicBlockNative : nativeint * string -> nativeint
    val appendBasicBlock : ValueRef -> string -> BasicBlockRef
    val insertBasicBlockInContextNative :
      nativeint * nativeint * string -> nativeint
    val insertBasicBlockInContext :
      ContextRef -> BasicBlockRef -> string -> BasicBlockRef
    val insertBasicBlockNative : nativeint * string -> nativeint
    val insertBasicBlock : BasicBlockRef -> string -> BasicBlockRef
    val deleteBasicBlockNative : nativeint -> unit
    val deleteBasicBlock : BasicBlockRef -> unit
    val removeBasicBlockFromParentNative : nativeint -> unit
    val removeBasicBlockFromParent : BasicBlockRef -> unit
    val moveBasicBlockBeforeNative : nativeint * nativeint -> unit
    val moveBasicBlockBefore : BasicBlockRef -> BasicBlockRef -> unit
    val moveBasicBlockAfterNative : nativeint * nativeint -> unit
    val moveBasicBlockAfter : BasicBlockRef -> BasicBlockRef -> unit
    val getFirstInstructionNative : nativeint -> nativeint
    val getFirstInstruction : BasicBlockRef -> ValueRef
    val getLastInstructionNative : nativeint -> nativeint
    val getLastInstruction : BasicBlockRef -> ValueRef
    val hasMetadataNative : nativeint -> int
    val hasMetadata : ValueRef -> int
    val getMetadataNative : nativeint * uint32 -> nativeint
    val getMetadata : ValueRef -> uint32 -> ValueRef
    val setMetadataNative : nativeint * uint32 * nativeint -> unit
    val setMetadata : ValueRef -> uint32 -> ValueRef -> unit
    val getInstructionParentNative : nativeint -> nativeint
    val getInstructionParent : ValueRef -> BasicBlockRef
    val getNextInstructionNative : nativeint -> nativeint
    val getNextInstruction : ValueRef -> ValueRef
    val getPreviousInstructionNative : nativeint -> nativeint
    val getPreviousInstruction : ValueRef -> ValueRef
    val instructionEraseFromParentNative : nativeint -> unit
    val instructionEraseFromParent : ValueRef -> unit
    val getInstructionOpcodeNative : nativeint -> int
    val getInstructionOpcode : ValueRef -> Opcode
    val getICmpPredicateNative : nativeint -> int
    val getICmpPredicate : ValueRef -> IntPredicate
    val setInstructionCallConvNative : nativeint * uint32 -> unit
    val setInstructionCallConv : ValueRef -> uint32 -> unit
    val getInstructionCallConvNative : nativeint -> uint32
    val getInstructionCallConv : ValueRef -> uint32
    val addInstrAttributeNative : nativeint * uint32 * int -> unit
    val addInstrAttribute : ValueRef -> uint32 -> Attribute -> unit
    val removeInstrAttributeNative : nativeint * uint32 * int -> unit
    val removeInstrAttribute : ValueRef -> uint32 -> Attribute -> unit
    val setInstrParamAlignmentNative : nativeint * uint32 * uint32 -> unit
    val setInstrParamAlignment : ValueRef -> uint32 -> uint32 -> unit
    val isTailCallNative : nativeint -> bool
    val isTailCall : ValueRef -> bool
    val setTailCallNative : nativeint * bool -> unit
    val setTailCall : ValueRef -> bool -> unit
    val getSwitchDefaultDestNative : nativeint -> nativeint
    val getSwitchDefaultDest : ValueRef -> BasicBlockRef
    val addIncomingNative : nativeint * nativeint * nativeint * uint32 -> unit
    val countIncomingNative : nativeint -> uint32
    val countIncoming : ValueRef -> uint32
    val getIncomingValueNative : nativeint * uint32 -> nativeint
    val getIncomingValue : ValueRef -> uint32 -> ValueRef
    val getIncomingBlockNative : nativeint * uint32 -> nativeint
    val getIncomingBlock : ValueRef -> uint32 -> BasicBlockRef
    val createBuilderInContextNative : nativeint -> nativeint
    val createBuilderInContext : ContextRef -> BuilderRef
    val createBuilderNative : unit -> nativeint
    val createBuilder : unit -> BuilderRef
    val positionBuilderNative : nativeint * nativeint * nativeint -> unit
    val positionBuilder : BuilderRef -> BasicBlockRef -> ValueRef -> unit
    val positionBuilderBeforeNative : nativeint * nativeint -> unit
    val positionBuilderBefore : BuilderRef -> ValueRef -> unit
    val positionBuilderAtEndNative : nativeint * nativeint -> unit
    val positionBuilderAtEnd : BuilderRef -> BasicBlockRef -> unit
    val getInsertBlockNative : nativeint -> nativeint
    val getInsertBlock : BuilderRef -> BasicBlockRef
    val clearInsertionPositionNative : nativeint -> unit
    val clearInsertionPosition : BuilderRef -> unit
    val insertIntoBuilderNative : nativeint * nativeint -> unit
    val insertIntoBuilder : BuilderRef -> ValueRef -> unit
    val insertIntoBuilderWithNameNative : nativeint * nativeint * string -> unit
    val insertIntoBuilderWithName : BuilderRef -> ValueRef -> string -> unit
    val disposeBuilderNative : nativeint -> unit
    val disposeBuilder : BuilderRef -> unit
    val setCurrentDebugLocationNative : nativeint * nativeint -> unit
    val setCurrentDebugLocation : BuilderRef -> ValueRef -> unit
    val getCurrentDebugLocationNative : nativeint -> nativeint
    val getCurrentDebugLocation : BuilderRef -> ValueRef
    val setInstDebugLocationNative : nativeint * nativeint -> unit
    val setInstDebugLocation : BuilderRef -> ValueRef -> unit
    val buildRetVoidNative : nativeint -> nativeint
    val buildRetVoid : BuilderRef -> ValueRef
    val buildRetNative : nativeint * nativeint -> nativeint
    val buildRet : BuilderRef -> ValueRef -> ValueRef
    val buildAggregateRetNative : nativeint * nativeint * uint32 -> nativeint
    val buildBrNative : nativeint * nativeint -> nativeint
    val buildBr : BuilderRef -> BasicBlockRef -> ValueRef
    val buildCondBrNative :
      nativeint * nativeint * nativeint * nativeint -> nativeint
    val buildCondBr :
      BuilderRef -> ValueRef -> BasicBlockRef -> BasicBlockRef -> ValueRef
    val buildSwitchNative :
      nativeint * nativeint * nativeint * uint32 -> nativeint
    val buildSwitch :
      BuilderRef -> ValueRef -> BasicBlockRef -> uint32 -> ValueRef
    val buildIndirectBrNative : nativeint * nativeint * uint32 -> nativeint
    val buildIndirectBr : BuilderRef -> ValueRef -> uint32 -> ValueRef
    val buildInvokeNative :
      nativeint * nativeint * nativeint * uint32 * nativeint * nativeint *
      string -> nativeint
    val buildLandingPadNative :
      nativeint * nativeint * nativeint * uint32 * string -> nativeint
    val buildLandingPad :
      BuilderRef -> TypeRef -> ValueRef -> uint32 -> string -> ValueRef
    val buildResumeNative : nativeint * nativeint -> nativeint
    val buildResume : BuilderRef -> ValueRef -> ValueRef
    val buildUnreachableNative : nativeint -> nativeint
    val buildUnreachable : BuilderRef -> ValueRef
    val addCaseNative : nativeint * nativeint * nativeint -> unit
    val addCase : ValueRef -> ValueRef -> BasicBlockRef -> unit
    val addDestinationNative : nativeint * nativeint -> unit
    val addDestination : ValueRef -> BasicBlockRef -> unit
    val addClauseNative : nativeint * nativeint -> unit
    val addClause : ValueRef -> ValueRef -> unit
    val setCleanupNative : nativeint * bool -> unit
    val setCleanup : ValueRef -> bool -> unit
    val buildAddNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildAdd : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNSWAddNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildNSWAdd : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNUWAddNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildNUWAdd : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildFAddNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFAdd : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildSubNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildSub : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNSWSubNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildNSWSub : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNUWSubNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildNUWSub : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildFSubNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFSub : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildMulNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildMul : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNSWMulNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildNSWMul : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNUWMulNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildNUWMul : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildFMulNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFMul : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildUDivNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildUDiv : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildSDivNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildSDiv : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildExactSDivNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildExactSDiv :
      BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildFDivNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFDiv : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildURemNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildURem : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildSRemNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildSRem : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildFRemNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFRem : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildShlNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildShl : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildLShrNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildLShr : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildAShrNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildAShr : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildAndNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildAnd : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildOrNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildOr : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildXorNative : nativeint * nativeint * nativeint * string -> nativeint
    val buildXor : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildBinOpNative :
      nativeint * int * nativeint * nativeint * string -> nativeint
    val buildBinOp :
      BuilderRef -> Opcode -> ValueRef -> ValueRef -> string -> ValueRef
    val buildNegNative : nativeint * nativeint * string -> nativeint
    val buildNeg : BuilderRef -> ValueRef -> string -> ValueRef
    val buildNSWNegNative : nativeint * nativeint * string -> nativeint
    val buildNSWNeg : BuilderRef -> ValueRef -> string -> ValueRef
    val buildNUWNegNative : nativeint * nativeint * string -> nativeint
    val buildNUWNeg : BuilderRef -> ValueRef -> string -> ValueRef
    val buildFNegNative : nativeint * nativeint * string -> nativeint
    val buildFNeg : BuilderRef -> ValueRef -> string -> ValueRef
    val buildNotNative : nativeint * nativeint * string -> nativeint
    val buildNot : BuilderRef -> ValueRef -> string -> ValueRef
    val buildMallocNative : nativeint * nativeint * string -> nativeint
    val buildMalloc : BuilderRef -> TypeRef -> string -> ValueRef
    val buildArrayMallocNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildArrayMalloc :
      BuilderRef -> TypeRef -> ValueRef -> string -> ValueRef
    val buildAllocaNative : nativeint * nativeint * string -> nativeint
    val buildAlloca : BuilderRef -> TypeRef -> string -> ValueRef
    val buildArrayAllocaNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildArrayAlloca :
      BuilderRef -> TypeRef -> ValueRef -> string -> ValueRef
    val buildFreeNative : nativeint * nativeint -> nativeint
    val buildFree : BuilderRef -> ValueRef -> ValueRef
    val buildLoadNative : nativeint * nativeint * string -> nativeint
    val buildLoad : BuilderRef -> ValueRef -> string -> ValueRef
    val buildStoreNative : nativeint * nativeint * nativeint -> nativeint
    val buildStore : BuilderRef -> ValueRef -> ValueRef -> ValueRef
    val buildGEPNative :
      nativeint * nativeint * nativeint * uint32 * string -> nativeint
    val buildInBoundsGEPNative :
      nativeint * nativeint * nativeint * uint32 * string -> nativeint
    val buildStructGEPNative :
      nativeint * nativeint * uint32 * string -> nativeint
    val buildStructGEP : BuilderRef -> ValueRef -> uint32 -> string -> ValueRef
    val buildGlobalStringNative : nativeint * string * string -> nativeint
    val buildGlobalString : BuilderRef -> string -> string -> ValueRef
    val buildGlobalStringPtrNative : nativeint * string * string -> nativeint
    val buildGlobalStringPtr : BuilderRef -> string -> string -> ValueRef
    val getVolatileNative : nativeint -> bool
    val getVolatile : ValueRef -> bool
    val setVolatileNative : nativeint * bool -> unit
    val setVolatile : ValueRef -> bool -> unit
    val buildTruncNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildTrunc : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildZExtNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildZExt : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildSExtNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildSExt : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildFPToUINative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFPToUI : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildFPToSINative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFPToSI : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildUIToFPNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildUIToFP : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildSIToFPNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildSIToFP : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildFPTruncNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFPTrunc : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildFPExtNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFPExt : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildPtrToIntNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildPtrToInt : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildIntToPtrNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildIntToPtr : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildBitCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildBitCast : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildZExtOrBitCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildZExtOrBitCast :
      BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildSExtOrBitCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildSExtOrBitCast :
      BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildTruncOrBitCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildTruncOrBitCast :
      BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildCastNative :
      nativeint * int * nativeint * nativeint * string -> nativeint
    val buildCast :
      BuilderRef -> Opcode -> ValueRef -> TypeRef -> string -> ValueRef
    val buildPointerCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildPointerCast :
      BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildIntCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildIntCast : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildFPCastNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildFPCast : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildICmpNative :
      nativeint * int * nativeint * nativeint * string -> nativeint
    val buildICmp :
      BuilderRef -> IntPredicate -> ValueRef -> ValueRef -> string -> ValueRef
    val buildFCmpNative :
      nativeint * int * nativeint * nativeint * string -> nativeint
    val buildFCmp :
      BuilderRef -> RealPredicate -> ValueRef -> ValueRef -> string -> ValueRef
    val buildPhiNative : nativeint * nativeint * string -> nativeint
    val buildPhi : BuilderRef -> TypeRef -> string -> ValueRef
    val buildCallNative :
      nativeint * nativeint * nativeint * uint32 * string -> nativeint
    val buildSelectNative :
      nativeint * nativeint * nativeint * nativeint * string -> nativeint
    val buildSelect :
      BuilderRef -> ValueRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildVAArgNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildVAArg : BuilderRef -> ValueRef -> TypeRef -> string -> ValueRef
    val buildExtractElementNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildExtractElement :
      BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildInsertElementNative :
      nativeint * nativeint * nativeint * nativeint * string -> nativeint
    val buildInsertElement :
      BuilderRef -> ValueRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildShuffleVectorNative :
      nativeint * nativeint * nativeint * nativeint * string -> nativeint
    val buildShuffleVector :
      BuilderRef -> ValueRef -> ValueRef -> ValueRef -> string -> ValueRef
    val buildExtractValueNative :
      nativeint * nativeint * uint32 * string -> nativeint
    val buildExtractValue :
      BuilderRef -> ValueRef -> uint32 -> string -> ValueRef
    val buildInsertValueNative :
      nativeint * nativeint * nativeint * uint32 * string -> nativeint
    val buildInsertValue :
      BuilderRef -> ValueRef -> ValueRef -> uint32 -> string -> ValueRef
    val buildIsNullNative : nativeint * nativeint * string -> nativeint
    val buildIsNull : BuilderRef -> ValueRef -> string -> ValueRef
    val buildIsNotNullNative : nativeint * nativeint * string -> nativeint
    val buildIsNotNull : BuilderRef -> ValueRef -> string -> ValueRef
    val buildPtrDiffNative :
      nativeint * nativeint * nativeint * string -> nativeint
    val buildPtrDiff : BuilderRef -> ValueRef -> ValueRef -> string -> ValueRef
    val createModuleProviderForExistingModuleNative : nativeint -> nativeint
    val createModuleProviderForExistingModule : ModuleRef -> ModuleProviderRef
    val disposeModuleProviderNative : nativeint -> unit
    val disposeModuleProvider : ModuleProviderRef -> unit
    val createMemoryBufferWithContentsOfFileNative :
      string * nativeint * nativeint -> bool
    val createMemoryBufferWithSTDINNative : nativeint * nativeint -> bool
    val disposeMemoryBufferNative : nativeint -> unit
    val disposeMemoryBuffer : MemoryBufferRef -> unit
    val getGlobalPassRegistryNative : unit -> nativeint
    val getGlobalPassRegistry : unit -> PassRegistryRef
    val createPassManagerNative : unit -> nativeint
    val createPassManager : unit -> PassManagerRef
    val createFunctionPassManagerForModuleNative : nativeint -> nativeint
    val createFunctionPassManagerForModule : ModuleRef -> PassManagerRef
    val createFunctionPassManagerNative : nativeint -> nativeint
    val createFunctionPassManager : ModuleProviderRef -> PassManagerRef
    val runPassManagerNative : nativeint * nativeint -> bool
    val runPassManager : PassManagerRef -> ModuleRef -> bool
    val initializeFunctionPassManagerNative : nativeint -> bool
    val initializeFunctionPassManager : PassManagerRef -> bool
    val runFunctionPassManagerNative : nativeint * nativeint -> bool
    val runFunctionPassManager : PassManagerRef -> ValueRef -> bool
    val finalizeFunctionPassManagerNative : nativeint -> bool
    val finalizeFunctionPassManager : PassManagerRef -> bool
    val disposePassManagerNative : nativeint -> unit
    val disposePassManager : PassManagerRef -> unit
  end
namespace LLVM.Generated
  module BitReader = begin
    val parseBitcodeNative : nativeint * nativeint * nativeint -> bool
    val parseBitcodeInContextNative :
      nativeint * nativeint * nativeint * nativeint -> bool
    val getBitcodeModuleInContextNative :
      nativeint * nativeint * nativeint * nativeint -> bool
    val getBitcodeModuleNative : nativeint * nativeint * nativeint -> bool
    val getBitcodeModuleProviderInContextNative :
      nativeint * nativeint * nativeint * nativeint -> bool
    val getBitcodeModuleProviderNative :
      nativeint * nativeint * nativeint -> bool
  end
namespace LLVM.Generated
  module BitWriter = begin
    val writeBitcodeToFileNative : nativeint * string -> int
    val writeBitcodeToFile : Core.ModuleRef -> string -> int
    val writeBitcodeToFDNative : nativeint * int * int * int -> int
    val writeBitcodeToFD : Core.ModuleRef -> int -> int -> int -> int
    val writeBitcodeToFileHandleNative : nativeint * int -> int
    val writeBitcodeToFileHandle : Core.ModuleRef -> int -> int
  end
namespace LLVM.Generated
  module Target = begin
    type ByteOrdering =
      |  BigEndian  =  0
      |  LittleEndian  =  1
    type TargetDataRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> TargetDataRef
        member Ptr : nativeint
      end
    type TargetLibraryInfoRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> TargetLibraryInfoRef
        member Ptr : nativeint
      end
    type StructLayoutRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> StructLayoutRef
        member Ptr : nativeint
      end
    val createTargetDataNative : string -> nativeint
    val createTargetData : string -> TargetDataRef
    val addTargetDataNative : nativeint * nativeint -> unit
    val addTargetData : TargetDataRef -> Core.PassManagerRef -> unit
    val addTargetLibraryInfoNative : nativeint * nativeint -> unit
    val addTargetLibraryInfo :
      TargetLibraryInfoRef -> Core.PassManagerRef -> unit
    val copyStringRepOfTargetDataNative : nativeint -> nativeint
    val copyStringRepOfTargetData : TargetDataRef -> string
    val byteOrderNative : nativeint -> int
    val byteOrder : TargetDataRef -> ByteOrdering
    val pointerSizeNative : nativeint -> uint32
    val pointerSize : TargetDataRef -> uint32
    val intPtrTypeNative : nativeint -> nativeint
    val intPtrType : TargetDataRef -> Core.TypeRef
    val sizeOfTypeInBitsNative : nativeint * nativeint -> uint64
    val sizeOfTypeInBits : TargetDataRef -> Core.TypeRef -> uint64
    val storeSizeOfTypeNative : nativeint * nativeint -> uint64
    val storeSizeOfType : TargetDataRef -> Core.TypeRef -> uint64
    val aBISizeOfTypeNative : nativeint * nativeint -> uint64
    val aBISizeOfType : TargetDataRef -> Core.TypeRef -> uint64
    val aBIAlignmentOfTypeNative : nativeint * nativeint -> uint32
    val aBIAlignmentOfType : TargetDataRef -> Core.TypeRef -> uint32
    val callFrameAlignmentOfTypeNative : nativeint * nativeint -> uint32
    val callFrameAlignmentOfType : TargetDataRef -> Core.TypeRef -> uint32
    val preferredAlignmentOfTypeNative : nativeint * nativeint -> uint32
    val preferredAlignmentOfType : TargetDataRef -> Core.TypeRef -> uint32
    val preferredAlignmentOfGlobalNative : nativeint * nativeint -> uint32
    val preferredAlignmentOfGlobal : TargetDataRef -> Core.ValueRef -> uint32
    val elementAtOffsetNative : nativeint * nativeint * uint64 -> uint32
    val elementAtOffset : TargetDataRef -> Core.TypeRef -> uint64 -> uint32
    val offsetOfElementNative : nativeint * nativeint * uint32 -> uint64
    val offsetOfElement : TargetDataRef -> Core.TypeRef -> uint32 -> uint64
    val disposeTargetDataNative : nativeint -> unit
    val disposeTargetData : TargetDataRef -> unit
  end
namespace LLVM.Generated
  module ExecutionEngine = begin
    val linkInJITNative : unit -> unit
    val linkInJIT : unit -> unit
    val linkInInterpreterNative : unit -> unit
    val linkInInterpreter : unit -> unit
    type GenericValueRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> GenericValueRef
        member Ptr : nativeint
      end
    type ExecutionEngineRef =
      class
        interface FFIUtil.ILLVMRef
        new : thePtr:nativeint -> ExecutionEngineRef
        member Ptr : nativeint
      end
    val createGenericValueOfIntNative : nativeint * uint64 * bool -> nativeint
    val createGenericValueOfInt :
      Core.TypeRef -> uint64 -> bool -> GenericValueRef
    val createGenericValueOfPointerNative : nativeint -> nativeint
    val createGenericValueOfFloatNative : nativeint * double -> nativeint
    val createGenericValueOfFloat : Core.TypeRef -> double -> GenericValueRef
    val genericValueIntWidthNative : nativeint -> uint32
    val genericValueIntWidth : GenericValueRef -> uint32
    val genericValueToIntNative : nativeint * bool -> uint64
    val genericValueToInt : GenericValueRef -> bool -> uint64
    val genericValueToPointerNative : nativeint -> nativeint
    val genericValueToFloatNative : nativeint * nativeint -> double
    val genericValueToFloat : Core.TypeRef -> GenericValueRef -> double
    val disposeGenericValueNative : nativeint -> unit
    val disposeGenericValue : GenericValueRef -> unit
    val createExecutionEngineForModuleNative :
      nativeint * nativeint * nativeint -> bool
    val createInterpreterForModuleNative :
      nativeint * nativeint * nativeint -> bool
    val createJITCompilerForModuleNative :
      nativeint * nativeint * uint32 * nativeint -> bool
    val createExecutionEngineNative : nativeint * nativeint * nativeint -> bool
    val createInterpreterNative : nativeint * nativeint * nativeint -> bool
    val createJITCompilerNative :
      nativeint * nativeint * uint32 * nativeint -> bool
    val disposeExecutionEngineNative : nativeint -> unit
    val disposeExecutionEngine : ExecutionEngineRef -> unit
    val runStaticConstructorsNative : nativeint -> unit
    val runStaticConstructors : ExecutionEngineRef -> unit
    val runStaticDestructorsNative : nativeint -> unit
    val runStaticDestructors : ExecutionEngineRef -> unit
    val runFunctionAsMainNative :
      nativeint * nativeint * uint32 * nativeint * nativeint -> int
    val runFunctionNative :
      nativeint * nativeint * uint32 * nativeint -> nativeint
    val freeMachineCodeForFunctionNative : nativeint * nativeint -> unit
    val freeMachineCodeForFunction : ExecutionEngineRef -> Core.ValueRef -> unit
    val addModuleNative : nativeint * nativeint -> unit
    val addModule : ExecutionEngineRef -> Core.ModuleRef -> unit
    val addModuleProviderNative : nativeint * nativeint -> unit
    val addModuleProvider : ExecutionEngineRef -> Core.ModuleProviderRef -> unit
    val removeModuleNative :
      nativeint * nativeint * nativeint * nativeint -> bool
    val removeModuleProviderNative :
      nativeint * nativeint * nativeint * nativeint -> bool
    val findFunctionNative : nativeint * string * nativeint -> bool
    val recompileAndRelinkFunctionNative : nativeint * nativeint -> nativeint
    val getExecutionEngineTargetDataNative : nativeint -> nativeint
    val getExecutionEngineTargetData :
      ExecutionEngineRef -> Target.TargetDataRef
    val addGlobalMappingNative : nativeint * nativeint * nativeint -> unit
    val getPointerToGlobalNative : nativeint * nativeint -> nativeint
  end
namespace LLVM.Generated
  module Analysis = begin
    type VerifierFailureAction =
      |  AbortProcessAction  =  0
      |  PrintMessageAction  =  1
      |  ReturnStatusAction  =  2
    val verifyModuleNative : nativeint * int * nativeint -> bool
    val verifyFunctionNative : nativeint * int -> bool
    val verifyFunction : Core.ValueRef -> VerifierFailureAction -> bool
    val viewFunctionCFGNative : nativeint -> unit
    val viewFunctionCFG : Core.ValueRef -> unit
    val viewFunctionCFGOnlyNative : nativeint -> unit
    val viewFunctionCFGOnly : Core.ValueRef -> unit
  end
namespace LLVM.Generated.Transforms
  module Scalar = begin
    val addAggressiveDCEPassNative : nativeint -> unit
    val addAggressiveDCEPass : Core.PassManagerRef -> unit
    val addCFGSimplificationPassNative : nativeint -> unit
    val addCFGSimplificationPass : Core.PassManagerRef -> unit
    val addDeadStoreEliminationPassNative : nativeint -> unit
    val addDeadStoreEliminationPass : Core.PassManagerRef -> unit
    val addGVNPassNative : nativeint -> unit
    val addGVNPass : Core.PassManagerRef -> unit
    val addIndVarSimplifyPassNative : nativeint -> unit
    val addIndVarSimplifyPass : Core.PassManagerRef -> unit
    val addInstructionCombiningPassNative : nativeint -> unit
    val addInstructionCombiningPass : Core.PassManagerRef -> unit
    val addJumpThreadingPassNative : nativeint -> unit
    val addJumpThreadingPass : Core.PassManagerRef -> unit
    val addLICMPassNative : nativeint -> unit
    val addLICMPass : Core.PassManagerRef -> unit
    val addLoopDeletionPassNative : nativeint -> unit
    val addLoopDeletionPass : Core.PassManagerRef -> unit
    val addLoopIdiomPassNative : nativeint -> unit
    val addLoopIdiomPass : Core.PassManagerRef -> unit
    val addLoopRotatePassNative : nativeint -> unit
    val addLoopRotatePass : Core.PassManagerRef -> unit
    val addLoopUnrollPassNative : nativeint -> unit
    val addLoopUnrollPass : Core.PassManagerRef -> unit
    val addLoopUnswitchPassNative : nativeint -> unit
    val addLoopUnswitchPass : Core.PassManagerRef -> unit
    val addMemCpyOptPassNative : nativeint -> unit
    val addMemCpyOptPass : Core.PassManagerRef -> unit
    val addPromoteMemoryToRegisterPassNative : nativeint -> unit
    val addPromoteMemoryToRegisterPass : Core.PassManagerRef -> unit
    val addReassociatePassNative : nativeint -> unit
    val addReassociatePass : Core.PassManagerRef -> unit
    val addSCCPPassNative : nativeint -> unit
    val addSCCPPass : Core.PassManagerRef -> unit
    val addScalarReplAggregatesPassNative : nativeint -> unit
    val addScalarReplAggregatesPass : Core.PassManagerRef -> unit
    val addScalarReplAggregatesPassSSANative : nativeint -> unit
    val addScalarReplAggregatesPassSSA : Core.PassManagerRef -> unit
    val addScalarReplAggregatesPassWithThresholdNative : nativeint * int -> unit
    val addScalarReplAggregatesPassWithThreshold :
      Core.PassManagerRef -> int -> unit
    val addSimplifyLibCallsPassNative : nativeint -> unit
    val addSimplifyLibCallsPass : Core.PassManagerRef -> unit
    val addTailCallEliminationPassNative : nativeint -> unit
    val addTailCallEliminationPass : Core.PassManagerRef -> unit
    val addConstantPropagationPassNative : nativeint -> unit
    val addConstantPropagationPass : Core.PassManagerRef -> unit
    val addDemoteMemoryToRegisterPassNative : nativeint -> unit
    val addDemoteMemoryToRegisterPass : Core.PassManagerRef -> unit
    val addVerifierPassNative : nativeint -> unit
    val addVerifierPass : Core.PassManagerRef -> unit
    val addCorrelatedValuePropagationPassNative : nativeint -> unit
    val addCorrelatedValuePropagationPass : Core.PassManagerRef -> unit
    val addEarlyCSEPassNative : nativeint -> unit
    val addEarlyCSEPass : Core.PassManagerRef -> unit
    val addLowerExpectIntrinsicPassNative : nativeint -> unit
    val addLowerExpectIntrinsicPass : Core.PassManagerRef -> unit
    val addTypeBasedAliasAnalysisPassNative : nativeint -> unit
    val addTypeBasedAliasAnalysisPass : Core.PassManagerRef -> unit
    val addBasicAliasAnalysisPassNative : nativeint -> unit
    val addBasicAliasAnalysisPass : Core.PassManagerRef -> unit
  end
namespace LLVM.Generated.Transforms
  module IPO = begin
    val addArgumentPromotionPassNative : nativeint -> unit
    val addArgumentPromotionPass : Core.PassManagerRef -> unit
    val addConstantMergePassNative : nativeint -> unit
    val addConstantMergePass : Core.PassManagerRef -> unit
    val addDeadArgEliminationPassNative : nativeint -> unit
    val addDeadArgEliminationPass : Core.PassManagerRef -> unit
    val addFunctionAttrsPassNative : nativeint -> unit
    val addFunctionAttrsPass : Core.PassManagerRef -> unit
    val addFunctionInliningPassNative : nativeint -> unit
    val addFunctionInliningPass : Core.PassManagerRef -> unit
    val addAlwaysInlinerPassNative : nativeint -> unit
    val addAlwaysInlinerPass : Core.PassManagerRef -> unit
    val addGlobalDCEPassNative : nativeint -> unit
    val addGlobalDCEPass : Core.PassManagerRef -> unit
    val addGlobalOptimizerPassNative : nativeint -> unit
    val addGlobalOptimizerPass : Core.PassManagerRef -> unit
    val addIPConstantPropagationPassNative : nativeint -> unit
    val addIPConstantPropagationPass : Core.PassManagerRef -> unit
    val addPruneEHPassNative : nativeint -> unit
    val addPruneEHPass : Core.PassManagerRef -> unit
    val addIPSCCPPassNative : nativeint -> unit
    val addIPSCCPPass : Core.PassManagerRef -> unit
    val addInternalizePassNative : nativeint * uint32 -> unit
    val addInternalizePass : Core.PassManagerRef -> uint32 -> unit
    val addStripDeadPrototypesPassNative : nativeint -> unit
    val addStripDeadPrototypesPass : Core.PassManagerRef -> unit
    val addStripSymbolsPassNative : nativeint -> unit
    val addStripSymbolsPass : Core.PassManagerRef -> unit
  end

namespace LLVM
  module Core = begin
    type Builder =
      class
        inherit Generated.Core.BuilderRef
        interface System.IDisposable
        new : unit -> Builder
        new : builderRef:Generated.Core.BuilderRef -> Builder
        new : ctxt:Generated.Core.ContextRef -> Builder
        new : bb:Generated.Core.BasicBlockRef -> Builder
      end
    val varArgFunctionType :
      Generated.Core.TypeRef ->
        Generated.Core.TypeRef array -> Generated.Core.TypeRef
    val functionType :
      Generated.Core.TypeRef ->
        Generated.Core.TypeRef array -> Generated.Core.TypeRef
    val getBasicBlocks :
      Generated.Core.ValueRef -> Generated.Core.BasicBlockRef list
    val buildCall :
      Generated.Core.BuilderRef ->
        Generated.Core.ValueRef ->
          Generated.Core.ValueRef array -> string -> Generated.Core.ValueRef
    val addIncoming :
      Generated.Core.ValueRef ->
        (Generated.Core.ValueRef * Generated.Core.BasicBlockRef) array -> unit
    val getNamedFunction :
      Generated.Core.ModuleRef -> string -> Generated.Core.ValueRef
    val optValueRef : Generated.Core.ValueRef -> Generated.Core.ValueRef option
    val tryGetNamedFunction :
      Generated.Core.ModuleRef -> string -> Generated.Core.ValueRef option
    val getParams : Generated.Core.ValueRef -> Generated.Core.ValueRef []
    val getParamTypes : Generated.Core.TypeRef -> Generated.Core.TypeRef []
    val buildSwitchWithCases :
      Generated.Core.BuilderRef ->
        Generated.Core.ValueRef ->
          (Generated.Core.ValueRef * Generated.Core.BasicBlockRef) array ->
            Generated.Core.BasicBlockRef -> unit
    val structTypeInContext :
      Generated.Core.ContextRef ->
        Generated.Core.TypeRef array -> bool -> Generated.Core.TypeRef
    val structType :
      Generated.Core.TypeRef array -> bool -> Generated.Core.TypeRef
    val buildGEP :
      Generated.Core.BuilderRef ->
        Generated.Core.ValueRef ->
          Generated.Core.ValueRef array -> string -> Generated.Core.ValueRef
    val structSetBody :
      Generated.Core.TypeRef -> Generated.Core.TypeRef array -> bool -> unit
    val getStructElementTypes :
      Generated.Core.TypeRef -> Generated.Core.TypeRef []
    val createMemoryBufferWithContentsOfFile :
      string -> Generated.Core.MemoryBufferRef
  end

namespace LLVM
  module BitReader = begin
    val parseBitcode :
      Generated.Core.MemoryBufferRef -> Generated.Core.ModuleRef
  end

namespace LLVM
  module ExecutionEngine = begin
    val runFunction :
      Generated.ExecutionEngine.ExecutionEngineRef ->
        Generated.Core.ValueRef ->
          Generated.ExecutionEngine.GenericValueRef array ->
            Generated.ExecutionEngine.GenericValueRef
    val private createEngineForModuleFromNativeFunc :
      (nativeint * nativeint * nativeint -> bool) ->
        Generated.Core.ModuleRef -> Generated.ExecutionEngine.ExecutionEngineRef
    val createExecutionEngineForModule :
      Generated.Core.ModuleRef -> Generated.ExecutionEngine.ExecutionEngineRef
    val createInterpreterForModule :
      Generated.Core.ModuleRef -> Generated.ExecutionEngine.ExecutionEngineRef
    val createJITCompilerForModule :
      Generated.Core.ModuleRef ->
        uint32 -> Generated.ExecutionEngine.ExecutionEngineRef
  end

namespace LLVM
  module Extra = begin
    val private typeToStringBuilder :
      Generated.Core.ModuleRef ->
        Generated.Core.TypeRef -> System.Text.StringBuilder
    val typeToString :
      Generated.Core.ModuleRef -> Generated.Core.TypeRef -> string
    val buildCopy :
      Generated.Core.ModuleRef ->
        Generated.Core.BuilderRef ->
          Generated.Core.ValueRef -> Generated.Core.ValueRef -> bool -> unit
  end

namespace LLVM
  module Target = begin
    val initializeX86TargetInfoNative : unit -> unit
    val initializeX86TargetNative : unit -> unit
    val initializeX86TargetMCNative : unit -> unit
    val initializeX86Target : unit -> unit
  end

