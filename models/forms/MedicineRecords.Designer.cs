namespace Med_Docs.models.forms
{
    partial class MedicineRecords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvMedicine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCommit = new System.Windows.Forms.Button();
            this.dgvNewPrescription = new System.Windows.Forms.DataGridView();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doses = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbnAdd = new System.Windows.Forms.RadioButton();
            this.rbnEdit = new System.Windows.Forms.RadioButton();
            this.rbnRemove = new System.Windows.Forms.RadioButton();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtDoses = new System.Windows.Forms.TextBox();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMedicine
            // 
            this.dgvMedicine.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMedicine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMedicine.Location = new System.Drawing.Point(12, 116);
            this.dgvMedicine.MultiSelect = false;
            this.dgvMedicine.Name = "dgvMedicine";
            this.dgvMedicine.ReadOnly = true;
            this.dgvMedicine.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMedicine.Size = new System.Drawing.Size(470, 323);
            this.dgvMedicine.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(367, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 59);
            this.label1.TabIndex = 35;
            this.label1.Text = "Prescription";
            // 
            // btnCommit
            // 
            this.btnCommit.AutoSize = true;
            this.btnCommit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnCommit.Enabled = false;
            this.btnCommit.FlatAppearance.BorderSize = 0;
            this.btnCommit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCommit.ForeColor = System.Drawing.Color.White;
            this.btnCommit.Location = new System.Drawing.Point(502, 610);
            this.btnCommit.Name = "btnCommit";
            this.btnCommit.Size = new System.Drawing.Size(207, 36);
            this.btnCommit.TabIndex = 39;
            this.btnCommit.Text = "Commit";
            this.btnCommit.UseVisualStyleBackColor = false;
            this.btnCommit.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvNewPrescription
            // 
            this.dgvNewPrescription.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNewPrescription.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvNewPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNewPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Description,
            this.Doses,
            this.TotalAmount,
            this.Type});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNewPrescription.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvNewPrescription.Location = new System.Drawing.Point(502, 116);
            this.dgvNewPrescription.MultiSelect = false;
            this.dgvNewPrescription.Name = "dgvNewPrescription";
            this.dgvNewPrescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvNewPrescription.Size = new System.Drawing.Size(470, 323);
            this.dgvNewPrescription.TabIndex = 40;
            this.dgvNewPrescription.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNewPrescription_CellClick);
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Doses
            // 
            this.Doses.HeaderText = "Doses";
            this.Doses.Name = "Doses";
            this.Doses.ReadOnly = true;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "Total Amount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 445);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(470, 36);
            this.button2.TabIndex = 41;
            this.button2.Text = "->";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(231, 25);
            this.label2.TabIndex = 42;
            this.label2.Text = "Existing Medicine Records";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(655, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 43;
            this.label3.Text = "New Prescription";
            // 
            // rbnAdd
            // 
            this.rbnAdd.AutoSize = true;
            this.rbnAdd.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnAdd.Location = new System.Drawing.Point(502, 447);
            this.rbnAdd.Name = "rbnAdd";
            this.rbnAdd.Size = new System.Drawing.Size(64, 29);
            this.rbnAdd.TabIndex = 44;
            this.rbnAdd.TabStop = true;
            this.rbnAdd.Text = "Add";
            this.rbnAdd.UseVisualStyleBackColor = true;
            this.rbnAdd.CheckedChanged += new System.EventHandler(this.rbnAdd_CheckedChanged);
            // 
            // rbnEdit
            // 
            this.rbnEdit.AutoSize = true;
            this.rbnEdit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnEdit.Location = new System.Drawing.Point(572, 447);
            this.rbnEdit.Name = "rbnEdit";
            this.rbnEdit.Size = new System.Drawing.Size(62, 29);
            this.rbnEdit.TabIndex = 45;
            this.rbnEdit.TabStop = true;
            this.rbnEdit.Text = "Edit";
            this.rbnEdit.UseVisualStyleBackColor = true;
            this.rbnEdit.CheckedChanged += new System.EventHandler(this.rbnEdit_CheckedChanged);
            // 
            // rbnRemove
            // 
            this.rbnRemove.AutoSize = true;
            this.rbnRemove.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbnRemove.Location = new System.Drawing.Point(640, 447);
            this.rbnRemove.Name = "rbnRemove";
            this.rbnRemove.Size = new System.Drawing.Size(96, 29);
            this.rbnRemove.TabIndex = 46;
            this.rbnRemove.TabStop = true;
            this.rbnRemove.Text = "Remove";
            this.rbnRemove.UseVisualStyleBackColor = true;
            this.rbnRemove.CheckedChanged += new System.EventHandler(this.rbnRemove_CheckedChanged);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(110, 2);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(360, 29);
            this.txtDescription.TabIndex = 47;
            // 
            // txtDoses
            // 
            this.txtDoses.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDoses.Location = new System.Drawing.Point(110, 41);
            this.txtDoses.Name = "txtDoses";
            this.txtDoses.Size = new System.Drawing.Size(360, 29);
            this.txtDoses.TabIndex = 48;
            // 
            // numAmount
            // 
            this.numAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAmount.Location = new System.Drawing.Point(110, 81);
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(106, 29);
            this.numAmount.TabIndex = 49;
            // 
            // cmbType
            // 
            this.cmbType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Tablet",
            "Capsule",
            "Bottle"});
            this.cmbType.Location = new System.Drawing.Point(273, 81);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(197, 29);
            this.cmbType.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 21);
            this.label4.TabIndex = 51;
            this.label4.Text = "Description:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label5.Location = new System.Drawing.Point(5, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Doses:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label6.Location = new System.Drawing.Point(5, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Total Amount:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label7.Location = new System.Drawing.Point(222, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Type:";
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.BackColor = System.Drawing.Color.DodgerBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(257, 671);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(470, 50);
            this.button3.TabIndex = 55;
            this.button3.Text = "Proceed";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.label5);
            this.pnlCRUD.Controls.Add(this.txtDescription);
            this.pnlCRUD.Controls.Add(this.label7);
            this.pnlCRUD.Controls.Add(this.txtDoses);
            this.pnlCRUD.Controls.Add(this.label6);
            this.pnlCRUD.Controls.Add(this.numAmount);
            this.pnlCRUD.Controls.Add(this.cmbType);
            this.pnlCRUD.Controls.Add(this.label4);
            this.pnlCRUD.Enabled = false;
            this.pnlCRUD.Location = new System.Drawing.Point(502, 475);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(470, 129);
            this.pnlCRUD.TabIndex = 56;
            // 
            // MedicineRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 733);
            this.Controls.Add(this.pnlCRUD);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rbnRemove);
            this.Controls.Add(this.rbnEdit);
            this.Controls.Add(this.rbnAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dgvNewPrescription);
            this.Controls.Add(this.btnCommit);
            this.Controls.Add(this.dgvMedicine);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 500);
            this.Name = "MedicineRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescription - Medicine";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MedicineRecords_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMedicine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNewPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.pnlCRUD.ResumeLayout(false);
            this.pnlCRUD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvMedicine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCommit;
        private System.Windows.Forms.DataGridView dgvNewPrescription;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbnAdd;
        private System.Windows.Forms.RadioButton rbnEdit;
        private System.Windows.Forms.RadioButton rbnRemove;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtDoses;
        private System.Windows.Forms.NumericUpDown numAmount;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doses;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
    }
}