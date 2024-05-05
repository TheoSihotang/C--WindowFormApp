using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KasirApp
{
    internal class ConnectionDb
    {
        public SqlConnection sqlConnection()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-P95993G";
            builder.InitialCatalog = "apotek_db";
            builder.IntegratedSecurity = true;
            builder.TrustServerCertificate = true;
            SqlConnection conn = new SqlConnection();

            conn.ConnectionString = builder.ToString();

            return conn;
        }
    }
}
