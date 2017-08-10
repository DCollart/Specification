using System;
using FluentAssertions;
using NUnit.Framework;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class AnonymousSpecificationTest
    {
        [Test]
        public void Should_ThrowNullArgumentException_When_Null()
        {
            // Arrange
            Action action = () => new AnonymousSpecification<object>(null);

            // Act & Assert
            action.ShouldThrow<ArgumentNullException>();
        }
    }
}