using System;
using EventAndLambdaExpression.EventAction;
using EventAndLambdaExpression.EventHandlerBasic;

namespace EventAndLambdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test.Execute();
            TestEventHandler.Execute();
            Console.ReadLine();
        }
    }
}
