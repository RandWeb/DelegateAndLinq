using System;

namespace MultiCastDelegate.Sample01
{
    public class MultiCastDelegateSample
    {
        private string _globalData;
        public delegate void SingleStringDelegate(string data);

        public SingleStringDelegate Delegate01;

        public MultiCastDelegateSample()
        {
            Delegate01 += AssignData;
            Delegate01 += WriteData;

            Delegate01 -= AssignData;
            Delegate01 -= WriteData;
            SingleStringDelegate x = WriteData;
            Delegate01 += x;
        }
        public void AssignData(string data)
        {
            _globalData = data;
            Console.WriteLine($"global data: '{data}'");

        }

        public void WriteData(string data)
        {
            Console.WriteLine($"data: '{data}'");
        }
    }
}
