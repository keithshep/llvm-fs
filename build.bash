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

fslex --unicode bindinggen/Lexer.fsl
fsyacc --module FSExternHelper.Parser bindinggen/Parser.fsy

fsc \
    bindinggen/Lexing.fs \
    bindinggen/Parsing.fs \
    bindinggen/HeaderSyntax.fs \
    bindinggen/Parser.fs \
    bindinggen/Lexer.fs \
    bindinggen/bindinggen.fs

mono bindinggen.exe ~/projects/third-party/llvm-2.7 src

fsc --target:library --out:LLVMFSharp.dll \
    src/LLVM/NativeInterface/Core.fs \
    src/LLVM/Core.fs \
    src/LLVM/NativeInterface/BitReader.fs \
    src/LLVM/NativeInterface/BitWriter.fs

fsc -r LLVMFSharp.dll test/simpletest.fs

