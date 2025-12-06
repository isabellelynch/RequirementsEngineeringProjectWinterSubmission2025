namespace GrindsBookingSystem
{
    partial class frmUpdateTutor
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTutID = new System.Windows.Forms.ComboBox();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.cboSurnames = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboRates = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.grpTutorDetails = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboSubjects = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.grpTutorDetails.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.TabIndex = 15;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Tutor ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name";
            // 
            // cboTutID
            // 
            this.cboTutID.FormattingEnabled = true;
            this.cboTutID.Location = new System.Drawing.Point(392, 32);
            this.cboTutID.Name = "cboTutID";
            this.cboTutID.Size = new System.Drawing.Size(121, 21);
            this.cboTutID.TabIndex = 20;
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(392, 77);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(121, 21);
            this.cboNames.TabIndex = 21;
            // 
            // cboSurnames
            // 
            this.cboSurnames.FormattingEnabled = true;
            this.cboSurnames.Location = new System.Drawing.Point(392, 117);
            this.cboSurnames.Name = "cboSurnames";
            this.cboSurnames.Size = new System.Drawing.Size(121, 21);
            this.cboSurnames.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Tutor Rate Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Email Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Phone Number";
            // 
            // cboRates
            // 
            this.cboRates.FormattingEnabled = true;
            this.cboRates.Location = new System.Drawing.Point(211, 28);
            this.cboRates.Name = "cboRates";
            this.cboRates.Size = new System.Drawing.Size(121, 21);
            this.cboRates.TabIndex = 26;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(211, 62);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(121, 20);
            this.txtEmail.TabIndex = 27;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(211, 92);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(121, 20);
            this.txtPhone.TabIndex = 28;
            // 
            // grpTutorDetails
            // 
            this.grpTutorDetails.Controls.Add(this.cboSubjects);
            this.grpTutorDetails.Controls.Add(this.label7);
            this.grpTutorDetails.Controls.Add(this.button2);
            this.grpTutorDetails.Controls.Add(this.txtPhone);
            this.grpTutorDetails.Controls.Add(this.txtEmail);
            this.grpTutorDetails.Controls.Add(this.cboRates);
            this.grpTutorDetails.Controls.Add(this.label6);
            this.grpTutorDetails.Controls.Add(this.label5);
            this.grpTutorDetails.Controls.Add(this.label4);
            this.grpTutorDetails.Location = new System.Drawing.Point(181, 201);
            this.grpTutorDetails.Name = "grpTutorDetails";
            this.grpTutorDetails.Size = new System.Drawing.Size(429, 212);
            this.grpTutorDetails.TabIndex = 29;
            this.grpTutorDetails.TabStop = false;
            this.grpTutorDetails.Text = "Extra Details";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(125, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 23);
            this.button2.TabIndex = 29;
            this.button2.Text = "Update Tutor Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnUpdateTutor_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(334, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Find Tutor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnFindTutor_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Subject";
            // 
            // cboSubjects
            // 
            this.cboSubjects.FormattingEnabled = true;
            this.cboSubjects.Location = new System.Drawing.Point(211, 128);
            this.cboSubjects.Name = "cboSubjects";
            this.cboSubjects.Size = new System.Drawing.Size(121, 21);
            this.cboSubjects.TabIndex = 31;
            // 
            // frmUpdateTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grpTutorDetails);
            this.Controls.Add(this.cboSurnames);
            this.Controls.Add(this.cboNames);
            this.Controls.Add(this.cboTutID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmUpdateTutor";
            this.Text = "Grinds Booking System - Update Tutor Details";
            this.Load += new System.EventHandler(this.frmUpdateTutor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpTutorDetails.ResumeLayout(false);
            this.grpTutorDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTutID;
        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.ComboBox cboSurnames;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboRates;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.GroupBox grpTutorDetails;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cboSubjects;
        private System.Windows.Forms.Label label7;
    }
}