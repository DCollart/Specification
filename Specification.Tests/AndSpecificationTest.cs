using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class AndSpecificationTest
    {
        [Test]
        public void Should_True_When_TrueAndTrue()
        {
            // Arrange
            var spec = new AndSpecification<object>(new TrueSpecification<object>(), new TrueSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void Should_False_When_TrueAndFalse()
        {
            // Arrange
            var spec = new AndSpecification<object>(new TrueSpecification<object>(), new FalseSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void Should_False_When_FalseAndTrue()
        {
            // Arrange
            var spec = new AndSpecification<object>(new FalseSpecification<object>(), new TrueSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }


        [Test]
        public void Should_False_When_FalseAndFalse()
        {
            // Arrange
            var spec = new AndSpecification<object>(new FalseSpecification<object>(), new FalseSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }
    }
}