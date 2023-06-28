using System;

namespace BuiltInDelegates;

class Program
{
    static void Main(string[] args)
    {
        BuiltInDelegateSample delegateSample = new();
        GenericDelegateSample genericDelegateSample = new();
        genericDelegateSample.Execute();
        delegateSample.Execute();

        Console.ReadLine();
    }
}