using System;
using System.Collections.Generic;

namespace AnonymousMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine();
        }
    }

    public class AnonymousMethodSample
    {
        public Func<string, string> DisplayDelegate= delegate(string text)
        {
            return $"Message: {text}";
        };

        public void Execute()
        {
           var message= DisplayDelegate("Hello");
        }

        public int Find(List<int> numList)
        {
            return numList.Find(delegate(int i)
            {
                return i % 7 == 0;
            });
        }

    }
}
