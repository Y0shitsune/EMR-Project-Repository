﻿using System;
using System.Data;
using System.Data.SqlClient;
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
            listUsers();
        }

        public void listUsers()
        {
            try
            {
                //Combo Box DBConnection
                _conn = DbConnection.getConnection();

                _conn.Open();

                string query = "SELECT UserID,First_Name,RoleID FROM APP_USER";
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                Console.WriteLine(ds);

                comboBox1.ValueMember = "RoleID";
                comboBox1.DisplayMember = "First_Name";

                comboBox1.DataSource = ds.Tables[0];

                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No connection to the database has been made", "Database Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string roleID = comboBox1.SelectedValue.ToString();
            comboBox1.ValueMember = "UserID";
            int userID = (int)comboBox1.SelectedValue;
            Console.WriteLine(userID);
            User user = new User(roleID,userID);

            ParentForm parent = new ParentForm(user);
            parent.Show();
            Hide();
        }
    }
}
