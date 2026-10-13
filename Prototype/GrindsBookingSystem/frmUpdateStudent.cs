using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmAddStudent;
using static GrindsBookingSystem.frmHome;


namespace GrindsBookingSystem
{
    public partial class frmUpdateStudent : Form
    {

        public frmUpdateStudent()
        {
            InitializeComponent();
        }
        private void ApplyFilters()
        {
            var filtered = StudentDataStore.Students.AsEnumerable();

            if (cboStudentID.SelectedIndex != -1)
            {
                int id = int.Parse(cboStudentID.Text);
                var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == id);

                cboNames.Text = student.FirstName;
                cboSurnames.Text = student.Surname;
            }

            if (int.TryParse(cboStudentID.Text, out int parsedId))
                filtered = filtered.Where(s => s.StudentID == parsedId);

            if (!string.IsNullOrWhiteSpace(cboNames.Text))
                filtered = filtered.Where(s => s.FirstName == cboNames.Text);

            if (!string.IsNullOrWhiteSpace(cboSurnames.Text))
                filtered = filtered.Where(s => s.Surname == cboSurnames.Text);

            frmHome.UpdateComboBoxesS(
                filtered,
                cboStudentID, cboNames, cboSurnames,
                cboStudentID_SelectedIndexChanged,
                cboNames_SelectedIndexChanged,
                cboSurnames_SelectedIndexChanged
            );

            if (cboStudentID.Items.Count == 1)
                cboStudentID.SelectedIndex = 0;

            if (cboNames.Items.Count == 1)
                cboNames.SelectedIndex = 0;

            if (cboSurnames.Items.Count == 1)
                cboSurnames.SelectedIndex = 0;
        }





        private void LoadAllStudents()
        {
            cboStudentID.SelectedIndexChanged -= cboStudentID_SelectedIndexChanged;
            cboNames.SelectedIndexChanged -= cboNames_SelectedIndexChanged;
            cboSurnames.SelectedIndexChanged -= cboSurnames_SelectedIndexChanged;
            frmHome.ClearCombos(this.Controls);

            foreach (var s in StudentDataStore.Students)
            {
                if (!cboStudentID.Items.Contains(s.StudentID))
                    cboStudentID.Items.Add(s.StudentID);

                if (!cboNames.Items.Contains(s.FirstName))
                    cboNames.Items.Add(s.FirstName);

                if (!cboSurnames.Items.Contains(s.Surname))
                    cboSurnames.Items.Add(s.Surname);
            }

            cboStudentID.SelectedIndexChanged += cboStudentID_SelectedIndexChanged;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            cboSurnames.SelectedIndexChanged += cboSurnames_SelectedIndexChanged;

        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllStudents();
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
        public void goHome()
        {
            this.Close();
            cboNames.Enabled = true;
            cboSurnames.Enabled = true;
            cboStudentID.Enabled = true;
        }
        public void reset()
        {
            LoadAllStudents();
            cboNames.Enabled = true;
            cboSurnames.Enabled = true;
            cboStudentID.Enabled = true;

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            grpStudentDetails.Visible = false;
        }

        private void frmUpdateStudent_Load_1(object sender, EventArgs e)
        {
            LoadAllStudents();
            grpStudentDetails.Visible = false;
        }

        private void btnUpdateStudent_Click_1(object sender, EventArgs e)
        {
            var idValue = int.Parse(cboStudentID.Text);
            var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == idValue);
            if (student == null)
            {
                MessageBox.Show("Student not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String validMessage = "";
            while (validMessage == "")
            {
                validMessage = frmHome.ValidateInput(txtFirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, "Student", 0, 0);
            }

            if (!validMessage.Equals("valid"))
            {
                DialogResult valid = MessageBox.Show(validMessage,
                                "Please re-enter",
                                MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                if (valid == DialogResult.Cancel)
                {
                    goHome();
                    return;
                }
                else
                {
                    return;
                }
            }
            else
            {
                //details are only saved once they have passed validation
                student.FirstName = txtFirstName.Text.Trim();
                student.Surname = txtLastName.Text.Trim();
                student.Email = txtEmail.Text.Trim();
                student.Phone = txtPhone.Text.Trim();

                MessageBox.Show("Student " + txtFirstName.Text + " " + txtLastName.Text + "'s details have been successfully updated.",
                                        "Success",
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
                DialogResult updateAnother = MessageBox.Show("Would you like to update another Student's details?",
                                                              "Please Confirm",
                                                              MessageBoxButtons.YesNo,
                                                              MessageBoxIcon.Question);
                if (updateAnother == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    goHome();
                }
            }
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cboStudentID.Text, out int id))
            {
                MessageBox.Show("Please select a student to continue.",
                                "No Student Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            cboNames.Enabled = false;
            cboSurnames.Enabled = false;
            cboStudentID.Enabled = false;

            var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == id);

            if (student == null)
            {
                MessageBox.Show("Student not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            txtFirstName.Text = student.FirstName;
            txtLastName.Text = student.Surname;
            txtEmail.Text = student.Email;
            txtPhone.Text = student.Phone;


            grpStudentDetails.Visible = true;
        }

        private void cboStudentID_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboSurnames_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void btnRefresh_Click_1(object sender, EventArgs e) => reset();
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
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
