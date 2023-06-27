using System;
using System.Linq;
using Collections;

namespace Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            AggregationSamples.AggregateSample();
            Console.WriteLine();
            AggregationSamples.AverageSample();
            Console.WriteLine();
            AggregationSamples.CountSample();
            Console.WriteLine();
            AggregationSamples.MaxMinSample();
            Console.WriteLine();
            AggregationSamples.SumSample();
            Console.ReadLine();
        }
    }

    public class AggregationSamples
    {
        public static void AggregateSample()
        {
            var numbersInString = SampleCollections.Numbers
                .Aggregate((accumulator, next) => accumulator+", "+next );
            Console.WriteLine(numbersInString);

            var studentsName = SampleCollections.Students
                .Aggregate("students name: ",
                    (accumulator, next) => $"{accumulator}{next.FirstName} {next.LastName}, ");
            Console.WriteLine(studentsName);

            var aggregate = SampleCollections.Digits
                .Aggregate((accumulator, next) => accumulator * 10 + next);
            Console.WriteLine(aggregate);
        }
        public static void AverageSample()
        {
            var averageScores = SampleCollections.Marks.Average(c => c.Score);
            Console.WriteLine($"average: {averageScores}");

            var studentMarkGroup = SampleCollections.Marks
                .GroupBy(c => c.StudentId);

            foreach (var scores in studentMarkGroup)
            {
                Console.WriteLine($"studentId: {scores.Key} with course count: {scores.Count()} => {scores.Average(c => c.Score)}");
            }

        }
        public static void CountSample()
        {
            var markCount = SampleCollections.Marks.Count();
            var acceptMarkCount = SampleCollections.Marks.Count(mark => mark.Score >= 12);
            var notAcceptMarkCount = SampleCollections.Marks.Count(mark => mark.Score < 12);

            var studentGroups = SampleCollections.Marks.GroupBy(c => c.StudentId);

            foreach (var studentScore in studentGroups)
            {
                Console.WriteLine($"studentId: {studentScore.Key} has {studentScore.Count(c=>c.Score>=12)} accept Scores");
                Console.WriteLine($"studentId: {studentScore.Key} has {studentScore.Count(c=>c.Score<12)} not accept Scores");
            }
        }

        public static void MaxMinSample()
        {
            var maxScore = SampleCollections.Marks.Max(c => c.Score);
            var minScore = SampleCollections.Marks.Min(c => c.Score);
            Console.WriteLine($"min score: {minScore} and max score: {maxScore}");

            var minAcceptScore = SampleCollections.Marks
                .Where(c => c.Score >= 12)
                .Min(c => c.Score);
            Console.WriteLine($"min accept score: {minAcceptScore}");

            var test = SampleCollections.Marks.Max();
            Console.WriteLine(test);
        }

        public static void SumSample()
        {
            var markSum = SampleCollections.Marks.Sum(c => c.Score);
            Console.WriteLine($"sum of score: {markSum}");

        }
    }
}
