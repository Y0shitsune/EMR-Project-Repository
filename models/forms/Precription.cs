using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Med_Docs.src;

namespace Med_Docs.models.forms
{
    public partial class Prescription : Form
    {
        SqlConnection _conn;
        ParentForm parent;
        User user;
        public Prescription(ParentForm parent, User user)
        {
            InitializeComponent();
            this.parent = parent;
            this.user = user;
            _conn = DbConnection.getConnection();
            string sql = "SELECT PatientID AS ID, Patient_Name AS Patient, Birthdate,Patient_Address AS Address FROM PATIENT";
            Size = new Size(598, 658);
            initTable(sql);
        }
        public void initTable(string query)
        {
            try
            {
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }
        private void Prescription_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
            parent.GoToDashboard();
            Dispose();
            Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MedicineRecords mr = new MedicineRecords(parent,user);
            mr.Show();
            Dispose();
            Hide();
        }
    }
}
