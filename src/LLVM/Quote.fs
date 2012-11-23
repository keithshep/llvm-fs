module LLVM.Quote

open Microsoft.FSharp.Quotations
open Microsoft.FSharp.Quotations.Patterns
open Microsoft.FSharp.Quotations.DerivedPatterns

module LGC = LLVM.Generated.Core
module LC = LLVM.Core

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
    if ty.IsArray then
        Some <| ArrayTy (ty.GetElementType())
    else
        None

let rec arrayLLVMTyOf (elemTy:System.Type) (size:uint32) =
    let rawArrTy = LGC.arrayType (llvmTyOf elemTy) size
    LC.structType [|LGC.int32Type(); rawArrTy|] false
and allocableLLVMTyOf (ty:System.Type) : LGC.TypeRef =
    match ty with
    | ArrayTy elemTy ->
        // TODO length should be nativeint rather than int32
        let rawArrTy = LGC.arrayType (llvmTyOf elemTy) 0u
        LC.structType [|LGC.int32Type(); rawArrTy|] false
    | _ ->
        failwithf "No support for type %A" ty
and llvmTyOf (ty:System.Type) : LGC.TypeRef =
    match ty with
    | Int32Ty | UInt32Ty -> LGC.int32Type()
    | Int16Ty | UInt16Ty -> LGC.int16Type()
    | Int8Ty | UInt8Ty -> LGC.int8Type()
    | BoolTy -> LGC.int1Type()
    | UnitTy -> LGC.voidType()
    | _ -> LGC.pointerType (allocableLLVMTyOf ty) 0u
let llvmTyOfVar (var:Var) : LGC.TypeRef = llvmTyOf var.Type
let llvmTyOfExpr (expr:Expr) : LGC.TypeRef = llvmTyOf expr.Type
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

    let rec implementExpr
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
            let lhsVal, bb = implementExpr bb valMap lhsExpr
            let rhsVal, bb = implementExpr bb valMap rhsExpr

            let eqVal =
                match lhsVal, rhsVal with
                | Some lhsVal, Some rhsVal -> llvmBinOp lhsVal rhsVal
                | _ -> failwith "internal error: bad args for bin op"
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
                let alloca = LGC.buildAlloca entryBldr (llvmTyOfVar iVar) iVar.Name
                use bldr = new LC.Builder(bb)
                LGC.buildStore bldr startVal alloca |> ignore

                // create the end value
                match implementExpr bb valMap endExpr with
                | None, _ -> failwith "internal error: for loop limit expression evaluated to unit"
                | Some endVal, bb ->

                    // create the body of the loop
                    let forBB = LGC.appendBasicBlock fnVal "for"
                    use bldr = new LC.Builder(bb)
                    LGC.buildBr bldr forBB |> ignore
                    use forBldr = new LC.Builder(forBB)
                    let currVal = LGC.buildLoad forBldr alloca iVar.Name
                    let valMap = valMap.Add(iVar.Name, currVal)
                    let _, forBB = implementExpr forBB valMap bodyExpr

                    // increment the var and see if we need to loop again
                    use forBldr = new LC.Builder(forBB)
                    let incVal = LGC.buildAdd forBldr currVal (LC.constInt32 1) (iVar.Name + "Incr")
                    LGC.buildStore bldr incVal alloca |> ignore
                    let contLoopVal = LGC.buildICmp forBldr LGC.IntPredicate.IntSLE currVal endVal "contLoop"

                    let loopBreakBB = LGC.appendBasicBlock fnVal "loopExit"
                    LGC.buildCondBr forBldr contLoopVal forBB loopBreakBB |> ignore

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
            let _, bldr = implementExpr bb valMap exprToIgnore
            None, bb
        | Call (_instExpr, methInfo, paramExprs) ->
            match methInfo.DeclaringType.FullName, methInfo.Name, paramExprs with
            | "Microsoft.FSharp.Core.LanguagePrimitives+IntrinsicFunctions", "GetArray", [arrExpr; iExpr] ->
                match implementExpr bb valMap arrExpr with
                | None, _ -> failwith "internal error: array param of GetArray evaluated as unit"
                | Some arrVal, bb ->
                    match implementExpr bb valMap iExpr with
                    | None, _ -> failwith "internal error: index param of GetArray evaluated as unit"
                    | Some iVal, bb ->
                        use bldr = new LC.Builder(bb)

                        let rawArrAddr = LGC.buildStructGEP bldr arrVal 1u "rawArrAddr"
                        let itemAddr = LC.buildGEP bldr rawArrAddr [|LC.constInt32 0; iVal|] "itemAddr"
                        let itemVal = LGC.buildLoad bldr itemAddr "itemVal"
                        Some itemVal, bb
            | _ ->
                noImpl()
        | PropertyGet (Some instExpr, prop, []) ->
            if instExpr.Type.IsArray && prop.Name = "Length" then
                match implementExpr bb valMap instExpr with
                | None, _ -> failwith "internal error: array object evaluated as unit"
                | Some arrVal, bb ->
                    use bldr = new LC.Builder(bb)
                    let lenAddr = LGC.buildStructGEP bldr arrVal 0u "lenAddr"
                    let lenVal = LGC.buildLoad bldr lenAddr "lenVal"
                    Some lenVal, bb
            else
                noImpl()
        | FullAppl (Var f, xs) ->
            let bb = ref bb
            let argVals = [|
                for x in xs do
                    let xVal, newBB = implementExpr !bb valMap x
                    bb := newBB
                    match xVal with
                    | None -> failwith "internal error: found unit function arg"
                    | Some xVal -> yield xVal
            |]
            use bldr = new LC.Builder(!bb)
            let callVal = LC.buildCall bldr valMap.[f.Name] argVals (f.Name + "Result")

            Some callVal, !bb
        | NewArray (elemTy, itemExprs) ->
            (*let llvmTy = arrayLLVMTyOf elemTy (uint32 itemExprs.Length)
            let arrSizeVal = LGC.sizeOf llvmTy
            LGC.buildar*)
            noImpl()
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
        let addAndIgnore x y = ignore (x + y)

        // if/else expression
        let addOrSub x y =
            if x > y then
                x - y
            else
                x + y

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
        let fac x =
            let mutable sum = 1
            for i = 2 to x do
                sum <- sum * i
            sum

        // simple array with for loop
        let sum (xs:int array) =
            let mutable sum = 0
            for i = 0 to xs.Length - 1 do
                sum <- sum + xs.[i]
            sum

        // simple array with while loop
        let sum' (xs:int array) =
            let mutable sum = 0
            let mutable i = 0
            while i < xs.Length do
                sum <- sum + xs.[i]
            sum

        let sum375() =
            sum [|3; 7; 5|]

        ()
    @>
