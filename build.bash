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
mkdir -p src/LLVM/Generated/Transforms
mono bindinggen.exe LLVM-2.9.dll ~/temp/llvm-2.9 src

# build the LLVM C binding library
fsc --nologo --target:library --out:LLVMFSharp.dll \
    src/LLVM/Generated/Core.fs \
    src/LLVM/Generated/BitReader.fs \
    src/LLVM/Generated/BitWriter.fs \
    src/LLVM/Generated/Target.fs \
    src/LLVM/Generated/ExecutionEngine.fs \
    src/LLVM/Generated/Analysis.fs \
    src/LLVM/Generated/Transforms/Scalar.fs \
    src/LLVM/Generated/Transforms/IPO.fs \
    src/LLVM/FFIUtil.fs \
    src/LLVM/Core.fs \
    src/LLVM/ExecutionEngine.fs

# build the test
fsc --nologo -r LLVMFSharp.dll test/simpletest.fs
fsc --nologo -r LLVMFSharp.dll test/simpletest2.fs

