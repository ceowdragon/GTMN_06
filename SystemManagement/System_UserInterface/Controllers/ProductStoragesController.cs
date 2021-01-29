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
    [RoutePrefix("ProductStorages")]
    public class ProductStoragesController : ApiController
    {
        ProductStoragesBL productStoragesBL = new ProductStoragesBL();
        // GET: api/ProductStorages
        [Route("")]
        public IEnumerable<ProductStorages> Get()
        {
            productStoragesBL.getData();
            return ProductStoragesBL.listProductStorages;
        }

        // GET: api/ProductStorages/5
        [Route("{ProductStorageId}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/ProductStorages
        [Route("")]
        public int Post([FromBody]ProductStorages productStorages)
        {
            return 1;
        }

        // PUT: api/ProductStorages/5
        [Route("")]
        public int Put([FromBody]ProductStorages productStorages)
        {
            return 1;
        }

        // DELETE: api/ProductStorages/5
        [Route("{ProductStorageId}")]
        public void Delete(int id)
        {
        }
    }
}
