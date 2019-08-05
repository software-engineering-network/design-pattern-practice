using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TinyTypes.Gerhard.ProductService.Test
{
    public class PriceTest
    {
        [Fact]
        public void WhenPrice_IsValid_ItContainsValidDecimalValue()
        {
            decimal validPrice = 9.99m;
            Price price = new Price(validPrice);
            Assert.Equal(price.Value, validPrice);
        }

        [Fact]
        public void WhenPrice_IsNegative_ItThrowsArgumentException()
        {
            decimal negativePrice = -9.99m;
            Assert.Throws<ArgumentException>(() => new Price(negativePrice));
        }

        [Fact]
        public void WhenPrice_IsMoreThanTwoDecimalPlaces_ItThrowsArgumentException()
        {
            decimal priceThatIsTooPrecise = 9.999m;
            Assert.Throws<ArgumentException>(() => new Price(priceThatIsTooPrecise));
        }
    }
}
