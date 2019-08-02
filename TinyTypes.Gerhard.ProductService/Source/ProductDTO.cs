using System;
using System.Collections.Generic;
using System.Text;

namespace TinyTypes.Gerhard.ProductService
{
    public class ProductDTO
    {
        public string Name
        {
            get;
            private set;
        }

        public decimal Price
        {
            get;
            private set;
        }

        public ProductDTO(string name, decimal price)
        {
            Name = name;
            Price = price;
        }
    }
}
