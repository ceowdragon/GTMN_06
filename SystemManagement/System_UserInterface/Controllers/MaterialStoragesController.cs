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
    [RoutePrefix("MaterialStorages")]
    public class MaterialStoragesController : ApiController
    {
        MaterialStorageBL materialstorageBL = new MaterialStorageBL();

        // GET: api/MaterialStorages
        [Route("")]
        public IEnumerable<MaterialStorages> Get()
        {
            //get data
            materialstorageBL.getData();

            return MaterialStorageBL.listMaterialStorages;
        }

        // GET: api/MaterialStorages/5
        [Route("{MaterialStorageId}")]
        public string Get(int MaterialStorageId)
        {
            return "value";
        }

        // POST: api/MaterialStorages
        [Route("")]
        public int Post([FromBody] MaterialStorages materialStorages)
        {
            materialstorageBL.getData();
            materialstorageBL.InsertMaterialStorages(materialStorages);
            return 1;
        }

        // PUT: api/MaterialStorages/5
        [Route("")]
        public int Put([FromBody] MaterialStorages materialStorages)
        {
            materialstorageBL.UpdateMaterialStorages(materialStorages);
            return 1;
        }

        // DELETE: api/MaterialStorages/5
        [Route("{MaterialStorageId}")]
        public void Delete(int MaterialStorageId)
        {

        }
    }
}
