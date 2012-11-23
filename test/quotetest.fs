open LLVM.Quote
open LLVM.Generated.Core
open LLVM.Core
open LLVM.Generated.ExecutionEngine
open LLVM.ExecutionEngine
open LLVM.Generated.Target
open LLVM.Generated.BitWriter
open LLVM.BitReader

[<EntryPoint>]
let main _ =

    let llvmModuleRef = moduleCreateWithName "quote-module"
    compileQuote llvmModuleRef testQuote
    dumpModule llvmModuleRef
    writeBitcodeToFile llvmModuleRef "quotemodule.bc" |> ignore
    
    // exit success
    0

