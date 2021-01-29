using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;

namespace System_DatabaseLayout
{
    public class ProductStoragesDL
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

        public void LoadAllDatabase(List<ProductStorages> listProductStorages)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcProductStoragesSelect";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var productStorage = new ProductStorages();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    var colName = sqlDataReader.GetName(i);
                    var value = sqlDataReader.GetValue(i);
                    var property = productStorage.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(productStorage, value);
                    }
                }
                listProductStorages.Add(productStorage);
            }

            sqlConnection.Close();
        }

        public void InsertProductStorages(ProductStorages productStorages)
        {
            DatabaseConnection();
            sqlConnection.Open();

            //sqlCommand.CommandText = "EXEC ProcProductStoragesInsert @id, @codes, @code, @dimension, @quantity, @delivery, @note";
            //sqlCommand.Parameters.AddWithValue("@id", productStorages.ProductstorageId);
            //sqlCommand.Parameters.AddWithValue("@codes", productStorages.ProductstorageCode);
            //sqlCommand.Parameters.AddWithValue("@code", productStorages.ProductCode);
            //sqlCommand.Parameters.AddWithValue("@dimension", productStorages.ProductDimension);
            //sqlCommand.Parameters.AddWithValue("@quantity", productStorages.ProductQuantity);
            //sqlCommand.Parameters.AddWithValue("@delivery", productStorages.ProductDelivery);
            //sqlCommand.Parameters.AddWithValue("@note", productStorages.ProductstorageNote);
            //sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateProductStorages(ProductStorages productStorages)
        {
            DatabaseConnection();
            sqlConnection.Open();

            //sqlCommand.CommandText = "EXEC ProcProductStoragesUpdate @id, @codes, @code, @dimension, @quantity, @delivery, @note";
            //sqlCommand.Parameters.AddWithValue("@id", productStorages.ProductstorageId);
            //sqlCommand.Parameters.AddWithValue("@codes", productStorages.ProductstorageCode);
            //sqlCommand.Parameters.AddWithValue("@code", productStorages.ProductCode);
            //sqlCommand.Parameters.AddWithValue("@dimension", productStorages.ProductDimension);
            //sqlCommand.Parameters.AddWithValue("@quantity", productStorages.ProductQuantity);
            //sqlCommand.Parameters.AddWithValue("@delivery", productStorages.ProductDelivery);
            //sqlCommand.Parameters.AddWithValue("@note", productStorages.ProductstorageNote);
            //sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void DeleteProductStorages(int productstoragesId)
        {

        }

        public void SearchProductStorages(string key)
        {

        }
    }
}
