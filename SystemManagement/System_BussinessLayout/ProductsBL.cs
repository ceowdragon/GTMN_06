using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;
using System_DatabaseLayout;

namespace System_BussinessLayout
{
    public class ProductsBL
    {
        public ProductsDL database = new ProductsDL();
        public static List<Product> listProducts = new List<Product>();

        public void getData()
        {
            //listProducts.Clear();
            //database.LoadAllDatabase(listProducts);
        }

        public Product getProduct(int productId)
        {
            return null;
        }

        public void InsertProducts(Product product)
        {

        }

        public void UpdateProducts(Product product)
        {

        }

        public void DeleteProducts(Product product)
        {

        }
    }
}
