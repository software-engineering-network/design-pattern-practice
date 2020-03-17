using FluentAssertions;
using Xunit;

namespace TinyTypes.Jarrod.Entities.Test
{
    public abstract class TinyTypeBaseTest<T>
    {
        #region Test Methods

        protected abstract T CreateDifferentTinyType();
        protected abstract T CreateTinyType();

        [Fact]
        public void WhenEquating_WithDifferentValue_TinyTypesAreNotEquivalent()
        {
            var tinyType = CreateTinyType();
            var differentTinyType = CreateDifferentTinyType();

            differentTinyType.Should().NotBe(tinyType);
        }

        [Fact]
        public void WhenEquating_WithSameValue_TinyTypesAreEquivalent()
        {
            var tinyType = CreateTinyType();
            var equivalentTinyType = CreateTinyType();

            equivalentTinyType.Should().Be(tinyType);
        }

        #endregion
    }
}
