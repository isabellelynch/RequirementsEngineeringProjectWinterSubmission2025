namespace GrindsBookingSystem
{
    partial class frmAddTutor
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTutorName = new System.Windows.Forms.TextBox();
            this.txtTutorSurname = new System.Windows.Forms.TextBox();
            this.txtTutorEmail = new System.Windows.Forms.TextBox();
            this.txtTutorPhone = new System.Windows.Forms.TextBox();
            this.cboTutorRates = new System.Windows.Forms.ComboBox();
            this.cboTutorSubjects = new System.Windows.Forms.ComboBox();
            this.grpAddTutor = new System.Windows.Forms.GroupBox();
            this.btnAddTutor = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.grpAddTutor.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tutor Rate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Subject";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone Number";
            // 
            // txtTutorName
            // 
            this.txtTutorName.Location = new System.Drawing.Point(143, 48);
            this.txtTutorName.Name = "txtTutorName";
            this.txtTutorName.Size = new System.Drawing.Size(121, 20);
            this.txtTutorName.TabIndex = 6;
            // 
            // txtTutorSurname
            // 
            this.txtTutorSurname.Location = new System.Drawing.Point(143, 98);
            this.txtTutorSurname.Name = "txtTutorSurname";
            this.txtTutorSurname.Size = new System.Drawing.Size(121, 20);
            this.txtTutorSurname.TabIndex = 7;
            // 
            // txtTutorEmail
            // 
            this.txtTutorEmail.Location = new System.Drawing.Point(143, 147);
            this.txtTutorEmail.Name = "txtTutorEmail";
            this.txtTutorEmail.Size = new System.Drawing.Size(121, 20);
            this.txtTutorEmail.TabIndex = 8;
            // 
            // txtTutorPhone
            // 
            this.txtTutorPhone.Location = new System.Drawing.Point(143, 198);
            this.txtTutorPhone.Name = "txtTutorPhone";
            this.txtTutorPhone.Size = new System.Drawing.Size(121, 20);
            this.txtTutorPhone.TabIndex = 9;
            // 
            // cboTutorRates
            // 
            this.cboTutorRates.FormattingEnabled = true;
            this.cboTutorRates.Location = new System.Drawing.Point(443, 47);
            this.cboTutorRates.Name = "cboTutorRates";
            this.cboTutorRates.Size = new System.Drawing.Size(121, 21);
            this.cboTutorRates.TabIndex = 10;
            // 
            // cboTutorSubjects
            // 
            this.cboTutorSubjects.FormattingEnabled = true;
            this.cboTutorSubjects.Location = new System.Drawing.Point(443, 146);
            this.cboTutorSubjects.Name = "cboTutorSubjects";
            this.cboTutorSubjects.Size = new System.Drawing.Size(121, 21);
            this.cboTutorSubjects.TabIndex = 11;
            // 
            // grpAddTutor
            // 
            this.grpAddTutor.Controls.Add(this.btnAddTutor);
            this.grpAddTutor.Controls.Add(this.cboTutorSubjects);
            this.grpAddTutor.Controls.Add(this.cboTutorRates);
            this.grpAddTutor.Controls.Add(this.txtTutorPhone);
            this.grpAddTutor.Controls.Add(this.txtTutorEmail);
            this.grpAddTutor.Controls.Add(this.txtTutorSurname);
            this.grpAddTutor.Controls.Add(this.txtTutorName);
            this.grpAddTutor.Controls.Add(this.label6);
            this.grpAddTutor.Controls.Add(this.label5);
            this.grpAddTutor.Controls.Add(this.label4);
            this.grpAddTutor.Controls.Add(this.label3);
            this.grpAddTutor.Controls.Add(this.label2);
            this.grpAddTutor.Controls.Add(this.label1);
            this.grpAddTutor.Location = new System.Drawing.Point(60, 62);
            this.grpAddTutor.Name = "grpAddTutor";
            this.grpAddTutor.Size = new System.Drawing.Size(673, 325);
            this.grpAddTutor.TabIndex = 12;
            this.grpAddTutor.TabStop = false;
            this.grpAddTutor.Text = "Add New Tutor";
            // 
            // btnAddTutor
            // 
            this.btnAddTutor.Location = new System.Drawing.Point(281, 260);
            this.btnAddTutor.Name = "btnAddTutor";
            this.btnAddTutor.Size = new System.Drawing.Size(130, 43);
            this.btnAddTutor.TabIndex = 12;
            this.btnAddTutor.Text = "Add Tutor";
            this.btnAddTutor.UseVisualStyleBackColor = true;
            this.btnAddTutor.Click += new System.EventHandler(this.btnAddTutor_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnBack,
            this.btnRefresh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
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
            // frmAddTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpAddTutor);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAddTutor";
            this.Text = "Grinds Booking System - Add Tutor";
            this.Load += new System.EventHandler(this.frmAddTutor_Load);
            this.grpAddTutor.ResumeLayout(false);
            this.grpAddTutor.PerformLayout();
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTutorName;
        private System.Windows.Forms.TextBox txtTutorSurname;
        private System.Windows.Forms.TextBox txtTutorEmail;
        private System.Windows.Forms.TextBox txtTutorPhone;
        private System.Windows.Forms.ComboBox cboTutorRates;
        private System.Windows.Forms.ComboBox cboTutorSubjects;
        private System.Windows.Forms.GroupBox grpAddTutor;
        private System.Windows.Forms.Button btnAddTutor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
    }
}