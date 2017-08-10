using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class ExclusiveOrSpecification<T> : LogicalGateSpecification<T>
    {
        public ExclusiveOrSpecification(params ISpecification<T>[] specifications) : base(specifications)
        {
        }

        protected override Func<Expression, Expression, Expression> LogicalGate => Expression.ExclusiveOr;
    }
}