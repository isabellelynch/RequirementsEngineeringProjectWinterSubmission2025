namespace GrindsBookingSystem
{
    partial class frmAddGrind
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
            this.mnuViewStudentDetails = new System.Windows.Forms.MenuStrip();
            this.btnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.btnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.pickTime = new System.Windows.Forms.DateTimePicker();
            this.pickDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAttendance = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboRooms = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboTutors = new System.Windows.Forms.ComboBox();
            this.btnAddGrind = new System.Windows.Forms.Button();
            this.mnuViewStudentDetails.SuspendLayout();
            this.SuspendLayout();
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
            this.mnuViewStudentDetails.TabIndex = 18;
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
            // pickTime
            // 
            this.pickTime.Location = new System.Drawing.Point(353, 73);
            this.pickTime.Name = "pickTime";
            this.pickTime.Size = new System.Drawing.Size(200, 20);
            this.pickTime.TabIndex = 19;
            // 
            // pickDate
            // 
            this.pickDate.Location = new System.Drawing.Point(353, 132);
            this.pickDate.Name = "pickDate";
            this.pickDate.Size = new System.Drawing.Size(200, 20);
            this.pickDate.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(218, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Attendance Limit";
            // 
            // txtAttendance
            // 
            this.txtAttendance.Location = new System.Drawing.Point(353, 196);
            this.txtAttendance.Name = "txtAttendance";
            this.txtAttendance.Size = new System.Drawing.Size(200, 20);
            this.txtAttendance.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Room";
            // 
            // cboRooms
            // 
            this.cboRooms.FormattingEnabled = true;
            this.cboRooms.Location = new System.Drawing.Point(353, 251);
            this.cboRooms.Name = "cboRooms";
            this.cboRooms.Size = new System.Drawing.Size(200, 21);
            this.cboRooms.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 313);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Tutor";
            // 
            // cboTutors
            // 
            this.cboTutors.FormattingEnabled = true;
            this.cboTutors.Location = new System.Drawing.Point(353, 305);
            this.cboTutors.Name = "cboTutors";
            this.cboTutors.Size = new System.Drawing.Size(200, 21);
            this.cboTutors.TabIndex = 28;
            // 
            // btnAddGrind
            // 
            this.btnAddGrind.Location = new System.Drawing.Point(353, 362);
            this.btnAddGrind.Name = "btnAddGrind";
            this.btnAddGrind.Size = new System.Drawing.Size(142, 33);
            this.btnAddGrind.TabIndex = 29;
            this.btnAddGrind.Text = "Add Grind";
            this.btnAddGrind.UseVisualStyleBackColor = true;
            this.btnAddGrind.Click += new System.EventHandler(this.btnAddGrind_Click);
            // 
            // frmAddGrind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAddGrind);
            this.Controls.Add(this.cboTutors);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboRooms);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAttendance);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pickDate);
            this.Controls.Add(this.pickTime);
            this.Controls.Add(this.mnuViewStudentDetails);
            this.Name = "frmAddGrind";
            this.Text = "frmAddGrind";
            this.Load += new System.EventHandler(this.frmAddGrind_Load);
            this.mnuViewStudentDetails.ResumeLayout(false);
            this.mnuViewStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewStudentDetails;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.DateTimePicker pickTime;
        private System.Windows.Forms.DateTimePicker pickDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAttendance;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboRooms;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboTutors;
        private System.Windows.Forms.Button btnAddGrind;
    }
}