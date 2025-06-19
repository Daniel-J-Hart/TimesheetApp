namespace TimesheetApp
{
    partial class MainForm
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
            this.lblheader = new System.Windows.Forms.Label();
            this.lblemployee = new System.Windows.Forms.Label();
            this.lbljob = new System.Windows.Forms.Label();
            this.lblworkdate = new System.Windows.Forms.Label();
            this.lblhours = new System.Windows.Forms.Label();
            this.dtpWorkDate = new System.Windows.Forms.DateTimePicker();
            this.numHoursWorked = new System.Windows.Forms.NumericUpDown();
            this.BtnAddEntry = new System.Windows.Forms.Button();
            this.btnOpenSummary = new System.Windows.Forms.Button();
            this.txtEmployee = new System.Windows.Forms.TextBox();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnExitApp = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numHoursWorked)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblheader
            // 
            this.lblheader.AutoSize = true;
            this.lblheader.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheader.Location = new System.Drawing.Point(12, 19);
            this.lblheader.Name = "lblheader";
            this.lblheader.Size = new System.Drawing.Size(377, 61);
            this.lblheader.TabIndex = 0;
            this.lblheader.Text = "Timesheet Entry";
            // 
            // lblemployee
            // 
            this.lblemployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblemployee.AutoSize = true;
            this.lblemployee.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemployee.Location = new System.Drawing.Point(496, 365);
            this.lblemployee.Name = "lblemployee";
            this.lblemployee.Size = new System.Drawing.Size(184, 43);
            this.lblemployee.TabIndex = 1;
            this.lblemployee.Text = "Employee:";
            // 
            // lbljob
            // 
            this.lbljob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbljob.AutoSize = true;
            this.lbljob.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbljob.Location = new System.Drawing.Point(1160, 365);
            this.lbljob.Name = "lbljob";
            this.lbljob.Size = new System.Drawing.Size(88, 43);
            this.lbljob.TabIndex = 2;
            this.lbljob.Text = "Job:";
            // 
            // lblworkdate
            // 
            this.lblworkdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblworkdate.AutoSize = true;
            this.lblworkdate.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblworkdate.Location = new System.Drawing.Point(486, 485);
            this.lblworkdate.Name = "lblworkdate";
            this.lblworkdate.Size = new System.Drawing.Size(194, 43);
            this.lblworkdate.TabIndex = 3;
            this.lblworkdate.Text = "Work Date:";
            // 
            // lblhours
            // 
            this.lblhours.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblhours.AutoSize = true;
            this.lblhours.Font = new System.Drawing.Font("Trebuchet MS", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhours.Location = new System.Drawing.Point(1110, 489);
            this.lblhours.Name = "lblhours";
            this.lblhours.Size = new System.Drawing.Size(208, 43);
            this.lblhours.TabIndex = 6;
            this.lblhours.Text = "Time taken:";
            // 
            // dtpWorkDate
            // 
            this.dtpWorkDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpWorkDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpWorkDate.Location = new System.Drawing.Point(355, 531);
            this.dtpWorkDate.Name = "dtpWorkDate";
            this.dtpWorkDate.Size = new System.Drawing.Size(472, 62);
            this.dtpWorkDate.TabIndex = 12;
            // 
            // numHoursWorked
            // 
            this.numHoursWorked.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.numHoursWorked.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numHoursWorked.Location = new System.Drawing.Point(968, 531);
            this.numHoursWorked.Name = "numHoursWorked";
            this.numHoursWorked.Size = new System.Drawing.Size(472, 62);
            this.numHoursWorked.TabIndex = 13;
            // 
            // BtnAddEntry
            // 
            this.BtnAddEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnAddEntry.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddEntry.Location = new System.Drawing.Point(0, 697);
            this.BtnAddEntry.Name = "BtnAddEntry";
            this.BtnAddEntry.Size = new System.Drawing.Size(407, 221);
            this.BtnAddEntry.TabIndex = 14;
            this.BtnAddEntry.Text = "Submit Timesheet";
            this.BtnAddEntry.UseVisualStyleBackColor = true;
            this.BtnAddEntry.Click += new System.EventHandler(this.BtnAddEntry_Click);
            // 
            // btnOpenSummary
            // 
            this.btnOpenSummary.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenSummary.Location = new System.Drawing.Point(1408, 697);
            this.btnOpenSummary.Name = "btnOpenSummary";
            this.btnOpenSummary.Size = new System.Drawing.Size(407, 221);
            this.btnOpenSummary.TabIndex = 16;
            this.btnOpenSummary.Text = "Open Summary";
            this.btnOpenSummary.UseVisualStyleBackColor = true;
            this.btnOpenSummary.Click += new System.EventHandler(this.btnOpenSummary_Click);
            // 
            // txtEmployee
            // 
            this.txtEmployee.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmployee.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployee.Location = new System.Drawing.Point(355, 411);
            this.txtEmployee.Name = "txtEmployee";
            this.txtEmployee.Size = new System.Drawing.Size(472, 63);
            this.txtEmployee.TabIndex = 19;
            // 
            // txtJob
            // 
            this.txtJob.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtJob.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtJob.Location = new System.Drawing.Point(968, 411);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(472, 63);
            this.txtJob.TabIndex = 20;
            // 
            // btnExitApp
            // 
            this.btnExitApp.BackColor = System.Drawing.Color.Transparent;
            this.btnExitApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExitApp.Location = new System.Drawing.Point(785, 741);
            this.btnExitApp.Name = "btnExitApp";
            this.btnExitApp.Size = new System.Drawing.Size(230, 158);
            this.btnExitApp.TabIndex = 21;
            this.btnExitApp.Text = "Exit Application";
            this.btnExitApp.UseVisualStyleBackColor = false;
            this.btnExitApp.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lblheader);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1904, 100);
            this.panel1.TabIndex = 22;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkOrange;
            this.panel2.Location = new System.Drawing.Point(0, 943);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1904, 100);
            this.panel2.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnOpenSummary);
            this.Controls.Add(this.BtnAddEntry);
            this.Controls.Add(this.btnExitApp);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.txtEmployee);
            this.Controls.Add(this.numHoursWorked);
            this.Controls.Add(this.dtpWorkDate);
            this.Controls.Add(this.lblhours);
            this.Controls.Add(this.lblworkdate);
            this.Controls.Add(this.lbljob);
            this.Controls.Add(this.lblemployee);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numHoursWorked)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblheader;
        private System.Windows.Forms.Label lblemployee;
        private System.Windows.Forms.Label lbljob;
        private System.Windows.Forms.Label lblworkdate;
        private System.Windows.Forms.Label lblhours;
        private System.Windows.Forms.DateTimePicker dtpWorkDate;
        private System.Windows.Forms.NumericUpDown numHoursWorked;
        private System.Windows.Forms.Button BtnAddEntry;
        private System.Windows.Forms.Button btnOpenSummary;
        private System.Windows.Forms.TextBox txtEmployee;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnExitApp;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

