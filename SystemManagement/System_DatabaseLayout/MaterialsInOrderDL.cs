using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;

namespace System_DatabaseLayout
{
    public class MaterialsInOrderDL
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

        public void LoadAllDatabase(List<MaterialsInOrder> listMaterialsinorder)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcMaterialsInOrderSelect";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var materialsinorder = new MaterialsInOrder();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    var colName = sqlDataReader.GetName(i);
                    var value = sqlDataReader.GetValue(i);
                    var property = materialsinorder.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(materialsinorder, value);
                    }
                }
                listMaterialsinorder.Add(materialsinorder);
            }

            sqlConnection.Close();
        }

        public void InsertMaterialsinorder(MaterialsInOrder materialsInOrder)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC ProcMaterialsInOrderInsert @id, @code, @dimension, @prize, @send, @amount, @receive, @note";
            sqlCommand.Parameters.AddWithValue("@id", materialsInOrder.MaterialsinorderId);
            sqlCommand.Parameters.AddWithValue("@code", materialsInOrder.MaterialCode);
            sqlCommand.Parameters.AddWithValue("@dimension", materialsInOrder.MaterialDimension);
            sqlCommand.Parameters.AddWithValue("@prize", materialsInOrder.MaterialPrize);
            sqlCommand.Parameters.AddWithValue("@send", materialsInOrder.MaterialQuantitySend);
            sqlCommand.Parameters.AddWithValue("@amount", materialsInOrder.MaterialAmount);
            sqlCommand.Parameters.AddWithValue("@receive", materialsInOrder.MaterialQuantityReceive);
            sqlCommand.Parameters.AddWithValue("@note", materialsInOrder.MaterialNote);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateMaterialsinorder(MaterialsInOrder materialsInOrder)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC ProcMaterialsInOrderUpdate @id, @code, @dimension, @prize, @send, @amount, @receive, @note";
            sqlCommand.Parameters.AddWithValue("@id", materialsInOrder.MaterialsinorderId);
            sqlCommand.Parameters.AddWithValue("@code", materialsInOrder.MaterialCode);
            sqlCommand.Parameters.AddWithValue("@dimension", materialsInOrder.MaterialDimension);
            sqlCommand.Parameters.AddWithValue("@prize", materialsInOrder.MaterialPrize);
            sqlCommand.Parameters.AddWithValue("@send", materialsInOrder.MaterialQuantitySend);
            sqlCommand.Parameters.AddWithValue("@amount", materialsInOrder.MaterialAmount);
            sqlCommand.Parameters.AddWithValue("@receive", materialsInOrder.MaterialQuantityReceive);
            sqlCommand.Parameters.AddWithValue("@note", materialsInOrder.MaterialNote);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void DeleteMaterialsinorder(int materialsinorderId)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC ProcMaterialsInOrderDelete @id";
            sqlCommand.Parameters.AddWithValue("@id", materialsinorderId);
            sqlCommand.ExecuteNonQuery();

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
