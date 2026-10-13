using System;
using System.Collections;
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
using static GrindsBookingSystem.frmAddTutor;

namespace GrindsBookingSystem
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();

            //sample data is only loaded the first time the home page is created
            if (!sampleDataLoaded)
            {
                PopulateTutorsAndStudents();
                populateSchedule();
                PopulateBookings();
                sampleDataLoaded = true;
            }
        }

        private static bool sampleDataLoaded = false;
        private static bool isExiting = false;

        //opens a child form, hides the parent, and shows the parent again when the child is closed
        //(by its Back button, by finishing its task, or by the window's X button)
        public static void OpenChild(Form parent, Form child)
        {
            child.Owner = parent;
            child.FormClosed += (s, e) =>
            {
                if (!isExiting && !parent.IsDisposed)
                {
                    parent.Show();
                    parent.Activate();
                }
            };
            child.Show();
            parent.Hide();
        }

        //closes the whole application
        public static void ExitApplication()
        {
            isExiting = true;
            Application.Exit();
        }

        //returns a date the given number of days from today, moved forward to a weekday, at the given hour
        //(sample data uses this so the demo grinds are always in the future, whatever day the app is run)
        public static DateTime NextWeekday(int daysFromToday, int hour)
        {
            DateTime date = DateTime.Today.AddDays(daysFromToday);
            while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                date = date.AddDays(1);
            }
            return date.AddHours(hour);
        }

        //returns a date the given number of days before today, moved back to a weekday, at the given hour
        public static DateTime PreviousWeekday(int daysBeforeToday, int hour)
        {
            DateTime date = DateTime.Today.AddDays(-daysBeforeToday);
            while (date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday)
            {
                date = date.AddDays(-1);
            }
            return date.AddHours(hour);
        }

        //price per grind for each tutor rate code
        public static int GetRateAmount(string rateCode)
        {
            if (rateCode == null) return 0;
            if (rateCode.StartsWith("SNR")) return 50;
            if (rateCode.StartsWith("JNR")) return 40;
            if (rateCode.StartsWith("NEW")) return 30;
            return 0;
        }

        //finds the grind on the schedule that a booking belongs to
        public static Schedule FindGrindForBooking(Booking booking)
        {
            return ScheduleDataStore.ScheduleItems.FirstOrDefault(g => g.TimeandDate == booking.GrindTime && g.TutorID == booking.TutorID);
        }

        //cancels a booking everywhere it is stored (bookings list, the student's bookings and the grind's enrolment)
        //a refund is recorded if fullRefund is true, or if the grind is more than 7 days away
        //returns the amount refunded (0 if no refund was due)
        public static int CancelBookingAndRefund(Booking booking, bool fullRefund)
        {
            BookingDataStore.Bookings.Remove(booking);

            var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == booking.StudentID);
            if (student != null)
            {
                student.bookings.Remove(booking);
            }

            var grind = FindGrindForBooking(booking);
            if (grind != null)
            {
                if (student != null)
                {
                    grind.students.Remove(student);
                }
                if (grind.currentEnrollment > 0)
                {
                    grind.currentEnrollment--;
                }
            }

            if (fullRefund || booking.GrindTime > DateTime.Now.AddDays(7))
            {
                RefundDataStore.Refunds.Add(new Refund()
                {
                    refundRef = RefundDataStore.GetNextRefundRef(),
                    StudentID = booking.StudentID,
                    Amount = booking.Amount
                });
                return booking.Amount;
            }
            return 0;
        }

        //returns the name of a student for messages
        public static string StudentName(int studentID)
        {
            var s = StudentDataStore.Students.FirstOrDefault(st => st.StudentID == studentID);
            return s == null ? "Student " + studentID : s.FirstName + " " + s.Surname;
        }
     

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmAddTutor());
        }

        private void removeTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmRemoveTutor());
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmAddStudent());
        }

        private void removeStuentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmRemoveStudent());
        }

        private void updateTutorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmUpdateTutor());
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmUpdateStudent());
        }

        private void viewStudentDetaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmViewStudentDetails());
        }

        private void viewTutorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmViewTutorDetails());
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmSchedule());
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit ?",
                                                   "Please Confirm",
                                                   MessageBoxButtons.YesNo,
                                                   MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ExitApplication();
            }
        }

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmAddBooking());
        }

        public class Schedule
        {
            public DateTime TimeandDate { get; set; }
            public int MaxAttendnace { get; set; }
            public int currentEnrollment { get; set; }
            public String RoomNo { get; set; }

            public int TutorID { get; set; }
            public List<Student> students { get; set; } = new List<Student>();

        }

        public class Booking
        {
            public int bookingRef { get; set; }
            public int StudentID { get; set; }
            public DateTime DateOfBooking { get; set; }
            public DateTime GrindTime { get; set; }
            public int TutorID { get; set; }
            public int Amount { get; set; }
        }

        public void PopulateBookings()
        {
            if (BookingDataStore.Bookings.Count > 0) return;

            //past bookings (used by the revenue and tutor earnings reports)
            AddSampleBooking(1, 1, PreviousWeekday(60, 9), PreviousWeekday(65, 9));
            AddSampleBooking(2, 2, PreviousWeekday(30, 15), PreviousWeekday(35, 9));

            //upcoming bookings, linked to grinds on the schedule
            //student 3's grind is less than 7 days away, so cancelling it will not give a refund
            //student 1's grind is more than 7 days away, so cancelling it will give a refund
            var soonGrind = ScheduleDataStore.ScheduleItems.FirstOrDefault(g => g.RoomNo == "S306");
            var laterGrind = ScheduleDataStore.ScheduleItems.FirstOrDefault(g => g.RoomNo == "R200");
            AddSampleBooking(3, soonGrind.TutorID, soonGrind.TimeandDate, DateTime.Today.AddDays(-2), soonGrind);
            AddSampleBooking(1, laterGrind.TutorID, laterGrind.TimeandDate, DateTime.Today.AddDays(-1), laterGrind);
        }

        private void AddSampleBooking(int studentID, int tutorID, DateTime grindTime, DateTime dateOfBooking, Schedule grind = null)
        {
            var tutor = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == tutorID);
            var student = StudentDataStore.Students.FirstOrDefault(s => s.StudentID == studentID);
            if (tutor == null || student == null) return;

            Booking b = new Booking()
            {
                bookingRef = BookingDataStore.GetNextBookigRef(),
                StudentID = studentID,
                DateOfBooking = dateOfBooking,
                GrindTime = grindTime,
                TutorID = tutorID,
                Amount = GetRateAmount(tutor.RateCode),
            };
            BookingDataStore.Bookings.Add(b);
            student.bookings.Add(b);

            if (grind != null && !grind.students.Contains(student))
            {
                grind.students.Add(student);
            }
        }

        public static class BookingDataStore
        {
            public static List<Booking> Bookings = new List<Booking>();

            private static int nextBookingRef = 1;
            public static int GetNextBookigRef()
            {
                return nextBookingRef++;
            }
        }
        public class Refund
        {
            public int refundRef { get; set; }
            public int StudentID { get; set; }
            public int Amount { get; set; }
        }

        public static class RefundDataStore
        {
            public static List<Refund> Refunds = new List<Refund>();
            private static int nextRefundRef = 1;
            public static int GetNextRefundRef()
            {
                return nextRefundRef++;
            }
        }
        public class Student
        {
            public int StudentID { get; set; }
            public string FirstName { get; set; }
            public string Surname { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public List<Booking> bookings { get; set; } = new List<Booking>();

        }

        public static class StudentDataStore
        {
            public static List<Student> Students = new List<Student>();

            private static int nextId = 1;
            public static int GetNextId()
            {
                return nextId++;
            }
        }

        
        public class Tutor
        {
            public int TutorID { get; set; }
            public string FirstName { get; set; }
            public string Surname { get; set; }
            public string RateCode { get; set; }
            public string Subject { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
        }

        public static class TutorDataStore
        {
            public static List<Tutor> Tutors = new List<Tutor>();

            private static int nextTutorId = 1;
            public static int GetNextId()
            {
                return nextTutorId++;
            }
        }
        public void PopulateTutorsAndStudents()
        {
            if (TutorDataStore.Tutors.Count > 0) return;

            Tutor t1 = new Tutor()
            {
                TutorID = TutorDataStore.GetNextId(),
                FirstName = "Isabelle",
                Surname = "Lynch",
                Phone = "089-9998765",
                Email = "isabelle@gmail.com",
                RateCode = "SNR",
                Subject = "Maths"
            };

            if (!TutorDataStore.Tutors.Contains(t1))
            {
                TutorDataStore.Tutors.Add(t1);
            }
            Tutor t2 = new Tutor()
            {
                TutorID = TutorDataStore.GetNextId(),
                FirstName = "Gavin",
                Surname = "Lynch",
                Phone = "089-6748765",
                Email = "gav@gmail.com",
                RateCode = "JNR",
                Subject = "Science"
            };
            if (!TutorDataStore.Tutors.Contains(t2))
            {
                TutorDataStore.Tutors.Add(t2);
            }

            Tutor t3 = new Tutor()
            {
                TutorID = TutorDataStore.GetNextId(),
                FirstName = "Brian",
                Surname = "Hill",
                Phone = "089-9922765",
                Email = "brian@hotmail.com",
                RateCode = "NEW",
                Subject = "English"
            };
            if (!TutorDataStore.Tutors.Contains(t3))
            {
                TutorDataStore.Tutors.Add(t3);
            }


            Student s1 = new Student()
            {
                StudentID = StudentDataStore.GetNextId(),
                FirstName = "Isabelle",
                Surname = "Lynch",
                Phone = "089-9998765",
                Email = "isabelle@gmail.com",
            };

            if (!StudentDataStore.Students.Contains(s1))
            {
                StudentDataStore.Students.Add(s1);
            }
            Student s2 = new Student()
            {
                StudentID = StudentDataStore.GetNextId(),
                FirstName = "Gavin",
                Surname = "Lynch",
                Phone = "089-6748765",
                Email = "gav@gmail.com",
            };
            if (!StudentDataStore.Students.Contains(s2))
            {
                StudentDataStore.Students.Add(s2);
            }

            Student s3 = new Student()
            {
                StudentID = StudentDataStore.GetNextId(),
                FirstName = "Brian",
                Surname = "Hill",
                Phone = "089-9922765",
                Email = "brian@hotmail.com",
            };
            if (!StudentDataStore.Students.Contains(s3))
            {
                StudentDataStore.Students.Add(s3);
            }

        }
        public static class ScheduleDataStore
        {
            public static List<Schedule> ScheduleItems = new List<Schedule>();
        }
        public static class BookingsDataStore
        {
            public static List<Booking> Bookings = new List<Booking>();
        }


        public void populateSchedule()
        {
            if (ScheduleDataStore.ScheduleItems.Count > 0) return;

            Schedule s1 = new Schedule()
            {
                TimeandDate = NextWeekday(10, 9),
                MaxAttendnace = 15,
                currentEnrollment = 10,
                RoomNo = "R200",
                TutorID = 1
            };

            if (!ScheduleDataStore.ScheduleItems.Contains(s1))
            {
                ScheduleDataStore.ScheduleItems.Add(s1);
            }



            Schedule s2 = new Schedule()
            {
                TimeandDate = NextWeekday(12, 10),
                MaxAttendnace = 10,
                currentEnrollment = 8,
                RoomNo = "S302",
                TutorID = 1
            };

            if (!ScheduleDataStore.ScheduleItems.Contains(s2))
            {
                ScheduleDataStore.ScheduleItems.Add(s2);
            }


            Schedule s3 = new Schedule()
            {
                TimeandDate = NextWeekday(3, 14),
                MaxAttendnace = 10,
                currentEnrollment = 8,
                RoomNo = "S306",
                TutorID = 3
            };

            if (!ScheduleDataStore.ScheduleItems.Contains(s3))
            {
                ScheduleDataStore.ScheduleItems.Add(s3);
            }


            Schedule s4 = new Schedule()
            {
                TimeandDate = NextWeekday(14, 15),
                MaxAttendnace = 12,
                currentEnrollment = 3,
                RoomNo = "R302",
                TutorID = 2
            };

            if (!ScheduleDataStore.ScheduleItems.Contains(s4))
            {
                ScheduleDataStore.ScheduleItems.Add(s4);
            }
        }

        private void cancelBokingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmCancelBooking());
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmShowBookings());
        }
        public static void ClearCombos(Control.ControlCollection Controls)
        {
            foreach (Control control in Controls)
            {
                if (control is ComboBox comboBox)
                {
                    comboBox.Items.Clear();
                    comboBox.Text = "";
                }
            }
        }
        public static String ValidateInput(String Firstname, String Lastname, String Email, String Phone, String StudentTutor, int tutorRateIndex, int tutorSubjectIndex)
        {
            if (string.IsNullOrWhiteSpace(Firstname))
            {
                return StudentTutor + " First Name field must not be empty.";
            }
            else if (!Regex.IsMatch(Firstname, @"^[a-zA-Z\s]+$"))
            {
                return StudentTutor + " First Name field must only contain letters.";
            }


            else if (string.IsNullOrWhiteSpace(Lastname))
            {
                return StudentTutor + " Surname field must not be empty.";
            }
            else if (!Regex.IsMatch(Lastname, @"^[a-zA-Z\s]+$"))
            {
                return StudentTutor + " Surname field must only contain letters.";
            }

            else if (string.IsNullOrWhiteSpace(Email))
            {
                return StudentTutor + " Email field must not be empty.";
            }
            else if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return StudentTutor + " Email field must be in the correct format, example : isabelle@gmail.com";
            }
            else if (string.IsNullOrWhiteSpace(Phone))
            {
                return StudentTutor + " Phone Number field must not be empty.";
            }
            else if (!Regex.IsMatch(Phone, @"^\d{3}-\d{7}$"))
            {
                return StudentTutor + " Phone Number field must be in the format XXX-XXXXXXX.";
            }
            else if (StudentTutor.Equals("Tutor") && tutorRateIndex == -1)
            {
                return "Tutor Rate Code must be selected.";
            }
            else if (StudentTutor.Equals("Tutor") && tutorSubjectIndex == -1)
            {
                return "Tutor Subject must be selected.";
            }
            

            else
            {
                return "valid";
            }
        }

        public static void UpdateComboS<T>(ComboBox combo, IEnumerable<T> values)
        {
            string current = combo.Text;
            combo.Items.Clear();
            foreach (var v in values)
                combo.Items.Add(v);
            if (string.IsNullOrWhiteSpace(current))
            {
                combo.SelectedIndex = -1;
                return;
            }
            try
            {
                T converted = (T)Convert.ChangeType(current, typeof(T));
                if (values.Contains(converted))
                    combo.Text = current;
                else
                    combo.SelectedIndex = -1;
            }
            catch
            {
                combo.SelectedIndex = -1;
            }
        }

        public static void UpdateComboBoxesS(
            IEnumerable<Student> filtered,
            ComboBox cboStudentID,
            ComboBox cboNames,
            ComboBox cboSurnames,
            EventHandler idChanged,
            EventHandler nameChanged,
            EventHandler surnameChanged)
        {
            cboStudentID.SelectedIndexChanged -= idChanged;
            cboNames.SelectedIndexChanged -= nameChanged;
            cboSurnames.SelectedIndexChanged -= surnameChanged;

            UpdateComboS(cboStudentID, filtered.Select(s => s.StudentID).Distinct());
            UpdateComboS(cboNames, filtered.Select(s => s.FirstName).Distinct());
            UpdateComboS(cboSurnames, filtered.Select(s => s.Surname).Distinct());

            cboStudentID.SelectedIndexChanged += idChanged;
            cboNames.SelectedIndexChanged += nameChanged;
            cboSurnames.SelectedIndexChanged += surnameChanged;
        }

        public static void UpdateComboBoxesT(
            IEnumerable<Tutor> filtered,
            ComboBox cboTutorID,
            ComboBox cboNames,
            ComboBox cboSurnames,
            EventHandler idChanged,
            EventHandler nameChanged,
            EventHandler surnameChanged)
        {
            cboTutorID.SelectedIndexChanged -= idChanged;
            cboNames.SelectedIndexChanged -= nameChanged;
            cboSurnames.SelectedIndexChanged -= surnameChanged;

            UpdateComboS(cboTutorID, filtered.Select(T => T.TutorID).Distinct());
            UpdateComboS(cboNames, filtered.Select(T => T.FirstName).Distinct());
            UpdateComboS(cboSurnames, filtered.Select(T => T.Surname).Distinct());

            cboTutorID.SelectedIndexChanged += idChanged;
            cboNames.SelectedIndexChanged += nameChanged;
            cboSurnames.SelectedIndexChanged += surnameChanged;
        }

        public class DateTimeListViewComparer : IComparer
        {
            private readonly int dateColumnIndex;
            private readonly int timeColumnIndex;
            private readonly bool ascending;

            public DateTimeListViewComparer(int dateColumnIndex, int timeColumnIndex, bool ascending = true)
            {
                this.dateColumnIndex = dateColumnIndex;
                this.timeColumnIndex = timeColumnIndex;
                this.ascending = ascending;
            }

            public int Compare(object x, object y)
            {
                DateTime dt1 = GetDateTime(x as ListViewItem);
                DateTime dt2 = GetDateTime(y as ListViewItem);

                return ascending ? dt1.CompareTo(dt2) : dt2.CompareTo(dt1);
            }

            //uses the grind time stored in the item's Tag, rather than parsing the displayed text,
            //because the displayed date/time format depends on the computer's regional settings
            private DateTime GetDateTime(ListViewItem item)
            {
                if (item == null) return DateTime.MinValue;
                if (item.Tag is Schedule schedule) return schedule.TimeandDate;
                if (item.Tag is Booking booking) return booking.GrindTime;

                DateTime date;
                TimeSpan time;
                DateTime.TryParse(item.SubItems[dateColumnIndex].Text, out date);
                TimeSpan.TryParse(item.SubItems[timeColumnIndex].Text, out time);
                return date.Date.Add(time);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tutorEarningsAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmTutorReport());
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChild(this, new frmAdmin());
        }
    }
}
