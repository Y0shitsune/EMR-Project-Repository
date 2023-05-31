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
using Med_Docs.models;
using Med_Docs.src;

namespace Med_Docs
{
    public partial class Main : Form
    {
        User user;
        public Main(User user)
        {
            InitializeComponent();
            this.user = user;
            openCRUD();
        }

        public void openCRUD()
        {
            UserControl1 crud = new UserControl1();
            splitContainer1.Panel2.Controls.Add(crud);
            crud.Dock = DockStyle.Fill;
        }
    }
}
