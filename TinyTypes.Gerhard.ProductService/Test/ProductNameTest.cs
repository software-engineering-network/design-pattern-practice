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

        [Fact]
        public void WhenProductName_IsNull_ItThrowsArgumentException()
        {
            Assert.Throws<ArgumentException>(() => new ProductName(null));
        }

        [Fact]
        public void WhenProductName_IsEmpty_ItThrowsArgumentException()
        {
            string emptyProductName = "";
            Assert.Throws<ArgumentException>(() => new ProductName(emptyProductName));
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
