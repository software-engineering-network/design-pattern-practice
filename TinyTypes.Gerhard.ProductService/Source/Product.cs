using System;
using System.Collections.Generic;
using System.Text;

namespace TinyTypes.Gerhard.ProductService
{
    public class Product : IEquatable<Product>
    {
        public ProductName Name { get; private set; }
        public Price Price { get; private set; }

        public Product(ProductDTO productDTO)
        {
            Price = new Price(productDTO.Price);
            Name = new ProductName(productDTO.Name);
        }

        public Product(Price price, ProductName name)
        {
            Price = price;
            Name = name;
        }

        public bool Equals(Product otherProduct) =>
        Name == otherProduct.Name &&
        Price == otherProduct.Price;
    }
}
