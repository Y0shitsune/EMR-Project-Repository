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

        //Constructor
        public ParentForm(User user)
        {
            InitializeComponent();
            WindowState = FormWindowState.Normal;

            Form np = new NewPatient();
            OpenChildForm(np);
        }

    public void OpenChildForm(Form childForm)
        {
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.SizeGripStyle = SizeGripStyle.Auto;

            pnlMain.Controls.Add(childForm);
            pnlMain.Tag = childForm;

            pnlMain.HorizontalScroll.Maximum = 0;
            pnlMain.AutoScroll = false;
            pnlMain.VerticalScroll.Visible = false;
            pnlMain.AutoScroll = true;

            childForm.BringToFront();
            childForm.Show();
        }
    }
}
