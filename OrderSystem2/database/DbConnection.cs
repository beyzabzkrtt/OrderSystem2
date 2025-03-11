using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace OrderSystem2.database
{
    public class DbConnection
    {
        private readonly string _connectionString = "Server=localhost;Database=OrderSystem;Integrated Security=True;TrustServerCertificate=True";

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
