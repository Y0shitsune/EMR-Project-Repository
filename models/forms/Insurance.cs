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
using Med_Docs.src;

namespace Med_Docs.models.forms
{
    public partial class Insurance : Form
    {
        SqlConnection _conn;
        Form parent;
        ArrayList patient;
        string query;
        public Insurance(Form parent,ArrayList patient, string query)
        {
            InitializeComponent();
            this.parent = parent;
            this.patient = patient;
            this.query = query;
            _conn = DbConnection.getConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //validate muna input bago mag execute
            //note: do try catch and use functions
            addNewEntry(query);

            query = $"SELECT PatientID FROM PATIENT WHERE Patient_Name='{patient[0]}'";

            string patientID = getPatientID(query);
            string insuranceID = textBox1.Text.ToString();
            string provider = txtName.Text.ToString();
            DateTime dt = monthCalendar1.SelectionStart;
            string expiration = $"{dt.Year}-{dt.Month}-{dt.Day}";


            query = "INSERT INTO INSURANCE VALUES(" +
                $"'{insuranceID}'," +
                $"'{provider}'," +
                $"'{expiration}'," +
                $"{patientID}" +
                $");"
            ;

            addNewEntry(query);

            MessageBox.Show("Patient recorded successfully!", "Patient Record");

            parent.Enabled = true;
            parent.Show();
            Hide();
            try
            {

                
            }
            catch(Exception ex)
            {
                
                //MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                _conn.Close();
            }
        }

        private void addNewEntry(string q)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand(q, _conn);
            command.ExecuteNonQuery();
            _conn.Close();
        }

        private string getPatientID(string q)
        {
            _conn.Open();
            SqlCommand command = new SqlCommand(q, _conn);
            SqlDataAdapter da = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            da.Fill(ds);
            _conn.Close();
            return ds.Tables[0].Rows[0]["PatientID"].ToString();
        }
    }
}
