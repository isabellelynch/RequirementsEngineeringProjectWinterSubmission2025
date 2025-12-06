using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
            
        }

        
         
    private void btnYearlyRev_Click(object sender, EventArgs e)
    {
            int total = 0;

            if (cboYear.SelectedIndex == -1) 
            { 
                MessageBox.Show("A year must be selected before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            foreach(var b in BookingDataStore.Bookings)
            {
                if (b.DateOfBooking.Year.ToString() == cboYear.SelectedItem.ToString()) 
                {
                    total += b.Amount;
                }
            }
            MessageBox.Show("Total Revenue for the year " + cboYear.SelectedItem.ToString() + " is €" + total, "Total Yearly Revenue", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loadYears();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            loadYears();
        }

        private void btnTutorReport_Click(object sender, EventArgs e)
        {
            Form form = new frmTutorReport();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?",
                                                   "Please Confirm",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Owner.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadYears();
        }

        private void loadYears()
        {
            frmHome.ClearCombos(this.Controls);
            if (cboYear.Items.Count == 0)
            {
                for(int i = DateTime.Now.Year; i >= 2005; i--)
                {
                    cboYear.Items.Add(i.ToString());
                }
                
            }
            cboYear.SelectedIndex = -1;
        }
    }
}
