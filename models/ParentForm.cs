using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Med_Docs.src;
using Med_Docs.models.forms;

namespace Med_Docs.models
{
    public partial class ParentForm : Form
    {

        //Fields
        User user;
        Form currentForm = new Form();

        //Constructor
        public ParentForm(User user)
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        public void OpenChildForm(Form childForm)
        {
            currentForm.Close();
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.SizeGripStyle = SizeGripStyle.Auto;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;

            childForm.Width = pnlMain.Width-10;
            childForm.Height += 50;

            childForm.BringToFront();
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            OpenChildForm(np);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientRecords np = new PatientRecords();
            OpenChildForm(np);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (currentForm.GetType() == typeof(PatientRecords)) {
                PatientRecords prForm = (PatientRecords) currentForm;
                prForm.initRecords(textBox1.Text.ToString());
            }
            else
            {
                PatientRecords np = new PatientRecords();
                OpenChildForm(np);
                np.initRecords(textBox1.Text.ToString());
            }
        }
    }
}
