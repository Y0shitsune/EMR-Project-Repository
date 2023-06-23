using Med_Docs.models.documents;
using Med_Docs.src;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Med_Docs.models.forms
{
    public partial class HospitalSelection : Form
    {
        Form context;
        User user;
        SqlConnection _conn;

        public HospitalSelection(Form context,User user)
        {
            InitializeComponent();
            this.context = context;
            this.user = user;
            initForm();
        }

        private void initForm()
        {
            Parent = context;
            Text = Parent.Text;
            _conn = DbConnection.getConnection();

            string query = "SELECT Description,HospitalID FROM HOSPITAL" +
                " INNER JOIN APP_USER_HOSPITAL ON HOSPITAL.HospitalID = APP_USER_HOSPITAL.HospitalID" +
                $" WHERE APP_USER_HOSPITAL.UserID = {user.getID()};";

            try
            {
                _conn.Open();

                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                cmbHospital.ValueMember = "HospitalID";
                cmbHospital.DisplayMember = "Description";

                cmbHospital.DataSource = ds.Tables[0];

                _conn.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Database Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnProceed_Click(object sender, EventArgs e)
        {
            //get the type-of form

            //string query = $"INSERT FROM PRESCRIPTION(LicenseNumber,FacilityID) VALUES()";

            //CrystalReportGeneration.GenerateReport();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void HospitalSelection_FormClosing(object sender, FormClosingEventArgs e)
        {
            Parent.Enabled = true;
            Dispose();
            Hide();
        }
    }
}
