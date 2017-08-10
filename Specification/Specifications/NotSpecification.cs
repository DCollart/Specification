using System;
using System.Linq;
using System.Linq.Expressions;
using Specification.Helpers;

namespace Specification.Specifications
{
    public class NotSpecification<T> : Specification<T>
    {
        private readonly ISpecification<T> _spec; 
        public NotSpecification(ISpecification<T> spec)
        {
            _spec = spec;
        }

        public override Expression<Func<T, bool>> IsSatisfiedByExpression
        {
            get
            {
                var param = _spec.IsSatisfiedByExpression.Parameters.First();
                var body = Expression.Not(_spec.IsSatisfiedByExpression.Body);
                var lambda = (Expression<Func<T, bool>>)Expression.Lambda(body, param);
                return lambda.ReplaceParameters(param);
            }
        }
    }
}