using System;
using System.Collections.Generic;
using System.Text;

namespace EventAndLambdaExpression.EventAction
{
    /// <summary>
    /// publisher
    /// </summary>
    public class EventClass
    {
        public event Action OnChange = () => { };

        public void Raise()
        {
            OnChange();
        }
    }

    public class Subscriber01
    {
        public void Handler()
        {
            Console.WriteLine("Subscriber01.handler");
        }
    }
    public class Subscriber02
    {
        public void Handler()
        {
            Console.WriteLine("Subscriber02.handler");
        }
    }

    public class Test
    {
        public static void Execute()
        {
            EventClass eventClass=new EventClass();
            Subscriber01 subscriber01=new Subscriber01();
            Subscriber02 subscriber02=new Subscriber02();

            eventClass.OnChange += () => subscriber01.Handler();
            eventClass.OnChange += () => subscriber02.Handler();
            eventClass.Raise();
        }
    }
}
