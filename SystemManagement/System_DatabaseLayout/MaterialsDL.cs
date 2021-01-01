using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System_CommonEntity;

namespace System_DatabaseLayout
{
    public class MaterialsDL
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

        public void LoadAllDatabase(List<Material> materials)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcMaterialsSelect";
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                var material = new Material();
                for (int i = 0; i < sqlDataReader.FieldCount; i++)
                {
                    var colName = sqlDataReader.GetName(i);
                    var value = sqlDataReader.GetValue(i);
                    var property = material.GetType().GetProperty(colName);
                    if (property != null)
                    {
                        property.SetValue(material, value);
                    }
                }
                materials.Add(material);
            }

            sqlConnection.Close();
        }

        public void InsertMaterial(Material material)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcMaterialsInsert @id, @code, @name, @diX, @diY, @fsc, @unit, @flute, @struc, @prize";
            sqlCommand.Parameters.AddWithValue("@id", material.MaterialId);
            sqlCommand.Parameters.AddWithValue("@code", material.MaterialCode);
            sqlCommand.Parameters.AddWithValue("@name", material.MaterialName);
            sqlCommand.Parameters.AddWithValue("@diX", material.MaterialDimensionX);
            sqlCommand.Parameters.AddWithValue("@diY", material.MaterialDimensionY);
            sqlCommand.Parameters.AddWithValue("@fsc", material.MaterialFsc);
            sqlCommand.Parameters.AddWithValue("@unit", material.MaterialUnit);
            sqlCommand.Parameters.AddWithValue("@flute", material.MaterialFlute);
            sqlCommand.Parameters.AddWithValue("@struc", material.MaterialStructure);
            sqlCommand.Parameters.AddWithValue("@prize", material.MaterialPrize);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void UpdateMaterial(Material material)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcMaterialsUpdate @code, @name, @diX, @diY, @fsc, @unit, @flute, @struc, @prize";
            sqlCommand.Parameters.AddWithValue("@code", material.MaterialCode);
            sqlCommand.Parameters.AddWithValue("@name", material.MaterialName);
            sqlCommand.Parameters.AddWithValue("@diX", material.MaterialDimensionX);
            sqlCommand.Parameters.AddWithValue("@diY", material.MaterialDimensionY);
            sqlCommand.Parameters.AddWithValue("@fsc", material.MaterialFsc);
            sqlCommand.Parameters.AddWithValue("@unit", material.MaterialUnit);
            sqlCommand.Parameters.AddWithValue("@flute", material.MaterialFlute);
            sqlCommand.Parameters.AddWithValue("@struc", material.MaterialStructure);
            sqlCommand.Parameters.AddWithValue("@prize", material.MaterialPrize);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void DeleteMaterial(string materialCode)
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlCommand.CommandText = "EXEC dbo.ProcMaterialsDelete @code";
            sqlCommand.Parameters.AddWithValue("@code", materialCode);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }

        public void SearchMaterial()
        {
            DatabaseConnection();
            sqlConnection.Open();

            sqlConnection.Close();
        }
    }
}
