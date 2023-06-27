using System;
using System.Linq;
using Collections;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            ConversionSample.ToListSample();
            Console.ReadLine();
        }
    }

    public class ConversionSample
    {
        public static void AsEnumerableSample()
        {
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray);
            Console.WriteLine("------");
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray.AsEnumerable());
        }
        public static void AsQueryableSample()
        {
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray);
            Console.WriteLine("------");
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray.AsQueryable());
        }

        public static void CastSample()
        {
            SampleCollections.ReportTypeProperties(SampleCollections.Digits);
            Console.WriteLine("------");
            SampleCollections.ReportTypeProperties(SampleCollections.Digits.Cast<double>());
        }
        public static void ToArraySample()
        {
            SampleCollections.ReportTypeProperties(SampleCollections.Digits);
            SampleCollections.ReportTypeProperties(SampleCollections.Digits.ToArray());

        }
        public static void ToDictionarySample()
        {
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray);
            var dic = SampleCollections.StudentsArray.ToDictionary(c => c.Id);
            SampleCollections.ReportTypeProperties(dic);
            SampleCollections.WriteDictionary(dic);

        }
        public static void ToListSample()
        {
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray);
            SampleCollections.ReportTypeProperties(SampleCollections.StudentsArray.ToList());
        }

    }
}
