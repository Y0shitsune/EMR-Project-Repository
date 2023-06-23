using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Med_Docs.src;
using Med_Docs.models.forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using Med_Docs.models.documents;
using System.Diagnostics;
using System.IO;
using System.Text.Json;

namespace Med_Docs.models
{
    public partial class ParentForm : Form
    {

        //Fields
        Form currentForm = new Form();
        public User user { get; }
        DateTime currentDate = DateTime.Today;

        //Constructor
        public ParentForm(User user)
        {
            this.user = user;
            InitializeComponent();
            InitForm();
            //CompareData();
        }

        private void InitForm()
        {
            WindowState = FormWindowState.Normal;
            Size = Screen.PrimaryScreen.WorkingArea.Size;
            Image m = pictureBox1.Image;

            Bitmap b = new Bitmap(pictureBox1.Width,pictureBox1.Height);
            Graphics g = Graphics.FromImage(b);
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.DrawImage(m, 0, 0, pictureBox1.Width, pictureBox1.Height);
            g.Dispose();

            pnlExitBar.Width = Size.Width;
            pictureBox1.Image = b;

            pnlMain.Height = Size.Height - pnlTopBar.Height;
            pnlMain.Width = Size.Width - pnlSideBar.Width;

            foreach (Control c in pnlSideBar.Controls)
            {
                int buttonCount = pnlSideBar.Controls.Count-1;
                if (c.Name != "pnlLogo")
                {
                    c.Height = (Size.Height - pnlTopBar.Height)/buttonCount;
                    foreach(Control c2 in c.Controls)
                    {
                        c2.Height = c.Height;
                    }
                }
            }
            OpenChildForm(new Dashboard(this));
        }

        private void OpenChildForm(Form childForm)
        {
            if (childForm.GetType() != typeof(Dashboard))
            {
                textBox1.Clear();
            }

            currentForm.Dispose();
            currentForm.Close();

            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.SizeGripStyle = SizeGripStyle.Auto;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;

            childForm.Width = pnlMain.Width-5;
            childForm.Height += 50;

            childForm.BringToFront();
            childForm.Show();

            Console.WriteLine(pnlMain.Size);
            Console.WriteLine(childForm.Size);
        }

        public void GoToDashboard()
        {
            OpenChildForm(new Dashboard(this));
        }

        //Side Bar Buttons

        //New Patient Button
        private void button1_Click(object sender, EventArgs e)
        {
            NewPatient np = new NewPatient(this);
            OpenChildForm(np);
        }

        //Patient Records Button
        private void button2_Click(object sender, EventArgs e)
        {
            PatientRecords pr = new PatientRecords();
            pr.Show();
            OpenChildForm(pr);
        }

        //Laboratory Form
        private void button5_Click(object sender, EventArgs e)
        {

        }

        //Prescription Button
        private void button3_Click(object sender, EventArgs e)
        {
            Prescription pn = new Prescription(this,user);
            Enabled = false;
            pn.Show();
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
            Application.Exit();
        }

        //Search Box
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (currentForm.GetType() == typeof(Dashboard))
            {
                Dashboard dash = (Dashboard)currentForm;
                dash.loadRegistry(textBox1.Text.ToString());
            }
            else
            {
                Dashboard dash = new Dashboard(this);
                OpenChildForm(dash);
                dash.loadRegistry(textBox1.Text.ToString());
            }
        }

        private void ParentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            currentForm.Dispose();
            currentForm.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard dash = new Dashboard(this);
            dash.Show();
            OpenChildForm(dash);
        }
    }
}
