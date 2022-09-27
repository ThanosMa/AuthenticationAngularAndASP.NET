using MyDatabase;
using MyDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTest.Controllers
{
    public class ProductController : ApiController
    {

        // GET: api/Product
        
        public IEnumerable<Product> Get()
        { 
            List<Product> products;
            using(ApplicationDbContext db = new ApplicationDbContext())
            {
                products = db.Products.ToList();
            }
            
           
            return products;
        }
        
       
            
            
        

        // GET: api/Product/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Product
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Product/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Product/5
        public void Delete(int id)
        {
        }
    }
}
