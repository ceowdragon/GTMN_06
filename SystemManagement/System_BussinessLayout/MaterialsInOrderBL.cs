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
        public static List<MaterialsInOrder> listMaterialsinorder = new List<MaterialsInOrder>() { 
            new MaterialsInOrder(){ MaterialsinorderId = 1, MaterialCode = "USA0003", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "A", MaterialAmount = "1000", MaterialNote = "Bad conner"},
            new MaterialsInOrder(){ MaterialsinorderId = 2, MaterialCode = "USA0003", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "A", MaterialAmount = "200", MaterialNote = "Error printing"},
            new MaterialsInOrder(){ MaterialsinorderId = 3, MaterialCode = "USA0002", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "AB", MaterialAmount = "100", MaterialNote = "Bad cover"},
            new MaterialsInOrder(){ MaterialsinorderId = 4, MaterialCode = "USA0003", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "AB", MaterialAmount = "120", MaterialNote = "Delivery error"},
            new MaterialsInOrder(){ MaterialsinorderId = 5, MaterialCode = "FRA0001", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "AB", MaterialAmount = "1000", MaterialNote = "Bad conner"},
            new MaterialsInOrder(){ MaterialsinorderId = 6, MaterialCode = "FRA0001", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BE", MaterialAmount = "200", MaterialNote = "Error printing"},
            new MaterialsInOrder(){ MaterialsinorderId = 7, MaterialCode = "FRA0005", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BE", MaterialAmount = "100", MaterialNote = "Bad cover"},
            new MaterialsInOrder(){ MaterialsinorderId = 8, MaterialCode = "FRA0005", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BE", MaterialAmount = "120", MaterialNote = "Delivery error"},
            new MaterialsInOrder(){ MaterialsinorderId = 9, MaterialCode = "GER0003", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "E", MaterialAmount = "1000", MaterialNote = "Bad conner"},
            new MaterialsInOrder(){ MaterialsinorderId = 10, MaterialCode = "GER0003", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "E", MaterialAmount = "200", MaterialNote = "Error printing"},
            new MaterialsInOrder(){ MaterialsinorderId = 11, MaterialCode = "GER0004", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "E", MaterialAmount = "100", MaterialNote = "Bad cover"},
            new MaterialsInOrder(){ MaterialsinorderId = 12, MaterialCode = "GER0004", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BC", MaterialAmount = "120", MaterialNote = "Delivery error"},
            new MaterialsInOrder(){ MaterialsinorderId = 13, MaterialCode = "GER0007", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BC", MaterialAmount = "1000", MaterialNote = "Bad conner"},
            new MaterialsInOrder(){ MaterialsinorderId = 14, MaterialCode = "GER0011", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BC", MaterialAmount = "200", MaterialNote = "Error printing"},
            new MaterialsInOrder(){ MaterialsinorderId = 15, MaterialCode = "CHI0002", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BC", MaterialAmount = "100", MaterialNote = "Bad cover"},
            new MaterialsInOrder(){ MaterialsinorderId = 16, MaterialCode = "CHI0002", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "BC", MaterialAmount = "120", MaterialNote = "Delivery error"},
            new MaterialsInOrder(){ MaterialsinorderId = 17, MaterialCode = "CHI0002", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "C", MaterialAmount = "1000", MaterialNote = "Bad conner"},
            new MaterialsInOrder(){ MaterialsinorderId = 18, MaterialCode = "CHI0005", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "C", MaterialAmount = "200", MaterialNote = "Error printing"},
            new MaterialsInOrder(){ MaterialsinorderId = 19, MaterialCode = "CHI0005", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "C", MaterialAmount = "100", MaterialNote = "Bad cover"},
            new MaterialsInOrder(){ MaterialsinorderId = 20, MaterialCode = "CHI0005", MaterialDimension = "325x310x325", MaterialPrize = "2TKT150-1MVN100", MaterialQuantitySend = "C", MaterialAmount = "120", MaterialNote = "Delivery error"}
        };

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
