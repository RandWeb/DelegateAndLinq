using System;
using System.Collections.Generic;
using System.Text;

namespace LambdaExpression
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

    }
    public class LambdaExpressionSample
    {
        private Func<int, string> MyFunc01 = delegate(int i)
        {
            return i.ToString();
        };

        private Func<int, string> MyFunc02 = i =>
        {
            Console.WriteLine($"input parameters:{i}");
            return i.ToString();
        };

        private Func<int, string> MyFunc03 = (i) => i.ToString();

        private Action<int, int> action01 = (i, j) => Console.WriteLine($"{i}*{j}={i * j}");

        private Func<Student, bool> IsTeenager = student => student.Age > 12 && student.Age < 18;

        public void Execute()
        {
            Console.WriteLine(MyFunc01(124));
            Console.WriteLine(MyFunc02(136));
            action01(12, 59);
            Console.WriteLine($"student with 25 old year is Teenager? {IsTeenager(new Student() {Age = 25})}");
            Console.WriteLine($"student with 16 old year is Teenager? {IsTeenager(new Student() {Age = 16})}");
            
        }
    }
}
