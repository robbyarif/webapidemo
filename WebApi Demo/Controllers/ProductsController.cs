using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_Demo.Models;

namespace WebApi_Demo.Controllers
{
    public class ProductsController : ApiController
    {
        private Product[] products = new Product[]
        {
            new Product {Id = 1, Name = "Honda Mobilio", Category = "Car", Price = 200},
            new Product {Id = 2, Name = "Honda Supra X", Category = "Motorcycle", Price = 15},
            new Product {Id = 3, Name = "Toyota CHR", Category = "Car", Price = 359},
        };

        public IEnumerable<Product> GetAllProducts()
        {
            return products;
        }
        public IHttpActionResult GetProduct(int id)
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                return Redirect("http://google.co.id");
            }
            return Ok(product);
        }

    }
}
