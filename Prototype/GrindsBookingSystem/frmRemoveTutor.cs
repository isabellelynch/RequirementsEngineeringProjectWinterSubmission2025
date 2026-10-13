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

                //the tutor's upcoming grinds, and any bookings made for them, must be cancelled
                var futureGrinds = ScheduleDataStore.ScheduleItems
                    .Where(g => g.TutorID == tutorToRemove.TutorID && g.TimeandDate > DateTime.Now)
                    .ToList();
                var futureBookings = BookingDataStore.Bookings
                    .Where(b => b.TutorID == tutorToRemove.TutorID && b.GrindTime > DateTime.Now)
                    .ToList();

                string grindWarning = futureGrinds.Count > 0 || futureBookings.Count > 0
                    ? "\n\nThis tutor has " + futureGrinds.Count + " upcoming grind(s) and " + futureBookings.Count +
                      " booking(s). These will be cancelled and all students will receive a full refund."
                    : "";

                DialogResult response = MessageBox.Show(
                    "Are you sure you want to remove " +  tutorToRemove.FirstName + " " + tutorToRemove.Surname + "?" + grindWarning,
                    "Confirm Removal",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (response == DialogResult.Yes)
                {
                    //cancel every future booking with this tutor - the practice cancelled, so a full refund is always given
                    int totalRefund = 0;
                    var studentsToNotify = new List<string>();
                    foreach (var booking in futureBookings)
                    {
                        totalRefund += frmHome.CancelBookingAndRefund(booking, true);
                        studentsToNotify.Add(frmHome.StudentName(booking.StudentID));
                    }

                    //remove the tutor's grinds from the schedule
                    foreach (var grind in futureGrinds)
                    {
                        ScheduleDataStore.ScheduleItems.Remove(grind);
                    }

                    TutorDataStore.Tutors.Remove(tutorToRemove);

                    string message = "Tutor " + tutorToRemove.FirstName + " " + tutorToRemove.Surname + " has been successfully removed from the system.";
                    if (futureGrinds.Count > 0 || futureBookings.Count > 0)
                    {
                        message += "\n\n" + futureGrinds.Count + " grind(s) removed from the schedule and " +
                                   futureBookings.Count + " booking(s) cancelled. Total refunded: €" + totalRefund + ".";
                    }
                    if (studentsToNotify.Count > 0)
                    {
                        //in the full system these students would be emailed about the cancellation
                        message += "\n\nStudents to be notified: " + string.Join(", ", studentsToNotify.Distinct());
                    }
                    MessageBox.Show(message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllTutors();
                }
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

        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllTutors();
        }


    }

