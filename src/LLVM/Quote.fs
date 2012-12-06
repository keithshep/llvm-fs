module LLVM.Quote

open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Quotations.DerivedPatterns

module LGC = LLVM.Generated.Core
module LC = LLVM.Core

let private onlyForQuotations() =
    failwith "this function is only meant to be used within a quotation"

let private typesGenEq (ty1:System.Type) (ty2:System.Type) =
    let genTy (ty:System.Type) =
        if ty.IsGenericType then
            ty.GetGenericTypeDefinition()
        else
            ty

    genTy ty1 = genTy ty2

type [<AbstractClass>] RawArray<'a> =
    abstract Item : int -> 'a with get, set
    static member HeapAlloc (size:int) : RawArray<'a> = onlyForQuotations()
    static member StackAlloc (size:int) : RawArray<'a> = onlyForQuotations()

let free (heapAllocated:'a) = onlyForQuotations()

type Def = {
    funVar : Var
    funParams : Var list
    body : Expr
}

type LetDef =
    | LetDef of Def
    | LetRecDefs of Def list

let rec lambdas (expr:Expr) =
    match expr with
    | Lambda (var, expr) ->
        let varTail, expr = lambdas expr
        var :: varTail, expr
    | _ ->
        [], expr

let allLetFuncDefs (expr:Expr) : LetDef list * Expr =
    let rec go expr =
        let next (letDef:LetDef) (remExpr:Expr) =
            let letDefTail, remExpr = go remExpr
            letDef :: letDefTail, remExpr
        match expr with
        | Let (funId, defExpr, remExpr) ->
            let vars, body = lambdas defExpr
            next (LetDef {Def.funVar=funId; funParams=vars; body=body}) remExpr
        | LetRecursive (funList, remExpr) ->
            let makeFun (var:Var, expr:Expr) =
                let funParams, body = lambdas expr
                {Def.funVar=var; funParams=funParams; body=body}
            next (LetRecDefs (List.map makeFun funList)) remExpr
        | _ ->
            [], expr

    go expr

let uInt32Ty = typeof<System.UInt32>
let int32Ty = typeof<System.Int32>
let uInt16Ty = typeof<System.UInt16>
let int16Ty = typeof<System.Int16>
let uInt8Ty = typeof<System.Byte>
let int8Ty = typeof<System.SByte>

let (|UnitTy|_|) (ty:System.Type) =
    if ty = typeof<unit> then Some UnitTy else None

let (|BoolTy|_|) (ty:System.Type) =
    if ty = typeof<bool> then Some BoolTy else None

let (|SingleTy|_|) (ty:System.Type) =
    if ty = typeof<single> then Some SingleTy else None
let (|DoubleTy|_|) (ty:System.Type) =
    if ty = typeof<double> then Some DoubleTy else None

let (|Int8Ty|_|) (ty:System.Type) =
    if ty = typeof<int8> then Some Int8Ty else None
let (|UInt8Ty|_|) (ty:System.Type) =
    if ty = typeof<uint8> then Some UInt8Ty else None
let (|Int16Ty|_|) (ty:System.Type) =
    if ty = typeof<int16> then Some Int16Ty else None
let (|UInt16Ty|_|) (ty:System.Type) =
    if ty = typeof<uint16> then Some UInt16Ty else None
let (|Int32Ty|_|) (ty:System.Type) =
    if ty = typeof<int32> then Some Int32Ty else None
let (|UInt32Ty|_|) (ty:System.Type) =
    if ty = typeof<uint32> then Some UInt32Ty else None
let (|Int64Ty|_|) (ty:System.Type) =
    if ty = typeof<int64> then Some Int64Ty else None
let (|UInt64Ty|_|) (ty:System.Type) =
    if ty = typeof<uint64> then Some UInt64Ty else None

let (|AnySIntTy|_|) (ty:System.Type) =
    match ty with
    | Int64Ty _ | Int32Ty _ | Int16Ty _ | Int8Ty _ -> Some AnySIntTy
    | _ -> None
let (|AnyUIntTy|_|) (ty:System.Type) =
    match ty with
    | UInt64Ty _ | UInt32Ty _ | UInt16Ty _ | UInt8Ty _ -> Some AnyUIntTy
    | _ -> None
let (|AnyIntTy|_|) (ty:System.Type) =
    match ty with
    | AnySIntTy _ | AnyUIntTy _ -> Some AnyIntTy
    | _ -> None
let (|AnyFloatTy|_|) (ty:System.Type) =
    match ty with
    | DoubleTy _ | SingleTy _ -> Some AnyFloatTy
    | _ -> None

let (|ArrayTy|_|) (ty:System.Type) =
    if typesGenEq ty typeof<RawArray<_>> then
        Some <| ArrayTy (ty.GetGenericArguments().[0])
    else
        None

let (|TupleTy|_|) (ty:System.Type) =
    let sysTupTys = [|
        typeof<System.Tuple<_>>
        typeof<System.Tuple<_, _>>
        typeof<System.Tuple<_, _, _>>
        typeof<System.Tuple<_, _, _, _>>
        typeof<System.Tuple<_, _, _, _, _>>
        typeof<System.Tuple<_, _, _, _, _, _>>
        typeof<System.Tuple<_, _, _, _, _, _, _>>
        typeof<System.Tuple<_, _, _, _, _, _, _, _>>
    |]

    let rec anyMatch (i:int) =
        if i >= sysTupTys.Length then
            false
        elif typesGenEq ty sysTupTys.[i] then
            true
        else
            anyMatch (i + 1)

    if anyMatch 0 then
        Some (TupleTy (ty.GetGenericArguments()))
    else
        None

let rec allocableLLVMTyOf (ty:System.Type) : LGC.TypeRef =
    match ty with
    | TupleTy elemTys -> LC.structType (Array.map llvmTyOf elemTys) false
    | _ -> failwithf "No support for type %A" ty
and llvmTyOf (ty:System.Type) : LGC.TypeRef =
    match ty with
    | Int32Ty | UInt32Ty -> LGC.int32Type()
    | Int16Ty | UInt16Ty -> LGC.int16Type()
    | Int8Ty | UInt8Ty -> LGC.int8Type()
    | BoolTy -> LGC.int1Type()
    | UnitTy -> LGC.voidType()
    | ArrayTy elemTy -> LGC.pointerType (llvmTyOf elemTy) 0u
    | _ -> LGC.pointerType (allocableLLVMTyOf ty) 0u
let llvmTyOfVar (var:Var) : LGC.TypeRef = llvmTyOf var.Type
let llvmTyOfExpr (expr:Expr) : LGC.TypeRef = llvmTyOf expr.Type

(*
// this can be used for dynamically sized arrays
let buildBitcastMalloc (bldr:LC.Builder) (ty:LGC.TypeRef) (bytesVal:LGC.ValueRef) =
    let mallocVal = LGC.buildArrayMalloc bldr (LGC.int8Type()) bytesVal ""
    LGC.buildBitCast bldr mallocVal ty ""
*)

let isUnitExpr (expr:Expr) : bool = expr.Type = typeof<unit>

let llvmFunTyOf (def:Def) : LGC.TypeRef =
    if def.funParams.IsEmpty then
        failwithf "top level definitions should be a function but \"%A\" is not" id
    
    let llvmRetTy = llvmTyOfExpr def.body
    match [|for p in def.funParams -> p.Type|] with
    | [|UnitTy|] -> LC.functionType llvmRetTy [||]
    | paramSysTys ->
        for t in paramSysTys do
            if t = typeof<unit> then
                failwithf "error: %s function uses unit parameter(s) which is not supported" def.funVar.Name
        let llvmParamTys = List.map llvmTyOfVar def.funParams |> Array.ofList
        LC.functionType llvmRetTy llvmParamTys

let declareFunction (moduleRef:LGC.ModuleRef) (def:Def) : LGC.ValueRef =
    LGC.addFunction moduleRef def.funVar.Name (llvmFunTyOf def)

let (|FullAppl|_|) (expr:Expr) =
    let rec go expr =
        match expr with
        | Application (f, x) ->
            match go f with
            | Some (g, xs) -> Some (g, x :: xs)
            | None -> Some (f, [x])
        | _ ->
            None

    match go expr with
    | None -> None
    | Some (f, xs) -> Some (FullAppl (f, List.rev xs))

let implementFunction (modRef:LGC.ModuleRef) (valMap:Map<string, LGC.ValueRef>) (fnVal:LGC.ValueRef) (fnDef:Def) : unit =
    
    let entryBlock = LGC.appendBasicBlock fnVal "entry"
    use entryBldr = new LC.Builder(entryBlock)

    // add all of the args to valMap
    let valMap = ref valMap
    fnDef.funParams |> List.iteri (
        fun i p ->
            if p.IsMutable then
                failwithf "error in function %s: mutable parameters are not supported" fnDef.funVar.Name
            valMap := (!valMap).Add(p.Name, LGC.getParam fnVal (uint32 i))
    )

    let rec implementExprs
            (bb:LGC.BasicBlockRef)
            (valMap:Map<string, LGC.ValueRef>)
            (exprs:Expr list)
            : list<LGC.ValueRef> * LGC.BasicBlockRef =
        let bb = ref bb
        let argVals = [
            for expr in exprs ->
                let xVal, newBB = implementSomeExpr !bb valMap expr
                bb := newBB
                xVal
        ]

        argVals, !bb
    and implementSomeExpr
            (bb:LGC.BasicBlockRef)
            (valMap:Map<string, LGC.ValueRef>)
            (expr:Expr)
            : LGC.ValueRef * LGC.BasicBlockRef =
        match implementExpr bb valMap expr with
        | None, _ -> failwith "internal error: expression unexpectedly evaluated as unit"
        | Some exprVal, bb ->
            exprVal, bb
    and implementExpr
            (bb:LGC.BasicBlockRef)
            (valMap:Map<string, LGC.ValueRef>)
            (expr:Expr)
            : LGC.ValueRef option * LGC.BasicBlockRef =

        let noImpl() =
            match expr with
            | Call (_, methInfo, _) ->
                failwithf
                    "error in function %s: call to %s.%s not supported. The full expression is: %A"
                    fnDef.funVar.Name
                    methInfo.DeclaringType.FullName
                    methInfo.Name
                    expr
            | _ ->
                failwithf "error in function %s: expression type not supported %A" fnDef.funVar.Name expr

        let implBinOp llvmBinOp lhsExpr rhsExpr : LGC.ValueRef option * LGC.BasicBlockRef =
            let lhsVal, bb = implementSomeExpr bb valMap lhsExpr
            let rhsVal, bb = implementSomeExpr bb valMap rhsExpr
            let eqVal = llvmBinOp lhsVal rhsVal

            Some eqVal, bb

        match expr with
        | Sequential (expr1, expr2) ->
            let _, bb = implementExpr bb valMap expr1
            implementExpr bb valMap expr2
        | Let (var, expr1, expr2) ->
            match implementExpr bb valMap expr1 with
            | None, _ ->
                failwithf
                    "error in function %s for variable %s: unit let-bound expressions are not supported"
                    fnDef.funVar.Name
                    var.Name
            | Some expr1Val, bb ->
                let letVal =
                    if var.IsMutable then
                        let alloca = LGC.buildAlloca entryBldr (llvmTyOfVar var) var.Name
                        use bldr = new LC.Builder(bb)
                        LGC.buildStore bldr expr1Val alloca |> ignore
                        alloca
                    else
                        LGC.setValueName expr1Val var.Name
                        expr1Val
                implementExpr bb (valMap.Add(var.Name, letVal)) expr2
        | IfThenElse (ifExpr, thenExpr, elseExpr) ->
            let ifVal, ifBB = implementExpr bb valMap ifExpr

            match ifVal with
            | None -> failwith "internal error: unexpected None in \"if value\""
            | Some ifVal ->
                let thenBB = LGC.appendBasicBlock fnVal "then"
                let elseBB = LGC.appendBasicBlock fnVal "else"
                use ifBldr = new LC.Builder(ifBB)
                LGC.buildCondBr ifBldr ifVal thenBB elseBB |> ignore

                let thenVal, thenBB = implementExpr thenBB valMap thenExpr
                let elseVal, elseBB = implementExpr elseBB valMap elseExpr

                let ifElseJoinBlock = LGC.appendBasicBlock fnVal "ifElseJoin"
                use thenBldr = new LC.Builder(thenBB)
                LGC.buildBr thenBldr ifElseJoinBlock |> ignore
                use elseBldr = new LC.Builder(elseBB)
                LGC.buildBr elseBldr ifElseJoinBlock |> ignore

                match thenVal, elseVal with
                | None, None ->
                    None, ifElseJoinBlock
                | Some thenVal, Some elseVal ->
                    use ifElseJoinBldr = new LC.Builder(ifElseJoinBlock)
                    let ifElsePhi =
                        LC.buildPhiWithIncoming
                            ifElseJoinBldr
                            (llvmTyOfExpr expr)
                            [|thenVal, thenBB; elseVal, elseBB|]
                            "ifElsePhi"
                    Some ifElsePhi, ifElseJoinBlock
                | _ ->
                    failwith "internal error: if/else types don't agree"
        | WhileLoop (condExpr, bodyExpr) ->
            use bldr = new LC.Builder(bb)
            let whileCondBB = LGC.appendBasicBlock fnVal "whileCondition"
            LGC.buildBr bldr whileCondBB |> ignore
            match implementExpr whileCondBB valMap condExpr with
            | None, _ -> failwith "internal error: while condition evaluated as unit"
            | Some contLoopVal, whileCondBB ->
                use bldr = new LC.Builder(whileCondBB)
                let whileBodyBB = LGC.appendBasicBlock fnVal "whileBody"
                let loopBreakBB = LGC.appendBasicBlock fnVal "loopExit"
                LGC.buildCondBr bldr contLoopVal whileBodyBB loopBreakBB |> ignore
                let _, whileBodyBB = implementExpr whileBodyBB valMap bodyExpr
                use bldr = new LC.Builder(whileBodyBB)
                LGC.buildBr bldr whileCondBB |> ignore

                None, loopBreakBB
        | ForIntegerRangeLoop (iVar, startExpr, endExpr, bodyExpr) ->
            match implementExpr bb valMap startExpr with
            | None, _ -> failwith "internal error: for loop iterator evaluated to unit"
            | Some startVal, bb ->
                // create the iterator value
                LGC.setValueName startVal iVar.Name
                let iAlloca = LGC.buildAlloca entryBldr (llvmTyOfVar iVar) iVar.Name
                use bldr = new LC.Builder(bb)
                LGC.buildStore bldr startVal iAlloca |> ignore

                // create the end value
                match implementExpr bb valMap endExpr with
                | None, _ -> failwith "internal error: for loop limit expression evaluated to unit"
                | Some endVal, bb ->

                    // the for loop test block
                    let forTestBB = LGC.appendBasicBlock fnVal "forTest"
                    use bldr = new LC.Builder(bb)
                    LGC.buildBr bldr forTestBB |> ignore
                    use forTestBldr = new LC.Builder(forTestBB)
                    let currVal = LGC.buildLoad forTestBldr iAlloca iVar.Name
                    let forBB = LGC.appendBasicBlock fnVal "forBody"
                    let loopBreakBB = LGC.appendBasicBlock fnVal "loopExit"
                    let contLoopVal = LGC.buildICmp forTestBldr LGC.IntPredicate.IntSLE currVal endVal "contLoop"
                    LGC.buildCondBr forTestBldr contLoopVal forBB loopBreakBB |> ignore

                    // create the body of the loop
                    use forBldr = new LC.Builder(forBB)
                    let valMap = valMap.Add(iVar.Name, currVal)
                    let _, forBB = implementExpr forBB valMap bodyExpr

                    // increment the var and break to for test block
                    use forBldr = new LC.Builder(forBB)
                    let incVal = LGC.buildAdd forBldr currVal (LC.constInt32 1) (iVar.Name + "Incr")
                    LGC.buildStore forBldr incVal iAlloca |> ignore
                    LGC.buildBr forBldr forTestBB |> ignore

                    None, loopBreakBB
        | Var v ->
            let valRef = valMap.[v.Name]
            if v.IsMutable then
                use bldr = new LC.Builder(bb)
                Some (LGC.buildLoad bldr valRef v.Name), bb
            else
                Some valRef, bb
        | VarSet (v, expr) ->
            match implementExpr bb valMap expr with
            | None, _ ->
                failwithf
                    "error in function %s: unit type not supported as a first class value"
                    fnDef.funVar.Name
            | Some valToSet, bb ->
                use bldr = new LC.Builder(bb)
                LGC.buildStore bldr valToSet valMap.[v.Name] |> ignore
                None, bb
        | Value (v, ty) ->
            let valVal =
                match v with
                | :? bool as v -> LC.constInt1 v
                | :? int8 as v -> LC.constInt8 v
                | :? uint8 as v -> LC.constUInt8 v
                | :? int16 as v -> LC.constInt16 v
                | :? uint16 as v -> LC.constUInt16 v
                | :? int32 as v -> LC.constInt32 v
                | :? uint32 as v -> LC.constUInt32 v
                | _ -> failwithf "error in function %s: type %A not supported" fnDef.funVar.Name ty
            Some valVal, bb
        | SpecificCall <@@ (-) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnyIntTy, AnyIntTy ->
                    fun lhs rhs -> LGC.buildSub bldr lhs rhs "tempSub"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFSub bldr lhs rhs "tempFSub"
                | _ ->
                    failwith "internal error: bad args for (-)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (=) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnyIntTy, AnyIntTy ->
                    fun lhs rhs -> LGC.buildICmp bldr LGC.IntPredicate.IntEQ lhs rhs "tempEq"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFCmp bldr LGC.RealPredicate.RealOEQ lhs rhs "tempFEq"
                | _ ->
                    failwith "internal error: bad args for (=)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (>) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnySIntTy, AnySIntTy ->
                    fun lhs rhs -> LGC.buildICmp bldr LGC.IntPredicate.IntSGT lhs rhs "tempSGT"
                | AnyUIntTy, AnyUIntTy ->
                    fun lhs rhs -> LGC.buildICmp bldr LGC.IntPredicate.IntUGT lhs rhs "tempUGT"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFCmp bldr LGC.RealPredicate.RealOGT lhs rhs "tempFGT"
                | _ ->
                    failwith "internal error: bad args for (>)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (<) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnySIntTy, AnySIntTy ->
                    fun lhs rhs -> LGC.buildICmp bldr LGC.IntPredicate.IntSLT lhs rhs "tempSLT"
                | AnyUIntTy, AnyUIntTy ->
                    fun lhs rhs -> LGC.buildICmp bldr LGC.IntPredicate.IntULT lhs rhs "tempULT"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFCmp bldr LGC.RealPredicate.RealOLT lhs rhs "tempFLT"
                | _ ->
                    failwith "internal error: bad args for (<)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (+) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnyIntTy, AnyIntTy ->
                    fun lhs rhs -> LGC.buildAdd bldr lhs rhs "tempAdd"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFAdd bldr lhs rhs "tempFAdd"
                | _ ->
                    failwith "internal error: bad args for (+)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (*) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnyIntTy, AnyIntTy ->
                    fun lhs rhs -> LGC.buildMul bldr lhs rhs "tempSMul"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFMul bldr lhs rhs "tempFMul"
                | _ ->
                    failwith "internal error: bad args for (*)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (/) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnySIntTy, AnySIntTy ->
                    fun lhs rhs -> LGC.buildSDiv bldr lhs rhs "tempSDiv"
                | AnyUIntTy, AnyUIntTy ->
                    fun lhs rhs -> LGC.buildUDiv bldr lhs rhs "tempUDiv"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFDiv bldr lhs rhs "tempFDiv"
                | _ ->
                    failwith "internal error: bad args for (/)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ (%) @@> (_, _, [lhsExpr; rhsExpr]) ->
            use bldr = new LC.Builder(bb)
            let binOp =
                match lhsExpr.Type, rhsExpr.Type with
                | AnySIntTy, AnySIntTy ->
                    fun lhs rhs -> LGC.buildSRem bldr lhs rhs "tempSRem"
                | AnyUIntTy, AnyUIntTy ->
                    fun lhs rhs -> LGC.buildURem bldr lhs rhs "tempURem"
                | AnyFloatTy, AnyFloatTy ->
                    fun lhs rhs -> LGC.buildFRem bldr lhs rhs "tempFRem"
                | _ ->
                    failwith "internal error: bad args for (>)"
            implBinOp binOp lhsExpr rhsExpr
        | SpecificCall <@@ ignore @@> (_, _, [exprToIgnore]) ->
            let _, bb = implementExpr bb valMap exprToIgnore
            None, bb
        | SpecificCall <@@ free @@> (_, _, [exprToFree]) ->
            match implementExpr bb valMap exprToFree with
            | None, _ -> failwith "internal error: dealloc target evaluated as unit"
            | Some valToFree, bb ->
                use bldr = new LC.Builder(bb)
                LGC.buildFree bldr valToFree |> ignore
                None, bb
        | Call (instExpr, methInfo, argExprs) ->
            let decTy = methInfo.DeclaringType
            if typesGenEq decTy typeof<RawArray<_>> then
                match methInfo.Name, argExprs with
                | "HeapAlloc", [sizeExpr] ->
                    match implementExpr bb valMap sizeExpr with
                    | None, _ -> failwith "internal error: array size parameter evaluated as unit"
                    | Some sizeVal, bb ->
                        use bldr = new LC.Builder(bb)
                        let llvmElemTy = llvmTyOf (decTy.GetGenericArguments().[0])
                        let arr = LGC.buildArrayMalloc bldr llvmElemTy sizeVal "arr"
                        Some arr, bb
                | _ ->
                    noImpl()
            else
                noImpl()
        | PropertyGet (Some instExpr, prop, indexArgExprs) ->
            match instExpr.Type, prop.Name, indexArgExprs with
            | ArrayTy _, "Item", [iExpr] ->
                match implementExpr bb valMap instExpr with
                | None, _ -> failwith "internal error: RawArray instance evaluated as unit"
                | Some arrVal, bb ->
                    match implementExpr bb valMap iExpr with
                    | None, _ -> failwith "internal error: index param of RawArray.Item evaluated as unit"
                    | Some iVal, bb ->
                        use bldr = new LC.Builder(bb)

                        let itemAddr = LC.buildGEP bldr arrVal [|iVal|] "itemAddr"
                        let itemVal = LGC.buildLoad bldr itemAddr "itemVal"
                        Some itemVal, bb
            | _ ->
                noImpl()
        | PropertySet (Some instExpr, prop, indexArgExprs, valExpr) ->
            match instExpr.Type, prop.Name, indexArgExprs with
            | ArrayTy _, "Item", [iExpr] ->
                match implementExpr bb valMap instExpr with
                | None, _ -> failwith "internal error: RawArray instance evaluated as unit"
                | Some arrVal, bb ->
                    match implementExpr bb valMap valExpr with
                    | None, _ -> failwith "internal error: value param of RawArray.Item evaluated as unit"
                    | Some valVal, bb ->
                        match implementExpr bb valMap iExpr with
                        | None, _ -> failwith "internal error: index param of RawArray.Item evaluated as unit"
                        | Some iVal, bb ->
                            use bldr = new LC.Builder(bb)

                            let itemAddr = LC.buildGEP bldr arrVal [|iVal|] "itemAddr"
                            LGC.buildStore bldr valVal itemAddr |> ignore
                            None, bb
            | _ ->
                noImpl()
        | FullAppl (Var f, xs) ->
            let argVals, bb = implementExprs bb valMap xs
            use bldr = new LC.Builder(bb)
            let callVal = LC.buildCall bldr valMap.[f.Name] (Array.ofList argVals) (f.Name + "Result")

            Some callVal, bb
        | NewTuple exprs ->
            let llvmTupleTy = allocableLLVMTyOf expr.Type
            let tupVals, bb = implementExprs bb valMap exprs
            use bldr = new LC.Builder(bb)
            let tupleVal = LGC.buildMalloc bldr llvmTupleTy "tuple"

            tupVals |> List.iteri (
                fun i currVal ->
                    let tupItemAddr = LGC.buildStructGEP bldr tupleVal (uint32 i) ""
                    LGC.buildStore bldr currVal tupItemAddr |> ignore
            )

            Some tupleVal, bb
        | TupleGet (tupExpr, i) ->
            let tupVal, bb = implementSomeExpr bb valMap tupExpr
            use bldr = new LC.Builder(bb)
            let tupItemAddr = LGC.buildStructGEP bldr tupVal (uint32 i) ""
            let itemVal = LGC.buildLoad bldr tupItemAddr ("tupleItem" + string i)

            Some itemVal, bb
        (*
        | NewArray (elemTy, itemExprs) ->
            let llvmTy = arrayLLVMTyOf elemTy (uint32 itemExprs.Length)
            let arrSizeVal = LGC.sizeOf llvmTy
        *)
        | _ ->
            noImpl()

    let startBlock = LGC.appendBasicBlock fnVal "start"
    ignore <|
        match implementExpr startBlock !valMap fnDef.body with
        | None, bb ->
            use bldr = new LC.Builder(bb)
            LGC.buildRetVoid bldr
        | Some retVal, bb ->
            use bldr = new LC.Builder(bb)
            LGC.buildRet bldr retVal
    LGC.buildBr entryBldr startBlock |> ignore

let compileQuote (moduleRef:LGC.ModuleRef) (expr:Expr) =
    let funcDefs, endExpr = allLetFuncDefs expr
    let mutable varMap = Map.empty
    for fd in funcDefs do
        printfn "@@@@ FUNCTION GROUP @@@@"
        printfn "%A" fd

        match fd with
        | LetDef def ->
            // for non-recursive defs we bind the function variable after it's implemented                                                                 
            let fn = declareFunction moduleRef def
            implementFunction moduleRef varMap fn def
            varMap <- varMap.Add(def.funVar.Name, fn)
        | LetRecDefs defs ->
            // for recursive defs we bind the function variable before it's implemented                                                                 
            for def in defs do
                let fn = declareFunction moduleRef def
                varMap <- varMap.Add(def.funVar.Name, fn)
            for def in defs do
                implementFunction moduleRef varMap varMap.[def.funVar.Name] def

let testQuote =
    <@
        // let's start with some super-simple functions
        let isEven x = x % 2 = 0

        // simple recursion
        let rec fib = function
            | 0 -> 0
            | 1 -> 1
            | n -> fib (n - 1) + fib (n - 2)

        // mutually recursive function def
        let rec mutRecIsEven = function
            | 0u -> true
            | n  -> mutRecIsOdd (n - 1u)
        and mutRecIsOdd = function
            | 0u -> false
            | n  -> mutRecIsEven (n - 1u)

        // for loop with a mutable
        let fac x : int =
            let mutable sum = 1
            for i = 2 to x do
                sum <- sum * i
            sum

        // simple array with for loop
        let sum (xs:RawArray<int>) (size:int) : int =
            let mutable sum = 0
            for i = 0 to size - 1 do
                sum <- sum + xs.[i]
            sum

        // simple array with while loop
        let sumUsingWhile (xs:RawArray<int>) (size:int) : int =
            let mutable sum = 0
            let mutable i = 0
            while i < size do
                sum <- sum + xs.[i]
                i <- i + 1
            sum

        let sum869() : int =

            // some pointless tuple code
            let tup = (8, 6, 9)
            let x, y, z = tup
            free tup

            // build the array and call sum
            let size = 3
            let arr = RawArray<int>.HeapAlloc size
            arr.[0] <- x
            arr.[1] <- y
            arr.[2] <- z
            let result = sum arr size
            free arr

            result

        let makeArr() : RawArray<int> =

            // some pointless tuple code
            let tup = (8, 6, 9)
            let x, y, z = tup
            free tup

            // build the array and call sum
            let size = 3
            let arr = RawArray<int>.HeapAlloc size
            arr.[0] <- x
            arr.[1] <- y
            arr.[2] <- z
            arr

        ()
    @>

