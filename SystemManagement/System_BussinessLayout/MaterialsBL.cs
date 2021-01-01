using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;
using System_DatabaseLayout;

namespace System_BussinessLayout
{
    public class MaterialsBL
    {
        public MaterialsDL database = new MaterialsDL();
        public static List<Material> listMaterials = new List<Material>()
        {
            new Material(){MaterialId = 1, MaterialCode = "2", MaterialName = "3", MaterialDimensionX = 400, MaterialDimensionY = 500, MaterialFsc = "6", MaterialUnit = "7", MaterialFlute = "A", MaterialStructure = "8", MaterialPrize = 20000}
        };
    

        public void getData()
        {
            //listMaterials.Clear();
            //database.LoadAllDatabase(listMaterials);
        }

        public Material getMaterial(int materialId)
        {
            var temp = listMaterials.Where(e => e.MaterialId == materialId).FirstOrDefault();
            return temp;
        }

        public void InsertMaterials(Material material)
        {
            material.MaterialId = listMaterials.Count() + 1;
            listMaterials.Add(material);

            //SQL INSERT
            database.InsertMaterial(material);
        }

        public void UpdateMaterial(Material material)
        {
            var XMaterial = listMaterials.Where(e => e.MaterialCode == material.MaterialCode).FirstOrDefault();
            listMaterials.Remove(XMaterial);
            material.MaterialId = XMaterial.MaterialId;
            listMaterials.Add(material);

            //SQL UPDATE
            database.UpdateMaterial(material);
        }

        public void DeleteMaterial(string materialCode)
        {
            var XMaterial = listMaterials.Where(e => e.MaterialCode == materialCode).FirstOrDefault();
            listMaterials.Remove(XMaterial);

            //SQL DELETE
            database.DeleteMaterial(materialCode);
        }
    }
}
