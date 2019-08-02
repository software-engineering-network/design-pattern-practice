using System;
using System.Text.RegularExpressions;

namespace TinyTypes.Gerhard.ProductService
{
    public class ProductName
    {
        private static readonly int MAX_PRODUCT_NAME_LENGTH = 40;
        private static readonly Regex VALID_PRODUCT_NAME_FORMAT = new Regex("^[a-zA-Z0-9 ]*$");

        public string Value
        {
            get;
            private set;
        }

        public ProductName(string productName)
        {
            if (!isValidProductName(productName)) throw new ArgumentException($"Product Name {productName} is not valid.");
            Value = productName;
        }

        public override bool Equals(object obj)
        {
            ProductName otherName = obj as ProductName;
            return Value.Equals(otherName?.Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        private bool isValidProductName(string productName)
        {
            return productName != null
                && productName.Length > 0
                && productName.Length <= MAX_PRODUCT_NAME_LENGTH
                && VALID_PRODUCT_NAME_FORMAT.IsMatch(productName);
        }
    }
}
