using System;
using System.Collections.Generic;

namespace TinyTypes.Jarrod.Entities.Domain
{
    public abstract class TinyType<T> : IEquatable<TinyType<T>>
    {
        #region Core

        protected TinyType(T value)
        {
            Value = value;
        }

        #endregion

        #region Public Interface

        public T Value { get; }

        #endregion

        #region Equality, Operators

        public bool Equals(TinyType<T> other)
        {
            if (other is null)
                return false;
            if (ReferenceEquals(this, other))
                return true;
            return EqualityComparer<T>.Default.Equals(Value, other.Value);
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
                return false;
            if (ReferenceEquals(this, obj))
                return true;
            if (obj.GetType() != GetType())
                return false;
            return Equals((TinyType<T>) obj);
        }

        public override int GetHashCode()
        {
            return EqualityComparer<T>.Default.GetHashCode(Value);
        }

        public static bool operator ==(TinyType<T> left, TinyType<T> right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(TinyType<T> left, TinyType<T> right)
        {
            return !Equals(left, right);
        }

        #endregion
    }
}
