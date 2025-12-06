namespace GrindsBookingSystem
{
    partial class frmAddBooking
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
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.cboStudentID = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mnuViewStudentDetails = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.btnMakeBooking = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.grpMakeBooking = new System.Windows.Forms.GroupBox();
            this.mnuViewStudentDetails.SuspendLayout();
            this.grpMakeBooking.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboLastName
            // 
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.Location = new System.Drawing.Point(379, 98);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(121, 21);
            this.cboLastName.TabIndex = 28;
            this.cboLastName.SelectedIndexChanged += new System.EventHandler(this.cboLastName_SelectedIndexChanged);
            // 
            // cboFirstName
            // 
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.Location = new System.Drawing.Point(379, 63);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(121, 21);
            this.cboFirstName.TabIndex = 27;
            this.cboFirstName.SelectedIndexChanged += new System.EventHandler(this.cboFirstName_SelectedIndexChanged);
            // 
            // cboStudentID
            // 
            this.cboStudentID.FormattingEnabled = true;
            this.cboStudentID.Location = new System.Drawing.Point(379, 32);
            this.cboStudentID.Name = "cboStudentID";
            this.cboStudentID.Size = new System.Drawing.Size(121, 21);
            this.cboStudentID.TabIndex = 26;
            this.cboStudentID.SelectedIndexChanged += new System.EventHandler(this.cboStudentID_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "First Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Student ID";
            // 
            // mnuViewStudentDetails
            // 
            this.mnuViewStudentDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnBack,
            this.btnRefresh});
            this.mnuViewStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.mnuViewStudentDetails.Name = "mnuViewStudentDetails";
            this.mnuViewStudentDetails.Size = new System.Drawing.Size(800, 24);
            this.mnuViewStudentDetails.TabIndex = 29;
            this.mnuViewStudentDetails.Text = "menuStrip1";
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
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(317, 136);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(130, 23);
            this.btnContinue.TabIndex = 30;
            this.btnContinue.Text = "Continue to Booking";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lvSchedule
            // 
            this.lvSchedule.HideSelection = false;
            this.lvSchedule.Location = new System.Drawing.Point(34, 36);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(543, 161);
            this.lvSchedule.TabIndex = 31;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // btnMakeBooking
            // 
            this.btnMakeBooking.Location = new System.Drawing.Point(207, 213);
            this.btnMakeBooking.Name = "btnMakeBooking";
            this.btnMakeBooking.Size = new System.Drawing.Size(182, 23);
            this.btnMakeBooking.TabIndex = 32;
            this.btnMakeBooking.Text = "Make Booking";
            this.btnMakeBooking.UseVisualStyleBackColor = true;
            this.btnMakeBooking.Click += new System.EventHandler(this.btnMakeBooking_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Please select the class that you would like to book";
            // 
            // grpMakeBooking
            // 
            this.grpMakeBooking.Controls.Add(this.label4);
            this.grpMakeBooking.Controls.Add(this.btnMakeBooking);
            this.grpMakeBooking.Controls.Add(this.lvSchedule);
            this.grpMakeBooking.Location = new System.Drawing.Point(100, 170);
            this.grpMakeBooking.Name = "grpMakeBooking";
            this.grpMakeBooking.Size = new System.Drawing.Size(615, 253);
            this.grpMakeBooking.TabIndex = 34;
            this.grpMakeBooking.TabStop = false;
            // 
            // frmAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpMakeBooking);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.mnuViewStudentDetails);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.cboStudentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAddBooking";
            this.Text = "frmAddBooking";
            this.mnuViewStudentDetails.ResumeLayout(false);
            this.mnuViewStudentDetails.PerformLayout();
            this.grpMakeBooking.ResumeLayout(false);
            this.grpMakeBooking.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.ComboBox cboStudentID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip mnuViewStudentDetails;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.Button btnMakeBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpMakeBooking;
    }
}