using System;
using System.Linq.Expressions;
using ExpressionTrees.CustomExpression;
using ExpressionTrees.ExpressionBasic;
using ExpressionTrees.ExpressionTreeBasic;
using ExpressionTrees.ExpressionVisitorBasic;

namespace ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExpressionSample expressionSample=new ExpressionSample();
            //expressionSample.Execute();

            //ExpressionTreeSample  expressionTreeSample=new ExpressionTreeSample();
            //expressionTreeSample.Sample01(new Person()
            //{
            //    Age = 16,FullName = "milad",NationalCode = "12345"
            //});
            //expressionTreeSample.Sample02();
            //expressionTreeSample.Sample03();
            //expressionTreeSample.Sample04();

            PrintExpression printExpression = new PrintExpression("Hello world");
            var compiled = Expression.Lambda<Action>(printExpression).Compile();
            compiled();

            VisitorSample visitorSample = new VisitorSample();
            visitorSample.Execute();
            Console.ReadLine();
        }
    }
}
