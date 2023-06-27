using System;
using System.Linq;
using Collections;

namespace Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcatSample.Sample();
            Console.ReadLine();
        }
    }

    public class ConcatSample
    {
        public static void Sample()
        {
            var numbers = SampleCollections.Numbers.Concat(SampleCollections.Numbers2);
            SampleCollections.WriteCollection(numbers);
        }
    }
}
