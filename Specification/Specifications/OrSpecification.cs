using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class OrSpecification<T> : LogicalGateSpecification<T>
    {
        public OrSpecification(params ISpecification<T>[] specifications) : base(specifications)
        {
        }

        protected override Func<Expression, Expression, Expression> LogicalGate => Expression.Or;
    }
}