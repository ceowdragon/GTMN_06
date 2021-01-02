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
        public static List<Product> listProducts = new List<Product>() { 
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201201", ProductFsc = "110258", ProductUnit = "$22,159.33", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201202", ProductFsc = "110547", ProductUnit = "$65,478.58", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201203", ProductFsc = "110962", ProductUnit = "$48,152.96", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201204", ProductFsc = "110782", ProductUnit = "$84,457.02", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201205", ProductFsc = "110120", ProductUnit = "$20,520.64", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201206", ProductFsc = "110475", ProductUnit = "$55,648.17", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201207", ProductFsc = "110258", ProductUnit = "$22,159.33", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201208", ProductFsc = "110547", ProductUnit = "$65,478.58", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201209", ProductFsc = "110962", ProductUnit = "$48,152.96", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201210", ProductFsc = "110782", ProductUnit = "$84,457.02", ProductFlute = "Done"},
            new Product(){ ProductId = "11/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201211", ProductFsc = "110120", ProductUnit = "$20,520.64", ProductFlute = "Done"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201212", ProductFsc = "None", ProductUnit = "$55,648.17", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201213", ProductFsc = "None", ProductUnit = "$65,478.58", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201214", ProductFsc = "None", ProductUnit = "$48,152.96", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201215", ProductFsc = "None", ProductUnit = "$84,457.02", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201216", ProductFsc = "None", ProductUnit = "$20,520.64", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201217", ProductFsc = "None", ProductUnit = "$55,648.17", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201218", ProductFsc = "None", ProductUnit = "$65,478.58", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201219", ProductFsc = "None", ProductUnit = "$48,152.96", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201220", ProductFsc = "None", ProductUnit = "$84,457.02", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201221", ProductFsc = "None", ProductUnit = "$20,520.64", ProductFlute = "Deliveried"},
            new Product(){ ProductId = "12/2020", ProductCode = "USA", ProductName = "3852147825", ProductDimension = "NY-201222", ProductFsc = "None", ProductUnit = "$55,648.17", ProductFlute = "Deliveried"}
        };

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
