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
                if(grind.TimeandDate < DateTime.Now)
                {
                    continue;
                }
                var item = new ListViewItem(grind.TimeandDate.ToShortDateString());
                item.SubItems.Add(grind.TimeandDate.ToShortTimeString());
                item.SubItems.Add(grind.RoomNo);
                item.SubItems.Add(grind.TutorID.ToString());
                item.Tag = grind;
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
            

            //the grind is stored in the row's Tag, so there is no need to parse the displayed date and time
            var grindToRemove = lvGrinds.SelectedItems[0].Tag as Schedule;

            if (grindToRemove == null || !ScheduleDataStore.ScheduleItems.Contains(grindToRemove))
            {
                MessageBox.Show("Could not find the selected grind.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                PopulateGrinds();
                return;
            }

            if(grindToRemove.TimeandDate <= DateTime.Today.AddDays(7) && grindToRemove.currentEnrollment > 0)
            {
                MessageBox.Show("You can only remove a grind that is less than 7 days away if it has no students enrolled, please check with higher management if this grind must be removed.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bookingsForGrind = BookingDataStore.Bookings
                .Where(b => b.GrindTime == grindToRemove.TimeandDate && b.TutorID == grindToRemove.TutorID)
                .ToList();

            DialogResult confirm = MessageBox.Show("Are you sure you want to remove the grind on " +
                grindToRemove.TimeandDate.ToString("g") + " in room " + grindToRemove.RoomNo + "?" +
                (bookingsForGrind.Count > 0 ? "\n\n" + bookingsForGrind.Count + " booking(s) will be cancelled and fully refunded." : ""),
                "Confirm Removal", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes)
            {
                return;
            }

            //cancel and fully refund every booking for this grind, as the practice is cancelling it
            int totalRefund = 0;
            var studentsToNotify = new List<string>();
            foreach (var booking in bookingsForGrind)
            {
                totalRefund += frmHome.CancelBookingAndRefund(booking, true);
                studentsToNotify.Add(frmHome.StudentName(booking.StudentID));
            }

            ScheduleDataStore.ScheduleItems.Remove(grindToRemove);

            string message = "Grind removed successfully!";
            if (bookingsForGrind.Count > 0)
            {
                //in the full system these students would be emailed about the cancellation
                message += "\n\n" + bookingsForGrind.Count + " booking(s) cancelled. Total refunded: €" + totalRefund + "." +
                           "\nStudents to be notified: " + string.Join(", ", studentsToNotify.Distinct());
            }
            MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            PopulateGrinds();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?",
                                                   "Please Confirm",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmHome.ExitApplication();
            }
        }
    }
}
