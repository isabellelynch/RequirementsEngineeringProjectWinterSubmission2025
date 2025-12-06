namespace GrindsBookingSystem
{
    partial class frmAddStudent
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentSurname = new System.Windows.Forms.TextBox();
            this.txtStudentEmail = new System.Windows.Forms.TextBox();
            this.txtStudentPhone = new System.Windows.Forms.TextBox();
            this.grpAddStudent = new System.Windows.Forms.GroupBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitBtnAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.backBtnAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddStudent.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phone Number";
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(246, 43);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(100, 20);
            this.txtStudentName.TabIndex = 4;
            // 
            // txtStudentSurname
            // 
            this.txtStudentSurname.Location = new System.Drawing.Point(246, 93);
            this.txtStudentSurname.Name = "txtStudentSurname";
            this.txtStudentSurname.Size = new System.Drawing.Size(100, 20);
            this.txtStudentSurname.TabIndex = 5;
            // 
            // txtStudentEmail
            // 
            this.txtStudentEmail.Location = new System.Drawing.Point(246, 143);
            this.txtStudentEmail.Name = "txtStudentEmail";
            this.txtStudentEmail.Size = new System.Drawing.Size(100, 20);
            this.txtStudentEmail.TabIndex = 6;
            // 
            // txtStudentPhone
            // 
            this.txtStudentPhone.Location = new System.Drawing.Point(246, 193);
            this.txtStudentPhone.Name = "txtStudentPhone";
            this.txtStudentPhone.Size = new System.Drawing.Size(100, 20);
            this.txtStudentPhone.TabIndex = 7;
            // 
            // grpAddStudent
            // 
            this.grpAddStudent.Controls.Add(this.btnAddStudent);
            this.grpAddStudent.Controls.Add(this.txtStudentPhone);
            this.grpAddStudent.Controls.Add(this.txtStudentEmail);
            this.grpAddStudent.Controls.Add(this.txtStudentSurname);
            this.grpAddStudent.Controls.Add(this.txtStudentName);
            this.grpAddStudent.Controls.Add(this.label4);
            this.grpAddStudent.Controls.Add(this.label3);
            this.grpAddStudent.Controls.Add(this.label2);
            this.grpAddStudent.Controls.Add(this.label1);
            this.grpAddStudent.Location = new System.Drawing.Point(140, 60);
            this.grpAddStudent.Name = "grpAddStudent";
            this.grpAddStudent.Size = new System.Drawing.Size(497, 316);
            this.grpAddStudent.TabIndex = 8;
            this.grpAddStudent.TabStop = false;
            this.grpAddStudent.Text = "Add New Student To The System";
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(212, 261);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(75, 23);
            this.btnAddStudent.TabIndex = 8;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitBtnAddStudent,
            this.backBtnAddStudent,
            this.btnRefresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitBtnAddStudent
            // 
            this.exitBtnAddStudent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitBtnAddStudent.Name = "exitBtnAddStudent";
            this.exitBtnAddStudent.Size = new System.Drawing.Size(37, 20);
            this.exitBtnAddStudent.Text = "Exit";
            this.exitBtnAddStudent.Click += new System.EventHandler(this.exitBtnAddStudent_Click);
            // 
            // backBtnAddStudent
            // 
            this.backBtnAddStudent.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backBtnAddStudent.Name = "backBtnAddStudent";
            this.backBtnAddStudent.Size = new System.Drawing.Size(44, 20);
            this.backBtnAddStudent.Text = "Back";
            this.backBtnAddStudent.Click += new System.EventHandler(this.backBtnAddStudent_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(58, 20);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAddStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddStudent";
            this.Text = "Grinds Booking System - Add Student";
            this.grpAddStudent.ResumeLayout(false);
            this.grpAddStudent.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentSurname;
        private System.Windows.Forms.TextBox txtStudentEmail;
        private System.Windows.Forms.TextBox txtStudentPhone;
        private System.Windows.Forms.GroupBox grpAddStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitBtnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem backBtnAddStudent;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
    }
}