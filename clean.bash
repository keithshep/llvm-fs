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

