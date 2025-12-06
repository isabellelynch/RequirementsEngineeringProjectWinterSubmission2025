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

                DialogResult result = MessageBox.Show("Are you sure you wish to add student " + txtStudentName.Text +
                                                     txtStudentSurname.Text + "to the system ?",
                                                     "Please Confirm",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Student " + txtStudentName.Text + txtStudentSurname.Text + "has been succesfully added to the system.",
                                    "Success",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    addStudent();
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
            frmHome home = new frmHome();
            home.Show();
            this.Close();

        }

        public void addStudent()
        {
            Student s = new Student()
            {
                StudentID = StudentDataStore.GetNextId(),
                FirstName = txtStudentName.Text,
                Surname = txtStudentSurname.Text,
                Phone = txtStudentPhone.Text,
                Email = txtStudentEmail.Text,
                bookings = new List<Booking>()
            };

            if (StudentDataStore.Students.Contains(s))
            {
                MessageBox.Show("Duplicate Student detected, this student already exists in our system.",
                                "Duplicate Student",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                clearUI();
                return;
            }

            StudentDataStore.Students.Add(s);
        }

        private void exitBtnAddStudent_Click(object sender, EventArgs e)
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

        private void backBtnAddStudent_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearUI();
        }

    }
}