using System;
using System.Linq;
using Collections;
using Collections.Comparer;


namespace Comparer
{
    class Program
    {
        static void Main(string[] args)
        {
            UseComparerSample.Ordering();
            Console.ReadLine();
        }
    }

    public class UseComparerSample
    {
        public static void SampleGroupBy()
        {
            var cars = SampleCollections.Cars;
            var grouped = cars.GroupBy(c => c.Motor,new MotorCompanyAndTypeComparer());
            SampleCollections.WriteGroupCollection(grouped);
            Console.WriteLine();
            var grouped2 = cars.GroupBy(c => c.Motor, new MotorTypeComparer());
            SampleCollections.WriteGroupCollection(grouped2);
            Console.WriteLine();

            var grouped3 = cars.GroupBy(c => c.Motor, new MotorTypeAndNameComparer());
            SampleCollections.WriteGroupCollection(grouped3);
        }
        public static void Ordering()
        {
            var students = SampleCollections.Students;

            Console.WriteLine("----------OrderBy---------");

            var orderedByAge = students.OrderBy(c => c.LastName,new StringLengthComparer()).ToList();
            SampleCollections.WriteCollection(orderedByAge);
            Console.WriteLine("----------OrderByDescending---------");

            var orderedByAgeDescending = students.OrderByDescending(c => c.LastName, new StringLengthComparer()).ToList();
            SampleCollections.WriteCollection(orderedByAgeDescending);

        }
    }
}
