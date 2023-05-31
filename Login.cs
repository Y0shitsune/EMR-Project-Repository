using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Med_Docs.models;
using Med_Docs.src;

namespace Med_Docs
{
    public partial class Login : Form
    {
        private SqlConnection _conn;
        public Login()
        {
            InitializeComponent();
            listUsers();
        }

        public void listUsers()
        {
            //Combo Box DBConnection
            _conn = DbConnection.getConnection();

            _conn.Open();

            string query = "SELECT First_Name,RoleID FROM APP_USER";
            SqlCommand cmd = new SqlCommand(query, _conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            adapter.Fill(ds);

            Console.WriteLine(ds);

            comboBox1.ValueMember = "RoleID";
            comboBox1.DisplayMember = "First_Name";

            comboBox1.DataSource = ds.Tables[0];

            _conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string roleID = comboBox1.SelectedValue.ToString();
            User user = new User(roleID);
            
            ParentForm parent = new ParentForm(user);
            parent.Show();
            this.Hide();
        }
    }
}
