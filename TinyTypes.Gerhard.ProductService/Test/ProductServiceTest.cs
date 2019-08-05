using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Xunit;

namespace TinyTypes.Gerhard.ProductService.Test
{
    public class ProductServiceTest
    {
        ProductService productService;
        ProductDTO validProductDto;
        ProductDTO invalidProductDto;
        Product validProduct;
        
        public ProductServiceTest()
        {
            productService = new ProductService();
            validProductDto = new ProductDTO("Bread", 2.99m);
            invalidProductDto = new ProductDTO("Fi$h", -1.99m);
            validProduct = new Product(validProductDto);
        }

        [Fact]
        public void WhenAddingAProduct_ThatHasValidData_ItSavesTheProduct()
        {
            ProductService productService = new ProductService();
            productService.AddNewProduct(validProductDto);
            Assert.True(productService.Products[0].Equals(validProduct));
        }

        [Fact]
        public void WhenAddingAProduct_ThatHasInvalidData_ItDoesNotSaveProductAndDoesErrorHandling()
        {
            ProductService productService = new ProductService();
            Assert.Throws<WebException>(() => productService.AddNewProduct(invalidProductDto));
            Assert.True(productService.Products.Count == 0);
        }
    }
}
