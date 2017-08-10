using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;
using Specification.Helpers;
using Specification.Specifications;

namespace Specification.Tests
{
    [TestFixture]
    public class LinqHelperTest
    {
        private readonly IEnumerable<object> _objects;

        public LinqHelperTest()
        {
            _objects = new List<object>()
            {
                new object(),
                new object(),
                new object()
            };
        }

        [Test]
        public void Should_Full_When_True()
        {
            // Arrange
            var spec = new TrueSpecification<object>();

            // Act
            var result = _objects.Where(spec);

            // Assert
            result.Should().HaveSameCount(_objects);
        }

        [Test]
        public void Should_Empty_When_False()
        {
            // Arrange
            var spec = new FalseSpecification<object>();

            // Act
            var result = _objects.Where(spec);

            // Assert
            result.Should().BeEmpty();
        }
    }
}