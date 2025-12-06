namespace GrindsBookingSystem
{
    partial class frmRemoveTutor
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
            this.cboTutID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNames = new System.Windows.Forms.ComboBox();
            this.cboSurnames = new System.Windows.Forms.ComboBox();
            this.lvRemoveTutors = new System.Windows.Forms.ListView();
            this.btnRemoveTutor = new System.Windows.Forms.Button();
            this.btnResetFilters = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.TabIndex = 14;
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
            this.label1.TabIndex = 15;
            this.label1.Text = "Tutor ID";
            // 
            // cboTutID
            // 
            this.cboTutID.FormattingEnabled = true;
            this.cboTutID.Location = new System.Drawing.Point(369, 32);
            this.cboTutID.Name = "cboTutID";
            this.cboTutID.Size = new System.Drawing.Size(121, 21);
            this.cboTutID.TabIndex = 16;
            this.cboTutID.SelectedIndexChanged += new System.EventHandler(this.cboTutID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Surname";
            // 
            // cboNames
            // 
            this.cboNames.FormattingEnabled = true;
            this.cboNames.Location = new System.Drawing.Point(369, 62);
            this.cboNames.Name = "cboNames";
            this.cboNames.Size = new System.Drawing.Size(121, 21);
            this.cboNames.TabIndex = 20;
            this.cboNames.SelectedIndexChanged += new System.EventHandler(this.cboNames_SelectedIndexChanged);
            // 
            // cboSurnames
            // 
            this.cboSurnames.FormattingEnabled = true;
            this.cboSurnames.Location = new System.Drawing.Point(369, 92);
            this.cboSurnames.Name = "cboSurnames";
            this.cboSurnames.Size = new System.Drawing.Size(121, 21);
            this.cboSurnames.TabIndex = 21;
            this.cboSurnames.SelectedIndexChanged += new System.EventHandler(this.cboSurnames_SelectedIndexChanged);
            // 
            // lvRemoveTutors
            // 
            this.lvRemoveTutors.HideSelection = false;
            this.lvRemoveTutors.Location = new System.Drawing.Point(123, 131);
            this.lvRemoveTutors.Name = "lvRemoveTutors";
            this.lvRemoveTutors.Size = new System.Drawing.Size(568, 227);
            this.lvRemoveTutors.TabIndex = 22;
            this.lvRemoveTutors.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemoveTutor
            // 
            this.btnRemoveTutor.Location = new System.Drawing.Point(417, 384);
            this.btnRemoveTutor.Name = "btnRemoveTutor";
            this.btnRemoveTutor.Size = new System.Drawing.Size(160, 25);
            this.btnRemoveTutor.TabIndex = 23;
            this.btnRemoveTutor.Text = "Remove Selected Tutor";
            this.btnRemoveTutor.UseVisualStyleBackColor = true;
            this.btnRemoveTutor.Click += new System.EventHandler(this.btnRemoveTutor_Click);
            // 
            // btnResetFilters
            // 
            this.btnResetFilters.Location = new System.Drawing.Point(234, 384);
            this.btnResetFilters.Name = "btnResetFilters";
            this.btnResetFilters.Size = new System.Drawing.Size(160, 25);
            this.btnResetFilters.TabIndex = 24;
            this.btnResetFilters.Text = "Reset Filters";
            this.btnResetFilters.UseVisualStyleBackColor = true;
            this.btnResetFilters.Click += new System.EventHandler(this.btnResetFilters_Click);
            // 
            // frmRemoveTutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnResetFilters);
            this.Controls.Add(this.btnRemoveTutor);
            this.Controls.Add(this.lvRemoveTutors);
            this.Controls.Add(this.cboSurnames);
            this.Controls.Add(this.cboNames);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTutID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmRemoveTutor";
            this.Text = "Grinds Booking System - Remove Tutor";
            this.Load += new System.EventHandler(this.frmRemoveTutor_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ToolStripMenuItem btnRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTutID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNames;
        private System.Windows.Forms.ComboBox cboSurnames;
        private System.Windows.Forms.ListView lvRemoveTutors;
        private System.Windows.Forms.Button btnRemoveTutor;
        private System.Windows.Forms.Button btnResetFilters;
    }
}