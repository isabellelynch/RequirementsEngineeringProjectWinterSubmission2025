namespace GrindsBookingSystem
{
    partial class frmRemoveGrind
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
            this.lvGrinds = new System.Windows.Forms.ListView();
            this.btnRemove = new System.Windows.Forms.Button();
            this.mnuViewStudentDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuViewStudentDetails
            // 
            this.mnuViewStudentDetails.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnBack});
            this.mnuViewStudentDetails.Location = new System.Drawing.Point(0, 0);
            this.mnuViewStudentDetails.Name = "mnuViewStudentDetails";
            this.mnuViewStudentDetails.Size = new System.Drawing.Size(800, 24);
            this.mnuViewStudentDetails.TabIndex = 19;
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
            // lvGrinds
            // 
            this.lvGrinds.HideSelection = false;
            this.lvGrinds.Location = new System.Drawing.Point(92, 99);
            this.lvGrinds.Name = "lvGrinds";
            this.lvGrinds.Size = new System.Drawing.Size(644, 256);
            this.lvGrinds.TabIndex = 20;
            this.lvGrinds.UseCompatibleStateImageBehavior = false;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(325, 386);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(147, 23);
            this.btnRemove.TabIndex = 21;
            this.btnRemove.Text = "Remove Grind";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click_1);
            // 
            // frmRemoveGrind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lvGrinds);
            this.Controls.Add(this.mnuViewStudentDetails);
            this.Name = "frmRemoveGrind";
            this.Text = "frmRemoveGrind";
            this.mnuViewStudentDetails.ResumeLayout(false);
            this.mnuViewStudentDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuViewStudentDetails;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ListView lvGrinds;
        private System.Windows.Forms.Button btnRemove;
    }
}