namespace LLVM.Intrinsic

module LGC = LLVM.Generated.Core
module LC = LLVM.Core

module private Common =
    let addOrGetNamedFunction (modRef:LGC.ModuleRef) (fnName:string) (funTy:Lazy<LGC.TypeRef>) =
        let funVal = LGC.getNamedFunction modRef fnName
        if funVal.Ptr <> 0n then
            funVal
        else
            LGC.addFunction modRef fnName funTy.Value

    let buildSingleArgFloatFun
            (modRef:LGC.ModuleRef)
            (bldr:LGC.BuilderRef)
            (fnName:string)
            (arg:LGC.ValueRef)
            (valName:string) =
        let fnTy = lazy (LC.functionType (LGC.floatType()) [|LGC.floatType()|])
        let fn = addOrGetNamedFunction modRef fnName fnTy
        LC.buildCall bldr fn [|arg|] valName

    let buildSingleArgDoubleFun
            (modRef:LGC.ModuleRef)
            (bldr:LGC.BuilderRef)
            (fnName:string)
            (arg:LGC.ValueRef)
            (valName:string) =
        let fnTy = lazy (LC.functionType (LGC.doubleType()) [|LGC.doubleType()|])
        let fn = addOrGetNamedFunction modRef fnName fnTy
        LC.buildCall bldr fn [|arg|] valName


module StdCLib =
    // build call to intrinsic:
    // declare float     @llvm.sqrt.f32(float %Val)
    let buildSqrtF32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) : LGC.ValueRef =
        Common.buildSingleArgFloatFun modRef bldr "llvm.sqrt.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.sqrt.f64(double %Val)
    let buildSqrtF64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) : LGC.ValueRef =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.sqrt.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.powi.f32(float  %Val, i32 %power)
    let buildPowiF32
            (modRef:LGC.ModuleRef)
            (bldr:LGC.BuilderRef)
            (valArg:LGC.ValueRef)
            (powArg:LGC.ValueRef)
            (name:string)
            : LGC.ValueRef =
        let fnTy = lazy (LC.functionType (LGC.floatType()) [|LGC.floatType(); LGC.int32Type()|])
        let fn = Common.addOrGetNamedFunction modRef "llvm.powi.f32" fnTy
        LC.buildCall bldr fn [|valArg; powArg|] name

    // build call to intrinsic:
    // declare double    @llvm.powi.f64(double %Val, i32 %power)
    let buildPowiF64
            (modRef:LGC.ModuleRef)
            (bldr:LGC.BuilderRef)
            (valArg:LGC.ValueRef)
            (powArg:LGC.ValueRef)
            (name:string)
            : LGC.ValueRef =
        let fnTy = lazy (LC.functionType (LGC.doubleType()) [|LGC.doubleType(); LGC.int32Type()|])
        let fn = Common.addOrGetNamedFunction modRef "llvm.powi.f64" fnTy
        LC.buildCall bldr fn [|valArg; powArg|] name

    // build call to intrinsic:
    // declare float     @llvm.sin.f32(float  %Val)
    let buildSinF32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.sin.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.sin.f64(double %Val)
    let buildSinF64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.sin.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.cos.f32(float  %Val)
    let buildCosF32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.cos.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.cos.f64(double %Val)
    let buildCosF64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.cos.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.pow.f32(float  %Val, float %Power)
    let buildPowF32
            (modRef:LGC.ModuleRef)
            (bldr:LGC.BuilderRef)
            (valArg:LGC.ValueRef)
            (powArg:LGC.ValueRef)
            (name:string)
            : LGC.ValueRef =
        let fnTy = lazy (LC.functionType (LGC.floatType()) [|LGC.floatType(); LGC.floatType()|])
        let fn = Common.addOrGetNamedFunction modRef "llvm.pow.f32" fnTy
        LC.buildCall bldr fn [|valArg; powArg|] name

    // build call to intrinsic:
    // declare double    @llvm.pow.f64(double %Val, double %Power)
    let buildPowF64
            (modRef:LGC.ModuleRef)
            (bldr:LGC.BuilderRef)
            (valArg:LGC.ValueRef)
            (powArg:LGC.ValueRef)
            (name:string)
            : LGC.ValueRef =
        let fnTy = lazy (LC.functionType (LGC.doubleType()) [|LGC.doubleType(); LGC.doubleType()|])
        let fn = Common.addOrGetNamedFunction modRef "llvm.pow.f64" fnTy
        LC.buildCall bldr fn [|valArg; powArg|] name

    // build call to intrinsic:
    // declare float     @llvm.exp.f32(float  %Val)
    let buildExpF32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.exp.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.exp.f64(double %Val)
    let buildExpF64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.exp.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.exp2.f32(float  %Val)
    let buildExp2F32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.exp2.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.exp2.f64(double %Val)
    let buildExp2F64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.exp2.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.log.f32(float  %Val)
    let buildlogF32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.log.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.log.f64(double %Val)
    let buildLogF64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.log.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.log10.f32(float  %Val)
    let buildLog10F32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.log10.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.log10.f64(double %Val)
    let buildLog10F64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.log10.f64" arg name

    // build call to intrinsic:
    // declare float     @llvm.log2.f32(float  %Val)
    let buildLog2F32 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgFloatFun modRef bldr "llvm.log2.f32" arg name

    // build call to intrinsic:
    // declare double    @llvm.log2.f64(double %Val)
    let buildLog2F64 (modRef:LGC.ModuleRef) (bldr:LGC.BuilderRef) (arg:LGC.ValueRef) (name:string) =
        Common.buildSingleArgDoubleFun modRef bldr "llvm.log2.f64" arg name
