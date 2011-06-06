#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

# build and run special purpose tool for generating LLVM C bindings
fslex --unicode bindinggen/Lexer.fsl
fsyacc --module FSExternHelper.Parser bindinggen/Parser.fsy
fsc --nologo \
    bindinggen/Lexing.fs \
    bindinggen/Parsing.fs \
    bindinggen/HeaderSyntax.fs \
    bindinggen/Parser.fs \
    bindinggen/Lexer.fs \
    bindinggen/bindinggen.fs
mono bindinggen.exe LLVM-2.9.dll ~/share src/LLVM/Generated.fs

# build the LLVM C binding library
fsc --nologo --sig:LLVMFSharp.fsi --target:library --out:LLVMFSharp.dll \
    src/LLVM/FFIUtil.fs \
    src/LLVM/Generated.fs \
    src/LLVM/Core.fs \
    src/LLVM/ExecutionEngine.fs

# build the test
fsc --nologo -r LLVMFSharp.dll test/simpletest.fs
fsc --nologo -r LLVMFSharp.dll test/simpletest2.fs

