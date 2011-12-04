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

# see if mono exists in the path. if not assume we're on windows and can
# run bindinggen.exe directly
if hash mono &> /dev/null; then
    mono bindinggen.exe LLVM-3.0.dll ~/bin/llvm-3.0 src/LLVM/Generated.fs
else
    bindinggen.exe LLVM-3.0.dll C:\\Users\\keith\\Desktop\\projects\\llvm-3.0 src\\LLVM\\Generated.fs
fi

