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
using static GrindsBookingSystem.frmAddTutor;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmUpdateTutor : Form
    {
        
        public frmUpdateTutor()
        {
            InitializeComponent();
        }
        private void ApplyFilters()
        {
            var filtered = TutorDataStore.Tutors.AsEnumerable();

            if (cboTutID.SelectedIndex != -1)
            {
                int id = int.Parse(cboTutID.Text);
                var tutor = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == id);

                cboNames.Text = tutor.FirstName;
                cboSurnames.Text = tutor.Surname;
            }

            if (int.TryParse(cboTutID.Text, out int parsedId))
                filtered = filtered.Where(t => t.TutorID == parsedId);

            if (!string.IsNullOrWhiteSpace(cboNames.Text))
                filtered = filtered.Where(t => t.FirstName == cboNames.Text);

            if (!string.IsNullOrWhiteSpace(cboSurnames.Text))
                filtered = filtered.Where(t => t.Surname == cboSurnames.Text);

            frmHome.UpdateComboBoxesT(
                filtered,
                cboTutID, cboNames, cboSurnames,
                cboTutID_SelectedIndexChanged,
                cboNames_SelectedIndexChanged,
                cboSurnames_SelectedIndexChanged
            );

            if (cboTutID.Items.Count == 1)
                cboTutID.SelectedIndex = 0;

            if (cboNames.Items.Count == 1)
                cboNames.SelectedIndex = 0;

            if (cboSurnames.Items.Count == 1)
                cboSurnames.SelectedIndex = 0;
        }


        private void cboTutID_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboSurnames_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();

        private void frmUpdateTutor_Load(object sender, EventArgs e)
        {
            LoadAllTutors();
            grpTutorDetails.Visible = false;
        }
        private void LoadAllTutors()
        {
            cboTutID.SelectedIndexChanged -= cboTutID_SelectedIndexChanged;
            cboNames.SelectedIndexChanged -= cboNames_SelectedIndexChanged;
            cboSurnames.SelectedIndexChanged -= cboSurnames_SelectedIndexChanged;
            frmHome.ClearCombos(this.Controls);
            foreach (var t in TutorDataStore.Tutors)
            {
                if (!cboTutID.Items.Contains(t.TutorID))
                    cboTutID.Items.Add(t.TutorID);

                if (!cboNames.Items.Contains(t.FirstName))
                    cboNames.Items.Add(t.FirstName);

                if (!cboSurnames.Items.Contains(t.Surname))
                    cboSurnames.Items.Add(t.Surname);
            }

            cboTutID.SelectedIndexChanged += cboTutID_SelectedIndexChanged;
            cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
            cboSurnames.SelectedIndexChanged += cboSurnames_SelectedIndexChanged;

        }

        private void btnRefresh_Click(object sender, EventArgs e) => reset();
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

        public void loadRateCodes()
        {
            cboRates.Items.Clear();
            cboRates.Items.Add("SNR - €50 per hour Senior Tutor");
            cboRates.Items.Add("JNR - €40 per hour Junior Tutor");
            cboRates.Items.Add("NEW - €30 per hour Trainee Tutor");
        }

        public void loadSubjects()
        {
            cboSubjects.Items.Clear();
            cboSubjects.Items.Add("Maths");
            cboSubjects.Items.Add("Irish");
            cboSubjects.Items.Add("English");
            cboSubjects.Items.Add("Science");
            cboSubjects.Items.Add("History");
            cboSubjects.Items.Add("Geography");
            cboSubjects.Items.Add("Accounting");
            cboSubjects.Items.Add("Applied Maths");
            cboSubjects.Items.Add("Business");
        }
        private void btnFindTutor_Click(object sender, EventArgs e)
        {
            

            if (!int.TryParse(cboTutID.Text, out int id))
            {
                MessageBox.Show("Please select a tutor to continue.",
                                "No Tutor Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            cboNames.Enabled = false;
            cboSurnames.Enabled = false;
            cboTutID.Enabled = false;

            var tutorView = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == id);

            if (tutorView == null)
            {
                MessageBox.Show("Tutor not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            loadRateCodes();
            loadSubjects();

            txtEmail.Text = tutorView.Email;
            txtPhone.Text = tutorView.Phone;

            //select the tutor's current rate code and subject in the drop downs
            cboRates.SelectedIndex = -1;
            for (int i = 0; i < cboRates.Items.Count; i++)
            {
                if (cboRates.Items[i].ToString().StartsWith(tutorView.RateCode))
                {
                    cboRates.SelectedIndex = i;
                }
            }
            cboSubjects.SelectedIndex = cboSubjects.Items.IndexOf(tutorView.Subject);

            grpTutorDetails.Visible = true;


        }

        private void btnUpdateTutor_Click(object sender, EventArgs e)
        {
            var idValue = int.Parse(cboTutID.Text);
            var tutorView = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == idValue);
            if (tutorView == null)
            {
                MessageBox.Show("Tutor not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            String validMessage = "";

            while (validMessage == "")
            {
                validMessage = frmHome.ValidateInput(cboNames.Text, cboSurnames.Text, txtEmail.Text, txtPhone.Text, "Tutor", cboRates.SelectedIndex, cboSubjects.SelectedIndex);
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
                //only the 3 letter rate code (e.g. SNR) is stored, so booking prices are worked out correctly
                tutorView.RateCode = cboRates.SelectedItem.ToString().Substring(0, 3);
                tutorView.Subject = cboSubjects.SelectedItem.ToString();
                tutorView.Email = txtEmail.Text.Trim();
                tutorView.Phone = txtPhone.Text.Trim();
               
            MessageBox.Show("Tutor " + cboNames.Text + " " + cboSurnames.Text + "'s details have been successfully updated.",
                                    "Success",
                                     MessageBoxButtons.OK,
                                     MessageBoxIcon.Information);
            DialogResult updateAnother = MessageBox.Show("Would you like to update another Tutor's details?",
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

        public void goHome()
        {
            this.Close();
            cboNames.Enabled = true;
            cboSurnames.Enabled = true;
            cboTutID.Enabled = true;
        }

        public void reset()
        {
            LoadAllTutors();
            cboNames.Enabled = true;
            cboSurnames.Enabled = true;
            cboTutID.Enabled = true;
            cboSubjects.Items.Clear();
            cboRates.Items.Clear();
            txtEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            grpTutorDetails.Visible = false;
        }
    }
}
