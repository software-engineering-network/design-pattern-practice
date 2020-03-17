using System;
using System.Text.RegularExpressions;

namespace TinyTypes.Gerhard.ProductService
{
    public class Price : TinyType<decimal>
    {
        public Price(decimal value) : base(value)
        {
        }

        public override bool IsValid(decimal value) =>
        value >= 0 &&
        decimal.Round(value, 2) == value;
    }
}
