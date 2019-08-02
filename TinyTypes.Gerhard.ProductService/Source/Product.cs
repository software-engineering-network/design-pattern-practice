using System;
using System.Collections.Generic;
using System.Text;

namespace TinyTypes.Gerhard.ProductService
{
    public class Product
    {
        public ProductName Name
        {
            get;
            private set;
        }

        public Price Price
        {
            get;
            private set;
        }

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

        public override bool Equals(object obj)
        {
            if (!(obj is Product)) return false;
            Product otherProduct = (Product) obj;
            bool nameEqual = Name.Equals(otherProduct.Name);
            bool priceEqual = Price.Equals(otherProduct.Price);
            return Name.Equals(otherProduct.Name) && Price.Equals(otherProduct.Price);
        }
    }
}
