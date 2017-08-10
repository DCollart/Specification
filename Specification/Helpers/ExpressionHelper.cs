using System;
using System.Linq.Expressions;

namespace Specification.Helpers
{
    public static class ExpressionHelper
    {

        public static Expression<Func<T, bool>> ReplaceParameters<T>(this Expression<Func<T, bool>> expression, ParameterExpression param)
        {
            return (Expression<Func<T, bool>>)new ReplaceVisitor<T>(param).Modify(expression);
        }

        private class ReplaceVisitor<T> : ExpressionVisitor
        {
            private readonly ParameterExpression _param;

            public ReplaceVisitor(ParameterExpression param)
            {
                _param = param;
            }

            public Expression Modify(Expression expression)
            {
                return Visit(expression);
            }

            protected override Expression VisitParameter(ParameterExpression node)
            {
                return node.Type == typeof(T) ? _param : node;
            }
        }
    }
}