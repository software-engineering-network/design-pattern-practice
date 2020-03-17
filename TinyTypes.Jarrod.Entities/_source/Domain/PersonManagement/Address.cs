using System;

namespace TinyTypes.Jarrod.Entities.Domain.PersonManagement
{
    public class Address : Entity<AddressId>
    {
        #region Core

        public Address() : base(new AddressId())
        {
        }

        public Address(Guid id) : base(new AddressId(id))
        {
        }

        #endregion
    }
}
