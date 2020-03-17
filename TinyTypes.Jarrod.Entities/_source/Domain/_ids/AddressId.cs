using System;

namespace TinyTypes.Jarrod.Entities.Domain
{
    public class AddressId : TinyTypeOfGuid
    {
        #region Core

        public AddressId()
        {
        }

        public AddressId(Guid value) : base(value)
        {
        }

        #endregion
    }
}
