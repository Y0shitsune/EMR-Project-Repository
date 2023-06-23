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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Med_Docs.models.forms
{
    public partial class Dashboard : Form
    {
        SqlConnection _conn;
        ParentForm parent;
        public Dashboard(ParentForm parent)
        {
            this.parent = parent;
            InitializeComponent();
            TopLevel = false;
            _conn = DbConnection.getConnection();
            loadControls();
        }

        private void loadControls()
        {
            //loadRegistry();
            //loadBirthdayPatients();
            //loadSchedule();
            lblDate.Text = DateTime.Now.ToShortDateString();

            switch (parent.user.getRole())
            {
                case 1000:
                    lblWelcomeMessage.Text = $"Welcome Admin {parent.user.getName()}";
                    lblWelcomeMessage.Location = new Point(Width / 2 - (Width / 13), lblWelcomeMessage.Location.Y);
                    break;
                case 1001:
                    lblWelcomeMessage.Text = $"Welcome Doctor {parent.user.getName()}";
                    lblWelcomeMessage.Location = new Point(Width / 2 - (Width / 13), lblWelcomeMessage.Location.Y);
                    break;
                case 1002:
                    lblWelcomeMessage.Text = $"Welcome Secretary {parent.user.getName()}";
                    lblWelcomeMessage.Location = new Point(Width / 2 - (Width / 12), lblWelcomeMessage.Location.Y);
                    break;
            }
        }

        private void loadRegistry()
        {
            try
            {
                string query = "SELECT PatientID AS ID, Patient_Name AS Patient, Sex, Birthdate, Patient_Address AS Adress, UserID AS Registrant FROM PATIENT;";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvRegistered.DataSource = ds.Tables[0];
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

        public void loadRegistry(string search)
        {
            try
            {
                string query = $"SELECT PatientID AS ID, Patient_Name AS Patient, Sex, Birthdate, Patient_Address AS Address, UserID AS Registrant FROM PATIENT WHERE CONCAT_WS(PatientID,Patient_Name,Sex,Birthdate,Patient_Address,UserID) LIKE '%{search}%';";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvRegistered.DataSource = ds.Tables[0];
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

        private void loadBirthdayPatients()
        {
            try
            {
                string query = "SELECT Patient_Name AS Name, Sex, Birthdate FROM PATIENT;";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                DataTable dt = new DataTable();
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Sex", typeof(string));
                dt.Columns.Add("Birthdate", typeof(string));


                adapter.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    DateTime date = DateTime.Parse(row[2].ToString());

                    if(date.Month.ToString().Equals(DateTime.Now.Month.ToString()))
                    {
                        DataRow dtrow = dt.NewRow();
                        dtrow["Name"] = row[0];
                        dtrow["Sex"] = row[1];
                        dtrow["Birthdate"] = date.ToShortDateString();
                        dt.Rows.Add(dtrow);
                    }
                }

                dgvBirthdays.DataSource = dt;

                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

        private void loadSchedule()
        {
            try
            {
                DataSet schedules = new DataSet();
                string query = $"SELECT PatientID,Patient_Name AS 'Name',Date,Time,UserID AS 'Scheduled By User' FROM SCHEDULE WHERE Date >= '{DateTime.Now.ToShortDateString()}';";

                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(schedules);

                _conn.Close();

            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

    }
}
