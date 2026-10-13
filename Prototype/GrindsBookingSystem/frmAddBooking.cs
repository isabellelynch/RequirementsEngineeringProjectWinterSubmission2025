using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmAddStudent;
using static GrindsBookingSystem.frmHome;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GrindsBookingSystem
{
    public partial class frmAddBooking : Form
    {
        public frmAddBooking()
        {
            InitializeComponent();
            LoadAllStudents();
            grpMakeBooking.Visible = false;
        }

        public void LoadAllStudents()
        {
            frmHome.ClearCombos(this.Controls);

            foreach (var s in StudentDataStore.Students)
            {
                if (!cboStudentID.Items.Contains(s.StudentID))
                    cboStudentID.Items.Add(s.StudentID);

                if (!cboFirstName.Items.Contains(s.FirstName))
                    cboFirstName.Items.Add(s.FirstName);

                if (!cboLastName.Items.Contains(s.Surname))
                    cboLastName.Items.Add(s.Surname);
            }

        }
        private void ApplyFilters()
        {
            var filtered = StudentDataStore.Students.AsEnumerable();

            if (cboStudentID.SelectedIndex != -1)
            {
                int id = int.Parse(cboStudentID.Text);
                var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == id);

                cboFirstName.Text = student.FirstName;
                cboLastName.Text = student.Surname;
            }

            if (int.TryParse(cboStudentID.Text, out int parsedId))
                filtered = filtered.Where(s => s.StudentID == parsedId);

            if (!string.IsNullOrWhiteSpace(cboFirstName.Text))
                filtered = filtered.Where(s => s.FirstName == cboFirstName.Text);

            if (!string.IsNullOrWhiteSpace(cboLastName.Text))
                filtered = filtered.Where(s => s.Surname == cboLastName.Text);

            frmHome.UpdateComboBoxesS(
                filtered,
                cboStudentID, cboFirstName, cboLastName,
                cboStudentID_SelectedIndexChanged,
                cboFirstName_SelectedIndexChanged,
                cboLastName_SelectedIndexChanged
            );

            if (cboStudentID.Items.Count == 1)
                cboStudentID.SelectedIndex = 0;

            if (cboFirstName.Items.Count == 1)
                cboFirstName.SelectedIndex = 0;

            if (cboLastName.Items.Count == 1)
                cboLastName.SelectedIndex = 0;
        }
        private void cboStudentID_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboFirstName_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboLastName_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        public void updateListView(IEnumerable<Schedule> schedules)
        {

            lvSchedule.Items.Clear();

            foreach (var s in schedules)
            {
                if(s.TimeandDate < DateTime.Now)
                {
                    continue;
                }
                var item = new ListViewItem(s.TimeandDate.ToShortDateString());
                item.SubItems.Add(s.TimeandDate.ToShortTimeString());
                item.SubItems.Add(s.MaxAttendnace.ToString());
                item.SubItems.Add(s.currentEnrollment.ToString());
                item.SubItems.Add(s.RoomNo);
                item.SubItems.Add(s.TutorID.ToString());

                item.Tag = s;

                lvSchedule.Items.Add(item);
            }
            lvSchedule.ListViewItemSorter = new DateTimeListViewComparer(0, 1, true);
            lvSchedule.Sort();
        }

        

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if (lvSchedule.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a grind to book before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedlv = lvSchedule.SelectedItems[0];
            var selectedGrind = selectedlv.Tag as Schedule;

            int intStudentID = int.Parse(cboStudentID.SelectedItem.ToString());
            var selectedStudent = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == intStudentID);

            var tutor = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == selectedGrind.TutorID);
            if (selectedStudent == null || tutor == null)
            {
                MessageBox.Show("The selected student or this grind's tutor could not be found. Please refresh and try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //all checks happen before anything is changed, so a cancelled booking doesn't use up a space
            if (selectedGrind.students.Contains(selectedStudent))
            {
                MessageBox.Show("The student you have chosen has already booked this grind.", "Already Booked",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedGrind.currentEnrollment >= selectedGrind.MaxAttendnace)
            {
                MessageBox.Show("This grind is fully booked, please select a different grind.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int thisAmount = frmHome.GetRateAmount(tutor.RateCode);

            DialogResult dialogResult = MessageBox.Show("Has Student " + selectedStudent.FirstName + " " + selectedStudent.Surname + " provided payment of €" + thisAmount + " for this grind?",
                "Payment?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
            {
                return;
            }

            selectedGrind.currentEnrollment++;
            selectedGrind.students.Add(selectedStudent);

            Booking thisBooking = new Booking()
            {
                bookingRef = BookingDataStore.GetNextBookigRef(),
                StudentID = selectedStudent.StudentID,
                DateOfBooking = DateTime.Today,
                GrindTime = selectedGrind.TimeandDate,
                TutorID = selectedGrind.TutorID,
                Amount = thisAmount
            };

            BookingDataStore.Bookings.Add(thisBooking);
            selectedStudent.bookings.Add(thisBooking);

            if (selectedGrind.currentEnrollment == selectedGrind.MaxAttendnace)
            {
                MessageBox.Show("This was the last space available in this grind.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            MessageBox.Show("This grind has been successfully booked for " + selectedStudent.FirstName + " " +
                selectedStudent.Surname, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            reset();


        }

        public void reset()
        {
            cboStudentID.Items.Clear();
            cboFirstName.Items.Clear();
            cboLastName.Items.Clear();
            lvSchedule.Items.Clear();
            grpMakeBooking.Visible = false;
            LoadAllStudents();
            cboStudentID.Enabled = true;
            cboFirstName.Enabled = true;
            cboLastName.Enabled = true;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {

            if(cboStudentID.SelectedIndex == -1)
            {
                MessageBox.Show("Student ID must be selected before continuing.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboFirstName.SelectedIndex == -1)
            {
                MessageBox.Show("Student First Name must be selected before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboLastName.SelectedIndex == -1)
            {
                MessageBox.Show("Student Last Name must be selected before continuing.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            grpMakeBooking.Visible = true;
            cboFirstName.Enabled = false;
            cboLastName.Enabled = false;
            cboStudentID.Enabled = false;

            if (lvSchedule.Columns.Count == 0)
            {
                lvSchedule.Columns.Add("Date", 100);
                lvSchedule.Columns.Add("Time", 100);
                lvSchedule.Columns.Add("Max Attendance", 115);
                lvSchedule.Columns.Add("Current Enrollment", 115);
                lvSchedule.Columns.Add("Room No", 130);
                lvSchedule.Columns.Add("Tutor ID", 120);
            }

            lvSchedule.View = View.Details;
            lvSchedule.FullRowSelect = true;
            lvSchedule.GridLines = true;
            updateListView(ScheduleDataStore.ScheduleItems.OrderBy(s => s.TimeandDate));
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
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
