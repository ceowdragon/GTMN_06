using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;
using System_DatabaseLayout;

namespace System_BussinessLayout
{
    public class MaterialsInOrderBL
    {
        public MaterialsInOrderDL database = new MaterialsInOrderDL();
        public static List<MaterialsInOrder> listMaterialsinorder = new List<MaterialsInOrder>();

        public void getData()
        {
            //listMaterialsinorder.Clear();
            //database.LoadAllDatabase(listMaterialsinorder);
        }

        public MaterialsInOrder getMaterialinorder(int materialinorderId)
        {
            var temp = listMaterialsinorder.Where(e => e.MaterialsinorderId == materialinorderId).FirstOrDefault();
            return temp;
        }

        public void InsertMaterialsinorder(MaterialsInOrder materialinorder)
        {
            materialinorder.MaterialsinorderId = listMaterialsinorder.Count() + 1;
            listMaterialsinorder.Add(materialinorder);

            //SQL INSERT
            database.InsertMaterialsinorder(materialinorder);
        }

        public void UpdateMaterialinorder(MaterialsInOrder materialinorder)
        {
            var XMaterialinorder = listMaterialsinorder.Where(e => e.MaterialsinorderId == materialinorder.MaterialsinorderId).FirstOrDefault();
            listMaterialsinorder.Remove(XMaterialinorder);
            materialinorder.MaterialsinorderId = XMaterialinorder.MaterialsinorderId;
            listMaterialsinorder.Add(materialinorder);

            //SQL UPDATE
            database.UpdateMaterialsinorder(materialinorder);
        }

        public void DeleteMaterialinorder(int MaterialinorderId)
        {
            var XMaterialinorder = listMaterialsinorder.Where(e => e.MaterialsinorderId == MaterialinorderId).FirstOrDefault();
            listMaterialsinorder.Remove(XMaterialinorder);

            //SQL DELETE
            database.DeleteMaterialsinorder(MaterialinorderId);
        }
    }
}
