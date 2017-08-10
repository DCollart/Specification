using System;
using System.Linq.Expressions;

namespace Specification.Specifications
{
    public abstract class Specification<T> : ISpecification<T>
    {
        public static ISpecification<T> True => new TrueSpecification<T>();
        public static ISpecification<T> False => new FalseSpecification<T>();


        private readonly Lazy<Func<T, bool>> _isSatisfiedBy;

        protected Specification()
        {
            _isSatisfiedBy = new Lazy<Func<T, bool>>(CompileExpression);

        }

        public bool IsSatisfiedBy(T entity)
        {
            return _isSatisfiedBy.Value(entity);
        }

        public abstract Expression<Func<T, bool>> IsSatisfiedByExpression { get; }

        private Func<T, bool> CompileExpression()
        {
            try
            {
                if (IsSatisfiedByExpression == null)
                {
                    throw new UnableToCompileException("The expression is null");
                }

                return IsSatisfiedByExpression.Compile();
            }
            catch (InvalidOperationException exception)
            {
                throw new UnableToCompileException("An error occured during the expression compilation", exception);
            }
        }
    }
}