using System;
using TinyTypes.Jarrod.Entities.Domain;

namespace TinyTypes.Jarrod.Entities.Test
{
    public class AddressIdTest : TinyTypeBaseTest<AddressId>
    {
        #region Core

        private readonly Guid _id;

        public AddressIdTest()
        {
            _id = Guid.NewGuid();
        }

        #endregion

        #region Test Methods

        protected override AddressId CreateDifferentTinyType()
        {
            return new AddressId();
        }

        protected override AddressId CreateTinyType()
        {
            return new AddressId(_id);
        }

        #endregion
    }
}
