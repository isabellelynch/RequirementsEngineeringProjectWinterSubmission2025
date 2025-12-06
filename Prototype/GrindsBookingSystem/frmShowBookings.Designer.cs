namespace GrindsBookingSystem
{
    partial class frmShowBookings
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
            this.btnShowBookings = new System.Windows.Forms.Button();
            this.grpCancelBooking = new System.Windows.Forms.GroupBox();
            this.lvBookings = new System.Windows.Forms.ListView();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.cboSName = new System.Windows.Forms.ComboBox();
            this.cboStudentID = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuViewStudentDetails = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.grpCancelBooking.SuspendLayout();
            this.mnuViewStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowBookings
            // 
            this.btnShowBookings.Location = new System.Drawing.Point(334, 139);
            this.btnShowBookings.Name = "btnShowBookings";
            this.btnShowBookings.Size = new System.Drawing.Size(138, 23);
            this.btnShowBookings.TabIndex = 39;
            this.btnShowBookings.Text = "Show Bookings";
            this.btnShowBookings.UseVisualStyleBackColor = true;
            this.btnShowBookings.Click += new System.EventHandler(this.btnShowBookings_Click);
            // 
            // grpCancelBooking
            // 
            this.grpCancelBooking.Controls.Add(this.lvBookings);
            this.grpCancelBooking.Location = new System.Drawing.Point(35, 167);
            this.grpCancelBooking.Name = "grpCancelBooking";
            this.grpCancelBooking.Size = new System.Drawing.Size(730, 235);
            this.grpCancelBooking.TabIndex = 40;
            this.grpCancelBooking.TabStop = false;
            // 
            // lvBookings
            // 
            this.lvBookings.HideSelection = false;
            this.lvBookings.Location = new System.Drawing.Point(84, 25);
            this.lvBookings.Name = "lvBookings";
            this.lvBookings.Size = new System.Drawing.Size(552, 194);
            this.lvBookings.TabIndex = 0;
            this.lvBookings.UseCompatibleStateImageBehavior = false;
            // 
            // cboName
            // 
            this.cboName.FormattingEnabled = true;
            this.cboName.Location = new System.Drawing.Point(343, 80);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 21);
            this.cboName.TabIndex = 38;
            this.cboName.SelectedIndexChanged += new System.EventHandler(this.cboName_SelectedIndexChanged);
            // 
            // cboSName
            // 
            this.cboSName.FormattingEnabled = true;
            this.cboSName.Location = new System.Drawing.Point(343, 112);
            this.cboSName.Name = "cboSName";
            this.cboSName.Size = new System.Drawing.Size(121, 21);
            this.cboSName.TabIndex = 37;
            this.cboSName.SelectedIndexChanged += new System.EventHandler(this.cboSName_SelectedIndexChanged);
            // 
            // cboStudentID
            // 
            this.cboStudentID.FormattingEnabled = true;
            this.cboStudentID.Location = new System.Drawing.Point(343, 48);
            this.cboStudentID.Name = "cboStudentID";
            this.cboStudentID.Size = new System.Drawing.Size(121, 21);
            this.cboStudentID.TabIndex = 36;
            this.cboStudentID.SelectedIndexChanged += new System.EventHandler(this.cboStudentID_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Student ID";
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
            this.mnuViewStudentDetails.TabIndex = 41;
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
            // frmShowBookings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mnuViewStudentDetails);
            this.Controls.Add(this.btnShowBookings);
            this.Controls.Add(this.grpCancelBooking);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.cboSName);
            this.Controls.Add(this.cboStudentID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frmShowBookings";
            this.Text = "frmShowBookings";
            this.Load += new System.EventHandler(this.frmShowBookings_Load);
            this.grpCancelBooking.ResumeLayout(false);
            this.mnuViewStudentDetails.ResumeLayout(false);
            this.mnuViewStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowBookings;
        private System.Windows.Forms.GroupBox grpCancelBooking;
        private System.Windows.Forms.ListView lvBookings;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ComboBox cboSName;
        private System.Windows.Forms.ComboBox cboStudentID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip mnuViewStudentDetails;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
    }
}