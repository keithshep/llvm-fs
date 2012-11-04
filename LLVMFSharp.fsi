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
    [<LiteralAttribute ()>]
    val llvmAssemblyName : string
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
      |  LinkOnceODRAutoHideLinkage  =  4
      |  WeakAnyLinkage  =  5
      |  WeakODRLinkage  =  6
      |  AppendingLinkage  =  7
      |  InternalLinkage  =  8
      |  PrivateLinkage  =  9
      |  DLLImportLinkage  =  10
      |  DLLExportLinkage  =  11
      |  ExternalWeakLinkage  =  12
      |  GhostLinkage  =  13
      |  CommonLinkage  =  14
      |  LinkerPrivateLinkage  =  15
      |  LinkerPrivateWeakLinkage  =  16
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
    val initializeCoreNative : R:nativeint -> unit
    val initializeCore : _R:PassRegistryRef -> unit
    val contextCreateNative : unit -> nativeint
    val contextCreate : unit -> ContextRef
    val getGlobalContextNative : unit -> nativeint
    val getGlobalContext : unit -> ContextRef
    val contextDisposeNative : C:nativeint -> unit
    val contextDispose : _C:ContextRef -> unit
    val getMDKindIDInContextNative :
      C:nativeint * Name:string * SLen:uint32 -> uint32
    val getMDKindIDInContext :
      _C:ContextRef -> _Name:string -> _SLen:uint32 -> uint32
    val getMDKindIDNative : Name:string * SLen:uint32 -> uint32
    val getMDKindID : _Name:string -> _SLen:uint32 -> uint32
    val moduleCreateWithNameNative : ModuleID:string -> nativeint
    val moduleCreateWithName : _ModuleID:string -> ModuleRef
    val moduleCreateWithNameInContextNative :
      ModuleID:string * C:nativeint -> nativeint
    val moduleCreateWithNameInContext :
      _ModuleID:string -> _C:ContextRef -> ModuleRef
    val disposeModuleNative : M:nativeint -> unit
    val disposeModule : _M:ModuleRef -> unit
    val getDataLayoutNative : M:nativeint -> nativeint
    val getDataLayout : _M:ModuleRef -> string
    val setDataLayoutNative : M:nativeint * Triple:string -> unit
    val setDataLayout : _M:ModuleRef -> _Triple:string -> unit
    val getTargetNative : M:nativeint -> nativeint
    val getTarget : _M:ModuleRef -> string
    val setTargetNative : M:nativeint * Triple:string -> unit
    val setTarget : _M:ModuleRef -> _Triple:string -> unit
    val dumpModuleNative : M:nativeint -> unit
    val dumpModule : _M:ModuleRef -> unit
    val printModuleToFileNative :
      M:nativeint * Filename:string * ErrorMessage:nativeint -> bool
    val setModuleInlineAsmNative : M:nativeint * Asm:string -> unit
    val setModuleInlineAsm : _M:ModuleRef -> _Asm:string -> unit
    val getModuleContextNative : M:nativeint -> nativeint
    val getModuleContext : _M:ModuleRef -> ContextRef
    val getTypeByNameNative : M:nativeint * Name:string -> nativeint
    val getTypeByName : _M:ModuleRef -> _Name:string -> TypeRef
    val getNamedMetadataNumOperandsNative : M:nativeint * name:string -> uint32
    val getNamedMetadataNumOperands : _M:ModuleRef -> _name:string -> uint32
    val getNamedMetadataOperandsNative :
      M:nativeint * name:string * Dest:nativeint -> unit
    val addNamedMetadataOperandNative :
      M:nativeint * name:string * Val:nativeint -> unit
    val addNamedMetadataOperand :
      _M:ModuleRef -> _name:string -> _Val:ValueRef -> unit
    val addFunctionNative :
      M:nativeint * Name:string * FunctionTy:nativeint -> nativeint
    val addFunction :
      _M:ModuleRef -> _Name:string -> _FunctionTy:TypeRef -> ValueRef
    val getNamedFunctionNative : M:nativeint * Name:string -> nativeint
    val getNamedFunction : _M:ModuleRef -> _Name:string -> ValueRef
    val getFirstFunctionNative : M:nativeint -> nativeint
    val getFirstFunction : _M:ModuleRef -> ValueRef
    val getLastFunctionNative : M:nativeint -> nativeint
    val getLastFunction : _M:ModuleRef -> ValueRef
    val getNextFunctionNative : Fn:nativeint -> nativeint
    val getNextFunction : _Fn:ValueRef -> ValueRef
    val getPreviousFunctionNative : Fn:nativeint -> nativeint
    val getPreviousFunction : _Fn:ValueRef -> ValueRef
    val getTypeKindNative : Ty:nativeint -> int
    val getTypeKind : _Ty:TypeRef -> TypeKind
    val typeIsSizedNative : Ty:nativeint -> bool
    val typeIsSized : _Ty:TypeRef -> bool
    val getTypeContextNative : Ty:nativeint -> nativeint
    val getTypeContext : _Ty:TypeRef -> ContextRef
    val int1TypeInContextNative : C:nativeint -> nativeint
    val int1TypeInContext : _C:ContextRef -> TypeRef
    val int8TypeInContextNative : C:nativeint -> nativeint
    val int8TypeInContext : _C:ContextRef -> TypeRef
    val int16TypeInContextNative : C:nativeint -> nativeint
    val int16TypeInContext : _C:ContextRef -> TypeRef
    val int32TypeInContextNative : C:nativeint -> nativeint
    val int32TypeInContext : _C:ContextRef -> TypeRef
    val int64TypeInContextNative : C:nativeint -> nativeint
    val int64TypeInContext : _C:ContextRef -> TypeRef
    val intTypeInContextNative : C:nativeint * NumBits:uint32 -> nativeint
    val intTypeInContext : _C:ContextRef -> _NumBits:uint32 -> TypeRef
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
    val intTypeNative : NumBits:uint32 -> nativeint
    val intType : _NumBits:uint32 -> TypeRef
    val getIntTypeWidthNative : IntegerTy:nativeint -> uint32
    val getIntTypeWidth : _IntegerTy:TypeRef -> uint32
    val halfTypeInContextNative : C:nativeint -> nativeint
    val halfTypeInContext : _C:ContextRef -> TypeRef
    val floatTypeInContextNative : C:nativeint -> nativeint
    val floatTypeInContext : _C:ContextRef -> TypeRef
    val doubleTypeInContextNative : C:nativeint -> nativeint
    val doubleTypeInContext : _C:ContextRef -> TypeRef
    val x86FP80TypeInContextNative : C:nativeint -> nativeint
    val x86FP80TypeInContext : _C:ContextRef -> TypeRef
    val fP128TypeInContextNative : C:nativeint -> nativeint
    val fP128TypeInContext : _C:ContextRef -> TypeRef
    val pPCFP128TypeInContextNative : C:nativeint -> nativeint
    val pPCFP128TypeInContext : _C:ContextRef -> TypeRef
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
    val functionTypeNative :
      ReturnType:nativeint * ParamTypes:nativeint * ParamCount:uint32 *
      IsVarArg:bool -> nativeint
    val isFunctionVarArgNative : FunctionTy:nativeint -> bool
    val isFunctionVarArg : _FunctionTy:TypeRef -> bool
    val getReturnTypeNative : FunctionTy:nativeint -> nativeint
    val getReturnType : _FunctionTy:TypeRef -> TypeRef
    val countParamTypesNative : FunctionTy:nativeint -> uint32
    val countParamTypes : _FunctionTy:TypeRef -> uint32
    val getParamTypesNative : FunctionTy:nativeint * Dest:nativeint -> unit
    val structTypeInContextNative :
      C:nativeint * ElementTypes:nativeint * ElementCount:uint32 * Packed:bool ->
        nativeint
    val structTypeNative :
      ElementTypes:nativeint * ElementCount:uint32 * Packed:bool -> nativeint
    val structCreateNamedNative : C:nativeint * Name:string -> nativeint
    val structCreateNamed : _C:ContextRef -> _Name:string -> TypeRef
    val getStructNameNative : Ty:nativeint -> nativeint
    val getStructName : _Ty:TypeRef -> string
    val structSetBodyNative :
      StructTy:nativeint * ElementTypes:nativeint * ElementCount:uint32 *
      Packed:bool -> unit
    val countStructElementTypesNative : StructTy:nativeint -> uint32
    val countStructElementTypes : _StructTy:TypeRef -> uint32
    val getStructElementTypesNative :
      StructTy:nativeint * Dest:nativeint -> unit
    val isPackedStructNative : StructTy:nativeint -> bool
    val isPackedStruct : _StructTy:TypeRef -> bool
    val isOpaqueStructNative : StructTy:nativeint -> bool
    val isOpaqueStruct : _StructTy:TypeRef -> bool
    val getElementTypeNative : Ty:nativeint -> nativeint
    val getElementType : _Ty:TypeRef -> TypeRef
    val arrayTypeNative :
      ElementType:nativeint * ElementCount:uint32 -> nativeint
    val arrayType : _ElementType:TypeRef -> _ElementCount:uint32 -> TypeRef
    val getArrayLengthNative : ArrayTy:nativeint -> uint32
    val getArrayLength : _ArrayTy:TypeRef -> uint32
    val pointerTypeNative :
      ElementType:nativeint * AddressSpace:uint32 -> nativeint
    val pointerType : _ElementType:TypeRef -> _AddressSpace:uint32 -> TypeRef
    val getPointerAddressSpaceNative : PointerTy:nativeint -> uint32
    val getPointerAddressSpace : _PointerTy:TypeRef -> uint32
    val vectorTypeNative :
      ElementType:nativeint * ElementCount:uint32 -> nativeint
    val vectorType : _ElementType:TypeRef -> _ElementCount:uint32 -> TypeRef
    val getVectorSizeNative : VectorTy:nativeint -> uint32
    val getVectorSize : _VectorTy:TypeRef -> uint32
    val voidTypeInContextNative : C:nativeint -> nativeint
    val voidTypeInContext : _C:ContextRef -> TypeRef
    val labelTypeInContextNative : C:nativeint -> nativeint
    val labelTypeInContext : _C:ContextRef -> TypeRef
    val x86MMXTypeInContextNative : C:nativeint -> nativeint
    val x86MMXTypeInContext : _C:ContextRef -> TypeRef
    val voidTypeNative : unit -> nativeint
    val voidType : unit -> TypeRef
    val labelTypeNative : unit -> nativeint
    val labelType : unit -> TypeRef
    val x86MMXTypeNative : unit -> nativeint
    val x86MMXType : unit -> TypeRef
    val typeOfNative : Val:nativeint -> nativeint
    val typeOf : _Val:ValueRef -> TypeRef
    val getValueNameNative : Val:nativeint -> nativeint
    val getValueName : _Val:ValueRef -> string
    val setValueNameNative : Val:nativeint * Name:string -> unit
    val setValueName : _Val:ValueRef -> _Name:string -> unit
    val dumpValueNative : Val:nativeint -> unit
    val dumpValue : _Val:ValueRef -> unit
    val replaceAllUsesWithNative : OldVal:nativeint * NewVal:nativeint -> unit
    val replaceAllUsesWith : _OldVal:ValueRef -> _NewVal:ValueRef -> unit
    val isConstantNative : Val:nativeint -> bool
    val isConstant : _Val:ValueRef -> bool
    val isUndefNative : Val:nativeint -> bool
    val isUndef : _Val:ValueRef -> bool
    val getFirstUseNative : Val:nativeint -> nativeint
    val getFirstUse : _Val:ValueRef -> UseRef
    val getNextUseNative : U:nativeint -> nativeint
    val getNextUse : _U:UseRef -> UseRef
    val getUserNative : U:nativeint -> nativeint
    val getUser : _U:UseRef -> ValueRef
    val getUsedValueNative : U:nativeint -> nativeint
    val getUsedValue : _U:UseRef -> ValueRef
    val getOperandNative : Val:nativeint * Index:uint32 -> nativeint
    val getOperand : _Val:ValueRef -> _Index:uint32 -> ValueRef
    val setOperandNative : User:nativeint * Index:uint32 * Val:nativeint -> unit
    val setOperand : _User:ValueRef -> _Index:uint32 -> _Val:ValueRef -> unit
    val getNumOperandsNative : Val:nativeint -> int
    val getNumOperands : _Val:ValueRef -> int
    val constNullNative : Ty:nativeint -> nativeint
    val constNull : _Ty:TypeRef -> ValueRef
    val constAllOnesNative : Ty:nativeint -> nativeint
    val constAllOnes : _Ty:TypeRef -> ValueRef
    val getUndefNative : Ty:nativeint -> nativeint
    val getUndef : _Ty:TypeRef -> ValueRef
    val isNullNative : Val:nativeint -> bool
    val isNull : _Val:ValueRef -> bool
    val constPointerNullNative : Ty:nativeint -> nativeint
    val constPointerNull : _Ty:TypeRef -> ValueRef
    val constIntNative :
      IntTy:nativeint * N:uint64 * SignExtend:bool -> nativeint
    val constInt : _IntTy:TypeRef -> _N:uint64 -> _SignExtend:bool -> ValueRef
    val constIntOfArbitraryPrecisionNative :
      IntTy:nativeint * NumWords:uint32 * Words:nativeptr<uint64> -> nativeint
    val constIntOfStringNative :
      IntTy:nativeint * Text:string * Radix:uint8 -> nativeint
    val constIntOfString :
      _IntTy:TypeRef -> _Text:string -> _Radix:uint8 -> ValueRef
    val constIntOfStringAndSizeNative :
      IntTy:nativeint * Text:string * SLen:uint32 * Radix:uint8 -> nativeint
    val constIntOfStringAndSize :
      _IntTy:TypeRef -> _Text:string -> _SLen:uint32 -> _Radix:uint8 -> ValueRef
    val constRealNative : RealTy:nativeint * N:double -> nativeint
    val constReal : _RealTy:TypeRef -> _N:double -> ValueRef
    val constRealOfStringNative : RealTy:nativeint * Text:string -> nativeint
    val constRealOfString : _RealTy:TypeRef -> _Text:string -> ValueRef
    val constRealOfStringAndSizeNative :
      RealTy:nativeint * Text:string * SLen:uint32 -> nativeint
    val constRealOfStringAndSize :
      _RealTy:TypeRef -> _Text:string -> _SLen:uint32 -> ValueRef
    val constIntGetZExtValueNative : ConstantVal:nativeint -> uint64
    val constIntGetZExtValue : _ConstantVal:ValueRef -> uint64
    val constIntGetSExtValueNative : ConstantVal:nativeint -> int64
    val constIntGetSExtValue : _ConstantVal:ValueRef -> int64
    val constStringInContextNative :
      C:nativeint * Str:string * Length:uint32 * DontNullTerminate:bool ->
        nativeint
    val constStringInContext :
      _C:ContextRef ->
        _Str:string -> _Length:uint32 -> _DontNullTerminate:bool -> ValueRef
    val constStringNative :
      Str:string * Length:uint32 * DontNullTerminate:bool -> nativeint
    val constString :
      _Str:string -> _Length:uint32 -> _DontNullTerminate:bool -> ValueRef
    val constStructInContextNative :
      C:nativeint * ConstantVals:nativeint * Count:uint32 * Packed:bool ->
        nativeint
    val constStructNative :
      ConstantVals:nativeint * Count:uint32 * Packed:bool -> nativeint
    val constArrayNative :
      ElementTy:nativeint * ConstantVals:nativeint * Length:uint32 -> nativeint
    val constNamedStructNative :
      StructTy:nativeint * ConstantVals:nativeint * Count:uint32 -> nativeint
    val constVectorNative :
      ScalarConstantVals:nativeint * Size:uint32 -> nativeint
    val getConstOpcodeNative : ConstantVal:nativeint -> int
    val getConstOpcode : _ConstantVal:ValueRef -> Opcode
    val alignOfNative : Ty:nativeint -> nativeint
    val alignOf : _Ty:TypeRef -> ValueRef
    val sizeOfNative : Ty:nativeint -> nativeint
    val sizeOf : _Ty:TypeRef -> ValueRef
    val constNegNative : ConstantVal:nativeint -> nativeint
    val constNeg : _ConstantVal:ValueRef -> ValueRef
    val constNSWNegNative : ConstantVal:nativeint -> nativeint
    val constNSWNeg : _ConstantVal:ValueRef -> ValueRef
    val constNUWNegNative : ConstantVal:nativeint -> nativeint
    val constNUWNeg : _ConstantVal:ValueRef -> ValueRef
    val constFNegNative : ConstantVal:nativeint -> nativeint
    val constFNeg : _ConstantVal:ValueRef -> ValueRef
    val constNotNative : ConstantVal:nativeint -> nativeint
    val constNot : _ConstantVal:ValueRef -> ValueRef
    val constAddNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constAdd : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constNSWAddNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constNSWAdd : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constNUWAddNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constNUWAdd : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constFAddNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constFAdd : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constSubNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constSub : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constNSWSubNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constNSWSub : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constNUWSubNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constNUWSub : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constFSubNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constFSub : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constMulNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constMul : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constNSWMulNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constNSWMul : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constNUWMulNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constNUWMul : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constFMulNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constFMul : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constUDivNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constUDiv : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constSDivNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constSDiv : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constExactSDivNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constExactSDiv :
      _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constFDivNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constFDiv : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constURemNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constURem : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constSRemNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constSRem : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constFRemNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constFRem : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constAndNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constAnd : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constOrNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constOr : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constXorNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constXor : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constICmpNative :
      Predicate:int * LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constICmp :
      _Predicate:IntPredicate ->
        _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constFCmpNative :
      Predicate:int * LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constFCmp :
      _Predicate:RealPredicate ->
        _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constShlNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constShl : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constLShrNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constLShr : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constAShrNative :
      LHSConstant:nativeint * RHSConstant:nativeint -> nativeint
    val constAShr : _LHSConstant:ValueRef -> _RHSConstant:ValueRef -> ValueRef
    val constGEPNative :
      ConstantVal:nativeint * ConstantIndices:nativeint * NumIndices:uint32 ->
        nativeint
    val constInBoundsGEPNative :
      ConstantVal:nativeint * ConstantIndices:nativeint * NumIndices:uint32 ->
        nativeint
    val constTruncNative : ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constTrunc : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constSExtNative : ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constSExt : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constZExtNative : ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constZExt : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constFPTruncNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constFPTrunc : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constFPExtNative : ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constFPExt : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constUIToFPNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constUIToFP : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constSIToFPNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constSIToFP : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constFPToUINative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constFPToUI : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constFPToSINative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constFPToSI : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constPtrToIntNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constPtrToInt : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constIntToPtrNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constIntToPtr : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constBitCastNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constBitCast : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constZExtOrBitCastNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constZExtOrBitCast :
      _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constSExtOrBitCastNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constSExtOrBitCast :
      _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constTruncOrBitCastNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constTruncOrBitCast :
      _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constPointerCastNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constPointerCast : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constIntCastNative :
      ConstantVal:nativeint * ToType:nativeint * isSigned:bool -> nativeint
    val constIntCast :
      _ConstantVal:ValueRef -> _ToType:TypeRef -> _isSigned:bool -> ValueRef
    val constFPCastNative :
      ConstantVal:nativeint * ToType:nativeint -> nativeint
    val constFPCast : _ConstantVal:ValueRef -> _ToType:TypeRef -> ValueRef
    val constSelectNative :
      ConstantCondition:nativeint * ConstantIfTrue:nativeint *
      ConstantIfFalse:nativeint -> nativeint
    val constSelect :
      _ConstantCondition:ValueRef ->
        _ConstantIfTrue:ValueRef -> _ConstantIfFalse:ValueRef -> ValueRef
    val constExtractElementNative :
      VectorConstant:nativeint * IndexConstant:nativeint -> nativeint
    val constExtractElement :
      _VectorConstant:ValueRef -> _IndexConstant:ValueRef -> ValueRef
    val constInsertElementNative :
      VectorConstant:nativeint * ElementValueConstant:nativeint *
      IndexConstant:nativeint -> nativeint
    val constInsertElement :
      _VectorConstant:ValueRef ->
        _ElementValueConstant:ValueRef -> _IndexConstant:ValueRef -> ValueRef
    val constShuffleVectorNative :
      VectorAConstant:nativeint * VectorBConstant:nativeint *
      MaskConstant:nativeint -> nativeint
    val constShuffleVector :
      _VectorAConstant:ValueRef ->
        _VectorBConstant:ValueRef -> _MaskConstant:ValueRef -> ValueRef
    val constExtractValueNative :
      AggConstant:nativeint * IdxList:nativeptr<uint32> * NumIdx:uint32 ->
        nativeint
    val constInsertValueNative :
      AggConstant:nativeint * ElementValueConstant:nativeint *
      IdxList:nativeptr<uint32> * NumIdx:uint32 -> nativeint
    val constInlineAsmNative :
      Ty:nativeint * AsmString:string * Constraints:string * HasSideEffects:bool *
      IsAlignStack:bool -> nativeint
    val constInlineAsm :
      _Ty:TypeRef ->
        _AsmString:string ->
          _Constraints:string ->
            _HasSideEffects:bool -> _IsAlignStack:bool -> ValueRef
    val blockAddressNative : F:nativeint * BB:nativeint -> nativeint
    val blockAddress : _F:ValueRef -> _BB:BasicBlockRef -> ValueRef
    val getGlobalParentNative : Global:nativeint -> nativeint
    val getGlobalParent : _Global:ValueRef -> ModuleRef
    val isDeclarationNative : Global:nativeint -> bool
    val isDeclaration : _Global:ValueRef -> bool
    val getLinkageNative : Global:nativeint -> int
    val getLinkage : _Global:ValueRef -> Linkage
    val setLinkageNative : Global:nativeint * Linkage:int -> unit
    val setLinkage : _Global:ValueRef -> _Linkage:Linkage -> unit
    val getSectionNative : Global:nativeint -> nativeint
    val getSection : _Global:ValueRef -> string
    val setSectionNative : Global:nativeint * Section:string -> unit
    val setSection : _Global:ValueRef -> _Section:string -> unit
    val getVisibilityNative : Global:nativeint -> int
    val getVisibility : _Global:ValueRef -> Visibility
    val setVisibilityNative : Global:nativeint * Viz:int -> unit
    val setVisibility : _Global:ValueRef -> _Viz:Visibility -> unit
    val getAlignmentNative : Global:nativeint -> uint32
    val getAlignment : _Global:ValueRef -> uint32
    val setAlignmentNative : Global:nativeint * Bytes:uint32 -> unit
    val setAlignment : _Global:ValueRef -> _Bytes:uint32 -> unit
    val addGlobalNative : M:nativeint * Ty:nativeint * Name:string -> nativeint
    val addGlobal : _M:ModuleRef -> _Ty:TypeRef -> _Name:string -> ValueRef
    val addGlobalInAddressSpaceNative :
      M:nativeint * Ty:nativeint * Name:string * AddressSpace:uint32 ->
        nativeint
    val addGlobalInAddressSpace :
      _M:ModuleRef ->
        _Ty:TypeRef -> _Name:string -> _AddressSpace:uint32 -> ValueRef
    val getNamedGlobalNative : M:nativeint * Name:string -> nativeint
    val getNamedGlobal : _M:ModuleRef -> _Name:string -> ValueRef
    val getFirstGlobalNative : M:nativeint -> nativeint
    val getFirstGlobal : _M:ModuleRef -> ValueRef
    val getLastGlobalNative : M:nativeint -> nativeint
    val getLastGlobal : _M:ModuleRef -> ValueRef
    val getNextGlobalNative : GlobalVar:nativeint -> nativeint
    val getNextGlobal : _GlobalVar:ValueRef -> ValueRef
    val getPreviousGlobalNative : GlobalVar:nativeint -> nativeint
    val getPreviousGlobal : _GlobalVar:ValueRef -> ValueRef
    val deleteGlobalNative : GlobalVar:nativeint -> unit
    val deleteGlobal : _GlobalVar:ValueRef -> unit
    val getInitializerNative : GlobalVar:nativeint -> nativeint
    val getInitializer : _GlobalVar:ValueRef -> ValueRef
    val setInitializerNative :
      GlobalVar:nativeint * ConstantVal:nativeint -> unit
    val setInitializer : _GlobalVar:ValueRef -> _ConstantVal:ValueRef -> unit
    val isThreadLocalNative : GlobalVar:nativeint -> bool
    val isThreadLocal : _GlobalVar:ValueRef -> bool
    val setThreadLocalNative : GlobalVar:nativeint * IsThreadLocal:bool -> unit
    val setThreadLocal : _GlobalVar:ValueRef -> _IsThreadLocal:bool -> unit
    val isGlobalConstantNative : GlobalVar:nativeint -> bool
    val isGlobalConstant : _GlobalVar:ValueRef -> bool
    val setGlobalConstantNative : GlobalVar:nativeint * IsConstant:bool -> unit
    val setGlobalConstant : _GlobalVar:ValueRef -> _IsConstant:bool -> unit
    val addAliasNative :
      M:nativeint * Ty:nativeint * Aliasee:nativeint * Name:string -> nativeint
    val addAlias :
      _M:ModuleRef ->
        _Ty:TypeRef -> _Aliasee:ValueRef -> _Name:string -> ValueRef
    val deleteFunctionNative : Fn:nativeint -> unit
    val deleteFunction : _Fn:ValueRef -> unit
    val getIntrinsicIDNative : Fn:nativeint -> uint32
    val getIntrinsicID : _Fn:ValueRef -> uint32
    val getFunctionCallConvNative : Fn:nativeint -> uint32
    val getFunctionCallConv : _Fn:ValueRef -> uint32
    val setFunctionCallConvNative : Fn:nativeint * CC:uint32 -> unit
    val setFunctionCallConv : _Fn:ValueRef -> _CC:uint32 -> unit
    val getGCNative : Fn:nativeint -> nativeint
    val getGC : _Fn:ValueRef -> string
    val setGCNative : Fn:nativeint * Name:string -> unit
    val setGC : _Fn:ValueRef -> _Name:string -> unit
    val addFunctionAttrNative : Fn:nativeint * PA:int -> unit
    val addFunctionAttr : _Fn:ValueRef -> _PA:Attribute -> unit
    val getFunctionAttrNative : Fn:nativeint -> int
    val getFunctionAttr : _Fn:ValueRef -> Attribute
    val removeFunctionAttrNative : Fn:nativeint * PA:int -> unit
    val removeFunctionAttr : _Fn:ValueRef -> _PA:Attribute -> unit
    val countParamsNative : Fn:nativeint -> uint32
    val countParams : _Fn:ValueRef -> uint32
    val getParamsNative : Fn:nativeint * Params:nativeint -> unit
    val getParamNative : Fn:nativeint * Index:uint32 -> nativeint
    val getParam : _Fn:ValueRef -> _Index:uint32 -> ValueRef
    val getParamParentNative : Inst:nativeint -> nativeint
    val getParamParent : _Inst:ValueRef -> ValueRef
    val getFirstParamNative : Fn:nativeint -> nativeint
    val getFirstParam : _Fn:ValueRef -> ValueRef
    val getLastParamNative : Fn:nativeint -> nativeint
    val getLastParam : _Fn:ValueRef -> ValueRef
    val getNextParamNative : Arg:nativeint -> nativeint
    val getNextParam : _Arg:ValueRef -> ValueRef
    val getPreviousParamNative : Arg:nativeint -> nativeint
    val getPreviousParam : _Arg:ValueRef -> ValueRef
    val addAttributeNative : Arg:nativeint * PA:int -> unit
    val addAttribute : _Arg:ValueRef -> _PA:Attribute -> unit
    val removeAttributeNative : Arg:nativeint * PA:int -> unit
    val removeAttribute : _Arg:ValueRef -> _PA:Attribute -> unit
    val getAttributeNative : Arg:nativeint -> int
    val getAttribute : _Arg:ValueRef -> Attribute
    val setParamAlignmentNative : Arg:nativeint * align:uint32 -> unit
    val setParamAlignment : _Arg:ValueRef -> _align:uint32 -> unit
    val mDStringInContextNative :
      C:nativeint * Str:string * SLen:uint32 -> nativeint
    val mDStringInContext :
      _C:ContextRef -> _Str:string -> _SLen:uint32 -> ValueRef
    val mDStringNative : Str:string * SLen:uint32 -> nativeint
    val mDString : _Str:string -> _SLen:uint32 -> ValueRef
    val mDNodeInContextNative :
      C:nativeint * Vals:nativeint * Count:uint32 -> nativeint
    val mDNodeNative : Vals:nativeint * Count:uint32 -> nativeint
    val getMDStringNative : V:nativeint * Len:nativeptr<uint32> -> nativeint
    val getMDNodeNumOperandsNative : V:nativeint -> uint32
    val getMDNodeNumOperands : _V:ValueRef -> uint32
    val getMDNodeOperandsNative : V:nativeint * Dest:nativeint -> unit
    val basicBlockAsValueNative : BB:nativeint -> nativeint
    val basicBlockAsValue : _BB:BasicBlockRef -> ValueRef
    val valueIsBasicBlockNative : Val:nativeint -> bool
    val valueIsBasicBlock : _Val:ValueRef -> bool
    val valueAsBasicBlockNative : Val:nativeint -> nativeint
    val valueAsBasicBlock : _Val:ValueRef -> BasicBlockRef
    val getBasicBlockParentNative : BB:nativeint -> nativeint
    val getBasicBlockParent : _BB:BasicBlockRef -> ValueRef
    val getBasicBlockTerminatorNative : BB:nativeint -> nativeint
    val getBasicBlockTerminator : _BB:BasicBlockRef -> ValueRef
    val countBasicBlocksNative : Fn:nativeint -> uint32
    val countBasicBlocks : _Fn:ValueRef -> uint32
    val getBasicBlocksNative : Fn:nativeint * BasicBlocks:nativeint -> unit
    val getFirstBasicBlockNative : Fn:nativeint -> nativeint
    val getFirstBasicBlock : _Fn:ValueRef -> BasicBlockRef
    val getLastBasicBlockNative : Fn:nativeint -> nativeint
    val getLastBasicBlock : _Fn:ValueRef -> BasicBlockRef
    val getNextBasicBlockNative : BB:nativeint -> nativeint
    val getNextBasicBlock : _BB:BasicBlockRef -> BasicBlockRef
    val getPreviousBasicBlockNative : BB:nativeint -> nativeint
    val getPreviousBasicBlock : _BB:BasicBlockRef -> BasicBlockRef
    val getEntryBasicBlockNative : Fn:nativeint -> nativeint
    val getEntryBasicBlock : _Fn:ValueRef -> BasicBlockRef
    val appendBasicBlockInContextNative :
      C:nativeint * Fn:nativeint * Name:string -> nativeint
    val appendBasicBlockInContext :
      _C:ContextRef -> _Fn:ValueRef -> _Name:string -> BasicBlockRef
    val appendBasicBlockNative : Fn:nativeint * Name:string -> nativeint
    val appendBasicBlock : _Fn:ValueRef -> _Name:string -> BasicBlockRef
    val insertBasicBlockInContextNative :
      C:nativeint * BB:nativeint * Name:string -> nativeint
    val insertBasicBlockInContext :
      _C:ContextRef -> _BB:BasicBlockRef -> _Name:string -> BasicBlockRef
    val insertBasicBlockNative :
      InsertBeforeBB:nativeint * Name:string -> nativeint
    val insertBasicBlock :
      _InsertBeforeBB:BasicBlockRef -> _Name:string -> BasicBlockRef
    val deleteBasicBlockNative : BB:nativeint -> unit
    val deleteBasicBlock : _BB:BasicBlockRef -> unit
    val removeBasicBlockFromParentNative : BB:nativeint -> unit
    val removeBasicBlockFromParent : _BB:BasicBlockRef -> unit
    val moveBasicBlockBeforeNative : BB:nativeint * MovePos:nativeint -> unit
    val moveBasicBlockBefore :
      _BB:BasicBlockRef -> _MovePos:BasicBlockRef -> unit
    val moveBasicBlockAfterNative : BB:nativeint * MovePos:nativeint -> unit
    val moveBasicBlockAfter :
      _BB:BasicBlockRef -> _MovePos:BasicBlockRef -> unit
    val getFirstInstructionNative : BB:nativeint -> nativeint
    val getFirstInstruction : _BB:BasicBlockRef -> ValueRef
    val getLastInstructionNative : BB:nativeint -> nativeint
    val getLastInstruction : _BB:BasicBlockRef -> ValueRef
    val hasMetadataNative : Val:nativeint -> int
    val hasMetadata : _Val:ValueRef -> int
    val getMetadataNative : Val:nativeint * KindID:uint32 -> nativeint
    val getMetadata : _Val:ValueRef -> _KindID:uint32 -> ValueRef
    val setMetadataNative :
      Val:nativeint * KindID:uint32 * Node:nativeint -> unit
    val setMetadata : _Val:ValueRef -> _KindID:uint32 -> _Node:ValueRef -> unit
    val getInstructionParentNative : Inst:nativeint -> nativeint
    val getInstructionParent : _Inst:ValueRef -> BasicBlockRef
    val getNextInstructionNative : Inst:nativeint -> nativeint
    val getNextInstruction : _Inst:ValueRef -> ValueRef
    val getPreviousInstructionNative : Inst:nativeint -> nativeint
    val getPreviousInstruction : _Inst:ValueRef -> ValueRef
    val instructionEraseFromParentNative : Inst:nativeint -> unit
    val instructionEraseFromParent : _Inst:ValueRef -> unit
    val getInstructionOpcodeNative : Inst:nativeint -> int
    val getInstructionOpcode : _Inst:ValueRef -> Opcode
    val getICmpPredicateNative : Inst:nativeint -> int
    val getICmpPredicate : _Inst:ValueRef -> IntPredicate
    val setInstructionCallConvNative : Instr:nativeint * CC:uint32 -> unit
    val setInstructionCallConv : _Instr:ValueRef -> _CC:uint32 -> unit
    val getInstructionCallConvNative : Instr:nativeint -> uint32
    val getInstructionCallConv : _Instr:ValueRef -> uint32
    val addInstrAttributeNative :
      Instr:nativeint * index:uint32 * arg2:int -> unit
    val addInstrAttribute :
      _Instr:ValueRef -> _index:uint32 -> _arg2:Attribute -> unit
    val removeInstrAttributeNative :
      Instr:nativeint * index:uint32 * arg2:int -> unit
    val removeInstrAttribute :
      _Instr:ValueRef -> _index:uint32 -> _arg2:Attribute -> unit
    val setInstrParamAlignmentNative :
      Instr:nativeint * index:uint32 * align:uint32 -> unit
    val setInstrParamAlignment :
      _Instr:ValueRef -> _index:uint32 -> _align:uint32 -> unit
    val isTailCallNative : CallInst:nativeint -> bool
    val isTailCall : _CallInst:ValueRef -> bool
    val setTailCallNative : CallInst:nativeint * IsTailCall:bool -> unit
    val setTailCall : _CallInst:ValueRef -> _IsTailCall:bool -> unit
    val getSwitchDefaultDestNative : SwitchInstr:nativeint -> nativeint
    val getSwitchDefaultDest : _SwitchInstr:ValueRef -> BasicBlockRef
    val addIncomingNative :
      PhiNode:nativeint * IncomingValues:nativeint * IncomingBlocks:nativeint *
      Count:uint32 -> unit
    val countIncomingNative : PhiNode:nativeint -> uint32
    val countIncoming : _PhiNode:ValueRef -> uint32
    val getIncomingValueNative : PhiNode:nativeint * Index:uint32 -> nativeint
    val getIncomingValue : _PhiNode:ValueRef -> _Index:uint32 -> ValueRef
    val getIncomingBlockNative : PhiNode:nativeint * Index:uint32 -> nativeint
    val getIncomingBlock : _PhiNode:ValueRef -> _Index:uint32 -> BasicBlockRef
    val createBuilderInContextNative : C:nativeint -> nativeint
    val createBuilderInContext : _C:ContextRef -> BuilderRef
    val createBuilderNative : unit -> nativeint
    val createBuilder : unit -> BuilderRef
    val positionBuilderNative :
      Builder:nativeint * Block:nativeint * Instr:nativeint -> unit
    val positionBuilder :
      _Builder:BuilderRef -> _Block:BasicBlockRef -> _Instr:ValueRef -> unit
    val positionBuilderBeforeNative :
      Builder:nativeint * Instr:nativeint -> unit
    val positionBuilderBefore : _Builder:BuilderRef -> _Instr:ValueRef -> unit
    val positionBuilderAtEndNative : Builder:nativeint * Block:nativeint -> unit
    val positionBuilderAtEnd :
      _Builder:BuilderRef -> _Block:BasicBlockRef -> unit
    val getInsertBlockNative : Builder:nativeint -> nativeint
    val getInsertBlock : _Builder:BuilderRef -> BasicBlockRef
    val clearInsertionPositionNative : Builder:nativeint -> unit
    val clearInsertionPosition : _Builder:BuilderRef -> unit
    val insertIntoBuilderNative : Builder:nativeint * Instr:nativeint -> unit
    val insertIntoBuilder : _Builder:BuilderRef -> _Instr:ValueRef -> unit
    val insertIntoBuilderWithNameNative :
      Builder:nativeint * Instr:nativeint * Name:string -> unit
    val insertIntoBuilderWithName :
      _Builder:BuilderRef -> _Instr:ValueRef -> _Name:string -> unit
    val disposeBuilderNative : Builder:nativeint -> unit
    val disposeBuilder : _Builder:BuilderRef -> unit
    val setCurrentDebugLocationNative : Builder:nativeint * L:nativeint -> unit
    val setCurrentDebugLocation : _Builder:BuilderRef -> _L:ValueRef -> unit
    val getCurrentDebugLocationNative : Builder:nativeint -> nativeint
    val getCurrentDebugLocation : _Builder:BuilderRef -> ValueRef
    val setInstDebugLocationNative : Builder:nativeint * Inst:nativeint -> unit
    val setInstDebugLocation : _Builder:BuilderRef -> _Inst:ValueRef -> unit
    val buildRetVoidNative : arg0:nativeint -> nativeint
    val buildRetVoid : _arg0:BuilderRef -> ValueRef
    val buildRetNative : arg0:nativeint * V:nativeint -> nativeint
    val buildRet : _arg0:BuilderRef -> _V:ValueRef -> ValueRef
    val buildAggregateRetNative :
      arg0:nativeint * RetVals:nativeint * N:uint32 -> nativeint
    val buildBrNative : arg0:nativeint * Dest:nativeint -> nativeint
    val buildBr : _arg0:BuilderRef -> _Dest:BasicBlockRef -> ValueRef
    val buildCondBrNative :
      arg0:nativeint * If:nativeint * Then:nativeint * Else:nativeint ->
        nativeint
    val buildCondBr :
      _arg0:BuilderRef ->
        _If:ValueRef -> _Then:BasicBlockRef -> _Else:BasicBlockRef -> ValueRef
    val buildSwitchNative :
      arg0:nativeint * V:nativeint * Else:nativeint * NumCases:uint32 ->
        nativeint
    val buildSwitch :
      _arg0:BuilderRef ->
        _V:ValueRef -> _Else:BasicBlockRef -> _NumCases:uint32 -> ValueRef
    val buildIndirectBrNative :
      B:nativeint * Addr:nativeint * NumDests:uint32 -> nativeint
    val buildIndirectBr :
      _B:BuilderRef -> _Addr:ValueRef -> _NumDests:uint32 -> ValueRef
    val buildInvokeNative :
      arg0:nativeint * Fn:nativeint * Args:nativeint * NumArgs:uint32 *
      Then:nativeint * Catch:nativeint * Name:string -> nativeint
    val buildLandingPadNative :
      B:nativeint * Ty:nativeint * PersFn:nativeint * NumClauses:uint32 *
      Name:string -> nativeint
    val buildLandingPad :
      _B:BuilderRef ->
        _Ty:TypeRef ->
          _PersFn:ValueRef -> _NumClauses:uint32 -> _Name:string -> ValueRef
    val buildResumeNative : B:nativeint * Exn:nativeint -> nativeint
    val buildResume : _B:BuilderRef -> _Exn:ValueRef -> ValueRef
    val buildUnreachableNative : arg0:nativeint -> nativeint
    val buildUnreachable : _arg0:BuilderRef -> ValueRef
    val addCaseNative :
      Switch:nativeint * OnVal:nativeint * Dest:nativeint -> unit
    val addCase :
      _Switch:ValueRef -> _OnVal:ValueRef -> _Dest:BasicBlockRef -> unit
    val addDestinationNative : IndirectBr:nativeint * Dest:nativeint -> unit
    val addDestination : _IndirectBr:ValueRef -> _Dest:BasicBlockRef -> unit
    val addClauseNative : LandingPad:nativeint * ClauseVal:nativeint -> unit
    val addClause : _LandingPad:ValueRef -> _ClauseVal:ValueRef -> unit
    val setCleanupNative : LandingPad:nativeint * Val:bool -> unit
    val setCleanup : _LandingPad:ValueRef -> _Val:bool -> unit
    val buildAddNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildAdd :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNSWAddNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildNSWAdd :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNUWAddNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildNUWAdd :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildFAddNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildFAdd :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildSubNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildSub :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNSWSubNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildNSWSub :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNUWSubNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildNUWSub :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildFSubNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildFSub :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildMulNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildMul :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNSWMulNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildNSWMul :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNUWMulNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildNUWMul :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildFMulNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildFMul :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildUDivNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildUDiv :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildSDivNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildSDiv :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildExactSDivNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildExactSDiv :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildFDivNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildFDiv :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildURemNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildURem :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildSRemNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildSRem :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildFRemNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildFRem :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildShlNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildShl :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildLShrNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildLShr :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildAShrNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildAShr :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildAndNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildAnd :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildOrNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildOr :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildXorNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildXor :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildBinOpNative :
      B:nativeint * Op:int * LHS:nativeint * RHS:nativeint * Name:string ->
        nativeint
    val buildBinOp :
      _B:BuilderRef ->
        _Op:Opcode -> _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildNegNative : arg0:nativeint * V:nativeint * Name:string -> nativeint
    val buildNeg : _arg0:BuilderRef -> _V:ValueRef -> _Name:string -> ValueRef
    val buildNSWNegNative : B:nativeint * V:nativeint * Name:string -> nativeint
    val buildNSWNeg : _B:BuilderRef -> _V:ValueRef -> _Name:string -> ValueRef
    val buildNUWNegNative : B:nativeint * V:nativeint * Name:string -> nativeint
    val buildNUWNeg : _B:BuilderRef -> _V:ValueRef -> _Name:string -> ValueRef
    val buildFNegNative :
      arg0:nativeint * V:nativeint * Name:string -> nativeint
    val buildFNeg : _arg0:BuilderRef -> _V:ValueRef -> _Name:string -> ValueRef
    val buildNotNative : arg0:nativeint * V:nativeint * Name:string -> nativeint
    val buildNot : _arg0:BuilderRef -> _V:ValueRef -> _Name:string -> ValueRef
    val buildMallocNative :
      arg0:nativeint * Ty:nativeint * Name:string -> nativeint
    val buildMalloc :
      _arg0:BuilderRef -> _Ty:TypeRef -> _Name:string -> ValueRef
    val buildArrayMallocNative :
      arg0:nativeint * Ty:nativeint * Val:nativeint * Name:string -> nativeint
    val buildArrayMalloc :
      _arg0:BuilderRef ->
        _Ty:TypeRef -> _Val:ValueRef -> _Name:string -> ValueRef
    val buildAllocaNative :
      arg0:nativeint * Ty:nativeint * Name:string -> nativeint
    val buildAlloca :
      _arg0:BuilderRef -> _Ty:TypeRef -> _Name:string -> ValueRef
    val buildArrayAllocaNative :
      arg0:nativeint * Ty:nativeint * Val:nativeint * Name:string -> nativeint
    val buildArrayAlloca :
      _arg0:BuilderRef ->
        _Ty:TypeRef -> _Val:ValueRef -> _Name:string -> ValueRef
    val buildFreeNative : arg0:nativeint * PointerVal:nativeint -> nativeint
    val buildFree : _arg0:BuilderRef -> _PointerVal:ValueRef -> ValueRef
    val buildLoadNative :
      arg0:nativeint * PointerVal:nativeint * Name:string -> nativeint
    val buildLoad :
      _arg0:BuilderRef -> _PointerVal:ValueRef -> _Name:string -> ValueRef
    val buildStoreNative :
      arg0:nativeint * Val:nativeint * Ptr:nativeint -> nativeint
    val buildStore :
      _arg0:BuilderRef -> _Val:ValueRef -> _Ptr:ValueRef -> ValueRef
    val buildGEPNative :
      B:nativeint * Pointer:nativeint * Indices:nativeint * NumIndices:uint32 *
      Name:string -> nativeint
    val buildInBoundsGEPNative :
      B:nativeint * Pointer:nativeint * Indices:nativeint * NumIndices:uint32 *
      Name:string -> nativeint
    val buildStructGEPNative :
      B:nativeint * Pointer:nativeint * Idx:uint32 * Name:string -> nativeint
    val buildStructGEP :
      _B:BuilderRef ->
        _Pointer:ValueRef -> _Idx:uint32 -> _Name:string -> ValueRef
    val buildGlobalStringNative :
      B:nativeint * Str:string * Name:string -> nativeint
    val buildGlobalString :
      _B:BuilderRef -> _Str:string -> _Name:string -> ValueRef
    val buildGlobalStringPtrNative :
      B:nativeint * Str:string * Name:string -> nativeint
    val buildGlobalStringPtr :
      _B:BuilderRef -> _Str:string -> _Name:string -> ValueRef
    val getVolatileNative : MemoryAccessInst:nativeint -> bool
    val getVolatile : _MemoryAccessInst:ValueRef -> bool
    val setVolatileNative : MemoryAccessInst:nativeint * IsVolatile:bool -> unit
    val setVolatile : _MemoryAccessInst:ValueRef -> _IsVolatile:bool -> unit
    val buildTruncNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildTrunc :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildZExtNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildZExt :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildSExtNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildSExt :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildFPToUINative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildFPToUI :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildFPToSINative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildFPToSI :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildUIToFPNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildUIToFP :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildSIToFPNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildSIToFP :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildFPTruncNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildFPTrunc :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildFPExtNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildFPExt :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildPtrToIntNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildPtrToInt :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildIntToPtrNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildIntToPtr :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildBitCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildBitCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildZExtOrBitCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildZExtOrBitCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildSExtOrBitCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildSExtOrBitCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildTruncOrBitCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildTruncOrBitCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildCastNative :
      B:nativeint * Op:int * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildCast :
      _B:BuilderRef ->
        _Op:Opcode ->
          _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildPointerCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildPointerCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildIntCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildIntCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildFPCastNative :
      arg0:nativeint * Val:nativeint * DestTy:nativeint * Name:string ->
        nativeint
    val buildFPCast :
      _arg0:BuilderRef ->
        _Val:ValueRef -> _DestTy:TypeRef -> _Name:string -> ValueRef
    val buildICmpNative :
      arg0:nativeint * Op:int * LHS:nativeint * RHS:nativeint * Name:string ->
        nativeint
    val buildICmp :
      _arg0:BuilderRef ->
        _Op:IntPredicate ->
          _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildFCmpNative :
      arg0:nativeint * Op:int * LHS:nativeint * RHS:nativeint * Name:string ->
        nativeint
    val buildFCmp :
      _arg0:BuilderRef ->
        _Op:RealPredicate ->
          _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val buildPhiNative :
      arg0:nativeint * Ty:nativeint * Name:string -> nativeint
    val buildPhi : _arg0:BuilderRef -> _Ty:TypeRef -> _Name:string -> ValueRef
    val buildCallNative :
      arg0:nativeint * Fn:nativeint * Args:nativeint * NumArgs:uint32 *
      Name:string -> nativeint
    val buildSelectNative :
      arg0:nativeint * If:nativeint * Then:nativeint * Else:nativeint *
      Name:string -> nativeint
    val buildSelect :
      _arg0:BuilderRef ->
        _If:ValueRef ->
          _Then:ValueRef -> _Else:ValueRef -> _Name:string -> ValueRef
    val buildVAArgNative :
      arg0:nativeint * List:nativeint * Ty:nativeint * Name:string -> nativeint
    val buildVAArg :
      _arg0:BuilderRef ->
        _List:ValueRef -> _Ty:TypeRef -> _Name:string -> ValueRef
    val buildExtractElementNative :
      arg0:nativeint * VecVal:nativeint * Index:nativeint * Name:string ->
        nativeint
    val buildExtractElement :
      _arg0:BuilderRef ->
        _VecVal:ValueRef -> _Index:ValueRef -> _Name:string -> ValueRef
    val buildInsertElementNative :
      arg0:nativeint * VecVal:nativeint * EltVal:nativeint * Index:nativeint *
      Name:string -> nativeint
    val buildInsertElement :
      _arg0:BuilderRef ->
        _VecVal:ValueRef ->
          _EltVal:ValueRef -> _Index:ValueRef -> _Name:string -> ValueRef
    val buildShuffleVectorNative :
      arg0:nativeint * V1:nativeint * V2:nativeint * Mask:nativeint *
      Name:string -> nativeint
    val buildShuffleVector :
      _arg0:BuilderRef ->
        _V1:ValueRef ->
          _V2:ValueRef -> _Mask:ValueRef -> _Name:string -> ValueRef
    val buildExtractValueNative :
      arg0:nativeint * AggVal:nativeint * Index:uint32 * Name:string ->
        nativeint
    val buildExtractValue :
      _arg0:BuilderRef ->
        _AggVal:ValueRef -> _Index:uint32 -> _Name:string -> ValueRef
    val buildInsertValueNative :
      arg0:nativeint * AggVal:nativeint * EltVal:nativeint * Index:uint32 *
      Name:string -> nativeint
    val buildInsertValue :
      _arg0:BuilderRef ->
        _AggVal:ValueRef ->
          _EltVal:ValueRef -> _Index:uint32 -> _Name:string -> ValueRef
    val buildIsNullNative :
      arg0:nativeint * Val:nativeint * Name:string -> nativeint
    val buildIsNull :
      _arg0:BuilderRef -> _Val:ValueRef -> _Name:string -> ValueRef
    val buildIsNotNullNative :
      arg0:nativeint * Val:nativeint * Name:string -> nativeint
    val buildIsNotNull :
      _arg0:BuilderRef -> _Val:ValueRef -> _Name:string -> ValueRef
    val buildPtrDiffNative :
      arg0:nativeint * LHS:nativeint * RHS:nativeint * Name:string -> nativeint
    val buildPtrDiff :
      _arg0:BuilderRef ->
        _LHS:ValueRef -> _RHS:ValueRef -> _Name:string -> ValueRef
    val createModuleProviderForExistingModuleNative : M:nativeint -> nativeint
    val createModuleProviderForExistingModule :
      _M:ModuleRef -> ModuleProviderRef
    val disposeModuleProviderNative : M:nativeint -> unit
    val disposeModuleProvider : _M:ModuleProviderRef -> unit
    val createMemoryBufferWithContentsOfFileNative :
      Path:string * OutMemBuf:nativeint * OutMessage:nativeint -> bool
    val createMemoryBufferWithSTDINNative :
      OutMemBuf:nativeint * OutMessage:nativeint -> bool
    val disposeMemoryBufferNative : MemBuf:nativeint -> unit
    val disposeMemoryBuffer : _MemBuf:MemoryBufferRef -> unit
    val getGlobalPassRegistryNative : unit -> nativeint
    val getGlobalPassRegistry : unit -> PassRegistryRef
    val createPassManagerNative : unit -> nativeint
    val createPassManager : unit -> PassManagerRef
    val createFunctionPassManagerForModuleNative : M:nativeint -> nativeint
    val createFunctionPassManagerForModule : _M:ModuleRef -> PassManagerRef
    val createFunctionPassManagerNative : MP:nativeint -> nativeint
    val createFunctionPassManager : _MP:ModuleProviderRef -> PassManagerRef
    val runPassManagerNative : PM:nativeint * M:nativeint -> bool
    val runPassManager : _PM:PassManagerRef -> _M:ModuleRef -> bool
    val initializeFunctionPassManagerNative : FPM:nativeint -> bool
    val initializeFunctionPassManager : _FPM:PassManagerRef -> bool
    val runFunctionPassManagerNative : FPM:nativeint * F:nativeint -> bool
    val runFunctionPassManager : _FPM:PassManagerRef -> _F:ValueRef -> bool
    val finalizeFunctionPassManagerNative : FPM:nativeint -> bool
    val finalizeFunctionPassManager : _FPM:PassManagerRef -> bool
    val disposePassManagerNative : PM:nativeint -> unit
    val disposePassManager : _PM:PassManagerRef -> unit
  end
