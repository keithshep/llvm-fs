#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

rm -f \
    LLVMFSharp.dll \
    fsexternhelper.exe \
    src/FSExternHelper/Parser.fs \
    src/FSExternHelper/Parser.fsi \
    src/FSExternHelper/Lexer.fs \
    src/LLVM/NativeInterface/*.fs

fslex --unicode src/FSExternHelper/Lexer.fsl
fsyacc --module FSExternHelper.Parser src/FSExternHelper/Parser.fsy

fsc \
    src/ParseUtil/Lexing.fs \
    src/ParseUtil/Parsing.fs \
    src/FSExternHelper/HeaderSyntax.fs \
    src/FSExternHelper/Parser.fs \
    src/FSExternHelper/Lexer.fs \
    src/fsexternhelper.fs

mono fsexternhelper.exe ~/projects/third-party/llvm-2.7 src

fsc --target:library --out:LLVMFSharp.dll \
    src/LLVM/NativeInterface/Core.fs \
    src/LLVM/NativeInterface/BitReader.fs \
    src/LLVM/NativeInterface/BitWriter.fs

