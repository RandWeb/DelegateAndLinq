using System;
using System.Collections.Generic;
using System.Linq;
using Collections;

namespace Generation
{
    class Program
    {
        static void Main(string[] args)
        {
            //GenerationSample.DefaultIfEmptySample();
            //GenerationSample.EmptySample();
            //GenerationSample.RangeSample();
            GenerationSample.RepeatSample();
            Console.ReadLine();
        }
    }

    public class GenerationSample
    {
        public static void DefaultIfEmptySample()
        {
            var emptyList=new List<string>();

            var newList = emptyList.DefaultIfEmpty();
            var newList2 = emptyList.DefaultIfEmpty("None");

            Console.WriteLine($"Count: {newList.Count()}");
            Console.WriteLine($"first item: {newList.ElementAt(0)}");

            Console.WriteLine($"Count: {newList2.Count()}");
            Console.WriteLine($"first item: {newList2.ElementAt(0)}");

            var numbers = SampleCollections.Numbers.DefaultIfEmpty("zero");

            var defaultStudentList = SampleCollections.EmptyStudents.DefaultIfEmpty(new Student()
            {
                Id = 0
            });
            SampleCollections.WriteCollection(defaultStudentList);
        }

        public static void EmptySample()
        {
            var emptyStudent = Enumerable.Empty<Student>();
        }

        public static void RangeSample()
        {
            var intCollection = Enumerable.Range(1, 15);
            SampleCollections.WriteCollection(intCollection);
        }

        public static void RepeatSample()
        {
            var studentCollection = Enumerable.Repeat(new Student()
            {
                Id = 0,
                LastName = "roozi"
            }, 10);
            SampleCollections.WriteCollection(studentCollection);
        }
    }
}