namespace LLVM.Generated
  module BitReader = begin
    val parseBitcodeNative :
      MemBuf:nativeint * OutModule:nativeint * OutMessage:nativeint -> bool
    val parseBitcodeInContextNative :
      ContextRef:nativeint * MemBuf:nativeint * OutModule:nativeint *
      OutMessage:nativeint -> bool
    val getBitcodeModuleInContextNative :
      ContextRef:nativeint * MemBuf:nativeint * OutM:nativeint *
      OutMessage:nativeint -> bool
    val getBitcodeModuleNative :
      MemBuf:nativeint * OutM:nativeint * OutMessage:nativeint -> bool
    val getBitcodeModuleProviderInContextNative :
      ContextRef:nativeint * MemBuf:nativeint * OutMP:nativeint *
      OutMessage:nativeint -> bool
    val getBitcodeModuleProviderNative :
      MemBuf:nativeint * OutMP:nativeint * OutMessage:nativeint -> bool
  end
namespace LLVM.Generated
  module BitWriter = begin
    val writeBitcodeToFileNative : M:nativeint * Path:string -> int
    val writeBitcodeToFile : _M:Core.ModuleRef -> _Path:string -> int
    val writeBitcodeToFDNative :
      M:nativeint * FD:int * ShouldClose:int * Unbuffered:int -> int
    val writeBitcodeToFD :
      _M:Core.ModuleRef -> _FD:int -> _ShouldClose:int -> _Unbuffered:int -> int
    val writeBitcodeToFileHandleNative : M:nativeint * Handle:int -> int
    val writeBitcodeToFileHandle : _M:Core.ModuleRef -> _Handle:int -> int
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
    val createTargetDataNative : StringRep:string -> nativeint
    val createTargetData : _StringRep:string -> TargetDataRef
    val addTargetDataNative : arg0:nativeint * arg1:nativeint -> unit
    val addTargetData : _arg0:TargetDataRef -> _arg1:Core.PassManagerRef -> unit
    val addTargetLibraryInfoNative : arg0:nativeint * arg1:nativeint -> unit
    val addTargetLibraryInfo :
      _arg0:TargetLibraryInfoRef -> _arg1:Core.PassManagerRef -> unit
    val copyStringRepOfTargetDataNative : arg0:nativeint -> nativeint
    val copyStringRepOfTargetData : _arg0:TargetDataRef -> string
    val byteOrderNative : arg0:nativeint -> int
    val byteOrder : _arg0:TargetDataRef -> ByteOrdering
    val pointerSizeNative : arg0:nativeint -> uint32
    val pointerSize : _arg0:TargetDataRef -> uint32
    val pointerSizeForASNative : arg0:nativeint * AS:uint32 -> uint32
    val pointerSizeForAS : _arg0:TargetDataRef -> _AS:uint32 -> uint32
    val intPtrTypeNative : arg0:nativeint -> nativeint
    val intPtrType : _arg0:TargetDataRef -> Core.TypeRef
    val intPtrTypeForASNative : arg0:nativeint * AS:uint32 -> nativeint
    val intPtrTypeForAS : _arg0:TargetDataRef -> _AS:uint32 -> Core.TypeRef
    val sizeOfTypeInBitsNative : arg0:nativeint * arg1:nativeint -> uint64
    val sizeOfTypeInBits : _arg0:TargetDataRef -> _arg1:Core.TypeRef -> uint64
    val storeSizeOfTypeNative : arg0:nativeint * arg1:nativeint -> uint64
    val storeSizeOfType : _arg0:TargetDataRef -> _arg1:Core.TypeRef -> uint64
    val aBISizeOfTypeNative : arg0:nativeint * arg1:nativeint -> uint64
    val aBISizeOfType : _arg0:TargetDataRef -> _arg1:Core.TypeRef -> uint64
    val aBIAlignmentOfTypeNative : arg0:nativeint * arg1:nativeint -> uint32
    val aBIAlignmentOfType : _arg0:TargetDataRef -> _arg1:Core.TypeRef -> uint32
    val callFrameAlignmentOfTypeNative :
      arg0:nativeint * arg1:nativeint -> uint32
    val callFrameAlignmentOfType :
      _arg0:TargetDataRef -> _arg1:Core.TypeRef -> uint32
    val preferredAlignmentOfTypeNative :
      arg0:nativeint * arg1:nativeint -> uint32
    val preferredAlignmentOfType :
      _arg0:TargetDataRef -> _arg1:Core.TypeRef -> uint32
    val preferredAlignmentOfGlobalNative :
      arg0:nativeint * GlobalVar:nativeint -> uint32
    val preferredAlignmentOfGlobal :
      _arg0:TargetDataRef -> _GlobalVar:Core.ValueRef -> uint32
    val elementAtOffsetNative :
      arg0:nativeint * StructTy:nativeint * Offset:uint64 -> uint32
    val elementAtOffset :
      _arg0:TargetDataRef -> _StructTy:Core.TypeRef -> _Offset:uint64 -> uint32
    val offsetOfElementNative :
      arg0:nativeint * StructTy:nativeint * Element:uint32 -> uint64
    val offsetOfElement :
      _arg0:TargetDataRef -> _StructTy:Core.TypeRef -> _Element:uint32 -> uint64
    val disposeTargetDataNative : arg0:nativeint -> unit
    val disposeTargetData : _arg0:TargetDataRef -> unit
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
    val createGenericValueOfIntNative :
      Ty:nativeint * N:uint64 * IsSigned:bool -> nativeint
    val createGenericValueOfInt :
      _Ty:Core.TypeRef -> _N:uint64 -> _IsSigned:bool -> GenericValueRef
    val createGenericValueOfPointerNative : P:nativeint -> nativeint
    val createGenericValueOfFloatNative : Ty:nativeint * N:double -> nativeint
    val createGenericValueOfFloat :
      _Ty:Core.TypeRef -> _N:double -> GenericValueRef
    val genericValueIntWidthNative : GenValRef:nativeint -> uint32
    val genericValueIntWidth : _GenValRef:GenericValueRef -> uint32
    val genericValueToIntNative : GenVal:nativeint * IsSigned:bool -> uint64
    val genericValueToInt : _GenVal:GenericValueRef -> _IsSigned:bool -> uint64
    val genericValueToPointerNative : GenVal:nativeint -> nativeint
    val genericValueToFloatNative : TyRef:nativeint * GenVal:nativeint -> double
    val genericValueToFloat :
      _TyRef:Core.TypeRef -> _GenVal:GenericValueRef -> double
    val disposeGenericValueNative : GenVal:nativeint -> unit
    val disposeGenericValue : _GenVal:GenericValueRef -> unit
    val createExecutionEngineForModuleNative :
      OutEE:nativeint * M:nativeint * OutError:nativeint -> bool
    val createInterpreterForModuleNative :
      OutInterp:nativeint * M:nativeint * OutError:nativeint -> bool
    val createJITCompilerForModuleNative :
      OutJIT:nativeint * M:nativeint * OptLevel:uint32 * OutError:nativeint ->
        bool
    val createExecutionEngineNative :
      OutEE:nativeint * MP:nativeint * OutError:nativeint -> bool
    val createInterpreterNative :
      OutInterp:nativeint * MP:nativeint * OutError:nativeint -> bool
    val createJITCompilerNative :
      OutJIT:nativeint * MP:nativeint * OptLevel:uint32 * OutError:nativeint ->
        bool
    val disposeExecutionEngineNative : EE:nativeint -> unit
    val disposeExecutionEngine : _EE:ExecutionEngineRef -> unit
    val runStaticConstructorsNative : EE:nativeint -> unit
    val runStaticConstructors : _EE:ExecutionEngineRef -> unit
    val runStaticDestructorsNative : EE:nativeint -> unit
    val runStaticDestructors : _EE:ExecutionEngineRef -> unit
    val runFunctionAsMainNative :
      EE:nativeint * F:nativeint * ArgC:uint32 * ArgV:nativeint * EnvP:nativeint ->
        int
    val runFunctionNative :
      EE:nativeint * F:nativeint * NumArgs:uint32 * Args:nativeint -> nativeint
    val freeMachineCodeForFunctionNative : EE:nativeint * F:nativeint -> unit
    val freeMachineCodeForFunction :
      _EE:ExecutionEngineRef -> _F:Core.ValueRef -> unit
    val addModuleNative : EE:nativeint * M:nativeint -> unit
    val addModule : _EE:ExecutionEngineRef -> _M:Core.ModuleRef -> unit
    val addModuleProviderNative : EE:nativeint * MP:nativeint -> unit
    val addModuleProvider :
      _EE:ExecutionEngineRef -> _MP:Core.ModuleProviderRef -> unit
    val removeModuleNative :
      EE:nativeint * M:nativeint * OutMod:nativeint * OutError:nativeint -> bool
    val removeModuleProviderNative :
      EE:nativeint * MP:nativeint * OutMod:nativeint * OutError:nativeint ->
        bool
    val findFunctionNative :
      EE:nativeint * Name:string * OutFn:nativeint -> bool
    val recompileAndRelinkFunctionNative :
      EE:nativeint * Fn:nativeint -> nativeint
    val getExecutionEngineTargetDataNative : EE:nativeint -> nativeint
    val getExecutionEngineTargetData :
      _EE:ExecutionEngineRef -> Target.TargetDataRef
    val addGlobalMappingNative :
      EE:nativeint * Global:nativeint * Addr:nativeint -> unit
    val getPointerToGlobalNative : EE:nativeint * Global:nativeint -> nativeint
  end
