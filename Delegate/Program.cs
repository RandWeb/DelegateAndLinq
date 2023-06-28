using System;

namespace Delegate;

class Program
{
    static void Main(string[] args)
    {
        DelegateSample delegateSample = new DelegateSample();
        delegateSample.Delegate01("text to store");
        delegateSample.Delegate02("text to write");
        Console.ReadLine();
    }
}