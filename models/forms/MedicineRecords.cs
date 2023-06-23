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

namespace Med_Docs.models.forms
{
    public partial class MedicineRecords : Form
    {
        //ATTRIBUTES
        SqlConnection _conn;
        ParentForm parent;
        User user;

        //CONSTRUCTOR
        public MedicineRecords(ParentForm parent, User user)
        {
            InitializeComponent();
            this.parent = parent;
            Parent = parent;
            this.user = user;
            _conn = DbConnection.getConnection();
            initRecords();
        }

        //FUNCTIONS
        public void initRecords()
        {
            try
            {
                string query = "SELECT DISTINCT(Description),Doses FROM MEDICINE";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvMedicine.DataSource = ds.Tables[0];
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }
        public void initRecords(string search)
        {
            try
            {
                string query = "SELECT Description,Doses FROM MEDICINE";
                _conn.Open();
                SqlCommand cmd = new SqlCommand(query, _conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                DataSet ds = new DataSet();

                adapter.Fill(ds);

                dgvMedicine.DataSource = ds.Tables[0];
                _conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
                _conn.Close();
            }
        }

        //EVENTS
        private void button1_Click(object sender, EventArgs e)
        {
            if(rbnAdd.Checked)
            {
                //Description,'\n','Sig: ',Doses,'\n','#',Total
                //string newRow = "Description,'\n','Sig: ',Doses,'\n','#',Total";
                dgvNewPrescription.Rows.Add(txtDescription.Text,txtDoses.Text,numAmount.Value,cmbType.Text);
            }
            else if(rbnEdit.Checked)
            {
                int selectedRow = dgvNewPrescription.CurrentCell.RowIndex;
                if (selectedRow != dgvNewPrescription.NewRowIndex)
                {
                    dgvNewPrescription.Rows[selectedRow].Cells[0].Value = txtDescription.Text;
                    dgvNewPrescription.Rows[selectedRow].Cells[1].Value = txtDoses.Text;
                    dgvNewPrescription.Rows[selectedRow].Cells[2].Value = numAmount.Value;
                    dgvNewPrescription.Rows[selectedRow].Cells[3].Value = cmbType.Text;
                }
            }
            else if(rbnRemove.Checked)
            {
                int selectedRow = dgvNewPrescription.CurrentCell.RowIndex;
                if(selectedRow != dgvNewPrescription.NewRowIndex)
                {
                    dgvNewPrescription.Rows.RemoveAt(selectedRow);
                    dgvNewPrescription.Refresh();
                }
            }
        }
        private void rbnAdd_CheckedChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtDoses.Text = "";
            numAmount.Value = 0;
            cmbType.Text = "";
            pnlCRUD.Enabled = true;
            btnCommit.Enabled = true;
        }
        private void rbnEdit_CheckedChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtDoses.Text = "";
            numAmount.Value = 0;
            cmbType.Text = "";
            pnlCRUD.Enabled = true;
            btnCommit.Enabled = true;
        }
        private void rbnRemove_CheckedChanged(object sender, EventArgs e)
        {
            txtDescription.Text = "";
            txtDoses.Text = "";
            numAmount.Value = 0;
            cmbType.Text = "";
            pnlCRUD.Enabled = false;
            btnCommit.Enabled = true;
        }
        private void MedicineRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            parent.Enabled = true;
            parent.GoToDashboard();
            Dispose();
            Hide();
        }
        private void dgvNewPrescription_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRow = dgvNewPrescription.CurrentCell.RowIndex;
            if (rbnEdit.Checked)
            {
                if (selectedRow != dgvNewPrescription.NewRowIndex)
                {
                    txtDescription.Text = dgvNewPrescription.Rows[selectedRow].Cells[0].Value.ToString();
                    txtDoses.Text = dgvNewPrescription.Rows[selectedRow].Cells[1].Value.ToString();
                    numAmount.Value = int.Parse(dgvNewPrescription.Rows[selectedRow].Cells[2].Value.ToString());
                    cmbType.Text = dgvNewPrescription.Rows[selectedRow].Cells[3].Value.ToString();
                }
            }
        }
        //Add From Existing
        private void button2_Click(object sender, EventArgs e)
        {
            rbnAdd.Checked = true;
            int selectedRow = dgvMedicine.CurrentCell.RowIndex;
            if (selectedRow != dgvMedicine.NewRowIndex)
            {
                txtDescription.Text = dgvMedicine.Rows[selectedRow].Cells[0].Value.ToString();
                txtDoses.Text = dgvMedicine.Rows[selectedRow].Cells[1].Value.ToString();
            }
        }
        //Proceed to pdf generation
        private void button3_Click(object sender, EventArgs e)
        {
            Boolean isValidated = true;
            //for each cell blablabal cancel if amount is zero or type is blank
            foreach(DataRow r in dgvMedicine.Rows)
            {
                if (int.Parse(r[2].ToString()) == 0 || r[3].ToString().Trim().Equals(""))
                {
                    //message error cant do that bro
                    isValidated = false;
                    break;
                }
            }

            if (isValidated)
            {
                HospitalSelection hs = new HospitalSelection(this,user);
            }
        }



    }
}
