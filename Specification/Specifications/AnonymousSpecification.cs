using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class AnonymousSpecification<T> : Specification<T>
    {
        public AnonymousSpecification(Expression<Func<T, bool>> expression)
        {
            if (expression == null)
            {
                throw new ArgumentNullException(nameof(expression));
            }
            IsSatisfiedByExpression = expression;
        }

        public override Expression<Func<T, bool>> IsSatisfiedByExpression { get; }
    }
}