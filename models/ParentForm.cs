using Med_Docs.src;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

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

            this.user = user;
        }
    }
}
