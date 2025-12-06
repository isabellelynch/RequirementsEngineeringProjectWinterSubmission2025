using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static GrindsBookingSystem.frmHome;

namespace GrindsBookingSystem
{
    public partial class frmTutorReport : Form
    {
        public frmTutorReport()
        {
            InitializeComponent();


        }

        private void frmTutorReport_Load(object sender, EventArgs e)
        {
            chartTutorEarnings.Series.Clear();

            Series series = new Series();
            series.Name = "";
            series.IsVisibleInLegend = false;
            series.ChartType = SeriesChartType.Bar;
            series.Color = Color.Pink;
            series.BorderWidth = 3;
            chartTutorEarnings.Titles.Add("Tutor Earnings Analysis");

            chartTutorEarnings.ChartAreas[0].AxisX.Title = "Tutor First Name";
            chartTutorEarnings.ChartAreas[0].AxisY.Title = "Earnings €";
            chartTutorEarnings.ChartAreas[0].AxisX.Interval = 1;


            foreach (var t in TutorDataStore.Tutors)
            {
                int total = 0;
                int index = 0;
                foreach(var b in BookingDataStore.Bookings)
                {
                    if(b.TutorID == t.TutorID)
                    {
                        total += b.Amount;
                    }
                }
                var item = new ListViewItem(t.TutorID.ToString());
                item.SubItems.Add(t.FirstName);
                item.SubItems.Add(t.Surname);
                item.SubItems.Add(total.ToString());

                var point = new DataPoint(index, total)
                {
                    AxisLabel = t.FirstName,
                    Tag = t
                };

                series.Points.Add(point);
                index ++;
            }
            chartTutorEarnings.Series.Add(series);
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




        private void chartTutorEarnings_MouseDown(object sender, MouseEventArgs e)
        {
            HitTestResult result = chartTutorEarnings.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                int pointIndex = result.PointIndex;
                Series series = result.Series;
                DataPoint point = series.Points[pointIndex];
                var tutorView = point.Tag as Tutor;
                if (tutorView != null)
                {
                    MessageBox.Show("The details of the chosen tutor are:\n\n" + $"Tutor ID : {tutorView.TutorID}\n" +
                        $"First Name : {tutorView.FirstName}\n" + $"Last Name : {tutorView.Surname}\n" +
                        $"Subject : {tutorView.Subject}\n" + $"Phone : {tutorView.Phone}\n" + $"Email : {tutorView.Email}",
                        "Tutor Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
        }
    }
}


