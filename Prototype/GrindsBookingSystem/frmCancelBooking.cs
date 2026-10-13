using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmCancelBooking : Form
    {
        public frmCancelBooking()
        {
            InitializeComponent();
        }


        private void LoadAllStudents()
        {
            frmHome.ClearCombos(this.Controls);

            foreach (var s in StudentDataStore.Students)
            {
                if (!cboStudentID.Items.Contains(s.StudentID))
                    cboStudentID.Items.Add(s.StudentID);

                if (!cboName.Items.Contains(s.FirstName))
                    cboName.Items.Add(s.FirstName);

                if (!cboSName.Items.Contains(s.Surname))
                    cboSName.Items.Add(s.Surname);
            }

        }

        private void ApplyFilters()
        {
            var filtered = StudentDataStore.Students.AsEnumerable();

            if (cboStudentID.SelectedIndex != -1)
            {
                int id = int.Parse(cboStudentID.Text);
                var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == id);

                cboName.Text = student.FirstName;
                cboSName.Text = student.Surname;
            }

            if (int.TryParse(cboStudentID.Text, out int parsedId))
                filtered = filtered.Where(s => s.StudentID == parsedId);

            if (!string.IsNullOrWhiteSpace(cboName.Text))
                filtered = filtered.Where(s => s.FirstName == cboName.Text);

            if (!string.IsNullOrWhiteSpace(cboSName.Text))
                filtered = filtered.Where(s => s.Surname == cboSName.Text);

            frmHome.UpdateComboBoxesS(
                filtered,
                cboStudentID, cboName, cboSName,
                cboStudentID_SelectedIndexChanged,
                cboName_SelectedIndexChanged,
                cboSName_SelectedIndexChanged
            );

            if (cboStudentID.Items.Count == 1)
                cboStudentID.SelectedIndex = 0;

            if (cboName.Items.Count == 1)
                cboName.SelectedIndex = 0;

            if (cboSName.Items.Count == 1)
                cboSName.SelectedIndex = 0;
        }

        private void frmCancelBooking_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
            grpCancelBooking.Visible = false;
        }

        private void cboStudentID_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cboName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void cboSName_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            if (cboStudentID.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student before continuing.", "No Student Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedStudent = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == int.Parse(cboStudentID.SelectedItem.ToString()));
            if (selectedStudent == null)
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            grpCancelBooking.Visible = true;
            cboStudentID.Enabled = false;
            cboName.Enabled = false;
            cboSName.Enabled = false;
            var selectedBookings = selectedStudent.bookings;
            updateListView(selectedBookings);
        }

        public void updateListView(IEnumerable<Booking> bookings)
        {

            lvBookings.Items.Clear();
            if (lvBookings.Columns.Count == 0)
            {

                lvBookings.Columns.Add("Booking Date", 100);
                lvBookings.Columns.Add("Grind Date/Time", 140);
                lvBookings.Columns.Add("Booking Reference", 100);
                lvBookings.Columns.Add("Tutor ID", 115);
                lvBookings.Columns.Add("Amount", 130);
            }


            lvBookings.View = View.Details;
            lvBookings.FullRowSelect = true;
            lvBookings.GridLines = true;



            foreach (var b in bookings)
            {
                if(b.GrindTime < DateTime.Now)
                {
                    continue;
                }
                var item = new ListViewItem(b.DateOfBooking.ToShortDateString());
                item.SubItems.Add(b.GrindTime.ToString("g"));
                item.SubItems.Add(b.bookingRef.ToString());
                item.SubItems.Add(b.TutorID.ToString());
                item.SubItems.Add(b.Amount.ToString());


                item.Tag = b;

                lvBookings.Items.Add(item);
            }

            lvBookings.ListViewItemSorter = new DateTimeListViewComparer(0, 1, true);
            lvBookings.Sort();
        }

        private void btnCancelBooking_Click(object sender, EventArgs e)
        {
            if (lvBookings.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a booking to cancel before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var selectedlv = lvBookings.SelectedItems[0];
            var selectedBooking = selectedlv.Tag as Booking;
            var selectedStudent = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == int.Parse(cboStudentID.SelectedItem.ToString()));

            //confirm before changing anything, so choosing Cancel leaves the booking untouched
            if (selectedBooking.GrindTime > DateTime.Now.AddDays(7))
            {
                DialogResult confirm = MessageBox.Show("This booking is more than 7 days away, so a refund of €" + selectedBooking.Amount +
                    " will be given. Would you like to proceed with the cancellation?",
                    "Please Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (confirm == DialogResult.Cancel)
                {
                    return;
                }
            }
            else
            {
                DialogResult noRefund = MessageBox.Show("Note: No refund will be granted for this cancellation as it is less than 7 days away, would you like to proceed with the cancellation?",
                    "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (noRefund == DialogResult.Cancel)
                {
                    return;
                }
            }

            //removes the booking from the bookings list, the student and the grind, and records any refund
            frmHome.CancelBookingAndRefund(selectedBooking, false);

            DialogResult result = MessageBox.Show("This Booking has been successfully Cancelled, Would you like to cancel another booking for this student?", "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                updateListView(selectedStudent.bookings);
            }
            else
            {
                reset();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
        }

        public void reset()
        {
            frmHome.ClearCombos(this.Controls);
            cboStudentID.Enabled = true;
            cboName.Enabled = true;
            cboSName.Enabled = true;

            LoadAllStudents();
            lvBookings.Items.Clear();
            grpCancelBooking.Visible = false;

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
