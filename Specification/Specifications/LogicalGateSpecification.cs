using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Specification.Helpers;

namespace Specification.Specifications
{
    public abstract class LogicalGateSpecification<T> : Specification<T>
    {
        private readonly IEnumerable<ISpecification<T>> _specifications;

        protected LogicalGateSpecification(params ISpecification<T>[] specifications)
        {
            _specifications = specifications;
        }

        public override Expression<Func<T, bool>> IsSatisfiedByExpression
        {
            get
            {
                var param = _specifications.First().IsSatisfiedByExpression.Parameters.First();
                var body = _specifications.Select(s => s.IsSatisfiedByExpression.Body).Aggregate(LogicalGate);
                var lambda = (Expression<Func<T, bool>>)Expression.Lambda(body, param);
                return lambda.ReplaceParameters(param);
            }
        }

        protected abstract Func<Expression, Expression, Expression> LogicalGate { get; }
    }
}