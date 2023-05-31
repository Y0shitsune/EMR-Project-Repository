using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_Docs.src
{
    internal class DbConnection
    {
        private static string connectionString = "Data Source=DESKTOP-3AK887F;Initial Catalog=DB_MedDocs;Integrated Security=True";
        public static SqlConnection getConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}