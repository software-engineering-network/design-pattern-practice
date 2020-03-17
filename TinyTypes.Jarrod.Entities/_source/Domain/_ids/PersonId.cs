using System;

namespace TinyTypes.Jarrod.Entities.Domain
{
    public class PersonId : TinyTypeOfGuid
    {
        #region Core

        public PersonId()
        {
        }

        public PersonId(Guid value) : base(value)
        {
        }

        #endregion
    }
}
