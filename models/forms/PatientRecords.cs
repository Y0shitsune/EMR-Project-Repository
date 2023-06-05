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
    public partial class PatientRecords : Form
    {
        SqlConnection _conn;
        public PatientRecords()
        {
            InitializeComponent();
            panel1.Enabled = false;
            TopLevel = false;
            button1.Enabled = false;
            _conn = DbConnection.getConnection();
            initRecords();
        }

        public void initRecords()
        {
            try
            {
                string query = "SELECT PatientID AS ID, Patient_Name AS Patient, Age, Sex, Birthdate,Patient_Address AS Adress FROM PATIENT;";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                _conn.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

        public void initRecords(string search)
        {
            try
            {
                string query = $"SELECT PatientID AS ID, Patient_Name AS Patient, Age, Sex, Birthdate,Patient_Address AS Adress FROM PATIENT WHERE CONCAT_WS(PatientID,Patient_Name,Age,Sex,Birthdate,Patient_Address) LIKE '%{search}%';";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dataGridView1.DataSource = ds.Tables[0];
                _conn.Close();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = radioButton1.Checked;
            button1.Enabled = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            panel1.Enabled = radioButton1.Checked;
            button1.Enabled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                try
                {
                    //Patient_Name AS Patient, Age, Sex, Birthdate,Patient_Address AS Adress FROM PATIENT
                    //validate the inputs
                    int id = (int)dataGridView1.SelectedCells[0].Value;
                    DateTime dt = clnBday.SelectionStart;
                    string date = $"{dt.Year}-{dt.Month}-{dt.Day}";
                    //basta replace where id = id
                    string query = "UPDATE PATIENT SET " +
                        $"Patient_Name = '{txtName.Text}'," +
                        $"Age = '{(int)numAge.Value}'," +
                        $"Sex = '{cbxSex.SelectedItem}'," +
                        $"Birthdate = '{date}'," +
                        $"Patient_Address = '{txtAddress.Text}' " +
                        $"WHERE PatientID = {id};";

                    _conn.Open();
                    SqlCommand command = new SqlCommand(query, _conn);
                    command.ExecuteNonQuery();
                    _conn.Close();
                    initRecords();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                    _conn.Close();
                }
            }
            else if(radioButton2.Checked)
            {
                try
                {
                    string id = dataGridView1.SelectedCells[0].Value.ToString();

                    _conn.Open();
                    string query = $"DELETE FROM INSURANCE WHERE PatientID='{id}'";
                    SqlCommand command = new SqlCommand(query, _conn);
                    command.ExecuteNonQuery();

                    query = $"DELETE FROM PATIENT WHERE PatientID='{id}'";
                    command = new SqlCommand(query, _conn);
                    command.ExecuteNonQuery();
                    _conn.Close();

                    initRecords();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "Error");
                    _conn.Close();
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Patient_Name AS Patient, Age, Sex, Birthdate,Patient_Address AS Adress FROM PATIENT

            //replace rin yung birthdate and sex (somehow idk)
            ArrayList ar = new ArrayList();

            foreach (var item in dataGridView1.SelectedCells)
            {
                ar.Add(item);
            }

            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }

            if(dataGridView1.SelectedCells[2].Value.GetType() != typeof(DBNull))
            {
                string name = dataGridView1.SelectedCells[1].Value.ToString();
                int age = (int)dataGridView1.SelectedCells[2].Value;
                string address = dataGridView1.SelectedCells[5].Value.ToString();

                txtName.Text = name;
                numAge.Value = age;
                txtAddress.Text = address;
            }
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Scheduling s = new Scheduling(ParentForm);
            ParentForm.Enabled = false;
            s.Show();
        }
    }
}
