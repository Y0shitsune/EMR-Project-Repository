using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Med_Docs.src;

namespace Med_Docs.models
{
    public partial class UserControl1 : UserControl
    {
        SqlConnection _conn;
        public UserControl1()
        {
            InitializeComponent();
            initTable();
        }
        
        public void initTable()
        {
            _conn = DbConnection.getConnection();
            _conn.Open();
            string query = "SELECT * FROM APP_USER";
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            _conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
