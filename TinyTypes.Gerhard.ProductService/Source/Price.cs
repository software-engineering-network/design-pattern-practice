using System;
using System.Text.RegularExpressions;

namespace TinyTypes.Gerhard.ProductService
{
    public class Price
    {
        public decimal Value
        {
            get;
            private set;
        }

        public Price(decimal price)
        {
            if (!isValidPrice(price)) throw new ArgumentException($"Price {price} is not valid.");
            this.Value = price;
        }

        public override bool Equals(object obj)
        {
            Price otherPrice = obj as Price;
            return Value.Equals(otherPrice?.Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        private bool isValidPrice(decimal price)
        {
            return price >= 0
                && decimal.Round(price, 2) == price;
        }
    }
}