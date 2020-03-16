using System;
using FluentAssertions;
using TinyTypes.Jarrod.Entities.Domain;
using Xunit;

namespace TinyTypes.Jarrod.Entities.Test
{
    public abstract class EntityBaseTest<T> where T : TinyType<Guid>
    {
        #region Test Methods

        protected abstract Entity<T> CreateDifferentEntity();
        protected abstract Entity<T> CreateSameEntity(Guid id);

        [Fact]
        public void WhenEquating_WithDifferentId_EntitiesAreNotEquivalent()
        {
            var entity = CreateDifferentEntity();
            var differentEntity = CreateDifferentEntity();

            differentEntity.Should().NotBe(entity);
        }

        [Fact]
        public void WhenEquating_WithSameId_EntitiesAreEquivalent()
        {
            var id = Guid.NewGuid();
            var entity = CreateSameEntity(id);
            var equivalentEntity = CreateSameEntity(id);

            equivalentEntity.Should().Be(entity);
        }

        #endregion
    }
}
