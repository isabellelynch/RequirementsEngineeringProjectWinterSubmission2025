namespace GrindsBookingSystem
{
    partial class frmSchedule
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
            this.lvSchedule = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddGrind = new System.Windows.Forms.Button();
            this.btnRemoveGrind = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.btnBack});
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
            // lvSchedule
            // 
            this.lvSchedule.HideSelection = false;
            this.lvSchedule.Location = new System.Drawing.Point(51, 86);
            this.lvSchedule.Name = "lvSchedule";
            this.lvSchedule.Size = new System.Drawing.Size(693, 257);
            this.lvSchedule.TabIndex = 15;
            this.lvSchedule.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(300, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Grinds Booking System - Schedule";
            // 
            // btnAddGrind
            // 
            this.btnAddGrind.Location = new System.Drawing.Point(245, 383);
            this.btnAddGrind.Name = "btnAddGrind";
            this.btnAddGrind.Size = new System.Drawing.Size(130, 25);
            this.btnAddGrind.TabIndex = 17;
            this.btnAddGrind.Text = "Add Grind";
            this.btnAddGrind.UseVisualStyleBackColor = true;
            this.btnAddGrind.Click += new System.EventHandler(this.btnAddGrind_Click);
            // 
            // btnRemoveGrind
            // 
            this.btnRemoveGrind.Location = new System.Drawing.Point(422, 383);
            this.btnRemoveGrind.Name = "btnRemoveGrind";
            this.btnRemoveGrind.Size = new System.Drawing.Size(130, 25);
            this.btnRemoveGrind.TabIndex = 18;
            this.btnRemoveGrind.Text = "Remove Grind";
            this.btnRemoveGrind.UseVisualStyleBackColor = true;
            this.btnRemoveGrind.Click += new System.EventHandler(this.btnRemoveGrind_Click);
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRemoveGrind);
            this.Controls.Add(this.btnAddGrind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvSchedule);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frmSchedule";
            this.Text = "Grinds Booking System - Schedule";
            this.Load += new System.EventHandler(this.frmSchedule_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnExit;
        private System.Windows.Forms.ToolStripMenuItem btnBack;
        private System.Windows.Forms.ListView lvSchedule;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddGrind;
        private System.Windows.Forms.Button btnRemoveGrind;
    }
}