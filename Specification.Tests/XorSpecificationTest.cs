using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class XorSpecificationTest
    {
        [Test]
        public void Should_False_When_TrueXorTrue()
        {
            // Arrange
            var spec = new ExclusiveOrSpecification<object>(new TrueSpecification<object>(), new TrueSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void Should_True_When_TrueXorFalse()
        {
            // Arrange
            var spec = new ExclusiveOrSpecification<object>(new TrueSpecification<object>(), new FalseSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }

        [Test]
        public void Should_True_When_FalseXorTrue()
        {
            // Arrange
            var spec = new ExclusiveOrSpecification<object>(new FalseSpecification<object>(), new TrueSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeTrue();
        }


        [Test]
        public void Should_False_When_FalseXorFalse()
        {
            // Arrange
            var spec = new ExclusiveOrSpecification<object>(new FalseSpecification<object>(), new FalseSpecification<object>());

            // Act
            bool result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }
    }
}