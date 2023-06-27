using System;
using System.Linq;
using Collections;
using Collections.Comparer;

namespace Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            SetsSample.UnionSample();
            Console.ReadLine();
        }
    }

    public class SetsSample
    {
        public static void DistinctSample()
        {
            var digitWithoutDuplicate = SampleCollections.DigitsWithDuplicate.Distinct();
            SampleCollections.WriteCollection(digitWithoutDuplicate);

            var motorWithoutDuplicate = SampleCollections.MotorSet.Distinct(new MotorTypeComparer());
            SampleCollections.WriteCollection(motorWithoutDuplicate);
        }
        public static void ExceptSample()
        {
            var exceptDigits = SampleCollections.DigitsWithDuplicate.Except(SampleCollections.Digits);
            SampleCollections.WriteCollection(exceptDigits);

            var exceptMotors =
                SampleCollections.MotorSet.Except(SampleCollections.MotorSet2, new MotorTypeAndNameComparer());

            SampleCollections.WriteCollection(exceptMotors);
        }
        public static void IntersectSample()
        {
            var intersectDigits = SampleCollections.DigitsWithDuplicate
                .Intersect(SampleCollections.Digits);
            SampleCollections.WriteCollection(intersectDigits);

            var intersectMotors = SampleCollections.MotorSet
                .Intersect(SampleCollections.MotorSet2, new MotorTypeComparer());
            SampleCollections.WriteCollection(intersectMotors);

        }
        public static void UnionSample()
        {
            var unionDigits = SampleCollections.DigitsWithDuplicate
                .Union(SampleCollections.Digits);
            SampleCollections.WriteCollection(unionDigits);

            var unionMotors = SampleCollections.MotorSet
                .Union(SampleCollections.MotorSet2, new MotorCompanyAndTypeComparer());
            SampleCollections.WriteCollection(unionMotors);

        }
    }
}
