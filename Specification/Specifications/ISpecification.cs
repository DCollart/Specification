using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T entity);
        Expression<Func<T, bool>>  IsSatisfiedByExpression { get; }
    }
}