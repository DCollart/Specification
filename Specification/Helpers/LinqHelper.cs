using System.Collections.Generic;
using System.Linq;
using Specification.Specifications;

namespace Specification.Helpers
{
    public static class LinqHelper
    {
        public static IEnumerable<T> Where<T>(this IEnumerable<T> input, ISpecification<T> spec)
        {
            return input.Where(spec.IsSatisfiedBy);
        }

        public static IQueryable<T> Where<T>(this IQueryable<T> input, ISpecification<T> spec)
        {
            return input.Where(spec.IsSatisfiedByExpression);
        }
    }
}