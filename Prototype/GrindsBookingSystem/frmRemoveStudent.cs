using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmRemoveStudent : Form
    {
        public frmRemoveStudent()
        {
            InitializeComponent();

            lvRemoveStudent.Columns.Clear();

            lvRemoveStudent.Columns.Add("ID", 50);
            lvRemoveStudent.Columns.Add("First Name", 120);
            lvRemoveStudent.Columns.Add("Surname", 120);

            lvRemoveStudent.View = View.Details;
            lvRemoveStudent.FullRowSelect = true;

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
                cboStudentID_SelectedIndexChanged_1,
                cboName_SelectedIndexChanged,
                cboSName_SelectedIndexChanged
            );

            if (cboStudentID.Items.Count == 1)
                cboStudentID.SelectedIndex = 0;

            if (cboName.Items.Count == 1)
                cboName.SelectedIndex = 0;

            if (cboSName.Items.Count == 1)
                cboSName.SelectedIndex = 0;
            UpdateListView( filtered );
        }
        private void UpdateListView(IEnumerable<Student> students)
        {
            lvRemoveStudent.Items.Clear();

            foreach (var s in students)
            {
                var item = new ListViewItem(s.StudentID.ToString());
                item.SubItems.Add(s.FirstName);
                item.SubItems.Add(s.Surname);

                lvRemoveStudent.Items.Add(item);
            }
        }

        private void LoadAllStudents()
        {
            //stop the filter events firing while the combo boxes are being cleared and refilled
            cboStudentID.SelectedIndexChanged -= cboStudentID_SelectedIndexChanged_1;
            cboName.SelectedIndexChanged -= cboName_SelectedIndexChanged;
            cboSName.SelectedIndexChanged -= cboSName_SelectedIndexChanged;

            frmHome.ClearCombos(this.Controls);
            UpdateListView(StudentDataStore.Students);

            foreach (var s in StudentDataStore.Students)
            {
                if (!cboStudentID.Items.Contains(s.StudentID))
                    cboStudentID.Items.Add(s.StudentID);

                if (!cboName.Items.Contains(s.FirstName))
                    cboName.Items.Add(s.FirstName);

                if (!cboSName.Items.Contains(s.Surname))
                    cboSName.Items.Add(s.Surname);
            }

            cboStudentID.SelectedIndexChanged += cboStudentID_SelectedIndexChanged_1;
            cboName.SelectedIndexChanged += cboName_SelectedIndexChanged;
            cboSName.SelectedIndexChanged += cboSName_SelectedIndexChanged;
        }
        private void cboStudentID_SelectedIndexChanged_1(object sender, EventArgs e) => ApplyFilters();
        private void cboName_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboSName_SelectedIndexChanged(object sender, EventArgs e) =>  ApplyFilters();
        private void btnResetFilters_Click(object sender, EventArgs e)
        {
            cboStudentID.SelectedIndexChanged -= cboStudentID_SelectedIndexChanged_1;
            cboName.SelectedIndexChanged -= cboName_SelectedIndexChanged;
            cboSName.SelectedIndexChanged -= cboSName_SelectedIndexChanged;

            frmHome.ClearCombos(this.Controls);
            LoadAllStudents();

            cboStudentID.SelectedIndexChanged += cboStudentID_SelectedIndexChanged_1;
            cboName.SelectedIndexChanged += cboName_SelectedIndexChanged;
            cboSName.SelectedIndexChanged += cboSName_SelectedIndexChanged;
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllStudents();
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

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lvRemoveStudent.SelectedItems.Count == 0)
            {
                MessageBox.Show("No Student Selected, Please select a student to be removed before continuing.",
                                "No Student Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            ListViewItem selectedItem = lvRemoveStudent.SelectedItems[0];

            int id = int.Parse(selectedItem.Text);

            var studentToRemove = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == id);

            if (studentToRemove == null)
            {
                MessageBox.Show("No Student Found",
                                "No Student Found",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            //any future bookings this student has made must be cancelled when they are removed
            var futureBookings = BookingDataStore.Bookings
                .Where(b => b.StudentID == studentToRemove.StudentID && b.GrindTime > DateTime.Now)
                .ToList();

            string bookingWarning = futureBookings.Count > 0
                ? "\n\nThis student has " + futureBookings.Count + " upcoming booking(s), which will be cancelled. " +
                  "Only bookings more than 7 days away will be refunded."
                : "";

            DialogResult response = MessageBox.Show(
                "Are you sure you want to remove " + studentToRemove.FirstName + " " + studentToRemove.Surname + "?" + bookingWarning,
                "Confirm Removal",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (response == DialogResult.Yes)
            {
                int totalRefund = 0;
                foreach (var booking in futureBookings)
                {
                    totalRefund += frmHome.CancelBookingAndRefund(booking, false);
                }

                StudentDataStore.Students.Remove(studentToRemove);

                string message = "Student " + studentToRemove.FirstName + " " + studentToRemove.Surname + " has been successfully removed from the system.";
                if (futureBookings.Count > 0)
                {
                    message += "\n\n" + futureBookings.Count + " upcoming booking(s) cancelled. Total refunded: €" + totalRefund + ".";
                }
                MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllStudents();
            }
        }

        private void frmRemoveStudent_Load(object sender, EventArgs e)=> LoadAllStudents();
        
    }

}
