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
    public partial class Scheduling : Form
    {
        SqlConnection _conn;
        Form parent;
        public Scheduling(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            _conn = DbConnection.getConnection();
            string sql = "SELECT PatientID AS ID, Patient_Name AS Patient, Birthdate,Patient_Address AS Address FROM PATIENT";
            initTable(sql);
        }

        //$"SELECT PatientID AS ID, Patient_Name AS Patient, Birthdate AS Date of Birth,Patient_Address AS Adress FROM PATIENT WHERE CONCAT_WS(PatientID,Patient_Name,Age,Sex,Birthdate,Patient_Address) LIKE '%{search}%';";
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

        //Clarence pakilagyan ng text para malinaw kung ano naselect na calendar date ah

        //sige

        //tanks yu

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string query = $"SELECT PatientID AS ID, Patient_Name AS Patient, Birthdate,Patient_Address AS Address FROM PATIENT WHERE CONCAT_WS(PatientID,Patient_Name,Sex,Birthdate,Patient_Address) LIKE '%{textBox1.Text}%';";
            initTable(query);
        }

        private void Scheduling_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
            Dispose();
            Hide();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT PatientID AS ID, Patient_Name AS Patient, Birthdate,Patient_Address AS Address FROM PATIENT WHERE CONCAT_WS(PatientID,Patient_Name,Sex,Birthdate,Patient_Address)" +
                    $"LIKE '%{textBox1.Text}%';";
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
    }
}
