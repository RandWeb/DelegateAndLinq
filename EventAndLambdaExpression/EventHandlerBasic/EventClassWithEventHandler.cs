using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndLambdaExpression.EventHandlerBasic
{
    public class MyArg
    {
        public int Value { get; private set; }

        public MyArg(int value)
        {
            Value = value;
        }
    }
    public class EventClassWithEventHandler
    {
        public event EventHandler<MyArg> OnChange = (sender, e) => { };

        public void Raise()
        {
            OnChange(this,new MyArg(100));
        }
    }

    public class Subscriber
    {
        public void Handler(MyArg arg)
        {
            Console.WriteLine($"Arg: {arg.Value}");
        }
    }

    public class TestEventHandler
    {
        public static void Execute()
        {
            EventClassWithEventHandler eventClass=new EventClassWithEventHandler();
            Subscriber subscriber=new Subscriber();

            eventClass.OnChange += (sender, e) => subscriber.Handler(e);

            eventClass.Raise();
        }
    }
}
