namespace Med_Docs.models.forms
{
    partial class PatientRecords
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cbxSex = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clnBday = new System.Windows.Forms.MonthCalendar();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(711, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 59);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Records";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(250, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1216, 530);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // radioButton1
            // 
            this.radioButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(250, 650);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(215, 29);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Modify Patient Record";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(493, 650);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(210, 29);
            this.radioButton2.TabIndex = 3;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Delete Patient Record";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cbxSex
            // 
            this.cbxSex.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.cbxSex.FormattingEnabled = true;
            this.cbxSex.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cbxSex.Location = new System.Drawing.Point(154, 43);
            this.cbxSex.Name = "cbxSex";
            this.cbxSex.Size = new System.Drawing.Size(454, 33);
            this.cbxSex.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(154, 82);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(454, 119);
            this.txtAddress.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sex:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(154, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(454, 33);
            this.txtName.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Date of Birth:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Patient Name:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.clnBday);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.cbxSex);
            this.panel1.Location = new System.Drawing.Point(250, 693);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1216, 224);
            this.panel1.TabIndex = 16;
            // 
            // clnBday
            // 
            this.clnBday.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.clnBday.Location = new System.Drawing.Point(785, 12);
            this.clnBday.MaxSelectionCount = 1;
            this.clnBday.Name = "clnBday";
            this.clnBday.ShowTodayCircle = false;
            this.clnBday.TabIndex = 18;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.DodgerBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(625, 934);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(491, 50);
            this.button1.TabIndex = 19;
            this.button1.Text = "Proceed";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSchedule.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSchedule.FlatAppearance.BorderSize = 0;
            this.btnSchedule.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSchedule.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSchedule.Location = new System.Drawing.Point(1228, 644);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(238, 40);
            this.btnSchedule.TabIndex = 20;
            this.btnSchedule.Text = "Schedule Patient";
            this.btnSchedule.UseVisualStyleBackColor = false;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // PatientRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1720, 1000);
            this.Controls.Add(this.btnSchedule);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1720, 2000);
            this.MinimumSize = new System.Drawing.Size(1390, 699);
            this.Name = "PatientRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbxSex;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MonthCalendar clnBday;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSchedule;
    }
}