using System;
using System.Linq;
using Collections;

namespace Partitioning
{
    class Program
    {
        static void Main(string[] args)
        {
            //PartitioningSample.TakeSample();
            Console.WriteLine("page1:");
            PartitioningSample.Pagination(2,1);
            Console.WriteLine("page2:");
            PartitioningSample.Pagination(2,2);
            Console.WriteLine("page3:");
            PartitioningSample.Pagination(2,3);
            Console.ReadLine();
        }
    }

    public class PartitioningSample
    {
        public static void SkipSample()
        {
            var skipNumbers = SampleCollections.Numbers.Skip(2);
            SampleCollections.WriteCollection(skipNumbers);
            var skipNumbers2 = SampleCollections.Numbers.Skip(15);
            Console.WriteLine("----------");

            var skipLastNumbers = SampleCollections.Numbers.SkipLast(2);
            SampleCollections.WriteCollection(skipLastNumbers);
            var skipLastNumbers2 = SampleCollections.Numbers.SkipLast(15);
            Console.WriteLine("----------");

            var skipStudents = SampleCollections.Students
                .SkipWhile(c => c.Age != 32);
            SampleCollections.WriteCollection(skipStudents);
            Console.WriteLine("----------");

            var skipStudentWithIndex = SampleCollections.Students
                .SkipWhile((student, index) => student.Age > index*5);
            SampleCollections.WriteCollection(skipStudentWithIndex);

        }

        public static void TakeSample()
        {
            var takeNumber = SampleCollections.Numbers.Take(2);
            SampleCollections.WriteCollection(takeNumber);
            var takeNumber2 = SampleCollections.Numbers.Take(25);
            SampleCollections.WriteCollection(takeNumber2);


            var takeNumber3 = SampleCollections.Numbers.TakeLast(2);
            SampleCollections.WriteCollection(takeNumber3);

            var takeWhileStudents = SampleCollections.Students
                .TakeWhile(c => c.Age < 32);
            SampleCollections.WriteCollection(takeWhileStudents);

            var takeWhileStudents2 = SampleCollections.Students
                .TakeWhile((student, index) => student.Age >index * 5);
            SampleCollections.WriteCollection(takeWhileStudents2);

        }
        
        public static void Pagination(int pageSize=2,int pageNumber=3)
        {
            var page = SampleCollections.Students.Skip((pageNumber - 1) * pageSize).Take(pageSize);
            SampleCollections.WriteCollection(page);

        }
    }
}
