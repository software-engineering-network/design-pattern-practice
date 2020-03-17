using System;
using System.Collections.Generic;

namespace TinyTypes.Jarrod.Entities.Domain.PersonManagement
{
    public class Person : Entity<PersonId>
    {
        #region Core

        private readonly List<Address> _addresses;

        public Person() : base(new PersonId())
        {
        }

        public Person(Guid id) : base(new PersonId(id))
        {
            _addresses = new List<Address>();
        }

        #endregion

        #region Public Interface

        public IEnumerable<Address> Addresses => _addresses;

        public void Add(Address address)
        {
            _addresses.Add(address);
        }

        #endregion
    }
}
