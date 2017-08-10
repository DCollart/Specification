using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

//using NUnit.Framework;

namespace Specification.Tests
{
    [TestFixture]
    public class FalseSpecificationTest
    {
        [Test]
        public void Should_True_When_Always()
        {
            // Arrange
            var spec = new FalseSpecification<object>();

            // Act
            var result = spec.IsSatisfiedBy(new object());

            // Assert
            result.Should().BeFalse();
        }

        [Test]
        public void Should_True_When_Null()
        {
            // Arrange
            var spec = new FalseSpecification<object>();

            // Act
            var result = spec.IsSatisfiedBy(null);


            // Assert
            result.Should().BeFalse();
        }
    }
}