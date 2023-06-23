using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using Med_Docs.models;
using Med_Docs.src;

namespace Med_Docs
{
    public partial class Login : Form
    {
        private SqlConnection _conn;
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*_conn = DbConnection.getConnection();
            int roleID = 0;
            int userID = 0;
            User user;

            //check first if username exist then if password matches

            // get the userId,roleID,doctorID,and firstname


            if (roleID == 1000) //Admin
            {
                string query = $"SELECT RoleID,ID FROM APP_USER WHERE UserName = '{txtUser.Text.ToString().Trim()}'";
                user = new User(userID);
            }
            else if (roleID == 1001) //Doctor
            {
                string query = $"SELECT RoleID,ID FROM APP_USER WHERE UserName = '{txtUser.Text.ToString().Trim()}'";
                user = new Doctor(userID);
            }
            else //Secretary
            {
                int doctorID = 0;
                user = new Secretary(userID,doctorID);
            }*/

            //remove this
            Doctor user = new Doctor(3001,"Joe");

            ParentForm parent = new ParentForm(user);
            parent.Show();
            Hide();
        }

    }
}