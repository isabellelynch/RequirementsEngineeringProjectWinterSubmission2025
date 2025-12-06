namespace GrindsBookingSystem
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tutorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeTutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTutorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewTutorDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeStuentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStudentDetaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBokingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewBookingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picHome = new System.Windows.Forms.PictureBox();
            this.yearlyRevenueAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tutorEarningsAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tutorsToolStripMenuItem,
            this.studentsToolStripMenuItem,
            this.scheduleToolStripMenuItem,
            this.bookingsToolStripMenuItem,
            this.adminToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tutorsToolStripMenuItem
            // 
            this.tutorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeTutorToolStripMenuItem,
            this.updateTutorDetailsToolStripMenuItem,
            this.viewTutorDetailsToolStripMenuItem});
            this.tutorsToolStripMenuItem.Name = "tutorsToolStripMenuItem";
            this.tutorsToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.tutorsToolStripMenuItem.Text = "Tutors";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.addToolStripMenuItem.Text = "Add Tutor";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeTutorToolStripMenuItem
            // 
            this.removeTutorToolStripMenuItem.Name = "removeTutorToolStripMenuItem";
            this.removeTutorToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.removeTutorToolStripMenuItem.Text = "Remove Tutor";
            this.removeTutorToolStripMenuItem.Click += new System.EventHandler(this.removeTutorToolStripMenuItem_Click);
            // 
            // updateTutorDetailsToolStripMenuItem
            // 
            this.updateTutorDetailsToolStripMenuItem.Name = "updateTutorDetailsToolStripMenuItem";
            this.updateTutorDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.updateTutorDetailsToolStripMenuItem.Text = "Update Tutor Details";
            this.updateTutorDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateTutorDetailsToolStripMenuItem_Click);
            // 
            // viewTutorDetailsToolStripMenuItem
            // 
            this.viewTutorDetailsToolStripMenuItem.Name = "viewTutorDetailsToolStripMenuItem";
            this.viewTutorDetailsToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.viewTutorDetailsToolStripMenuItem.Text = "View Tutor Details";
            this.viewTutorDetailsToolStripMenuItem.Click += new System.EventHandler(this.viewTutorDetailsToolStripMenuItem_Click);
            // 
            // studentsToolStripMenuItem
            // 
            this.studentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addStudentToolStripMenuItem,
            this.removeStuentToolStripMenuItem,
            this.updateStudentDetailsToolStripMenuItem,
            this.viewStudentDetaisToolStripMenuItem});
            this.studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            this.studentsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.studentsToolStripMenuItem.Text = "Students";
            // 
            // addStudentToolStripMenuItem
            // 
            this.addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            this.addStudentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new System.EventHandler(this.addStudentToolStripMenuItem_Click);
            // 
            // removeStuentToolStripMenuItem
            // 
            this.removeStuentToolStripMenuItem.Name = "removeStuentToolStripMenuItem";
            this.removeStuentToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removeStuentToolStripMenuItem.Text = "Remove Student";
            this.removeStuentToolStripMenuItem.Click += new System.EventHandler(this.removeStuentToolStripMenuItem_Click);
            // 
            // updateStudentDetailsToolStripMenuItem
            // 
            this.updateStudentDetailsToolStripMenuItem.Name = "updateStudentDetailsToolStripMenuItem";
            this.updateStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.updateStudentDetailsToolStripMenuItem.Text = "Update Student Details";
            this.updateStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.updateStudentDetailsToolStripMenuItem_Click);
            // 
            // viewStudentDetaisToolStripMenuItem
            // 
            this.viewStudentDetaisToolStripMenuItem.Name = "viewStudentDetaisToolStripMenuItem";
            this.viewStudentDetaisToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.viewStudentDetaisToolStripMenuItem.Text = "View Student Details";
            this.viewStudentDetaisToolStripMenuItem.Click += new System.EventHandler(this.viewStudentDetaisToolStripMenuItem_Click);
            // 
            // scheduleToolStripMenuItem
            // 
            this.scheduleToolStripMenuItem.Name = "scheduleToolStripMenuItem";
            this.scheduleToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.scheduleToolStripMenuItem.Text = "Schedule";
            this.scheduleToolStripMenuItem.Click += new System.EventHandler(this.scheduleToolStripMenuItem_Click);
            // 
            // bookingsToolStripMenuItem
            // 
            this.bookingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeBookingToolStripMenuItem,
            this.cancelBokingToolStripMenuItem,
            this.viewBookingsToolStripMenuItem});
            this.bookingsToolStripMenuItem.Name = "bookingsToolStripMenuItem";
            this.bookingsToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.bookingsToolStripMenuItem.Text = "Bookings";
            // 
            // makeBookingToolStripMenuItem
            // 
            this.makeBookingToolStripMenuItem.Name = "makeBookingToolStripMenuItem";
            this.makeBookingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.makeBookingToolStripMenuItem.Text = "Make Booking";
            this.makeBookingToolStripMenuItem.Click += new System.EventHandler(this.makeBookingToolStripMenuItem_Click);
            // 
            // cancelBokingToolStripMenuItem
            // 
            this.cancelBokingToolStripMenuItem.Name = "cancelBokingToolStripMenuItem";
            this.cancelBokingToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.cancelBokingToolStripMenuItem.Text = "Cancel Booking";
            this.cancelBokingToolStripMenuItem.Click += new System.EventHandler(this.cancelBokingToolStripMenuItem_Click);
            // 
            // viewBookingsToolStripMenuItem
            // 
            this.viewBookingsToolStripMenuItem.Name = "viewBookingsToolStripMenuItem";
            this.viewBookingsToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.viewBookingsToolStripMenuItem.Text = "View Bookings";
            this.viewBookingsToolStripMenuItem.Click += new System.EventHandler(this.viewBookingsToolStripMenuItem_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yearlyRevenueAnalysisToolStripMenuItem,
            this.tutorEarningsAnalysisToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // picHome
            // 
            this.picHome.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHome.BackgroundImage")));
            this.picHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHome.Location = new System.Drawing.Point(0, 27);
            this.picHome.Name = "picHome";
            this.picHome.Size = new System.Drawing.Size(800, 423);
            this.picHome.TabIndex = 1;
            this.picHome.TabStop = false;
            // 
            // yearlyRevenueAnalysisToolStripMenuItem
            // 
            this.yearlyRevenueAnalysisToolStripMenuItem.Name = "yearlyRevenueAnalysisToolStripMenuItem";
            this.yearlyRevenueAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.yearlyRevenueAnalysisToolStripMenuItem.Text = "Yearly Revenue Analysis";
            this.yearlyRevenueAnalysisToolStripMenuItem.Click += new System.EventHandler(this.yearlyRevenueAnalysisToolStripMenuItem_Click);
            // 
            // tutorEarningsAnalysisToolStripMenuItem
            // 
            this.tutorEarningsAnalysisToolStripMenuItem.Name = "tutorEarningsAnalysisToolStripMenuItem";
            this.tutorEarningsAnalysisToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.tutorEarningsAnalysisToolStripMenuItem.Text = "Tutor Earnings Analysis";
            this.tutorEarningsAnalysisToolStripMenuItem.Click += new System.EventHandler(this.tutorEarningsAnalysisToolStripMenuItem_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picHome);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmHome";
            this.Text = "Home Page - Grinds Booking System";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem studentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeStuentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStudentDetaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeTutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTutorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewTutorDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBokingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewBookingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.PictureBox picHome;
        private System.Windows.Forms.ToolStripMenuItem yearlyRevenueAnalysisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tutorEarningsAnalysisToolStripMenuItem;
    }
}

