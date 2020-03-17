using System;
using TinyTypes.Jarrod.Entities.Domain;

namespace TinyTypes.Jarrod.Entities.Test
{
    public class PersonIdTest : TinyTypeBaseTest<PersonId>
    {
        #region Core

        private readonly Guid _id;

        public PersonIdTest()
        {
            _id = Guid.NewGuid();
        }

        #endregion

        #region Test Methods

        protected override PersonId CreateDifferentTinyType()
        {
            return new PersonId();
        }

        protected override PersonId CreateTinyType()
        {
            return new PersonId(_id);
        }

        #endregion
    }
}
