#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

# build the LLVM binding DLL
fsc --nologo --debug --sig:LLVMFSharp.fsi --target:library --out:LLVMFSharp.dll \
    src/LLVM/FFIUtil.fs \
    src/LLVM/Generated.fs \
    src/LLVM/Core.fs \
    src/LLVM/BitReader.fs \
    src/LLVM/ExecutionEngine.fs \
    src/LLVM/Extra.fs \
    src/LLVM/Target.fs \
    src/LLVM/Quote.fs

# uncomment the following to build and run the tests

#echo "a very basic test"
#fsc --nologo -r LLVMFSharp.dll test/simpletest.fs
#mono simpletest.exe
#
#echo "a bit more complicated: this version uses the execution engine"
#fsc --nologo -r LLVMFSharp.dll test/simpletest2.fs
#mono simpletest2.exe
#
#echo "compile C code against two add functions built from LLVM"
#fsc --nologo -r LLVMFSharp.dll test/add.fs
#mono add.exe
#llc -march=x86-64 -filetype=obj addModule.bc
#gcc -o printadds addModule.o test/printadds.c
#./printadds
#
#echo "test that the API works with C#"
#dmcs -out:CSSimpleTest2.exe -r:LLVMFSharp.dll test/CSSimpleTest2.cs
#mono CSSimpleTest2.exe
#
#echo "metadata test"
#fsc --nologo -r LLVMFSharp.dll test/metadatatest.fs
#mono metadatatest.exe

echo "quote test"
fsc --nologo -r LLVMFSharp.dll test/quotetest.fs
mono quotetest.exe
llc -march=x86-64 -filetype=obj quotemodule.bc
llvm-dis quotemodule.bc
gcc -o quotetest quotemodule.o test/quotetest.c
./quotetest

