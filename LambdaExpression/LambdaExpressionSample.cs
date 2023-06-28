using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression;

public class Student
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    public int Age { get; set; }
}

public class LambdaExpressionSample
{
    private Func<int, string> GetInputWithTypeStringDelegate = delegate(int i) { return i.ToString(); };

    private Func<int, string> GetInputWithTypeStringLambda = i =>
    {
        Console.WriteLine($"input parameters:{i}");
        return i.ToString();
    };

    private Func<int, string> GetInputWithTypeStringFunc = (i) => i.ToString();

    private Action<int, int> MutiplayAction = (i, j) => Console.WriteLine($"{i}*{j}={i * j}");

    private Func<Student, bool> IsTeenager = student => student.Age > 12 && student.Age < 18;

    public void Execute()
    {
        Console.WriteLine(GetInputWithTypeStringDelegate(124));
        Console.WriteLine(GetInputWithTypeStringLambda(136));
        MutiplayAction(12, 59);
        Console.WriteLine($"student with 25 old year is Teenager? {IsTeenager(new Student() { Age = 25 })}");
        Console.WriteLine($"student with 16 old year is Teenager? {IsTeenager(new Student() { Age = 16 })}");
    }
}