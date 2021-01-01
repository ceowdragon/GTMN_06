using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;
using System_DatabaseLayout;

namespace System_BussinessLayout
{
    public class MaterialStorageBL
    {
        public MaterialStoragesDL database = new MaterialStoragesDL();
        public static List<MaterialStorages> listMaterialStorages = new List<MaterialStorages>();

        public void getData()
        {
            //listMaterialStorages.Clear();
            //database.LoadAllDatabase(listMaterialStorages);
        }

        public void InsertMaterialStorages(MaterialStorages materialStorages)
        {
            materialStorages.MaterialstorageId = listMaterialStorages.Count() + 1;
            materialStorages.MaterialDelivery = DateTime.Today.ToString("d");
            listMaterialStorages.Add(materialStorages);

            //SQL INSERT
            database.InsertMaterialStorages(materialStorages);
        }

        public void UpdateMaterialStorages(MaterialStorages materialStorages)
        {
            var xMaterialStorage = listMaterialStorages.Where(e => e.MaterialstorageId == materialStorages.MaterialstorageId).FirstOrDefault();
            listMaterialStorages.Remove(xMaterialStorage);
            materialStorages.MaterialstorageCode = xMaterialStorage.MaterialstorageCode;
            materialStorages.MaterialsinorderCode = xMaterialStorage.MaterialsinorderCode;
            materialStorages.MaterialCode = xMaterialStorage.MaterialCode;
            materialStorages.MaterialDimension = xMaterialStorage.MaterialDimension;
            materialStorages.MaterialDelivery = xMaterialStorage.MaterialDelivery;
            listMaterialStorages.Add(materialStorages);

            //SQL UPDATE
            database.UpdateMaterialsinorder(materialStorages);

        }

        public void DeleteMaterialStorages(int materialstorageId)
        {

        }
    }
}
