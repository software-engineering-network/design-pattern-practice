using System;
using System.Collections.Generic;

namespace TinyTypes.Jarrod.Entities.Domain
{
    public abstract class Entity<T>
        : IEquatable<Entity<T>>
        where T : TinyType<Guid>
    {
        #region Core

        protected Entity(T id)
        {
            Id = id;
        }

        #endregion

        #region Public Interface

        public T Id { get; }

        #endregion

        #region Equality, Operators

        public bool Equals(Entity<T> other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return EqualityComparer<T>.Default.Equals(Id, other.Id);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Entity<T>) obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Id);
        }

        public static bool operator ==(Entity<T> left, Entity<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Entity<T> left, Entity<T> right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}
