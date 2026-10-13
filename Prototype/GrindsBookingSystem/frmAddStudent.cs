using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmAddStudent : Form
    {
        String validMessage = "";
        public frmAddStudent()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {


            while (validMessage == "")
            {
                validMessage = frmHome.ValidateInput(txtStudentName.Text, txtStudentSurname.Text, txtStudentEmail.Text, txtStudentPhone.Text, "Student", 0, 0);
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
                    validMessage = "";
                    return;

                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Are you sure you wish to add student " + txtStudentName.Text + " " +
                                                     txtStudentSurname.Text + " to the system ?",
                                                     "Please Confirm",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    //only show the success message if the student was actually added (not a duplicate)
                    if (!addStudent())
                    {
                        return;
                    }
                    MessageBox.Show("Student " + txtStudentName.Text + " " + txtStudentSurname.Text + " has been successfully added to the system.",
                                    "Success",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    DialogResult addAnother = MessageBox.Show("Would you like to add another Student?",
                                                          "Please Confirm",
                                                          MessageBoxButtons.YesNo,
                                                          MessageBoxIcon.Question);
                    if (addAnother == DialogResult.Yes)
                    {
                        clearUI();
                    }
                    else
                    {
                        goHome();
                    }

                    return;
                }
                else
                {
                    MessageBox.Show("Adding Student Function Cancelled",
                                    "Cancelled",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);

                    clearUI();
                    return;
                }
            }
        }



        public void clearUI()
        {
            txtStudentName.Clear();
            txtStudentSurname.Clear();
            txtStudentEmail.Clear();
            txtStudentPhone.Clear();
            validMessage = "";
        }
        public void goHome()
        {
            clearUI();
            this.Close();

        }

        public bool addStudent()
        {
            //a student with the same name and email address is treated as a duplicate
            bool duplicate = StudentDataStore.Students.Any(st =>
                string.Equals(st.FirstName.Trim(), txtStudentName.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                string.Equals(st.Surname.Trim(), txtStudentSurname.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                string.Equals(st.Email.Trim(), txtStudentEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (duplicate)
            {
                MessageBox.Show("Duplicate Student detected, this student already exists in our system.",
                                "Duplicate Student",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                clearUI();
                return false;
            }

            Student s = new Student()
            {
                StudentID = StudentDataStore.GetNextId(),
                FirstName = txtStudentName.Text.Trim(),
                Surname = txtStudentSurname.Text.Trim(),
                Phone = txtStudentPhone.Text.Trim(),
                Email = txtStudentEmail.Text.Trim(),
                bookings = new List<Booking>()
            };

            StudentDataStore.Students.Add(s);
            return true;
        }

        private void exitBtnAddStudent_Click(object sender, EventArgs e)
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

        private void backBtnAddStudent_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearUI();
        }

    }
}