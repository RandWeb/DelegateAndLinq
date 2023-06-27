using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace ExpressionTrees.CustomExpression
{
    public class PrintExpression : Expression
    {
        public string Text { get; private set; }

        private static readonly MethodInfo _method = typeof(Console)
            .GetMethod("WriteLine", new Type[] { typeof(string) });

        public PrintExpression(string text)
        {
            Text = text;
        }

        public override bool CanReduce => true;

        public override Expression Reduce()
        {
            return Expression.Call(null, _method, Expression.Constant(Text));
        }

        public override ExpressionType NodeType => ExpressionType.Extension;

        public override Type Type => _method.ReturnType;

        public override string ToString()
        {
            return $"Print: {Text}";
        }
    }
}
