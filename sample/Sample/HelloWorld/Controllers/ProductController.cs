using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DataAccess;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        public List<ProductDto> GetProducts()
        {
            var dbContext = new FashionShopEntities();
            var products = dbContext.Products.Select(x => new ProductDto()
            {
                ProductId = x.ProductId,
                ProductTypeId = x.ProductTypeId,
                Price = x.Price,
                Code =  x.Code,
                Name =  x.Name,
                Image = x.Image,
                Description = x.Description,
                ModifiedBy =x.ModifiedBy,
                ModifiedDate = x.ModifiedDate
            }).ToList();

            return products;
        }
    }
}
