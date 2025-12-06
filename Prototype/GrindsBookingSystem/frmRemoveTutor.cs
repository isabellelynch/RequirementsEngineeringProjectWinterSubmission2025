using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static GrindsBookingSystem.frmAddTutor;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
        public partial class frmRemoveTutor : Form
        {
            public frmRemoveTutor()
            {
                InitializeComponent();
            }

            private void frmRemoveTutor_Load(object sender, EventArgs e)
            {
                if (lvRemoveTutors.Columns.Count == 0)
                {
                    lvRemoveTutors.Columns.Add("ID", 50);
                    lvRemoveTutors.Columns.Add("First Name", 120);
                    lvRemoveTutors.Columns.Add("Surname", 120);
                }

                lvRemoveTutors.View = View.Details;
                lvRemoveTutors.FullRowSelect = true;
                LoadAllTutors();
            }

       

        private void UpdateListView(IEnumerable<Tutor> tutors)
            {
                lvRemoveTutors.Items.Clear();

                foreach (var t in tutors)
                {
                    var item = new ListViewItem(t.TutorID.ToString());
                    item.SubItems.Add(t.FirstName);
                    item.SubItems.Add(t.Surname);
                    lvRemoveTutors.Items.Add(item);

                }
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
            
            UpdateListView(filtered);
        }



        private void cboTutID_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboNames_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();
        private void cboSurnames_SelectedIndexChanged(object sender, EventArgs e) => ApplyFilters();


            private void btnResetFilters_Click(object sender, EventArgs e)
            {
                cboTutID.SelectedIndexChanged -= cboTutID_SelectedIndexChanged;
                cboNames.SelectedIndexChanged -= cboNames_SelectedIndexChanged;
                cboSurnames.SelectedIndexChanged -= cboSurnames_SelectedIndexChanged;
                frmHome.ClearCombos(this.Controls);
                LoadAllTutors();

                cboTutID.SelectedIndexChanged += cboTutID_SelectedIndexChanged;
                cboNames.SelectedIndexChanged += cboNames_SelectedIndexChanged;
                cboSurnames.SelectedIndexChanged += cboSurnames_SelectedIndexChanged;
            }

            private void LoadAllTutors()
            {
                cboTutID.SelectedIndexChanged -= cboTutID_SelectedIndexChanged;
                cboNames.SelectedIndexChanged -= cboNames_SelectedIndexChanged;
                cboSurnames.SelectedIndexChanged -= cboSurnames_SelectedIndexChanged;
                frmHome.ClearCombos(this.Controls);
                UpdateListView(TutorDataStore.Tutors);

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

            private void btnRemoveTutor_Click(object sender, EventArgs e)
            {
                if (lvRemoveTutors.SelectedItems.Count == 0)
                {
                    MessageBox.Show("No Tutor Selected, Please select a tutor to be removed before continuing.",
                                    "No Tutor Selected",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                ListViewItem selectedItem = lvRemoveTutors.SelectedItems[0];

                int id = int.Parse(selectedItem.Text);

                var tutorToRemove = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == id);

                if (tutorToRemove == null)
                {
                    MessageBox.Show("No Tutor Found",
                                    "No Tutor Found",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                return;
                }

                DialogResult response = MessageBox.Show(
                    "Are you sure you want to remove " +  tutorToRemove.FirstName + " " + tutorToRemove.Surname + "?",
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (response == DialogResult.Yes)
                {
                    MessageBox.Show(
                        "Tutor " + tutorToRemove.FirstName + " " + tutorToRemove.Surname + " has been successfully removed from the system.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    TutorDataStore.Tutors.Remove(tutorToRemove);
                    foreach(var s in ScheduleDataStore.ScheduleItems)
                    {
                        if(s.TutorID == tutorToRemove.TutorID)
                        {
                            //ScheduleDataStore.ScheduleItems.Remove(s);
                            //foreach( var s2 in s.students)
                           // {
                                //send email to each s2 (student that had been enrolled
                                //in the class with the tutor that has been removed
                            //}
                            //foreach(var b in BookingDataStore.Bookings)
                            //{
                                //if(b.GrindTime == s.TimeandDate && b.TutorID == s.TutorID)
                                //{
                                    //refund amount paid to students who have paid
                                //}
                            //}
                        }
                    }
                    LoadAllTutors(); 
                }
            }

            private void btnBack_Click(object sender, EventArgs e)
            {
                this.Hide();
                Owner.Show();
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

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllTutors();
        }


    }

