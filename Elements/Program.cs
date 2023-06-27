using System;
using System.Linq;
using Collections;

namespace Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementsSample.SingleSample();
            Console.ReadLine();
        }
    }


    public class ElementsSample
    {
        public static void ElementAtSample()
        {
            var element = SampleCollections.Marks.ElementAt(5);
            Console.WriteLine(element);
            //var element2 = SampleCollections.Marks.ElementAt(100);
            var element3 = SampleCollections.Marks.ElementAtOrDefault(100);
            Console.WriteLine(element);

            var defaultMark = default(Mark);
            var defaultBool = default(bool);
        }
        public static void FirstSample()
        {
            var firstMark = SampleCollections.Marks.First();
            var student = SampleCollections.Students.First(c => c.Age < 12);
            //Exception
            var student2 = SampleCollections.Students.First(c => c.Age < 5);

            var student3 = SampleCollections.Students.FirstOrDefault(c => c.Age < 5);
            //Exception
            var student4 = SampleCollections.EmptyStudents.First();

            var student5 = SampleCollections.EmptyStudents.FirstOrDefault();

        }
        public static void LastSample()
        {
            var lastMark = SampleCollections.Marks.Last();
            var student = SampleCollections.Students.Last(c => c.Age > 12);
            //Exception
            var student2 = SampleCollections.Students.Last(c => c.Age < 5);

            var student3 = SampleCollections.Students.LastOrDefault(c => c.Age < 5);
            //Exception
            var student4 = SampleCollections.EmptyStudents.Last();

            var student5 = SampleCollections.EmptyStudents.LastOrDefault();

        }
        public static void SingleSample()
        {
            var singleStudent = SampleCollections.SingleItemStudents.Single();
            var singleStudent2 = SampleCollections.Students.Single();
            var singleStudent3 = SampleCollections.EmptyStudents.Single();

            var singleStudent4 = SampleCollections.Students.Single(c => c.Age == 21);
            var singleStudent5 = SampleCollections.Students.Single(c => c.Age > 15);

            var singleStudent6 = SampleCollections.EmptyStudents.SingleOrDefault();
            var singleStudent7 = SampleCollections.Students.SingleOrDefault(c=>c.Age==1000);

        }
    }
}
