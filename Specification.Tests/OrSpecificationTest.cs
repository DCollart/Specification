using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class OrSpecificationTest
    {
        [Test]
        public void Should_True_When_TrueOrTrue()
        {
            // Arrange
            var spec = new OrSpecification<object>(new TrueSpecification<object>(), new TrueSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void Should_True_When_TrueOrFalse()
        {
            // Arrange
            var spec = new OrSpecification<object>(new TrueSpecification<object>(), new FalseSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void Should_True_When_FalseOrTrue()
        {
            // Arrange
            var spec = new OrSpecification<object>(new FalseSpecification<object>(), new TrueSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }


        [Test]
        public void Should_False_When_FalseOrFalse()
        {
            // Arrange
            var spec = new OrSpecification<object>(new FalseSpecification<object>(), new FalseSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }
    }
}