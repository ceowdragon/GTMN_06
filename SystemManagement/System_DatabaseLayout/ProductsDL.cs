using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;

namespace System_DatabaseLayout
{
    public class ProductsDL
    {
        SqlConnection sqlConnection = new SqlConnection();
        SqlCommand sqlCommand = new SqlCommand();

        public void DatabaseConnection()
        {
            string connectionString = "Server=tcp:binhminhdatabase.database.windows.net,1433;Initial Catalog=Bimi_SMDB;Persist Security Info=False;User ID=ceowdragon;Password=Hung@21377622119;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //string connectionString = "Server=DESKTOP-529ADFD;Database=BIMI_SMDB;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
        }

        public void LoadAllDatabase(List<Product> products)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcProductsSelect";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var product = new Product();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    var colName = sqlDataReader.GetName(i);
                    var value = sqlDataReader.GetValue(i);
                    var property = product.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(product, value);
                    }
                }
                products.Add(product);
            }

            sqlConnection.Close();
        }

        public void InsertProduct(Product product)
        {

        }

        public void UpdateProduct(Product product)
        {

        }

        public void DeletaProduct(int productId)
        {

        }

        public void SearchProduct(string key)
        {

        }
    }
}
