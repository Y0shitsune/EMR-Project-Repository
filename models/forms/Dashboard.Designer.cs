namespace Med_Docs.models.forms
{
    partial class Dashboard
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
            this.lblDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBirthdays = new System.Windows.Forms.DataGridView();
            this.dgvRegistered = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWelcomeMessage = new System.Windows.Forms.Label();
            this.dgvScheduled = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthdays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduled)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(1565, 28);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(125, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "##/##/####";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(267, 550);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patients with Upcoming Birthdays";
            // 
            // dgvBirthdays
            // 
            this.dgvBirthdays.AllowUserToAddRows = false;
            this.dgvBirthdays.AllowUserToDeleteRows = false;
            this.dgvBirthdays.AllowUserToResizeRows = false;
            this.dgvBirthdays.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBirthdays.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvBirthdays.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBirthdays.Location = new System.Drawing.Point(105, 600);
            this.dgvBirthdays.Name = "dgvBirthdays";
            this.dgvBirthdays.Size = new System.Drawing.Size(729, 316);
            this.dgvBirthdays.TabIndex = 2;
            // 
            // dgvRegistered
            // 
            this.dgvRegistered.AllowUserToAddRows = false;
            this.dgvRegistered.AllowUserToDeleteRows = false;
            this.dgvRegistered.AllowUserToOrderColumns = true;
            this.dgvRegistered.AllowUserToResizeRows = false;
            this.dgvRegistered.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRegistered.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistered.Location = new System.Drawing.Point(105, 139);
            this.dgvRegistered.Name = "dgvRegistered";
            this.dgvRegistered.ReadOnly = true;
            this.dgvRegistered.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRegistered.Size = new System.Drawing.Size(1517, 396);
            this.dgvRegistered.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(743, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "Registered Patients";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1138, 550);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(240, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "Scheduled Patients";
            // 
            // lblWelcomeMessage
            // 
            this.lblWelcomeMessage.AutoSize = true;
            this.lblWelcomeMessage.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcomeMessage.Location = new System.Drawing.Point(727, 22);
            this.lblWelcomeMessage.Name = "lblWelcomeMessage";
            this.lblWelcomeMessage.Size = new System.Drawing.Size(279, 37);
            this.lblWelcomeMessage.TabIndex = 7;
            this.lblWelcomeMessage.Text = "Welcome (Title) Name";
            this.lblWelcomeMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgvScheduled
            // 
            this.dgvScheduled.AllowUserToAddRows = false;
            this.dgvScheduled.AllowUserToDeleteRows = false;
            this.dgvScheduled.AllowUserToOrderColumns = true;
            this.dgvScheduled.AllowUserToResizeRows = false;
            this.dgvScheduled.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvScheduled.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvScheduled.Location = new System.Drawing.Point(893, 600);
            this.dgvScheduled.Name = "dgvScheduled";
            this.dgvScheduled.Size = new System.Drawing.Size(729, 316);
            this.dgvScheduled.TabIndex = 5;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1720, 1000);
            this.Controls.Add(this.lblWelcomeMessage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvScheduled);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRegistered);
            this.Controls.Add(this.dgvBirthdays);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblDate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.dgvBirthdays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvScheduled)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBirthdays;
        private System.Windows.Forms.DataGridView dgvRegistered;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWelcomeMessage;
        private System.Windows.Forms.DataGridView dgvScheduled;
    }
}