using System;
using System.Linq.Expressions;
using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class SpecificationTest
    {
        private class TestSpecification : Specification<object>
        {
            public override Expression<Func<object, bool>> IsSatisfiedByExpression => null;
        }

        [Test]
        public void Should_ThrowUnableToCompileException_When_Null()
        {
            // Arrange
            var spec = new TestSpecification();
            Action action = () => spec.IsSatisfiedBy(new object());

            // Act & Assert
            action.ShouldThrow<UnableToCompileException>();
        }
    }
}