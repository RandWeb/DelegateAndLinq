using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using ExpressionTrees.CustomExpression;

namespace ExpressionTrees.ExpressionVisitorBasic
{
    public class PrintExpressionVisitor:ExpressionVisitor
    {
        protected override Expression VisitExtension(Expression node)
        {
            if (node is PrintExpression printExpression)
            {
                return new PrintExpression("Say: "+printExpression.Text.ToUpper());
            }
            else
            {
                return base.VisitExtension(node);
            }
        }
    }

    public class VisitorSample
    {
        public void Execute()
        {
            PrintExpressionVisitor visitor=new PrintExpressionVisitor();
            Expression print=new PrintExpression("Hello world");
            Expression visitedPrint = visitor.Visit(print);
            var compiled = Expression.Lambda<Action>(visitedPrint).Compile();
            compiled();

        }
    }
}
