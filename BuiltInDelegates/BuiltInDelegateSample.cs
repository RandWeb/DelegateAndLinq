using System;
using System.Collections.Generic;
using System.Text;

namespace BuiltInDelegates;

public class BuiltInDelegateSample
{
    public Action<int, int> ActionDelegate;
    public Func<int, int, string> FuncDelegate;

    private void AddInt(int x, int y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }

    private string AddIntToString(int x, int y)
    {
        return $"{x} + {y} = {x + y}";
    }

    private bool CheckNumber(int a, Predicate<int> predicate)
    {
        return predicate(a);
    }

    private bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    private bool GreaterOrEquals10(int number)
    {
        return number >= 10;
    }

    public void Execute()
    {
        ActionDelegate += AddInt;
        FuncDelegate += AddIntToString;
        ActionDelegate(10, 15);
        Console.WriteLine(FuncDelegate(15, 19));
        var isEven = CheckNumber(11, IsEven);
        Console.WriteLine($"11 is even:{isEven}");
        var g10 = CheckNumber(10, GreaterOrEquals10);
        Console.WriteLine($"GreaterOrEquals10:{g10}");
    }
}