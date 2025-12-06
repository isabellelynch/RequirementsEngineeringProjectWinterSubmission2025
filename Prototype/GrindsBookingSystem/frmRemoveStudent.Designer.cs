namespace GrindsBookingSystem
{
    partial class frmRemoveStudent
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mnuRemoveStudent = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.cboStudentID = new System.Windows.Forms.ComboBox();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboSName = new System.Windows.Forms.ComboBox();
            this.lvRemoveStudent = new System.Windows.Forms.ListView();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.btnRemoveStudent = new System.Windows.Forms.Button();
            this.mnuRemoveStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Surname";
            // 
            // mnuRemoveStudent
            // 
            this.mnuRemoveStudent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnBack,
            this.btnRefresh});
            this.mnuRemoveStudent.Location = new System.Drawing.Point(0, 0);
            this.mnuRemoveStudent.Name = "mnuRemoveStudent";
            this.mnuRemoveStudent.Size = new System.Drawing.Size(800, 24);
            this.mnuRemoveStudent.TabIndex = 15;
            this.mnuRemoveStudent.Text = "menuStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 20);
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(44, 20);
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 20);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // cboStudentID
            // 
            this.cboStudentID.FormattingEnabled = true;
            this.cboStudentID.Location = new System.Drawing.Point(352, 32);
            this.cboStudentID.Name = "cboStudentID";
            this.cboStudentID.Size = new System.Drawing.Size(121, 21);
            this.cboStudentID.TabIndex = 16;
            this.cboStudentID.SelectedIndexChanged += new System.EventHandler(this.cboStudentID_SelectedIndexChanged_1);
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(352, 62);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 21);
            this.cboName.TabIndex = 17;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            // 
            // cboSName
            // 
            this.cboSName.FormattingEnabled = true;
            this.cboSName.Location = new System.Drawing.Point(352, 92);
            this.cboSName.Name = "cboSName";
            this.cboSName.Size = new System.Drawing.Size(121, 21);
            this.cboSName.TabIndex = 18;
            this.cboSName.SelectedIndexChanged += new System.EventHandler(this.cboSName_SelectedIndexChanged);
            // 
            // lvRemoveStudent
            // 
            this.lvRemoveStudent.HideSelection = false;
            this.lvRemoveStudent.Location = new System.Drawing.Point(129, 157);
            this.lvRemoveStudent.Name = "lvRemoveStudent";
            this.lvRemoveStudent.Size = new System.Drawing.Size(568, 227);
            this.lvRemoveStudent.TabIndex = 23;
            this.lvRemoveStudent.UseCompatibleStateImageBehavior = false;
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(253, 399);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(160, 25);
            this.btnResetFilters.TabIndex = 25;
            this.btnResetFilters.Text = "Reset Filters";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // btnRemoveStudent
            // 
            this.btnRemoveStudent.Location = new System.Drawing.Point(431, 399);
            this.btnRemoveStudent.Name = "btnRemoveStudent";
            this.btnRemoveStudent.Size = new System.Drawing.Size(160, 25);
            this.btnRemoveStudent.TabIndex = 26;
            this.btnRemoveStudent.Text = "Remove Selected Student";
            this.btnRemoveStudent.UseVisualStyleBackColor = true;
            this.btnRemoveStudent.Click += new System.EventHandler(this.btnRemoveStudent_Click);
            // 
            // frmRemoveStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveStudent);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.lvRemoveStudent);
            this.Controls.Add(this.cboSName);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboStudentID);
            this.Controls.Add(this.mnuRemoveStudent);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmRemoveStudent";
            this.Text = "Grinds Booking System - Remove Student";
            this.Load += new System.EventHandler(this.frmRemoveStudent_Load);
            this.mnuRemoveStudent.ResumeLayout(false);
            this.mnuRemoveStudent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip mnuRemoveStudent;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.ComboBox cboStudentID;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboSName;
        private System.Windows.Forms.ListView lvRemoveStudent;
        private System.Windows.Forms.Button btnResetFilters;
        private System.Windows.Forms.Button btnRemoveStudent;
    }
}