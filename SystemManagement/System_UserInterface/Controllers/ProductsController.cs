using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System_BussinessLayout;
using System_CommonEntity;

namespace System_UserInterface.Controllers
{
    [RoutePrefix("Products")]
    public class ProductsController : ApiController
    {
        ProductsBL productsBL = new ProductsBL();
        // GET: api/Products
        [Route("")]
        public IEnumerable<Product> Get()
        {
            productsBL.getData();
            return ProductsBL.listProducts;
        }

        // GET: api/Products/5
        [Route("{ProductCode}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        [Route("")]
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        [Route("")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        [Route("ProductId")]
        public void Delete(int id)
        {
        }
    }
}
