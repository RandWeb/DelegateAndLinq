
using System;
using System.Linq;
using Collections;

namespace Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            SortingSample.Ordering();
            Console.ReadLine();
        }
    }

    public class SortingSample
    {
        public static void Ordering()
        {
            var students = SampleCollections.Students;

            Console.WriteLine("----------OrderBy---------");

            var orderedByAge = students.OrderBy(c => c.Age).ToList();
            SampleCollections.WriteCollection(orderedByAge);
            Console.WriteLine("----------OrderByDescending---------");

            var orderedByAgeDescending = students.OrderByDescending(c => c.Age).ToList();
            SampleCollections.WriteCollection(orderedByAgeDescending);

            Console.WriteLine("----------thenby---------");
            var orderbyNameThenByAge = students
                .OrderBy(c => c.FirstName)
                .ThenBy(c => c.Age).ToList();
            SampleCollections.WriteCollection(orderbyNameThenByAge);

            Console.WriteLine("----------ThenByDescending---------");
            var orderbyNameThenByDescendingAge = students
                .OrderBy(c => c.FirstName)
                .ThenByDescending(c => c.Age).ToList();
            SampleCollections.WriteCollection(orderbyNameThenByDescendingAge);
        }
    }
}
