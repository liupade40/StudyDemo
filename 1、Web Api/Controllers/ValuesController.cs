using _1_Web_Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Http;

namespace _1_Web_Api.Controllers
{
    public class ValuesController : ApiController
    {
        public void Post()
        {
        }
        public HttpResponseMessage Get1()
        {
            
            IEnumerable<Product> products = GetProductsFromDB();

            // Write the list to the response body.
            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, products);
            // response.Content = new StringContent("111");
            
            return response;
        }

        private IEnumerable<Product> GetProductsFromDB()
        {
            Product[] products = new Product[]
          {
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
          };
            return products;
        }
        private IHttpActionResult text()
        {
            return new TextResult("nihao", Request);
        }
        private IHttpActionResult No()
        {
            return NotFound();
        }
    }
}
