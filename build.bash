#!/bin/bash

# exit on error and don't allow the use of unset variables
set -o errexit
set -o nounset
set -x

# build the LLVM binding DLL
fsc --nologo --sig:LLVMFSharp.fsi --target:library --out:LLVMFSharp.dll \
    src/LLVM/FFIUtil.fs \
    src/LLVM/Generated.fs \
    src/LLVM/Core.fs \
    src/LLVM/ExecutionEngine.fs

# build the tests
fsc --nologo -r LLVMFSharp.dll test/simpletest.fs
fsc --nologo -r LLVMFSharp.dll test/simpletest2.fs

# determine if the C# compiler is dmcs (mono) or csc
CSC=""
if hash dmcs &> /dev/null; then
    CSC=dmcs
elif hash csc &> /dev/null; then
    CSC=csc
fi

if [ ${CSC} != "" ]; then
    ${CSC} -out:CSSimpleTest2.exe -r:LLVMFSharp.dll test/CSSimpleTest2.cs
else
    echo "cannot compile CSSimpleTest2.cs since no C# compiler was found"
fi

