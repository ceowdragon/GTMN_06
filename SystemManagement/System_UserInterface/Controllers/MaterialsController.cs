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
    [RoutePrefix("Materials")]
    public class MaterialsController : ApiController
    {
        MaterialsBL materialBL = new MaterialsBL();
        //Lấy toàn bộ danh sách
        [Route("")]
        public IEnumerable<Material> Get()
        {
            materialBL.getData();

            return MaterialsBL.listMaterials;
        }

        [Route("all")]
        public IEnumerable<Material> GetAll()
        {
            return MaterialsBL.listMaterials;
        }

        //Lấy 1 đối tượng trong danh sách
        [Route("{MaterialId}")]
        public Material Get(int MaterialId)
        {
            return materialBL.getMaterial(MaterialId);
        }

        //Thêm 1 đối tượng
        [Route("")]
        public int Post([FromBody]Material material)
        {
            materialBL.InsertMaterials(material);
            return 1;
        }

        //Cập nhật lại 1 đối tượng
        [Route("")]
        public int Put([FromBody]Material material)
        {
            materialBL.UpdateMaterial(material);
            return 1;

        }

        //Xóa 1 đối tượng
        [Route("{MaterialCode}")]
        public string Delete(string MaterialCode)
        {
            materialBL.DeleteMaterial(MaterialCode);
            return MaterialCode;
        }
    }
}
