using System;
using System.Collections;
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
using static GrindsBookingSystem.frmSchedule;

namespace GrindsBookingSystem
{
    public partial class frmSchedule : Form
    {
        public frmSchedule()
        {
            InitializeComponent();
            lvSchedule.MouseClick += lvSchedule_MouseClick;
            updateListView(ScheduleDataStore.ScheduleItems.OrderBy(s => s.TimeandDate));
            
        }

       
        private void lvSchedule_MouseClick(object sender, MouseEventArgs e)
        {
            ListViewHitTestInfo info = lvSchedule.HitTest(e.X, e.Y);

            if (info.Item != null && info.SubItem != null)
            {
                int columnIndex = info.Item.SubItems.IndexOf(info.SubItem);

                if (columnIndex == 5)
                {
                    int tutorID = int.Parse(info.SubItem.Text);

                    var tutorView = TutorDataStore.Tutors.FirstOrDefault(t => t.TutorID == tutorID);

                    if (tutorView == null)
                    {
                        MessageBox.Show("Tutor not found.",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                        return;
                    }

                    MessageBox.Show(
                        "The details of this tutor are:\n\n" +
                        $"Tutor ID : {tutorView.TutorID}\n" +
                        $"First Name : {tutorView.FirstName}\n" +
                        $"Last Name : {tutorView.Surname}\n" +
                        $"Subject : {tutorView.Subject}\n" +
                        $"Phone : {tutorView.Phone}\n" +
                        $"Email : {tutorView.Email}",
                        "Tutor Details",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
            }
        }
        

        private void frmSchedule_Load(object sender, EventArgs e)
        {
            if (lvSchedule.Columns.Count == 0)
            {
                lvSchedule.Columns.Add("Date", 100);
                lvSchedule.Columns.Add("Time", 100);
                lvSchedule.Columns.Add("Max Attendance", 115);
                lvSchedule.Columns.Add("Current Enrollment", 115);
                lvSchedule.Columns.Add("Room No", 130);
                lvSchedule.Columns.Add("Tutor ID", 120);
            }

            lvSchedule.View = View.Details;
            lvSchedule.FullRowSelect = true;
            lvSchedule.GridLines = true;

        }

        public void updateListView(IEnumerable<Schedule> schedules)
        {
            schedules = schedules.OrderBy(s => s.TimeandDate);
            foreach(var item in schedules)
            {
                
            }
            lvSchedule.Items.Clear();

            foreach (var s in schedules)
            {
                if(s.TimeandDate <  DateTime.Today)
                {
                    continue;
                }
                var item = new ListViewItem(s.TimeandDate.ToShortDateString());
                item.SubItems.Add(s.TimeandDate.ToShortTimeString());
                item.SubItems.Add(s.MaxAttendnace.ToString());
                item.SubItems.Add(s.currentEnrollment.ToString());
                item.SubItems.Add(s.RoomNo);
                item.SubItems.Add(s.TutorID.ToString());

                lvSchedule.Items.Add(item);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var form = new frmHome();
            form.Show();
            this.Hide();
        }

       

        private void btnAddGrind_Click(object sender, EventArgs e)
        {
            var form = new frmAddGrind();
            form.Owner = this;
            form.Show();
            this.Hide();
        }

        private void btnRemoveGrind_Click(object sender, EventArgs e)
        {
            var form = new frmRemoveGrind();
            form.Owner = this;
            form.Show();
            this.Hide();
        }


        public class ScheduleDateTimeComparer : IComparer
        {
            private bool ascending;

            public ScheduleDateTimeComparer(bool ascending)
            {
                this.ascending = ascending;
            }

            public int Compare(object x, object y)
            {
                ListViewItem item1 = x as ListViewItem;
                ListViewItem item2 = y as ListViewItem;

                DateTime date1 = DateTime.Parse(item1.SubItems[0].Text);
                DateTime date2 = DateTime.Parse(item2.SubItems[0].Text);

                TimeSpan time1 = TimeSpan.Parse(item1.SubItems[1].Text);
                TimeSpan time2 = TimeSpan.Parse(item2.SubItems[1].Text);

                DateTime dt1 = date1.Add(time1);
                DateTime dt2 = date2.Add(time2);

                return ascending ? dt1.CompareTo(dt2) : dt2.CompareTo(dt1);
            }
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
    }
}
    
