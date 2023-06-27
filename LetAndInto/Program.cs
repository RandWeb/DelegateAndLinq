using System;
using System.Collections.Generic;
using System.Linq;
using Collections;

namespace LetAndInto
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample.LetSample();
            Sample.IntoSample();
            Console.ReadLine();
        }
    }
    public class Sample
    {
        public static void LetSample()
        {
            var lowercaseStudentNames =
                from s in SampleCollections.Students
                where s.FirstName.ToLower().StartsWith("m")
                select s.FirstName.ToLower();

            var lowercaseStudentNames2 =
                from s in SampleCollections.Students
                let lowercaseStudentName = s.FirstName.ToLower()
                where lowercaseStudentName.StartsWith("m")
                select lowercaseStudentName;

            SampleCollections.WriteCollection(lowercaseStudentNames);
            SampleCollections.WriteCollection(lowercaseStudentNames2);
        }

        public static void IntoSample()
        {
            var teenagerStudents =
                from s in SampleCollections.Students
                where s.Age > 12 && s.Age < 20
                select s
                into teenStudent
                where teenStudent.FirstName.StartsWith("m")
                select teenStudent;
            SampleCollections.WriteCollection(teenagerStudents);

        }

    }
}
