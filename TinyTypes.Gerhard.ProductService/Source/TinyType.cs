using System;

namespace TinyTypes.Gerhard.ProductService
{
    public abstract class TinyType<T> : IEquatable<TinyType<T>>
    {
        public T Value { get; private set; }

        public TinyType(T value)
        {
            if (!IsValid(value))
                throw new ArgumentException($"Value ${value} is invalid");

            Value = value;
        }

        public bool Equals(TinyType<T> other)
        {
            if (other.Value == null)
                return false;

            return Value.Equals(other.Value);
        }
        
        public override bool Equals(object obj) => Equals(obj);
        public override int GetHashCode() => Value.GetHashCode();
        public static bool operator ==(TinyType<T> left, TinyType<T> right) => left.Equals(right);
        public static bool operator !=(TinyType<T> left, TinyType<T> right) => !left.Equals(right);
        public abstract bool IsValid(T value);
    }
}
