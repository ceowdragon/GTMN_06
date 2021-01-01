using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;

namespace System_DatabaseLayout
{
    public class MaterialStoragesDL
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

        public void LoadAllDatabase(List<MaterialStorages> listMaterialstorage)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcMaterialStoragesSelect";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var materialStorage = new MaterialStorages();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    var colName = sqlDataReader.GetName(i);
                    var value = sqlDataReader.GetValue(i);
                    var property = materialStorage.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(materialStorage, value);
                    }
                }
                listMaterialstorage.Add(materialStorage);
            }

            sqlConnection.Close();
        }

        public void InsertMaterialStorages(MaterialStorages materialStorage)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC ProcMaterialStoragesInsert @id, @codes, @codei, @code, @dimension, @quantity, @delivery, @note";
            sqlCommand.Parameters.AddWithValue("@id", materialStorage.MaterialstorageId);
            sqlCommand.Parameters.AddWithValue("@codes", materialStorage.MaterialstorageCode);
            sqlCommand.Parameters.AddWithValue("@codei", materialStorage.MaterialsinorderCode);
            sqlCommand.Parameters.AddWithValue("@code", materialStorage.MaterialCode);
            sqlCommand.Parameters.AddWithValue("@dimension", materialStorage.MaterialDimension);
            sqlCommand.Parameters.AddWithValue("@quantity", materialStorage.MaterialQuantity);
            sqlCommand.Parameters.AddWithValue("@delivery", materialStorage.MaterialDelivery);
            sqlCommand.Parameters.AddWithValue("@note", materialStorage.MaterialstorageNote);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateMaterialsinorder(MaterialStorages materialStorage)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC ProcMaterialStoragesUpdate @id, @codes, @codei, @code, @dimension, @quantity, @delivery, @note";
            sqlCommand.Parameters.AddWithValue("@id", materialStorage.MaterialstorageId);
            sqlCommand.Parameters.AddWithValue("@codes", materialStorage.MaterialstorageCode);
            sqlCommand.Parameters.AddWithValue("@codei", materialStorage.MaterialsinorderCode);
            sqlCommand.Parameters.AddWithValue("@code", materialStorage.MaterialCode);
            sqlCommand.Parameters.AddWithValue("@dimension", materialStorage.MaterialDimension);
            sqlCommand.Parameters.AddWithValue("@quantity", materialStorage.MaterialQuantity);
            sqlCommand.Parameters.AddWithValue("@delivery", materialStorage.MaterialDelivery);
            sqlCommand.Parameters.AddWithValue("@note", materialStorage.MaterialstorageNote);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void DeleteMaterialsinorder(int materialsinorderId)
        {
            DatabaseConnection();
            sqlConnection.Open();

            

            sqlConnection.Close();
        }

        public void SearchMaterialsinorder()
        {
            DatabaseConnection();
            sqlConnection.Open();



            sqlConnection.Close();
        }
    }
}
