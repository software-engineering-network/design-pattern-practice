using System;
using TinyTypes.Jarrod.Entities.Domain;
using TinyTypes.Jarrod.Entities.Domain.PersonManagement;

namespace TinyTypes.Jarrod.Entities.Test
{
    public class PersonTest : EntityBaseTest<PersonId>
    {
        #region Test Methods

        protected override Entity<PersonId> CreateDifferentEntity()
        {
            return new Person();
        }

        protected override Entity<PersonId> CreateSameEntity(Guid id)
        {
            return new Person(id);
        }

        #endregion
    }
}
