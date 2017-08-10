using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public class TrueSpecification<T> : Specification<T>
    {
        public override Expression<Func<T, bool>> IsSatisfiedByExpression => (e) => true;
    }
}