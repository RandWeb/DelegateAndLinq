using System;
using System.Linq;
using Collections;
using Collections.Comparer;

namespace SequenceEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            SequenceEqualSample.Sample();
            Console.ReadLine();
        }
    }

    public class SequenceEqualSample
    {
        public static void Sample()
        {
            var isEqual = SampleCollections.Numbers
                .SequenceEqual(SampleCollections.Numbers2,
                new StringComparerWithOutCaseSensitive());
            Console.WriteLine(isEqual);


            var isEqualMotors = SampleCollections.MotorSet.SequenceEqual(SampleCollections.EqualMotorSet);
            Console.WriteLine(isEqualMotors);

            var isEqualMotors2 = SampleCollections.MotorSet
                .SequenceEqual(SampleCollections.EqualMotorSet,new MotorCompanyAndTypeComparer());
            Console.WriteLine(isEqualMotors2);
        }
    }
}
