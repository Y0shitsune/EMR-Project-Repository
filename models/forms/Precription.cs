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
    public partial class Prescription : Form
    {
        SqlConnection _conn;
        ParentForm parent;
        public Prescription(Form parent)
        {
            InitializeComponent();
        }
    }
}
