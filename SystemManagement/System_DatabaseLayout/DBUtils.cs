using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System_DatabaseLayout
{
    class DBUtils
    {
        public void DatabaseConnection(SqlConnection sqlConnection, SqlCommand sqlCommand)
        {
            string connectionString = "Server=tcp:binhminhdatabase.database.windows.net,1433;Initial Catalog=Bimi_SMDB;Persist Security Info=False;User ID=ceowdragon;Password=Hung@21377622119;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //string connectionString = "Server=DESKTOP-529ADFD;Database=BIMI_SMDB;Trusted_Connection=True;";
            sqlConnection = new SqlConnection(connectionString);
            sqlCommand = sqlConnection.CreateCommand();
        }
    }
}
