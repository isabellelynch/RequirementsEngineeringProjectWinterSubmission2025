using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmAddStudent;
using static GrindsBookingSystem.frmHome;


namespace GrindsBookingSystem
{
    public partial class frmViewStudentDetails : Form
    {
        public frmViewStudentDetails()
        {
            InitializeComponent();
        }

        private void frmViewStudentDetails_Load(object sender, EventArgs e)
        {
            LoadAllStudents();
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
        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllStudents();
        private void btnBack_Click(object sender, EventArgs e)
        {
            Owner.Show();
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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cboStudentID.Text, out int id))
            {
                MessageBox.Show("Please select a student first.",
                                "No Student Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var studentView = StudentDataStore.Students
                                              .FirstOrDefault(s => s.StudentID == id);

            if (studentView == null)
            {
                MessageBox.Show("Student not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                "The details of the chosen student are:\n\n" +
                $"Student ID : {studentView.StudentID}\n" +
                $"First Name : {studentView.FirstName}\n" +
                $"Last Name : {studentView.Surname}\n" +
                $"Phone : {studentView.Phone}\n" +
                $"Email : {studentView.Email}",
                "Student Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LoadAllStudents();

        }
    }
}
