using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
            try
            {
                //Combo Box DBConnection
                _conn = DbConnection.getConnection();

                _conn.Open();

                string query = "SELECT UserID,First_Name,RoleID FROM APP_USER";
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                comboBox1.ValueMember = "RoleID";
                comboBox1.DisplayMember = "First_Name";

                comboBox1.DataSource = ds.Tables[0];

                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No connection to the database has been made", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string roleID = comboBox1.SelectedValue.ToString();
            comboBox1.ValueMember = "UserID";
            int userID = (int)comboBox1.SelectedValue;
            User user = new User(roleID,userID);

            ParentForm parent = new ParentForm(user);
            parent.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT MedicineID FROM PRESCRIPTION_DOCUMENT WHERE PrescriptionID = 909321";
                _conn = DbConnection.getConnection();
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                _conn.Close();

                query = $"SELECT * FROM MEDICINE WHERE MedicineID ={ds.Tables[0].Rows[0][0]}";
                ds.Tables[0].Rows.Remove(ds.Tables[0].Rows[0]);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    query += $"\nOR MedicineID ={row[0]}";
                }

                _conn.Open();
                cmd = new SqlCommand(query, _conn);
                adapter = new SqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                _conn.Close();

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    foreach(DataColumn col in ds.Tables[0].Columns)
                    {
                        Console.WriteLine(row[col]);
                    }
                }
            }
            catch(Exception ex)
            {
                _conn.Close();
                MessageBox.Show(ex.Message,"Error");
            }
        }
    }
}
