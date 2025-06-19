namespace TimesheetApp.AllForms
{
    partial class SummaryForm
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
            this.lblSummaryHeader = new System.Windows.Forms.Label();
            this.lblSummaryJob = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSummaryJob = new System.Windows.Forms.ComboBox();
            this.DgvSummary = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSummary)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSummaryHeader
            // 
            this.lblSummaryHeader.AutoSize = true;
            this.lblSummaryHeader.Font = new System.Drawing.Font("Trebuchet MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSummaryHeader.Location = new System.Drawing.Point(10, 10);
            this.lblSummaryHeader.Name = "lblSummaryHeader";
            this.lblSummaryHeader.Size = new System.Drawing.Size(617, 61);
            this.lblSummaryHeader.TabIndex = 0;
            this.lblSummaryHeader.Text = "Timesheet Summary Report";
            // 
            // lblSummaryJob
            // 
            this.lblSummaryJob.AutoSize = true;
            this.lblSummaryJob.Font = new System.Drawing.Font("Trebuchet MS", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryJob.Location = new System.Drawing.Point(897, 714);
            this.lblSummaryJob.Name = "lblSummaryJob";
            this.lblSummaryJob.Size = new System.Drawing.Size(74, 37);
            this.lblSummaryJob.TabIndex = 2;
            this.lblSummaryJob.Text = "Job:";
            // 
            // btnBack
            // 
            this.btnBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBack.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1581, 705);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(311, 217);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back to entry";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnExit.Font = new System.Drawing.Font("Trebuchet MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(16, 705);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(311, 217);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit Application";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.Controls.Add(this.lblSummaryHeader);
            this.panel1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel1.Location = new System.Drawing.Point(-5, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1911, 100);
            this.panel1.TabIndex = 14;
            // 
            // cmbSummaryJob
            // 
            this.cmbSummaryJob.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbSummaryJob.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSummaryJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSummaryJob.Font = new System.Drawing.Font("Trebuchet MS", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSummaryJob.FormattingEnabled = true;
            this.cmbSummaryJob.Location = new System.Drawing.Point(749, 754);
            this.cmbSummaryJob.Name = "cmbSummaryJob";
            this.cmbSummaryJob.Size = new System.Drawing.Size(366, 54);
            this.cmbSummaryJob.TabIndex = 16;
            this.cmbSummaryJob.SelectedIndexChanged += new System.EventHandler(this.cmbSummaryJob_SelectedIndexChanged);
            // 
            // DgvSummary
            // 
            this.DgvSummary.AllowUserToAddRows = false;
            this.DgvSummary.AllowUserToDeleteRows = false;
            this.DgvSummary.AllowUserToResizeColumns = false;
            this.DgvSummary.AllowUserToResizeRows = false;
            this.DgvSummary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvSummary.Location = new System.Drawing.Point(16, 146);
            this.DgvSummary.Name = "DgvSummary";
            this.DgvSummary.ReadOnly = true;
            this.DgvSummary.Size = new System.Drawing.Size(1876, 553);
            this.DgvSummary.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkOrange;
            this.panel3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.panel3.Location = new System.Drawing.Point(-5, 941);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1911, 100);
            this.panel3.TabIndex = 22;
            // 
            // SummaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.DgvSummary);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.cmbSummaryJob);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblSummaryJob);
            this.MaximizeBox = false;
            this.Name = "SummaryForm";
            this.Text = "SummaryForm";
            this.Load += new System.EventHandler(this.SummaryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSummary)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSummaryHeader;
        private System.Windows.Forms.Label lblSummaryJob;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSummaryJob;
        private System.Windows.Forms.DataGridView DgvSummary;
        private System.Windows.Forms.Panel panel3;
    }
}