using System;

namespace TinyTypes.Jarrod.Entities.Domain
{
    public abstract class TinyTypeOfGuid : TinyType<Guid>
    {
        #region Core

        protected TinyTypeOfGuid() : this(Guid.Empty)
        {
        }

        protected TinyTypeOfGuid(Guid id) : base(
            id == Guid.Empty
                ? Guid.NewGuid()
                : id
        )
        {
        }

        #endregion
    }
}
