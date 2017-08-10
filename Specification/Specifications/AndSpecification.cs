using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class AndSpecification<T> : LogicalGateSpecification<T>
    {
        public AndSpecification(params ISpecification<T>[] specifications) : base(specifications)
        {
        }

        protected override Func<Expression, Expression, Expression> LogicalGate => Expression.And;
    }
}