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
            new Material(){MaterialId = 1, MaterialCode = "USA0001", MaterialName = "Carton for NewYork", MaterialDimensionX = 400, MaterialDimensionY = 500, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "A", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 6532},
            new Material(){MaterialId = 2, MaterialCode = "USA0002", MaterialName = "Carton for NewYork", MaterialDimensionX = 200, MaterialDimensionY = 300, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "A", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 3456},
            new Material(){MaterialId = 3, MaterialCode = "USA0003", MaterialName = "Carton for NewYork", MaterialDimensionX = 600, MaterialDimensionY = 220, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "A", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 2876},
            new Material(){MaterialId = 4, MaterialCode = "USA0004", MaterialName = "Carton for NewYork", MaterialDimensionX = 780, MaterialDimensionY = 160, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "A", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 4567},
            new Material(){MaterialId = 5, MaterialCode = "USA0005", MaterialName = "Carton for Chicago", MaterialDimensionX = 520, MaterialDimensionY = 790, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "BC", MaterialStructure = "2TKT150-3MVN100", MaterialPrize = 14124},
            new Material(){MaterialId = 6, MaterialCode = "USA0006", MaterialName = "Carton for Chicago", MaterialDimensionX = 410, MaterialDimensionY = 520, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "BC", MaterialStructure = "2TKT150-3MVN100", MaterialPrize = 4574},
            new Material(){MaterialId = 7, MaterialCode = "USA0007", MaterialName = "Carton for Chicago", MaterialDimensionX = 660, MaterialDimensionY = 570, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "BC", MaterialStructure = "2TKT150-3MVN100", MaterialPrize = 8764},
            new Material(){MaterialId = 8, MaterialCode = "GER0001", MaterialName = "Carton for Berlin", MaterialDimensionX = 950, MaterialDimensionY = 180, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "AB", MaterialStructure = "1TKT150-4MVN100", MaterialPrize = 1246},
            new Material(){MaterialId = 9, MaterialCode = "GER0002", MaterialName = "Carton for Berlin", MaterialDimensionX = 380, MaterialDimensionY = 800, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "AB", MaterialStructure = "1TKT150-4MVN10", MaterialPrize = 3456},
            new Material(){MaterialId = 10, MaterialCode = "GER0003", MaterialName = "Carton for Berlin", MaterialDimensionX = 590, MaterialDimensionY = 660, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "AB", MaterialStructure = "1TKT150-4MVN10", MaterialPrize = 6512},
            new Material(){MaterialId = 11, MaterialCode = "GER0004", MaterialName = "Carton for Berlin", MaterialDimensionX = 120, MaterialDimensionY = 350, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "AB", MaterialStructure = "1TKT150-4MVN10", MaterialPrize = 7231},
            new Material(){MaterialId = 12, MaterialCode = "GER0005", MaterialName = "Carton for Berlin", MaterialDimensionX = 410, MaterialDimensionY = 740, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "AB", MaterialStructure = "1TKT150-4MVN10", MaterialPrize = 3156},
            new Material(){MaterialId = 13, MaterialCode = "GER0006", MaterialName = "Carton for Munich", MaterialDimensionX = 740, MaterialDimensionY = 1300, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "B", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 2167},
            new Material(){MaterialId = 14, MaterialCode = "GER0007", MaterialName = "Carton for Munich", MaterialDimensionX = 290, MaterialDimensionY = 440, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "B", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 5716},
            new Material(){MaterialId = 15, MaterialCode = "FRA0001", MaterialName = "Carton for Paris", MaterialDimensionX = 1110, MaterialDimensionY = 1100, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "C", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 12574},
            new Material(){MaterialId = 16, MaterialCode = "FRA0002", MaterialName = "Carton for Paris", MaterialDimensionX = 670, MaterialDimensionY = 800, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "C", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 4781},
            new Material(){MaterialId = 17, MaterialCode = "FRA0003", MaterialName = "Carton for Paris", MaterialDimensionX = 780, MaterialDimensionY = 340, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "C", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 6123},
            new Material(){MaterialId = 18, MaterialCode = "FRA0004", MaterialName = "Carton for Paris", MaterialDimensionX = 450, MaterialDimensionY = 500, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "C", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 5456},
            new Material(){MaterialId = 19, MaterialCode = "FRA0005", MaterialName = "Carton for Paris", MaterialDimensionX = 612, MaterialDimensionY = 789, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "B", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 12487},
            new Material(){MaterialId = 20, MaterialCode = "FRA0006", MaterialName = "Carton for Paris", MaterialDimensionX = 360, MaterialDimensionY = 900, MaterialFsc = "RoHS", MaterialUnit = "pcs", MaterialFlute = "B", MaterialStructure = "2TKT150-1MVN100", MaterialPrize = 8563}
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
