using System;
using Xunit;

namespace TinyTypes.Gerhard.ProductService.Test
{
    public class ProductNameTest
    {
        [Fact]
        public void WhenProductName_IsValid_ItContainsTheValidStringValue()
        {
            string validProductName = "Bread";
            ProductName productName = new ProductName("Bread");
            Assert.Equal(productName.Value, validProductName);
        }

        [Theory]
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        public void WhenProductName_IsNullEmptyOrWhitespace_ItThrowsArgumentException(string value)
        {
            Assert.Throws<ArgumentException>(() => new ProductName(value));
        }

        [Fact]
        public void WhenProductName_IsInvalid_ItThrowsArgumentException()
        {
            string invalidProductName = "Fi$h";
            Assert.Throws<ArgumentException>(() => new ProductName(invalidProductName));
        }

        [Fact]
        public void WhenProductName_IsTooLong_ItThrowsArgumentException()
        {
            string longProductName = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa";
            Assert.Throws<ArgumentException>(() => new ProductName(longProductName));
        }
    }
}
