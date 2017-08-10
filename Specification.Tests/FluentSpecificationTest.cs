using FluentAssertions;
using NUnit.Framework;
using Specification.Helpers;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class FluentSpecificationTest
    {
        [Test]
        public void Should_BeAnd_When_AndIsCalled()
        {
            // Arrange
            ISpecification<object> spec = new TrueSpecification<object>();

            // Act
            spec = spec.And(new TrueSpecification<object>());

            // Assert
            spec.Should().BeOfType<AndSpecification<object>>();
        }

        [Test]
        public void Should_BeOr_When_OrIsCalled()
        {
            // Arrange
            ISpecification<object> spec = new TrueSpecification<object>();

            // Act
            spec = spec.Or(new TrueSpecification<object>());

            // Assert
            spec.Should().BeOfType<OrSpecification<object>>();
        }

        [Test]
        public void Should_BeXor_When_XorIsCalled()
        {
            // Arrange
            ISpecification<object> spec = new TrueSpecification<object>();

            // Act
            spec = spec.ExclusiveOr(new TrueSpecification<object>());

            // Assert
            spec.Should().BeOfType<ExclusiveOrSpecification<object>>();
        }

        [Test]
        public void Should_BeNot_When_NotIsCalled()
        {
            // Arrange
            ISpecification<object> spec = new TrueSpecification<object>();

            // Act
            spec = spec.Not();

            // Assert
            spec.Should().BeOfType<NotSpecification<object>>();
        }
    }
}