namespace LLVM.Generated
  module Analysis = begin
    type VerifierFailureAction =
      |  AbortProcessAction  =  0
      |  PrintMessageAction  =  1
      |  ReturnStatusAction  =  2
    val verifyModuleNative :
      M:nativeint * Action:int * OutMessage:nativeint -> bool
    val verifyFunctionNative : Fn:nativeint * Action:int -> bool
    val verifyFunction :
      _Fn:Core.ValueRef -> _Action:VerifierFailureAction -> bool
    val viewFunctionCFGNative : Fn:nativeint -> unit
    val viewFunctionCFG : _Fn:Core.ValueRef -> unit
    val viewFunctionCFGOnlyNative : Fn:nativeint -> unit
    val viewFunctionCFGOnly : _Fn:Core.ValueRef -> unit
  end
namespace LLVM.Generated.Transforms
  module Scalar = begin
    val addAggressiveDCEPassNative : PM:nativeint -> unit
    val addAggressiveDCEPass : _PM:Core.PassManagerRef -> unit
    val addCFGSimplificationPassNative : PM:nativeint -> unit
    val addCFGSimplificationPass : _PM:Core.PassManagerRef -> unit
    val addDeadStoreEliminationPassNative : PM:nativeint -> unit
    val addDeadStoreEliminationPass : _PM:Core.PassManagerRef -> unit
    val addGVNPassNative : PM:nativeint -> unit
    val addGVNPass : _PM:Core.PassManagerRef -> unit
    val addIndVarSimplifyPassNative : PM:nativeint -> unit
    val addIndVarSimplifyPass : _PM:Core.PassManagerRef -> unit
    val addInstructionCombiningPassNative : PM:nativeint -> unit
    val addInstructionCombiningPass : _PM:Core.PassManagerRef -> unit
    val addJumpThreadingPassNative : PM:nativeint -> unit
    val addJumpThreadingPass : _PM:Core.PassManagerRef -> unit
    val addLICMPassNative : PM:nativeint -> unit
    val addLICMPass : _PM:Core.PassManagerRef -> unit
    val addLoopDeletionPassNative : PM:nativeint -> unit
    val addLoopDeletionPass : _PM:Core.PassManagerRef -> unit
    val addLoopIdiomPassNative : PM:nativeint -> unit
    val addLoopIdiomPass : _PM:Core.PassManagerRef -> unit
    val addLoopRotatePassNative : PM:nativeint -> unit
    val addLoopRotatePass : _PM:Core.PassManagerRef -> unit
    val addLoopUnrollPassNative : PM:nativeint -> unit
    val addLoopUnrollPass : _PM:Core.PassManagerRef -> unit
    val addLoopUnswitchPassNative : PM:nativeint -> unit
    val addLoopUnswitchPass : _PM:Core.PassManagerRef -> unit
    val addMemCpyOptPassNative : PM:nativeint -> unit
    val addMemCpyOptPass : _PM:Core.PassManagerRef -> unit
    val addPromoteMemoryToRegisterPassNative : PM:nativeint -> unit
    val addPromoteMemoryToRegisterPass : _PM:Core.PassManagerRef -> unit
    val addReassociatePassNative : PM:nativeint -> unit
    val addReassociatePass : _PM:Core.PassManagerRef -> unit
    val addSCCPPassNative : PM:nativeint -> unit
    val addSCCPPass : _PM:Core.PassManagerRef -> unit
    val addScalarReplAggregatesPassNative : PM:nativeint -> unit
    val addScalarReplAggregatesPass : _PM:Core.PassManagerRef -> unit
    val addScalarReplAggregatesPassSSANative : PM:nativeint -> unit
    val addScalarReplAggregatesPassSSA : _PM:Core.PassManagerRef -> unit
    val addScalarReplAggregatesPassWithThresholdNative :
      PM:nativeint * Threshold:int -> unit
    val addScalarReplAggregatesPassWithThreshold :
      _PM:Core.PassManagerRef -> _Threshold:int -> unit
    val addSimplifyLibCallsPassNative : PM:nativeint -> unit
    val addSimplifyLibCallsPass : _PM:Core.PassManagerRef -> unit
    val addTailCallEliminationPassNative : PM:nativeint -> unit
    val addTailCallEliminationPass : _PM:Core.PassManagerRef -> unit
    val addConstantPropagationPassNative : PM:nativeint -> unit
    val addConstantPropagationPass : _PM:Core.PassManagerRef -> unit
    val addDemoteMemoryToRegisterPassNative : PM:nativeint -> unit
    val addDemoteMemoryToRegisterPass : _PM:Core.PassManagerRef -> unit
    val addVerifierPassNative : PM:nativeint -> unit
    val addVerifierPass : _PM:Core.PassManagerRef -> unit
    val addCorrelatedValuePropagationPassNative : PM:nativeint -> unit
    val addCorrelatedValuePropagationPass : _PM:Core.PassManagerRef -> unit
    val addEarlyCSEPassNative : PM:nativeint -> unit
    val addEarlyCSEPass : _PM:Core.PassManagerRef -> unit
    val addLowerExpectIntrinsicPassNative : PM:nativeint -> unit
    val addLowerExpectIntrinsicPass : _PM:Core.PassManagerRef -> unit
    val addTypeBasedAliasAnalysisPassNative : PM:nativeint -> unit
    val addTypeBasedAliasAnalysisPass : _PM:Core.PassManagerRef -> unit
    val addBasicAliasAnalysisPassNative : PM:nativeint -> unit
    val addBasicAliasAnalysisPass : _PM:Core.PassManagerRef -> unit
  end
