using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCastDelegate.Sample02
{
    public class MultiCastDelegateSample2
    {
        public delegate void CalculatorDelegate(int a, int b);

        public CalculatorDelegate Calculator;

        public MultiCastDelegateSample2()
        {
            CalculatorDelegate mulDelegate = Multiply;
            CalculatorDelegate divDelegate = Div;
            CalculatorDelegate addDelegate = Add;
            CalculatorDelegate subDelegate = Sub;

            Calculator = (CalculatorDelegate) Delegate.Combine(new CalculatorDelegate[]
            {
                addDelegate,
                mulDelegate,
                divDelegate,
                subDelegate
            });

            var invocationList = Calculator.GetInvocationList();

            Calculator = (CalculatorDelegate) Delegate.Remove(Calculator, divDelegate);
        }
        public void Multiply(int x, int y)
        {
            Console.WriteLine($"{x}*{y} ={x * y}");
        }
        public void Div(int x, int y)
        {
            Console.WriteLine($"{x}/{y} ={x / y}");
        }
        public void Add(int x, int y)
        {
            Console.WriteLine($"{x}+{y} ={x + y}");
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine($"{x}-{y} ={x - y}");
        }
    }
}
