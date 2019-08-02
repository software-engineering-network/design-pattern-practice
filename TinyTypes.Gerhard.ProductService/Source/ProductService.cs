using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace TinyTypes.Gerhard.ProductService
{
    public class ProductService
    {
        public List<Product> Products
        {
            get;
            private set;
        }

        public ProductService()
        {
            Products = new List<Product>();
        }

        public void AddNewProduct(ProductDTO productDTO)
        {
            try
            {
                Products.Add(new Product(productDTO));
            } catch (Exception e)
            {
                HandleError(e);
            }
        }

        private void HandleError(Exception e)
        {
            Console.Error.WriteLine(e.Message);
            throw new WebException();
        }
    }
}