namespace LLVM.Generated.Transforms
  module IPO = begin
    val addArgumentPromotionPassNative : PM:nativeint -> unit
    val addArgumentPromotionPass : _PM:Core.PassManagerRef -> unit
    val addConstantMergePassNative : PM:nativeint -> unit
    val addConstantMergePass : _PM:Core.PassManagerRef -> unit
    val addDeadArgEliminationPassNative : PM:nativeint -> unit
    val addDeadArgEliminationPass : _PM:Core.PassManagerRef -> unit
    val addFunctionAttrsPassNative : PM:nativeint -> unit
    val addFunctionAttrsPass : _PM:Core.PassManagerRef -> unit
    val addFunctionInliningPassNative : PM:nativeint -> unit
    val addFunctionInliningPass : _PM:Core.PassManagerRef -> unit
    val addAlwaysInlinerPassNative : PM:nativeint -> unit
    val addAlwaysInlinerPass : _PM:Core.PassManagerRef -> unit
    val addGlobalDCEPassNative : PM:nativeint -> unit
    val addGlobalDCEPass : _PM:Core.PassManagerRef -> unit
    val addGlobalOptimizerPassNative : PM:nativeint -> unit
    val addGlobalOptimizerPass : _PM:Core.PassManagerRef -> unit
    val addIPConstantPropagationPassNative : PM:nativeint -> unit
    val addIPConstantPropagationPass : _PM:Core.PassManagerRef -> unit
    val addPruneEHPassNative : PM:nativeint -> unit
    val addPruneEHPass : _PM:Core.PassManagerRef -> unit
    val addIPSCCPPassNative : PM:nativeint -> unit
    val addIPSCCPPass : _PM:Core.PassManagerRef -> unit
    val addInternalizePassNative : arg0:nativeint * AllButMain:uint32 -> unit
    val addInternalizePass :
      _arg0:Core.PassManagerRef -> _AllButMain:uint32 -> unit
    val addStripDeadPrototypesPassNative : PM:nativeint -> unit
    val addStripDeadPrototypesPass : _PM:Core.PassManagerRef -> unit
    val addStripSymbolsPassNative : PM:nativeint -> unit
    val addStripSymbolsPass : _PM:Core.PassManagerRef -> unit
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
      retTy:Generated.Core.TypeRef ->
        paramTys:Generated.Core.TypeRef array -> Generated.Core.TypeRef
    val functionType :
      retTy:Generated.Core.TypeRef ->
        paramTys:Generated.Core.TypeRef array -> Generated.Core.TypeRef
    val getBasicBlocks :
      f:Generated.Core.ValueRef -> Generated.Core.BasicBlockRef list
    val buildCall :
      bld:Generated.Core.BuilderRef ->
        func:Generated.Core.ValueRef ->
          args:Generated.Core.ValueRef array ->
            name:string -> Generated.Core.ValueRef
    val addIncoming :
      phi:Generated.Core.ValueRef ->
        incoming:(Generated.Core.ValueRef * Generated.Core.BasicBlockRef) array ->
          unit
    val getNamedFunction :
      modRef:Generated.Core.ModuleRef -> name:string -> Generated.Core.ValueRef
    val optValueRef :
      vr:Generated.Core.ValueRef -> Generated.Core.ValueRef option
    val tryGetNamedFunction :
      modRef:Generated.Core.ModuleRef ->
        name:string -> Generated.Core.ValueRef option
    val getParams : func:Generated.Core.ValueRef -> Generated.Core.ValueRef []
    val getParamTypes :
      funcTy:Generated.Core.TypeRef -> Generated.Core.TypeRef []
    val buildSwitchWithCases :
      bldr:Generated.Core.BuilderRef ->
        testVal:Generated.Core.ValueRef ->
          cases:(Generated.Core.ValueRef * Generated.Core.BasicBlockRef) array ->
            defaultCase:Generated.Core.BasicBlockRef -> unit
    val structTypeInContext :
      ctxt:Generated.Core.ContextRef ->
        elemTys:Generated.Core.TypeRef array ->
          packed:bool -> Generated.Core.TypeRef
    val structType :
      elemTys:Generated.Core.TypeRef array ->
        packed:bool -> Generated.Core.TypeRef
    val buildGEP :
      bldr:Generated.Core.BuilderRef ->
        ptr:Generated.Core.ValueRef ->
          indices:Generated.Core.ValueRef array ->
            name:string -> Generated.Core.ValueRef
    val structSetBody :
      structTy:Generated.Core.TypeRef ->
        elemTys:Generated.Core.TypeRef array -> packed:bool -> unit
    val getStructElementTypes :
      structTy:Generated.Core.TypeRef -> Generated.Core.TypeRef []
    val createMemoryBufferWithContentsOfFile :
      path:string -> Generated.Core.MemoryBufferRef
    val mdNode : vals:Generated.Core.ValueRef array -> Generated.Core.ValueRef
    val mdNodeInContext :
      ctxt:Generated.Core.ContextRef ->
        vals:Generated.Core.ValueRef array -> Generated.Core.ValueRef
    val constInt1 : b:bool -> Generated.Core.ValueRef
    val constUInt8 : i:uint8 -> Generated.Core.ValueRef
    val constInt8 : i:int8 -> Generated.Core.ValueRef
    val constUInt16 : i:uint16 -> Generated.Core.ValueRef
    val constInt16 : i:int16 -> Generated.Core.ValueRef
    val constUInt32 : i:uint32 -> Generated.Core.ValueRef
    val constInt32 : i:int32 -> Generated.Core.ValueRef
    val constUInt64 : i:uint64 -> Generated.Core.ValueRef
    val constInt64 : i:int64 -> Generated.Core.ValueRef
    val constFloat : f:float32 -> Generated.Core.ValueRef
    val constDouble : d:double -> Generated.Core.ValueRef
    val constArray :
      elemTy:Generated.Core.TypeRef ->
        constVals:Generated.Core.ValueRef array -> Generated.Core.ValueRef
    val constStruct :
      constVals:Generated.Core.ValueRef array ->
        packed:bool -> Generated.Core.ValueRef
    val constStructInContext :
      c:Generated.Core.ContextRef ->
        constVals:Generated.Core.ValueRef array ->
          packed:bool -> Generated.Core.ValueRef
    val constNamedStruct :
      structTy:Generated.Core.TypeRef ->
        constVals:Generated.Core.ValueRef array -> Generated.Core.ValueRef
  end

