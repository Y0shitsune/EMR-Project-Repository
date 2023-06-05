using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Med_Docs.src;
using Med_Docs.models.forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

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
            this.user = user;
            InitializeComponent();
            initForm();
        }

        public void initForm()
        {
            WindowState = FormWindowState.Normal;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Image m = pictureBox1.Image;

            Bitmap b = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(m, 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.Dispose();

            pictureBox1.Image = b;
        }

        public void OpenChildForm(Form childForm)
        {
            currentForm.Dispose();
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

        //Side Bar Buttons

        //New Patient Button
        private void button1_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient();
            OpenChildForm(np);
        }

        //Patient Records Button
        private void button2_Click(object sender, EventArgs e)
        {
            PatientRecords np = new PatientRecords();
            np.Show();
            OpenChildForm(np);
        }

        //Scheduling
        private void button4_Click(object sender, EventArgs e)
        {
            Scheduling np = new Scheduling(this);
            Enabled = false;
            np.Show();
        }

        //Laboratory Form
        private void button5_Click(object sender, EventArgs e)
        {

        }

        //Prescription Button
        private void button3_Click(object sender, EventArgs e)
        {

        }

        //Medical Certificate Button
        private void button6_Click(object sender, EventArgs e)
        {

        }


        //Other Buttons

        //Close Button
        private void button7_Click(object sender, EventArgs e)
        {
            Dispose();
            Close();
        }

        //Search Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (currentForm.GetType() == typeof(PatientRecords))
            {
                PatientRecords prForm = (PatientRecords)currentForm;
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
