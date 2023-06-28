using System;
using System.Collections.Generic;

namespace AnonymousMethod;

class Program
{
    static void Main(string[] args)
    {
        AnonymousMethodSample anonymousMethodSample = new();

        IEnumerable<int>  result = anonymousMethodSample.Find(new List<int>()
            { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 10 });
        foreach (var i in result)
        {
            Console.WriteLine(i);
        }
        Console.ReadLine();
    }
}

public class AnonymousMethodSample
{
    private Func<string, string> DisplayDelegate = delegate(string text) { return $"Message: {text}"; };

    public void Execute()
    {
        var message = DisplayDelegate("Hello");
    }

    public IEnumerable<int> Find(List<int> numList)
    {
        yield return numList.Find(delegate(int i) { return i % 7 == 0; });
    }
}