namespace LLVM
  module BitReader = begin
    val parseBitcode :
      memBuf:Generated.Core.MemoryBufferRef -> Generated.Core.ModuleRef
  end

namespace LLVM
  module ExecutionEngine = begin
    val runFunction :
      ee:Generated.ExecutionEngine.ExecutionEngineRef ->
        func:Generated.Core.ValueRef ->
          args:Generated.ExecutionEngine.GenericValueRef array ->
            Generated.ExecutionEngine.GenericValueRef
    val private createEngineForModuleFromNativeFunc :
      nativeFunc:(nativeint * nativeint * nativeint -> bool) ->
        moduleRef:Generated.Core.ModuleRef ->
          Generated.ExecutionEngine.ExecutionEngineRef
    val createExecutionEngineForModule :
      modRef:Generated.Core.ModuleRef ->
        Generated.ExecutionEngine.ExecutionEngineRef
    val createInterpreterForModule :
      modRef:Generated.Core.ModuleRef ->
        Generated.ExecutionEngine.ExecutionEngineRef
    val createJITCompilerForModule :
      modRef:Generated.Core.ModuleRef ->
        optLvl:uint32 -> Generated.ExecutionEngine.ExecutionEngineRef
  end

namespace LLVM
  module Extra = begin
    val private typeToStringBuilder :
      modRef:Generated.Core.ModuleRef ->
        tyRef:Generated.Core.TypeRef -> System.Text.StringBuilder
    val typeToString :
      modRef:Generated.Core.ModuleRef -> tyRef:Generated.Core.TypeRef -> string
    val buildCopy :
      moduleRef:Generated.Core.ModuleRef ->
        bldr:Generated.Core.BuilderRef ->
          dest:Generated.Core.ValueRef ->
            src:Generated.Core.ValueRef -> isVolatile:bool -> unit
  end

namespace LLVM
  module Target = begin
    val initializeX86TargetInfoNative : unit -> unit
    val initializeX86TargetNative : unit -> unit
    val initializeX86TargetMCNative : unit -> unit
    val initializeX86Target : unit -> unit
  end

