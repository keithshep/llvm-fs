using Gen = LLVM.Generated;
using LLVM;

using System.Runtime.InteropServices;

public class SimpleTest2
{
    // a C# example adapted from http://www.mdevan.org/llvm-py/examples.html

    // Using LLVMInitializeX86Target in this way is kind of a hack. Ideally we would
    // be using LLVMInitializeNativeTarget but unfortunately the symbol for
    // LLVMInitializeNativeTarget never makes it into the LLVM shared library since
    // it is declared static.
    [DllImport("LLVM-3.0.dll", EntryPoint="LLVMInitializeX86Target")]
    static extern void initializeX86Target();

    public static int Main()
    {
        initializeX86Target ();
        
        var myModule = Gen.Core.moduleCreateWithName("tut2");

        // create a function type taking 2 integers, return a 32-bit integer
        var tyInt = Gen.Core.int32Type();
        var funcType = Core.functionType(tyInt, new Gen.Core.TypeRef[] {tyInt, tyInt});

        // create a function of that type
        var gcd = Gen.Core.addFunction(myModule, "gcd", funcType);

        var x = Gen.Core.getParam(gcd, 0u);
        var y = Gen.Core.getParam(gcd, 1u);
        Gen.Core.setValueName(x, "x");
        Gen.Core.setValueName(y, "y");

        // implement the function

        // blocks...
        var entry = Gen.Core.appendBasicBlock(gcd, "entry");
        var ret = Gen.Core.appendBasicBlock(gcd, "return");
        var condFalse = Gen.Core.appendBasicBlock(gcd, "cond_false");
        var condTrue = Gen.Core.appendBasicBlock(gcd, "cond_true");
        var condFalse2 = Gen.Core.appendBasicBlock(gcd, "cond_false_2");

        // create a builder
        var bldr = new Core.Builder();
        Gen.Core.positionBuilderAtEnd(bldr, entry);
        var xEqY = Gen.Core.buildICmp(bldr, Gen.Core.IntPredicate.IntEQ, x, y, "tmp");
        Gen.Core.buildCondBr(bldr, xEqY, ret, condFalse);

        Gen.Core.positionBuilderAtEnd(bldr, ret);
        Gen.Core.buildRet(bldr, x);

        Gen.Core.positionBuilderAtEnd(bldr, condFalse);
        var xLtY = Gen.Core.buildICmp(bldr, Gen.Core.IntPredicate.IntULT, x, y, "tmp");
        Gen.Core.buildCondBr(bldr, xLtY, condTrue, condFalse2);

        Gen.Core.positionBuilderAtEnd(bldr, condTrue);
        var ySubX = Gen.Core.buildSub(bldr, y, x, "tmp");
        var recur1 = Core.buildCall(bldr, gcd, new Gen.Core.ValueRef[] {x, ySubX}, "tmp");
        Gen.Core.buildRet(bldr, recur1);

        Gen.Core.positionBuilderAtEnd(bldr, condFalse2);
        var xSubY = Gen.Core.buildSub(bldr, x, y, "x_sub_y");
        var recur2 = Core.buildCall(bldr, gcd, new Gen.Core.ValueRef[] {xSubY, y}, "tmp");
        Gen.Core.buildRet(bldr, recur2);

        Gen.Core.dumpModule(myModule);
        Gen.BitWriter.writeBitcodeToFile(myModule, "tut2.bc");

        var myEng = ExecutionEngine.createExecutionEngineForModule(myModule);
        
        var _36 = Gen.ExecutionEngine.createGenericValueOfInt(tyInt, 36UL, false);
        var _81 = Gen.ExecutionEngine.createGenericValueOfInt(tyInt, 81UL, false);
        var result1 = ExecutionEngine.runFunction(
            myEng,
            gcd,
            new Gen.ExecutionEngine.GenericValueRef[] {_36, _81});
        
        System.Console.WriteLine(
            "gcd(36, 81) -> " +
            Gen.ExecutionEngine.genericValueToInt(result1, false));

        // exit code
        return 0;
    }
}

