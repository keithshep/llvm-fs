#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

rm -f \
    LLVMFSharp.dll \
    bindinggen.exe \
    simpletest.exe \
    bindinggen/Parser.fs \
    bindinggen/Parser.fsi \
    bindinggen/Lexer.fs \
    src/LLVM/NativeInterface/*.fs

