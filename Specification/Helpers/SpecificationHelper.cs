using Specification.Specifications;

namespace Specification.Helpers
{
    public static class SpecificationHelper
    {
        public static ISpecification<T> And<T>(this ISpecification<T> currentSpec, ISpecification<T> otherSpec)
        {
            return new AndSpecification<T>(currentSpec, otherSpec);
        }

        public static ISpecification<T> Or<T>(this ISpecification<T> currentSpec, ISpecification<T> otherSpec)
        {
            return new OrSpecification<T>(currentSpec, otherSpec);
        }

        public static ISpecification<T> ExclusiveOr<T>(this ISpecification<T> currentSpec, ISpecification<T> otherSpec)
        {
            return new ExclusiveOrSpecification<T>(currentSpec, otherSpec);
        }

        public static ISpecification<T> Not<T>(this ISpecification<T> spec)
        {
            return new NotSpecification<T>(spec);
        }

        public static bool IsSatisfiedBy<T>(this T entity, ISpecification<T> spec)
        {
            return spec.IsSatisfiedBy(entity);
        }
    }
}