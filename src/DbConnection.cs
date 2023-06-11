using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        public static DataSet doQuery(string query,SqlConnection _conn)
        {
            _conn.Open();
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet results = new DataSet();
            adapter.Fill(results);
            _conn.Close();
            return results;
        }

        public static int getAge(int patID)
        {
            string bdateQuery = "SELECT Birthdate FROM PATIENT " +
                $"WHERE PatientID = {patID};";

            DataSet result = doQuery(bdateQuery, getConnection());

            DateTime birthdate = DateTime.Parse(result.Tables[0].Rows[0][0].ToString());

            TimeSpan age = DateTime.Now - birthdate;
            int years = (int)(age.Days / 365.242199);
            return years;
        }
    }
}