using System;
using System.Linq;
using Collections;

namespace Join
{
    class Program
    {
        static void Main(string[] args)
        {
            //SampleJoin.Join();
            SampleJoin.GroupJoin();
            Console.ReadLine();
        }
    }

    public class SampleJoin
    {
        public static void Join()
        {
            var students = SampleCollections.Students;
            var marks = SampleCollections.Marks;
            var res = students.Join(marks,
                c => c.Id,
                c => c.StudentId,
                (s, m) => new
                {
                    Fullname=$"{s.FirstName} {s.LastName}",
                    CourseId=m.CourseId,
                    Score=m.Score
                });
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Fullname} in course {item.CourseId} has score {item.Score}");
            }
            Console.WriteLine();

            var courses = SampleCollections.Courses;
            var res2 = courses.Join(res,
                c => c.Id,
                c => c.CourseId,
                (c, o) => new
                {
                    Fullname = o.Fullname,
                    CourseName = c.Title,
                    Score = o.Score,
                    TeacherName = c.TeacherName
                });

            foreach (var item in res2)
            {
                Console.WriteLine($"{item.Fullname} in course {item.CourseName} with {item.TeacherName} has score {item.Score}");
            }
        }

        public static void GroupJoin()
        {
            var students = SampleCollections.Students;
            var oMarks = SampleCollections.Marks;

            var res = students.GroupJoin(oMarks,
                c => c.Id,
                c => c.StudentId,
                (student, marks) => new
                {
                    Fullname = $"{student.FirstName} {student.LastName}",
                    Marks = marks
                });
            foreach (var item in res)
            {
                Console.WriteLine($"{item.Fullname}:");
                foreach (var mark in item.Marks)
                {
                    Console.WriteLine(mark);
                }
            }
        }
    }
}
