using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltInDelegates;

public class GenericDelegateSample
{
    private delegate T FormulDelegate<T>(T a, T b);

    private delegate void FormulDelegatePrint<T>(T a, T b);

    private delegate TResult FormulDelegateResult<T, TResult>(T a, T b);

    private int AddInt(int x, int y)
    {
        return x + y;
    }

    private double AddDouble(double x, double y)
    {
        return x + y;
    }

    private void AddIntAndWrite(int x, int y)
    {
        Console.WriteLine($"add {x} and {y}={x + y}");
    }

    private string AddIntAndReturn(int x, int y)
    {
        return $"add {x} and {y}={x + y}";
    }

    public void Execute()
    {
        FormulDelegate<int> intAddition = AddInt;
        FormulDelegate<double> doubleAddition = AddDouble;

        Console.WriteLine($"addInt :{AddInt(2, 3)}");
        Console.WriteLine($"addDouble :{AddDouble(2.2, 3.6)}");

        FormulDelegatePrint<int> delegatePrint = AddIntAndWrite;
        delegatePrint(5, 9);

        FormulDelegateResult<int, string> delegateResult = AddIntAndReturn;
        delegateResult(8, 16);
    }
}