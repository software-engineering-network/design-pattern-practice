using System;
using TinyTypes.Jarrod.Entities.Domain;
using TinyTypes.Jarrod.Entities.Domain.PersonManagement;

namespace TinyTypes.Jarrod.Entities.Test
{
    public class AddressTest : EntityBaseTest<AddressId>
    {
        #region Test Methods

        protected override Entity<AddressId> CreateDifferentEntity()
        {
            return new Address();
        }

        protected override Entity<AddressId> CreateSameEntity(Guid id)
        {
            return new Address(id);
        }

        #endregion
    }
}
