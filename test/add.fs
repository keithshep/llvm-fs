open LLVM.Generated.Core
open LLVM.Core
open LLVM.Generated.BitWriter
open LLVM.Generated.ExecutionEngine
open LLVM.ExecutionEngine
open LLVM.Generated.Target

// an F# example adapted from http://www.mdevan.org/llvm-py/examples.html

// Using LLVMInitializeX86Target in this way is kind of a hack. Ideally we would
// be using LLVMInitializeNativeTarget but unfortunately the symbol for
// LLVMInitializeNativeTarget never makes it into the LLVM shared library since
// it is declared static.
open System.Runtime.InteropServices
[<DllImport("LLVM-3.0.dll", EntryPoint="LLVMInitializeX86Target")>]
extern void initializeX86Target()

[<EntryPoint>]
let main _ =

    initializeX86Target ()
    let myModule = moduleCreateWithName "addModule"

    // build a function that adds 2 integers (uses unnecessary load/stores)
    let makeAdd1 () =
//        let myModule = moduleCreateWithName "add1"

        // create a function type taking 2 integers, return a 32-bit integer
        let tyInt = int32Type ()
        let funcType = functionType tyInt [|tyInt; tyInt|]

        // create a function of that type
        let add = addFunction myModule "add1" funcType

        // name function args
        let x = getParam add 0u
        let y = getParam add 1u
        setValueName x "x"
        setValueName y "y"

        // blocks...
        let entry = appendBasicBlock add "entry"
        let ret = appendBasicBlock add "return"

        // create a builder
        use bldr = new Builder ()
        positionBuilderAtEnd bldr entry
        let xAlloca = buildAlloca bldr (int32Type ()) "xAlloca"
        let yAlloca = buildAlloca bldr (int32Type ()) "yAlloca"
        buildStore bldr x xAlloca |> ignore
        buildStore bldr y yAlloca |> ignore
        buildBr bldr ret |> ignore
        
        positionBuilderAtEnd bldr ret
        let xLoad = buildLoad bldr xAlloca "xLoad"
        let yLoad = buildLoad bldr yAlloca "yLoad"
        buildRet bldr (buildAdd bldr xLoad yLoad "retVal") |> ignore

//        writeBitcodeToFile myModule "add1.bc" |> ignore
//        dumpModule myModule
//
//        let myEng = createExecutionEngineForModule myModule
//        
//        let _36 = createGenericValueOfInt tyInt 3UL false
//        let _81 = createGenericValueOfInt tyInt 8UL false
//        let result = runFunction myEng add [|_36; _81|]
//        
//        printfn "add1(3, 8) -> %i" (genericValueToInt result false)

    // build an add function (without the unnecessary load/stores)
    let makeAdd2 () =
//        let myModule = moduleCreateWithName "add2"

        // create a function type taking 2 integers, return a 32-bit integer
        let tyInt = int32Type ()
        let funcType = functionType tyInt [|tyInt; tyInt|]

        // create a function of that type
        let add = addFunction myModule "add2" funcType

        // name function args
        let x = getParam add 0u
        let y = getParam add 1u
        setValueName x "x"
        setValueName y "y"

        // blocks...
        let entry = appendBasicBlock add "entry"
        use bldr = new Builder ()
        positionBuilderAtEnd bldr entry
        buildRet bldr (buildAdd bldr x y "retVal") |> ignore

//        writeBitcodeToFile myModule "add2.bc" |> ignore
//        dumpModule myModule
//
//        let myEng = createExecutionEngineForModule myModule
//        
//        let _36 = createGenericValueOfInt tyInt 3UL false
//        let _81 = createGenericValueOfInt tyInt 8UL false
//        let result = runFunction myEng add [|_36; _81|]
//        
//        printfn "add2(3, 8) -> %i" (genericValueToInt result false)

    makeAdd1 ()
    makeAdd2 ()
    dumpModule myModule
    writeBitcodeToFile myModule "addModule.bc" |> ignore

    // exit code
    0

