#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

rm -f \
    LLVMFSharp.fsi \
    LLVMFSharp.dll \
    LLVMFSharp.sln \
    LLVMFSharp.userprefs \
    bindinggen.exe \
    simpletest.exe \
    simpletest2.exe \
    CSSimpleTest2.exe \
    bindinggen/Parser.fs \
    bindinggen/Parser.fsi \
    bindinggen/Lexer.fs \
    src/LLVM/Generated.fs

