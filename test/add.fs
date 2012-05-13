open LLVM.Generated.Core
open LLVM.Core
open LLVM.Generated.BitWriter

// an F# example adapted from http://www.mdevan.org/llvm-py/examples.html

[<EntryPoint>]
let main _ =

    let myModule = moduleCreateWithName "addModule"

    // build a function that adds 2 integers (uses unnecessary load/stores)
    let makeAdd1 () =

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

    // build an add function (without the unnecessary load/stores)
    let makeAdd2 () =

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

    makeAdd1 ()
    makeAdd2 ()
    dumpModule myModule
    writeBitcodeToFile myModule "addModule.bc" |> ignore

    // exit code
    0

