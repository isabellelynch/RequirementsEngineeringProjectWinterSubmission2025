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
    public partial class frmAddTutor : Form
    {
        String validMessage = "";
        public frmAddTutor()
        {
            InitializeComponent();
        }
        private void btnAddTutor_Click(object sender, EventArgs e)
        {

            while (validMessage == "")
            {
                validMessage = frmHome.ValidateInput(txtTutorName.Text, txtTutorSurname.Text, txtTutorEmail.Text, txtTutorPhone.Text, "Tutor", cboTutorRates.SelectedIndex, cboTutorSubjects.SelectedIndex);
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

                DialogResult result = MessageBox.Show("Before we add " + txtTutorName.Text + " " +
                                                     txtTutorSurname.Text + " to the system, have they supplied proof of their Garda Vetting " +
                                                     "information?",
                                                     "Please Confirm",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var rate = cboTutorRates.SelectedItem.ToString().Substring(0,3);
                    var subject = cboTutorSubjects.SelectedItem.ToString();

                    //only show the success message if the tutor was actually added (not a duplicate)
                    if (!addTutor(rate, subject))
                    {
                        return;
                    }
                    MessageBox.Show("Tutor " + txtTutorName.Text + " " + txtTutorSurname.Text + " has been successfully added to the system.",
                                    "Success",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    DialogResult addAnother = MessageBox.Show("Would you like to add another Tutor?",
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
                    MessageBox.Show("Adding Tutor Function Cancelled, Tutor must be Garda Vetted before being added to the system",
                                    "Cancelled",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Warning);

                    clearUI();
                    return;
                }
            }
        }
        public void goHome()
        {
            clearUI();
            this.Close();
        }
        public void loadRateCodes()
        {
            cboTutorRates.Items.Clear();
            cboTutorRates.Items.Add("SNR - €50 per hour Senior Tutor");
            cboTutorRates.Items.Add("JNR - €40 per hour Junior Tutor");
            cboTutorRates.Items.Add("NEW - €30 per hour Trainee Tutor");
        }

        public void loadSubjects()
        {
            cboTutorSubjects.Items.Clear();
            cboTutorSubjects.Items.Add("Maths");
            cboTutorSubjects.Items.Add("Irish");
            cboTutorSubjects.Items.Add("English");
            cboTutorSubjects.Items.Add("Science");
            cboTutorSubjects.Items.Add("History");
            cboTutorSubjects.Items.Add("Geography");
            cboTutorSubjects.Items.Add("Accounting");
            cboTutorSubjects.Items.Add("Applied Maths");
            cboTutorSubjects.Items.Add("Business");
        }


        public void clearUI()
        {
            txtTutorName.Clear();
            txtTutorSurname.Clear();
            txtTutorEmail.Clear();
            txtTutorPhone.Clear();
            //deselect the drop downs rather than emptying them, so they can still be used afterwards
            cboTutorRates.SelectedIndex = -1;
            cboTutorRates.Text = "";
            cboTutorSubjects.SelectedIndex = -1;
            cboTutorSubjects.Text = "";
            validMessage = "";

        }
        
        public bool addTutor(String rate, String subject)
        {
            //a tutor with the same name and email address is treated as a duplicate
            bool duplicate = TutorDataStore.Tutors.Any(tu =>
                string.Equals(tu.FirstName.Trim(), txtTutorName.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                string.Equals(tu.Surname.Trim(), txtTutorSurname.Text.Trim(), StringComparison.OrdinalIgnoreCase) &&
                string.Equals(tu.Email.Trim(), txtTutorEmail.Text.Trim(), StringComparison.OrdinalIgnoreCase));

            if (duplicate)
            {
                MessageBox.Show("Duplicate Tutor detected, this tutor already exists in our system.",
                                "Duplicate Tutor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                clearUI();
                return false;
            }

            Tutor t = new Tutor()
            {
                TutorID = TutorDataStore.GetNextId(),
                FirstName = txtTutorName.Text.Trim(),
                Surname = txtTutorSurname.Text.Trim(),
                Phone = txtTutorPhone.Text.Trim(),
                Email = txtTutorEmail.Text.Trim(),
                RateCode = rate,
                Subject = subject
            };

            TutorDataStore.Tutors.Add(t);
            return true;
        }

        private void frmAddTutor_Load(object sender, EventArgs e)
        {
            loadRateCodes();
            loadSubjects();
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearUI();
        }
    }
}