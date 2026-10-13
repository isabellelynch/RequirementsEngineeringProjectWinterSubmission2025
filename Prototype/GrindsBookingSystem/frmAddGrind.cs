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
using static GrindsBookingSystem.frmSchedule;

namespace GrindsBookingSystem
{
    public partial class frmAddGrind : Form
    {
        public frmAddGrind()
        {
            InitializeComponent();
        }

        private void frmAddGrind_Load(object sender, EventArgs e)
        {
            LoadTutors();
            LoadRooms();
            SetDateTimeFormat();
        }

        public void LoadTutors()
        {
            cboTutors.SelectedIndex = -1;
            cboTutors.Text = "";

            cboTutors.Items.Clear();

            foreach (var t in TutorDataStore.Tutors)
            {
                cboTutors.Items.Add(t.TutorID + " - " + t.FirstName + " " + t.Surname);
            }

        }

        public void LoadRooms()
        {
            cboRooms.Items.Clear();
            cboRooms.Items.Add("R302");
            cboRooms.Items.Add("S302");
            cboRooms.Items.Add("T302");
            cboRooms.Items.Add("R300");
            cboRooms.Items.Add("S304");
            cboRooms.Items.Add("S306");
            cboRooms.Items.Add("R200");
            cboRooms.Items.Add("S300");

        }

        public void SetDateTimeFormat()
        {
            pickDate.Format = DateTimePickerFormat.Short;
            pickDate.MinDate = DateTime.Today;
            pickDate.MaxDate = DateTime.Today.AddDays(28);
            //start on a weekday so the default date is always valid
            pickDate.Value = frmHome.NextWeekday(0, 0).Date;
            pickTime.Format = DateTimePickerFormat.Time;
            pickTime.ShowUpDown = true;
            pickTime.Value = pickTime.Value.Date.AddHours(9);

            pickTime.ValueChanged += (s, e) =>
            {
                DateTime val = pickTime.Value;

                int hour = val.Hour;

                if (hour < 9) hour = 9;
                if (hour > 17) hour = 17;

                pickTime.Value = new DateTime(
                    val.Year,
                    val.Month,
                    val.Day,
                    hour,
                    0,
                    0
                );
            };

            pickDate.ValueChanged += (s, e) =>
            {
                DateTime val = pickDate.Value;

                if (val.DayOfWeek == DayOfWeek.Saturday || val.DayOfWeek == DayOfWeek.Sunday)
                {
                    //move to the Monday, unless that is past the last date allowed, in which case use the Friday before
                    DateTime monday = val.AddDays(val.DayOfWeek == DayOfWeek.Saturday ? 2 : 1);
                    DateTime friday = val.AddDays(val.DayOfWeek == DayOfWeek.Saturday ? -1 : -2);
                    DateTime newDate = monday <= pickDate.MaxDate ? monday : friday;
                    String dayName = val.DayOfWeek == DayOfWeek.Saturday ? "Saturdays" : "Sundays";

                    MessageBox.Show("Grinds can only be added Monday through Friday, " + dayName + " cannot be chosen. Date will now be changed to " + newDate.DayOfWeek,
                        "Error - No weekend Grinds!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pickDate.Value = newDate;
                }
            };


        }

        private void btnAddGrind_Click(object sender, EventArgs e)
        {
            String validMessage = validateGrind(out Schedule newGrind);

            if (validMessage == "valid")
            {
                ScheduleDataStore.ScheduleItems.Add(newGrind);

                DialogResult result = MessageBox.Show("New Grind has Successfully been added to the system. Would you like to add another one ?",
                    "Success", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    reset();
                }
                else
                {
                    goHome();
                }
            }
            else
            {
                MessageBox.Show(validMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //checks every input and returns "valid" (with the new grind) or an error message
        //the grind is only added to the schedule if everything is valid
        private String validateGrind(out Schedule newGrind)
        {
            newGrind = null;

            if (txtAttendance.Text.Trim() == "")
            {
                return "Attendance limit must be entered.";
            }
            if (int.TryParse(txtAttendance.Text.Trim(), out int attendance) == false)
            {
                return "Attendance limit must be made up of only numbers.";
            }
            if (attendance > 20 || attendance <= 0)
            {
                return "Attendance limit must be between 1 and 20 inclusive.";
            }
            if (cboRooms.SelectedIndex == -1)
            {
                return "Room Number must be selected.";
            }
            if (cboTutors.SelectedIndex == -1)
            {
                return "Tutor must be selected.";
            }

            DateTime grindTime = pickDate.Value.Date.AddHours(pickTime.Value.Hour);

            if (grindTime.DayOfWeek == DayOfWeek.Saturday || grindTime.DayOfWeek == DayOfWeek.Sunday)
            {
                return "Grinds can only be added Monday through Friday.";
            }
            if (grindTime.Hour < 9 || grindTime.Hour > 17)
            {
                return "Grinds must start between 9am and 5pm.";
            }
            if (grindTime <= DateTime.Now)
            {
                return "A grind cannot be added at a time that has already passed.";
            }

            //the tutor is shown as "ID - First Surname", so the ID is the part before the dash
            String tutorText = cboTutors.SelectedItem.ToString();
            int id = int.Parse(tutorText.Split('-')[0].Trim());

            String roomNo = cboRooms.SelectedItem.ToString();

            foreach (var item in ScheduleDataStore.ScheduleItems)
            {
                if (item.TimeandDate == grindTime && item.TutorID == id)
                {
                    return "Grind Already Booked with this Tutor at this time, please change tutor to continue.";
                }
                if (item.TimeandDate == grindTime && item.RoomNo == roomNo)
                {
                    return "Grind Already Booked in this Room at this time, please change room to continue.";
                }
            }

            newGrind = new Schedule
            {
                TimeandDate = grindTime,
                MaxAttendnace = attendance,
                currentEnrollment = 0,
                RoomNo = roomNo,
                TutorID = id
            };
            return "valid";
        }

        public void goHome()
        {
            this.Close();
        }

        public void reset()
        {
            pickDate.Value = frmHome.NextWeekday(0, 0).Date;
            pickTime.Value = pickTime.Value.Date.AddHours(9);
            txtAttendance.Text = "";
            cboRooms.SelectedIndex = -1;
            cboTutors.SelectedIndex = -1;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            reset();
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
    }
}
