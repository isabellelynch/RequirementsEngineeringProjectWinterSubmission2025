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
using static GrindsBookingSystem.frmAddTutor;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmViewTutorDetails : Form
    {
        public frmViewTutorDetails()
        {
            InitializeComponent();
        }

        private void LoadAllTutor()
        {
            frmHome.ClearCombos(this.Controls);

            foreach (var t in TutorDataStore.Tutors)
            {
                if (!cboTutorID.Items.Contains(t.TutorID))
                    cboTutorID.Items.Add(t.TutorID);

                if (!cboName.Items.Contains(t.FirstName))
                    cboName.Items.Add(t.FirstName);

                if (!cboLastName.Items.Contains(t.Surname))
                    cboLastName.Items.Add(t.Surname);
            }

        }

        private void ApplyFilters()
        {
            var filtered = TutorDataStore.Tutors.AsEnumerable();

            if (cboTutorID.SelectedIndex != -1)
            {
                int id = int.Parse(cboTutorID.Text);
                var tutor = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == id);

                cboName.Text = tutor.FirstName;
                cboLastName.Text = tutor.Surname;
            }

            if (int.TryParse(cboTutorID.Text, out int parsedId))
                filtered = filtered.Where(t => t.TutorID == parsedId);

            if (!string.IsNullOrWhiteSpace(cboName.Text))
                filtered = filtered.Where(t => t.FirstName == cboName.Text);

            if (!string.IsNullOrWhiteSpace(cboLastName.Text))
                filtered = filtered.Where(t => t.Surname == cboLastName.Text);

            frmHome.UpdateComboBoxesT(
                filtered,
                cboTutorID, cboName, cboLastName,
                cboTutorID_SelectedIndexChanged,
                cboName_SelectedIndexChanged,
                cboLastName_SelectedIndexChanged
            );

            if (cboTutorID.Items.Count == 1)
                cboTutorID.SelectedIndex = 0;

            if (cboName.Items.Count == 1)
                cboName.SelectedIndex = 0;

            if (cboLastName.Items.Count == 1)
                cboLastName.SelectedIndex = 0;
        }

        private void frmViewTutorDetails_Load(object sender, EventArgs e) => LoadAllTutor();
        private void cboTutorID_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboName_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboLastName_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllTutor();
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

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(cboTutorID.Text, out int id))
            {
                MessageBox.Show("Please select a tutor to continue.",
                                "No Tutor Selected",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            var tutorView = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == id);

            if (tutorView == null)
            {
                MessageBox.Show("Tutor not found.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show(
                "The details of the chosen tutor are:\n\n" +
                $"Tutor ID : {tutorView.TutorID}\n" +
                $"First Name : {tutorView.FirstName}\n" +
                $"Surname : {tutorView.Surname}\n" +
                $"Subject : {tutorView.Subject}\n" + 
                $"Phone Number : {tutorView.Phone}\n" +
                $"Email Address : {tutorView.Email}",
                "Tutor Details",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            LoadAllTutor();
        }
    }
    
}
