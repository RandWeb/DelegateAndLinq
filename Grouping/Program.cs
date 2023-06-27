using System;
using System.Linq;
using Collections;

namespace Grouping
{
    class Program
    {
        static void Main(string[] args)
        {
            GroupingSample.TestToLookup();
            Console.ReadLine();
        }
    }

    public class GroupingSample
    {
        public static void TestGroupBy()
        {
            var marks = SampleCollections.Marks;
            var groupbyStudentId = marks.GroupBy(c => c.StudentId);
            foreach (var group in groupbyStudentId)
            {
                Console.WriteLine($"marks by studentId: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            var groupbyCourseId = marks.GroupBy(c => c.CourseId);

            foreach (var group in groupbyCourseId)
            {
                Console.WriteLine($"marks by courseId: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }


        }

        public static void TestToLookup()
        {
            var courses = SampleCollections.Courses;
            var groupbyTeacher = courses.ToLookup(c => c.TeacherName);
            foreach (var group in groupbyTeacher)
            {
                Console.WriteLine($"course by teacher name: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
            Console.WriteLine("-------------------------------");
            Console.WriteLine();

            var groupbyTitle = courses.ToLookup(c => c.Title);
            foreach (var group in groupbyTitle)
            {
                Console.WriteLine($"course by title: {group.Key}");
                foreach (var item in group)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
