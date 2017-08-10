using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

//using NUnit.Framework;

namespace Specification.Tests
{
    [TestFixture]
    public class NotSpecificationTest
    {

        [Test]
        public void Should_False_When_True()
        {
            // Arrange
            ISpecification<object> spec = new TrueSpecification<object>();
            spec = new NotSpecification<object>(spec);

            // Act
            var result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void Should_True_When_False()
        {
            // Arrange
            ISpecification<object> spec = new FalseSpecification<object>();
            spec = new NotSpecification<object>(spec);

            // Act
            var result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }
    }
}