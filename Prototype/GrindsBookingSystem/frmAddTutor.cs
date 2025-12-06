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
                                                     txtTutorSurname.Text + " to the system, have they supplied proof of their Garda Vetting" +
                                                     "information?",
                                                     "Please Confirm",
                                                     MessageBoxButtons.YesNo,
                                                     MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Tutor " + txtTutorName.Text + " " + txtTutorSurname.Text + " has been succesfully added to the system.",
                                    "Success",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
                    var rate = cboTutorRates.Text.Substring(0,3);
                    var subject = cboTutorSubjects.Text;

                    addTutor(rate, subject);
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
            Owner.Show();
            this.Hide();
        }
        public void loadRateCodes()
        {
            cboTutorRates.Items.Add("SNR - €50 per hour Senior Tutor");
            cboTutorRates.Items.Add("JNR - €40 per hour Junior Tutor");
            cboTutorRates.Items.Add("NEW - €30 per hour Trainee Tutor");
        }

        public void loadSubjects()
        {
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
            cboTutorRates.Items.Clear();
            cboTutorSubjects.Items.Clear();
            validMessage = "";

        }
        
        public void addTutor(String rate, String subject)
        {
            Tutor t = new Tutor()
            {
                TutorID = TutorDataStore.GetNextId(),
                FirstName = txtTutorName.Text,
                Surname = txtTutorSurname.Text,
                Phone = txtTutorPhone.Text,
                Email = txtTutorEmail.Text,
                RateCode = rate,
                Subject = subject
            };

            if (TutorDataStore.Tutors.Contains(t))
            {
                MessageBox.Show("Duplicate Tutor detected, this student already exists in our system.",
                                "Duplicate Tutor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                clearUI();
                return;
            }

            TutorDataStore.Tutors.Add(t);
        }

        private void frmAddTutor_Load(object sender, EventArgs e)
        {
            loadRateCodes();
            loadSubjects();
        }
   

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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearUI();
        }
    }
}