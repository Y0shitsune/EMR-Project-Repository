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
    public partial class NewPatient : Form
    {
        SqlConnection _conn;
        ParentForm parentForm;
        public NewPatient(ParentForm parentForm)
        {
            InitializeComponent();
            TopLevel = false;
            this.parentForm = parentForm;
        }

        //Clarence pakilagyan ng text para malinaw kung ano naselect na calendar date ah

        //sige

        //tanks yu

        private void button1_Click(object sender, EventArgs e)
        {
            //NOTE: Wala pa kong validation lol
            //NOTE: Wala ka ring bagong window para sa insurance info lol

            string name = txtName.Text.ToString();
            string sex = cmbGender.Text.ToString();
            DateTime dt = clnBday.SelectionStart;
            string date = $"{dt.Year}-{dt.Month}-{dt.Day}";
            string address = txtAddress.Text.ToString();
            int user = parentForm.user.id;

            string query = "INSERT INTO PATIENT(Patient_Name,Sex,Birthdate,Patient_Address) VALUES" +
                $"('{name}','{sex}','{date}','{address}',{user});";

            try
            {
                if(cbxInsurance.Checked)
                {
                    ArrayList patient = new ArrayList
                    {
                        name,
                        sex,
                        dt,
                        date,
                        address,
                        user,
                    };

                    ParentForm.Enabled = false;
                    Insurance ins = new Insurance(ParentForm, patient, query);
                    ins.Show();
                }
                else
                {
                    _conn = DbConnection.getConnection();
                    _conn.Open();

                    SqlCommand command = new SqlCommand(query, _conn);
                    command.ExecuteNonQuery();

                    _conn.Close();

                    MessageBox.Show("Patient recorded successfull!",
                        "Patient Record");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Certified Bruh Moment",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }
    }
}
