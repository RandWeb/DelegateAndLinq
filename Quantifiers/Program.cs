using System;
using System.Linq;
using Collections;
using Collections.Comparer;

namespace Quantifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            //QuantifiersSample.AllSample();
            //QuantifiersSample.AnySample();
            QuantifiersSample.Contains();
            Console.ReadLine();
        }
    }

    public class QuantifiersSample
    {
        public static void AllSample()
        {
            var allStudentAccept = SampleCollections.Marks.All(c => c.Score >= 10);
            Console.WriteLine($"All Student Accept: {allStudentAccept}");
        }

        public static void AnySample()
        {
            var anyStudentNotAccept = SampleCollections.Marks.Any(c => c.Score <10);
            Console.WriteLine($"Any Student Not Accept: {anyStudentNotAccept}");
        }

        public static void Contains()
        {
            bool educationHasPostDoc = SampleCollections.Teachers
                .Any(c => c.Educations.Contains(new Education()
                {
                    Title = "postdoc"
                },new EducationComparer()));
            Console.WriteLine($"Any teacher has postdoc degree: {educationHasPostDoc}");
        }
    }
}
