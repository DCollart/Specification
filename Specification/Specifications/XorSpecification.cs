using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class XorSpecification<T> : LogicalGateSpecification<T>
    {
        public XorSpecification(params ISpecification<T>[] specifications) : base(specifications)
        {
        }

        protected override Func<Expression, Expression, Expression> LogicalGate => Expression.ExclusiveOr;
    }
}