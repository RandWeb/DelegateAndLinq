using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ExpressionTrees.ExpressionTreeBasic
{
    public class ExpressionTreeSample
    {
        private Expression<Func<Person, bool>> IsTeenager =
            p => p.Age > 12 && p.Age <= 19;
        public void Sample01(Person person)
        {
            ParameterExpression p = Expression.Parameter(typeof(Person), "p");

            BinaryExpression left = Expression.GreaterThan(
                Expression.Property(p, "Age"), Expression.Constant(12, typeof(int)));

            BinaryExpression right = Expression.LessThanOrEqual(
                Expression.Property(p, "Age"), Expression.Constant(19, typeof(int)));

            BinaryExpression andAlsoBody = Expression.AndAlso(left, right);


            var isTeenagerExpr = Expression.Lambda<Func<Person, bool>>(andAlsoBody, new[] { p });

            var funcTeen = isTeenagerExpr.Compile();
            Console.WriteLine($"{person.ToString()} is Teenager: {funcTeen(person)}");

            Console.WriteLine($"Expression Tree: {isTeenagerExpr}");
            Console.WriteLine($"Expression Tree body: {isTeenagerExpr.Body}");
            Console.WriteLine($"Count of parameters: {isTeenagerExpr.Parameters.Count}");
        }

        public void Sample02()
        {
            var num = 100;
            string res = num > 10 ? "num is greater than 10" : "num is less than 10";
            var ifTrue = Expression.Constant("num is greater than 10", typeof(string));
            var ifFalse = Expression.Constant("num is less than 10", typeof(string));
            var test = Expression.Constant(num > 10, typeof(bool));
            var condition = Expression.Condition(test, ifTrue, ifFalse);
            var func = Expression.Lambda<Func<string>>(condition).Compile();
        }

        public void Sample03()
        {
            Expression<Func<Person, string>> testCondition = p => p.Age > 12 ? "age >12" : "age<=12";

            var ifTrue = Expression.Constant("age >12", typeof(string));
            var ifFalse = Expression.Constant("age<=12", typeof(string));
            var pe = Expression.Parameter(typeof(Person), "p");
            var test = Expression.GreaterThan(Expression.Property(pe, "Age"),
                Expression.Constant(12, typeof(int)));

            var condition = Expression.Condition(test, ifTrue, ifFalse);

            var func = Expression.Lambda<Func<Person, string>>(condition,new []{pe}).Compile();
        }

        public int test(int a, int b)
        {
            var d = a * b;
            d += 42;
            return d;
        }

        public void Sample04()
        {
            var a = Expression.Parameter(typeof(int), "a");
            var b = Expression.Parameter(typeof(int), "b");

            var d = Expression.Variable(typeof(int), "d");

            var c = Expression.Multiply(a, b);
            var assignExpr = Expression.Assign(d, c);

            var x = Expression.Constant(42, typeof(int));
            var addAssign = Expression.AddAssign(d, x);

            var block = Expression.Block(new[] {d}, assignExpr, addAssign);
            var compiled = Expression.Lambda<Func<int, int, int>>(block, new[] {a, b}).Compile();

            Console.WriteLine($" test method (Sample04): {compiled(26, 12)}");
        }
    }
}
