using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Collections.Helper
{
    public class ExpressionHelper
    {
        public static Expression<Func<T, bool>> AndExpressions<T>(Expression<Func<T, bool>> expression1,
            Expression<Func<T, bool>> expression2)
        {
            var parameterExpr = Expression.Parameter(typeof(T));
            var expr = Expression.AndAlso(expression1.Body, expression2.Body);
            expr = (BinaryExpression) new ParamReplacer(parameterExpr).Visit(expr);
            var expression = Expression.Lambda<Func<T, bool>>(expr, parameterExpr);
            return expression;
        }
        public static Expression<Func<T, bool>> AndExpressions<T>(params Expression<Func<T, bool>>[] expressions)
        {
            Expression<Func<T, bool>> expression = s => true;
            foreach (var item in expressions)
            {
                if (item==null)
                {
                    continue;
                }
                expression = AndExpressions(expression, item);
            }

            return expression;
        }

    }

    public class ParamReplacer : ExpressionVisitor
    {
        private ParameterExpression ParameterExpression;

        public ParamReplacer(ParameterExpression parameterExpression)
        {
            ParameterExpression = parameterExpression;
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            return base.VisitParameter(ParameterExpression);
        }
    }
}
