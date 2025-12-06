using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmHome;
using static GrindsBookingSystem.frmSchedule;

namespace GrindsBookingSystem
{
    public partial class frmRemoveGrind : Form
    {
        public frmRemoveGrind()
        {
            InitializeComponent();
            lvGrinds.FullRowSelect = true;
            lvGrinds.View = View.Details;
            lvGrinds.GridLines = true;

            lvGrinds.Columns.Add("Date", 100);
            lvGrinds.Columns.Add("Time", 100);
            lvGrinds.Columns.Add("Room No", 100);
            lvGrinds.Columns.Add("Tutor ID", 80);

            PopulateGrinds();
        }

        private void PopulateGrinds()
        {
            lvGrinds.Items.Clear();
            foreach (var grind in ScheduleDataStore.ScheduleItems.OrderBy(g => g.TimeandDate))
            {
                if(grind.TimeandDate < DateTime.Today)
                {
                    continue;
                }
                var item = new ListViewItem(grind.TimeandDate.ToShortDateString());
                item.SubItems.Add(grind.TimeandDate.ToShortTimeString());
                item.SubItems.Add(grind.RoomNo);
                item.SubItems.Add(grind.TutorID.ToString());
                lvGrinds.Items.Add(item);
            }
        }

        private void btnRemove_Click_1(object sender, EventArgs e)
        {
            if (lvGrinds.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a grind to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            

            var selectedItem = lvGrinds.SelectedItems[0];
            DateTime date = DateTime.Parse(selectedItem.SubItems[0].Text);
            TimeSpan time = TimeSpan.Parse(selectedItem.SubItems[1].Text);
            string room = selectedItem.SubItems[2].Text;
            int tutorID = int.Parse(selectedItem.SubItems[3].Text);


            var grindToRemove = ScheduleDataStore.ScheduleItems.FirstOrDefault(g =>
                g.TimeandDate.Date == date.Date &&
                g.TimeandDate.TimeOfDay == time &&
                g.RoomNo == room &&
                g.TutorID == tutorID
            );

            if(grindToRemove.TimeandDate <= DateTime.Today.AddDays(7) && grindToRemove.currentEnrollment > 0)
            {
                MessageBox.Show("You can only remove a grind that is less than 7 days away if it has no students enrolled, please check with higher management if this grind must be removed.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (grindToRemove != null)
            {
                ScheduleDataStore.ScheduleItems.Remove(grindToRemove);
                MessageBox.Show("Grind removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                PopulateGrinds();
            }
            else
            {
                MessageBox.Show("Could not find the selected grind.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new frmSchedule();
            form.Show();
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
    }
}
