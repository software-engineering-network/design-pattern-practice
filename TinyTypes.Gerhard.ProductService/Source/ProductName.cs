using System;
using System.Text.RegularExpressions;

namespace TinyTypes.Gerhard.ProductService
{
    public class ProductName : TinyType<string>
    {
        private static readonly int MAX_PRODUCT_NAME_LENGTH = 40;
        private static readonly Regex VALID_PRODUCT_NAME_FORMAT = new Regex("^[a-zA-Z0-9 ]*$");

        public ProductName(string value) : base(value)
        {
        }

        public override bool IsValid(string value)
        {
            return !String.IsNullOrWhiteSpace(value) &&
                value.Length <= MAX_PRODUCT_NAME_LENGTH &&
                VALID_PRODUCT_NAME_FORMAT.IsMatch(value);
        }
    }
}
