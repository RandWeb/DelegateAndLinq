using System;
using System.Collections.Generic;
using System.Linq;
using Collections;
namespace LinqSyntax
{
    class Program
    {
        static void Main(string[] args)
        {

            Syntax.QueryExpression();
            Console.WriteLine("--------------------------");
            Syntax.FluentSyntax();
            Console.ReadLine();
        }
    }

    public class Syntax
    {
        public static void QueryExpression()
        {
            var students = SampleCollections.Students;

            //var teens=new List<Student>();
            //foreach (var stu in students)
            //{
            //    if (stu.Age>12 && stu.Age<19)
            //    {
            //        teens.Add(stu);
            //    }
            //}

            var teenagersInDeferredExecution =
                from stu in students
                where (stu.Age > 12 && stu.Age < 19)
                select stu;

            var teenagersImmediateExecution = (
                from stu in students
                where (stu.Age > 12 && stu.Age < 19)
                select stu).ToList();

            foreach (var teen in teenagersInDeferredExecution)
            {
                Console.WriteLine($"{teen.LastName},{teen.Age}");
            }
            
        }

        public static void FluentSyntax()
        {
            var students = SampleCollections.Students;
            var teenagersInDeferredExecution = students.Where(c => c.Age > 12 && c.Age < 19);
            var teenagersImmediateExecution = students.Where(c => c.Age > 12 && c.Age < 19).ToList();

            foreach (var teen in teenagersInDeferredExecution)
            {
                Console.WriteLine($"{teen.LastName},{teen.Age}");
            }
        }

    }
}
