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
    [RoutePrefix("MaterialsInOrder")]
    public class MaterialsInOrderController : ApiController
    {
        MaterialsInOrderBL materialinorderBL = new MaterialsInOrderBL();
        //Lấy toàn bộ danh sách
        [Route("")]
        public IEnumerable<MaterialsInOrder> Get()
        {
            materialinorderBL.getData();

            return MaterialsInOrderBL.listMaterialsinorder;
        }

        //Lấy 1 đối tượng trong danh sách
        [Route("{MaterialsinorderId}")]
        public MaterialsInOrder Get(int MaterialsinorderId)
        {
            return materialinorderBL.getMaterialinorder(MaterialsinorderId);
        }

        //Thêm 1 đối tượng
        [Route("")]
        public int Post([FromBody] MaterialsInOrder materialinorder)
        {
            materialinorderBL.getData();
            materialinorderBL.InsertMaterialsinorder(materialinorder);
            return 1;
        }

        //Cập nhật lại 1 đối tượng
        [Route("")]
        public int Put([FromBody] MaterialsInOrder materialinorder)
        {
            materialinorderBL.UpdateMaterialinorder(materialinorder);
            return 1;

        }

        //Xóa 1 đối tượng
        [Route("{MaterialinorderId}")]
        public int Delete(int MaterialinorderId)
        {
            materialinorderBL.DeleteMaterialinorder(MaterialinorderId);
            return MaterialinorderId;
        }
    }
}
