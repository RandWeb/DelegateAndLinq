using System;
using System.Linq;
using Collections;

namespace Projection
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProjectionSample.SampleSelect();
            ProjectionSample.SampleSelectMany();
            Console.ReadLine();
        }
    }

    public class ProjectionSample
    {
        public static void SampleSelect()
        {
            var students = SampleCollections.Students;
            var fullNames = students.Select(c => $"{c.FirstName} {c.LastName}");

            SampleCollections.WriteCollection(fullNames);
            Console.WriteLine();

            var persons = students.Select(c => new Person()
            {
                Name = c.FirstName,
                Family = c.LastName
            });
            SampleCollections.WriteCollection(persons);
        }


        public static void SampleSelectMany()
        {
            var educations = SampleCollections.Teachers.SelectMany(c => c.Educations);
            SampleCollections.WriteCollection(educations);
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Family { get; set; }
        public override string ToString()
        {
            return $"person: {Name} {Family}";
        }
    }
}
