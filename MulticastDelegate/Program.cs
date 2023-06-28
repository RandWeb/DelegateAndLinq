using System;
using MultiCastDelegate.Sample01;
using MultiCastDelegate.Sample02;

namespace MultiCastDelegate;

class Program
{
    static void Main(string[] args)
    {
        /*MultiCastDelegateSample multiCastDelegateSample=new MultiCastDelegateSample();
        multiCastDelegateSample.Delegate01("test text");*/

        MultiCastDelegateSample2 multiCastDelegateSample2=new MultiCastDelegateSample2();
        multiCastDelegateSample2.Calculator(3, 15);
        Console.ReadLine();
    }
}