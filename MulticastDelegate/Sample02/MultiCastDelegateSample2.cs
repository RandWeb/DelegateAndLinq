using System;

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

            Calculator = (CalculatorDelegate)Delegate.Combine(addDelegate, mulDelegate, divDelegate, subDelegate);

            Delegate[] invocationList = Calculator?.GetInvocationList();

            Calculator = (CalculatorDelegate)Delegate.Remove(Calculator, divDelegate);
        }

        private void Multiply(int x, int y)
        {
            Console.WriteLine($"{x}*{y} ={x * y}");
        }

        private void Div(int x, int y)
        {
            Console.WriteLine($"{x}/{y} ={x / y}");
        }

        private void Add(int x, int y)
        {
            Console.WriteLine($"{x}+{y} ={x + y}");
        }

        private void Sub(int x, int y)
        {
            Console.WriteLine($"{x}-{y} ={x - y}");
        }
    }
}