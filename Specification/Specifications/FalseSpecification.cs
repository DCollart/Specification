using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class FalseSpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> IsSatisfiedByExpression => (e) => false;
    }
}