# llvm-fs: An F# binding for LLVM

llvm-fs can be used to write your LLVM compiler in a .NET language. The code
is all F# but an effort has been made to make the library easy to use from
C#. See test/CSSimpleTest.cs for an example of how you can call the llvm-fs
functions from C#. If you have questions or comments about llvm-fs you can
use the project google group: http://groups.google.com/group/llvm-fs

## Building LLVM for llvm-fs

NOTE: this has been tested on OS X 10.6 and on Windows 7 (using MinGW
bash/gcc/g++ with python 2.7 installed)

Download a copy of the LLVM 3.2 source code. In order to use the LLVM native
libraries with llvm-fs they must be built with `--enabled-shared`.
Unfortunately the prebuilt LLVM binaries don't come with shared libraries so you
will have to build LLVM yourself. For windows you can do this by using a build
command like: `./configure --enable-shared --enable-jit && make && make install`.
OS X 10.6 needs more convincing to build the 32-bit libraries as required to
work with mono. The following LLVM configuration works on 10.6:

    CXX='g++ -m32' CC='gcc -m32' CFLAGS=-m32 CXXFLAGS=-m32 LDFLAGS=-m32 ./configure \
        --disable-bindings --build=i686-apple-darwin --host=i686-apple-darwin \
        --target=i686-apple-darwin --enable-targets=x86,x86_64 \
        --enable-optimized --enable-shared --enable-jit

## Building the llvm-fs Assembly

OS X/mono: On OS X run the `./build.bash` script to generate the LLVMFsharp.dll
assembly. This should also work on Linux but is untested (Please let me know if
it works on Linux for you).

Windows 7: open the llvm-fs.fsproj project file and build the project. This
will generate the LLVMFsharp.dll assembly for you.

## Using llvm-fs in your project

In order to use llvm-fs you will want to consult the following:

1. Example F# and C# code under the ./test directory. If you are using mono you
   can see how these tests are built and run by un-commenting everything under
   `# uncomment the following to build and run the tests` in the build.bash
   file.
2. The [LLVM C](http://llvm.org/doxygen/dir_ba5bdc16f452288d1429bb9e178a5965.html)
   documentation. Almost all of the llvm-fs binding functions are
   auto-generated from the C header files so these docs are very useful.
3. The LLVMFSharp.fsi file for all of the types and function signatures and
   of course the source code.

### Compiling F# Quotations

You can use F# Quotations to build LLVM functions. This is a lot more efficient
than using the API but there are caveats:

* The F# quotations are treated a way to represent LLVM IR more than F# code, so
  F# semantics are not 100% respected.
* Many common F# language constructs are not supported for simplicity and so
  that the code in quotations will map fairly directly to LLVM IR code. Examples
  of this are that:
    * the only supported types are: `bool`, `int[8,16,32,64]`,
      `uint[8,16,32,64]`, `single`, `double`, tuples and arrays (using
      `LLVM.Quote.RawArray` type which does not have a length property)
    * functions cannot be treated as first class values and partial application
      is not supported
    * there are no exceptions and there is no garbage collection. Any items
      allocated on the heap should be freed using the `LLVM.Quote.free` function.
      Tuple construction is always done on the heap and arrays can be allocated
      on the heap using `LLVM.Quote.heapAllocRawArray` or on the stack using
      `LLVM.Quote.stackAllocRawArray`.
    * functions can only be top level definitions (closures are not
      supported)
    * the list of top level function definitions in your quotation must end with
      a single unit value `()`

To get a better idea of how you can build functions with quotations take a look
at the examples in `test/quotetest.fs` which generates all of the functions
called in `test/quotetest.c`.

## Regenerating bindings

Regenerating bindings should not be necessary unless you're building bindings to
a new version of LLVM. If you want to do this start with the `./gen-bindings.bash`
script and ask questions on the project list if you have problems.

