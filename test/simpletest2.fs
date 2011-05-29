open LLVM.Generated.Core
open LLVM.Core
open LLVM.Generated.BitWriter
open LLVM.Generated.ExecutionEngine
open LLVM.ExecutionEngine
open LLVM.Generated.Target

// an F# example adapted from http://www.mdevan.org/llvm-py/examples.html

[<EntryPoint>]
let main _ =

//    ignore <| initializeNativeTarget ()
    
    let myModule = moduleCreateWithName "tut2"

    // create a function type taking 2 integers, return a 32-bit integer
    let tyInt = int32Type ()
    let funcType = functionType tyInt [|tyInt; tyInt|]

    // create a function of that type
    let gcd = addFunction myModule "gcd" funcType

    // name function args
    let x = getParam gcd 0u
    let y = getParam gcd 1u
    setValueName x "x"
    setValueName y "y"

    // implement the function

    // blocks...
    let entry = appendBasicBlock gcd "entry"
    let ret = appendBasicBlock gcd "return"
    let condFalse = appendBasicBlock gcd "cond_false"
    let condTrue = appendBasicBlock gcd "cond_true"
    let condFalse2 = appendBasicBlock gcd "cond_false_2"

    // create a builder
    let bldr = createBuilder ()
    positionBuilderAtEnd bldr entry
    let xEqY = buildICmp bldr IntPredicate.IntEQ x y "tmp"
    ignore <| buildCondBr bldr xEqY ret condFalse

    positionBuilderAtEnd bldr ret
    ignore <| buildRet bldr x

    positionBuilderAtEnd bldr condFalse
    let xLtY = buildICmp bldr IntPredicate.IntULT x y "tmp"
    ignore <| buildCondBr bldr xLtY condTrue condFalse2

    positionBuilderAtEnd bldr condTrue
    let ySubX = buildSub bldr y x "tmp"
    let recur1 = buildCall bldr gcd [|x; ySubX|] "tmp"
    ignore <| buildRet bldr recur1

    positionBuilderAtEnd bldr condFalse2
    let xSubY = buildSub bldr x y "x_sub_y"
    let recur2 = buildCall bldr gcd [|xSubY; y|] "tmp"
    ignore <| buildRet bldr recur2

    ignore <| writeBitcodeToFile myModule "tut2.bc"

//    let myEng = createExecutionEngineForModule myModule
//    
//    let _27 = createGenericValueOfInt tyInt 27UL false
//    let _81 = createGenericValueOfInt tyInt 81UL false
//    let result1 = runFunction myEng gcd [|_27; _81|]
//
//    printfn "gcd(27, 81) -> %i" (genericValueToInt result1 false)

    // exit code
    0

