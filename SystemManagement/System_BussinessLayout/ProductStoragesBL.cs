using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;
using System_DatabaseLayout;

namespace System_BussinessLayout
{
    public class ProductStoragesBL
    {
        public ProductStoragesDL database = new ProductStoragesDL();
        public static List<ProductStorages> listProductStorages = new List<ProductStorages>();

        public void getData()
        {
            //listProductStorages.Clear();
            //database.LoadAllDatabase(listProductStorages);
        }

        public void InsertProductStorages(ProductStorages productStorages)
        {
            productStorages.ProductstorageId = listProductStorages.Count() + 1;
            productStorages.ProductDelivery = DateTime.Today.ToString("d");
            listProductStorages.Add(productStorages);

            //SQL INSERT
            database.InsertProductStorages(productStorages);
        }

        public void UpdateProductStorages(ProductStorages productStorages)
        {
            var xProductStorage = listProductStorages.Where(e => e.ProductstorageId == productStorages.ProductstorageId).FirstOrDefault();
            listProductStorages.Remove(xProductStorage);
            productStorages.ProductstorageCode = xProductStorage.ProductstorageCode;
            productStorages.ProductCode = xProductStorage.ProductCode;
            productStorages.ProductDimension = xProductStorage.ProductDimension;
            productStorages.ProductDelivery = xProductStorage.ProductDelivery;
            listProductStorages.Add(productStorages);

            //SQL UPDATE
            database.UpdateProductStorages(productStorages);

        }

        public void DeleteProductStorages(int productstorageId)
        {

        }
    }
}
