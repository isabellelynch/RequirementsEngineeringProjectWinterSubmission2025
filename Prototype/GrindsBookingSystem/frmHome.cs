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
            populateSchedule();
            PopulateTutorsAndStudents();
            PopulateBookings();
        }
     

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmAddTutor();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void removeTutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmRemoveTutor();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmAddStudent();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void removeStuentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmRemoveStudent();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void updateTutorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmUpdateTutor();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void updateStudentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmUpdateStudent();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void viewStudentDetaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmViewStudentDetails();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void viewTutorDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmViewTutorDetails();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void scheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmSchedule();
            form.Owner = this;
            form.Show(); 
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void makeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new frmAddBooking();
            form.Owner = this;
            form.Show();
            this.Hide();
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

            Booking b1 = new Booking()
            {
                bookingRef = BookingDataStore.GetNextBookigRef(),
                StudentID = 1,
                DateOfBooking = new DateTime(2025, 11, 28, 9, 0 ,0),
                GrindTime = new DateTime(2025, 1, 12, 9, 0, 0),
                TutorID = 1,
                Amount = 50,
            };
            if(!BookingDataStore.Bookings.Contains(b1))
            {
                BookingDataStore.Bookings.Add(b1);
            }
            Student s = StudentDataStore.Students.FirstOrDefault(s1 => s1.StudentID == b1.StudentID);
            s.bookings.Add(b1);


            Booking b2 = new Booking()
            {
                bookingRef = BookingDataStore.GetNextBookigRef(),
                StudentID = 2,
                DateOfBooking = new DateTime(2025, 11, 11, 9, 0, 0),
                GrindTime = new DateTime(2025, 7, 12, 15, 0, 0),
                TutorID = 2,
                Amount = 40,
            };
            if (!BookingDataStore.Bookings.Contains(b2))
            {
                BookingDataStore.Bookings.Add(b2);
            }
            Student ss = StudentDataStore.Students.FirstOrDefault(s2 => s2.StudentID == b2.StudentID);
            ss.bookings.Add(b2);

            Booking b3 = new Booking()
            {
                bookingRef = BookingDataStore.GetNextBookigRef(),
                StudentID = 3,
                DateOfBooking = new DateTime(2025, 11, 15, 9, 0, 0),
                GrindTime = new DateTime(2025, 12, 12, 14, 0, 0),
                TutorID = 3,
                Amount = 30,
            };
            if (!BookingDataStore.Bookings.Contains(b3))
            {
                BookingDataStore.Bookings.Add(b3);
            }
            Student sss = StudentDataStore.Students.FirstOrDefault(s3 => s3.StudentID == b3.StudentID);
            sss.bookings.Add(b3);
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
                TimeandDate = new DateTime(2025, 12, 30, 9, 0, 0),
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
                TimeandDate = new DateTime(2025, 12, 28, 10, 0, 0),
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
                TimeandDate = new DateTime(2025, 12, 29, 14, 0, 0),
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
                TimeandDate = new DateTime(2025, 12, 30, 15, 0, 0),
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
            Form form = new frmCancelBooking();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        private void viewBookingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmShowBookings();
            form.Show();
            form.Owner = this;
            this.Hide();
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
            if (Firstname.Equals(""))
            {
                return StudentTutor + " First Name field must not be empty.";
            }
            else if (!Regex.IsMatch(Firstname, @"^[a-zA-Z\s]+$"))
            {
                return StudentTutor + " First Name field must only contain letters.";
            }


            else if (Lastname.Equals(""))
            {
                return StudentTutor + " Surname field must not be empty.";
            }
            else if (!Regex.IsMatch(Lastname, @"^[a-zA-Z\s]+$"))
            {
                return StudentTutor + " Surname field must only contain letters.";
            }

            else if (Email.Equals(""))
            {
                return StudentTutor + " Email field must not be empty.";
            }
            else if (!Regex.IsMatch(Email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                return StudentTutor + " Email field must be in the correct format, example : isabelle@gmail.com";
            }
            else if (Phone.Equals(""))
            {
                return StudentTutor + " Phone Number field must not be empty.";
            }
            else if (!Regex.IsMatch(Phone, @"\d{3}-\d{7}$"))
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
                var item1 = x as ListViewItem;
                var item2 = y as ListViewItem;

                // Read values
                DateTime date1 = DateTime.Parse(item1.SubItems[dateColumnIndex].Text);
                DateTime date2 = DateTime.Parse(item2.SubItems[dateColumnIndex].Text);

                TimeSpan time1 = TimeSpan.Parse(item1.SubItems[timeColumnIndex].Text);
                TimeSpan time2 = TimeSpan.Parse(item2.SubItems[timeColumnIndex].Text);

                // Combine date + time
                DateTime dt1 = date1.Add(time1);
                DateTime dt2 = date2.Add(time2);

                return ascending ? dt1.CompareTo(dt2) : dt2.CompareTo(dt1);
            }
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void tutorEarningsAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmTutorReport();
            form.Show();
            form.Owner = this;
            this.Hide();
        }

        private void yearlyRevenueAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new frmAdmin();
            form.Show();
            form.Owner = this;
            this.Hide();
        }
    }
}
