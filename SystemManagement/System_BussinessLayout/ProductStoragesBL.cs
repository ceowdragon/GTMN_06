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
        public static List<ProductStorages> listProductStorages = new List<ProductStorages>()
        {
            new ProductStorages(){ ProductstorageId = "1", ProductstorageDate = "02/11/2020", ProductstorageNumber = "UIT20110236", ProductstorageCode = "USA0001", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "20,000"},
            new ProductStorages(){ ProductstorageId = "2", ProductstorageDate = "02/11/2020", ProductstorageNumber = "UIT20110236", ProductstorageCode = "USA0003", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "14,100"},
            new ProductStorages(){ ProductstorageId = "3", ProductstorageDate = "02/11/2020", ProductstorageNumber = "UIT20110236", ProductstorageCode = "USA0004", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "8,900"},
            new ProductStorages(){ ProductstorageId = "4", ProductstorageDate = "03/11/2020", ProductstorageNumber = "UIT20110268", ProductstorageCode = "USA0001", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "36,360"},
            new ProductStorages(){ ProductstorageId = "5", ProductstorageDate = "03/11/2020", ProductstorageNumber = "UIT20110268", ProductstorageCode = "USA0002", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "25,740"},
            new ProductStorages(){ ProductstorageId = "6", ProductstorageDate = "03/11/2020", ProductstorageNumber = "UIT20110268", ProductstorageCode = "USA0006", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "2,000"},
            new ProductStorages(){ ProductstorageId = "7", ProductstorageDate = "07/11/2020", ProductstorageNumber = "UIT20110302", ProductstorageCode = "USA0003", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "13,300"},
            new ProductStorages(){ ProductstorageId = "8", ProductstorageDate = "07/11/2020", ProductstorageNumber = "UIT20110302", ProductstorageCode = "USA0005", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "4,400"},
            new ProductStorages(){ ProductstorageId = "9", ProductstorageDate = "07/11/2020", ProductstorageNumber = "UIT20110302", ProductstorageCode = "USA0006", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "6,500"},
            new ProductStorages(){ ProductstorageId = "10", ProductstorageDate = "07/11/2020", ProductstorageNumber = "UIT20110302", ProductstorageCode = "USA0007", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "17,850"},
            new ProductStorages(){ ProductstorageId = "11", ProductstorageDate = "07/11/2020", ProductstorageNumber = "UIT20110302", ProductstorageCode = "USA0008", ProductstorageName = "Carton for Floria", ProductUnit = "Pcs", ProductstorageQuantity = "23,410"},
            new ProductStorages(){ ProductstorageId = "12", ProductstorageDate = "13/11/2020", ProductstorageNumber = "UIT20110482", ProductstorageCode = "USA0002", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "9,900"},
            new ProductStorages(){ ProductstorageId = "13", ProductstorageDate = "13/11/2020", ProductstorageNumber = "UIT20110482", ProductstorageCode = "USA0003", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "1,250"},
            new ProductStorages(){ ProductstorageId = "14", ProductstorageDate = "13/11/2020", ProductstorageNumber = "UIT20110482", ProductstorageCode = "USA0005", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "500"},
            new ProductStorages(){ ProductstorageId = "15", ProductstorageDate = "13/11/2020", ProductstorageNumber = "UIT20110482", ProductstorageCode = "USA0007", ProductstorageName = "Carton for Floria", ProductUnit = "Pcs", ProductstorageQuantity = "71,720"},
            new ProductStorages(){ ProductstorageId = "16", ProductstorageDate = "25/11/2020", ProductstorageNumber = "UIT20110720", ProductstorageCode = "USA0001", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "8,500"},
            new ProductStorages(){ ProductstorageId = "17", ProductstorageDate = "25/11/2020", ProductstorageNumber = "UIT20110720", ProductstorageCode = "USA0004", ProductstorageName = "Carton for NewYork", ProductUnit = "Pcs", ProductstorageQuantity = "6,400"},
            new ProductStorages(){ ProductstorageId = "18", ProductstorageDate = "25/11/2020", ProductstorageNumber = "UIT20110720", ProductstorageCode = "USA0005", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "29,000"},
            new ProductStorages(){ ProductstorageId = "19", ProductstorageDate = "25/11/2020", ProductstorageNumber = "UIT20110720", ProductstorageCode = "USA0006", ProductstorageName = "Carton for Chicago", ProductUnit = "Pcs", ProductstorageQuantity = "21,120"},
            new ProductStorages(){ ProductstorageId = "20", ProductstorageDate = "25/11/2020", ProductstorageNumber = "UIT20110720", ProductstorageCode = "USA0009", ProductstorageName = "Carton for Floria", ProductUnit = "Pcs", ProductstorageQuantity = "10,100"}
        };

        public void getData()
        {
            //listProductStorages.Clear();
            //database.LoadAllDatabase(listProductStorages);
        }

        public void InsertProductStorages(ProductStorages productStorages)
        {
            //productStorages.ProductstorageId = listProductStorages.Count() + 1;
            //productStorages.ProductDelivery = DateTime.Today.ToString("d");
            //listProductStorages.Add(productStorages);

            ////SQL INSERT
            //database.InsertProductStorages(productStorages);
        }

        public void UpdateProductStorages(ProductStorages productStorages)
        {
            //var xProductStorage = listProductStorages.Where(e => e.ProductstorageId == productStorages.ProductstorageId).FirstOrDefault();
            //listProductStorages.Remove(xProductStorage);
            //productStorages.ProductstorageCode = xProductStorage.ProductstorageCode;
            //productStorages.ProductCode = xProductStorage.ProductCode;
            //productStorages.ProductDimension = xProductStorage.ProductDimension;
            //productStorages.ProductDelivery = xProductStorage.ProductDelivery;
            //listProductStorages.Add(productStorages);

            //SQL UPDATE
            //database.UpdateProductStorages(productStorages);

        }

        public void DeleteProductStorages(int productstorageId)
        {

        }
    }
}
