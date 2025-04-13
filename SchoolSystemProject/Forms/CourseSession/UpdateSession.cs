using Microsoft.EntityFrameworkCore;
using SchoolSystemProject.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSystemProject.Forms.CourseSession
{
    public partial class UpdateSession : Form
    {
        private DatabaseContext db = new DatabaseContext();
        private int crsSID;

        public UpdateSession()
        {
            InitializeComponent();
            Loader();
        }
        private void Loader()
        {
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            dateTimePicker1.Visible = false;
            crstext.Visible = false;
            instext.Visible = false;
            titletext.Visible = false;
            updateBtn.Visible = false;
            label1.Visible = true;
            searchBtn.Visible = true;
            searchTxt.Visible = true;
        }

        void ShowingFnc()
        {
            label3.Visible = false;
            label4.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            dateTimePicker1.Visible = false;
            crstext.Visible = false;
            instext.Visible = false;
            titletext.Visible = false;
            updateBtn.Visible = false;
        }

        void HidingFnc()
        {
            label1.Visible = false;
            searchBtn.Visible = false;
            searchTxt.Visible = false;
        }


        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out crsSID))
            {
                if (db.Crs_Sessions.Any(c => c.CrsSID == crsSID))
                {
                    var target = db.Crs_Sessions.Where(c => c.InsID == crsSID).FirstOrDefault();
                    ShowingFnc();
                    HidingFnc();

                    dateTimePicker1.Value = target.Date;
                    crstext.Text = target.CrsID.ToString();
                    instext.Text = target.InsID.ToString();
                    titletext.Text = target.Title.ToString();

                }
                else
                {
                    MessageBox.Show("Session ID not found.");
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            int crsId;
            if (!int.TryParse(crstext.Text, out crsId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            var course = await db.Courses
                                    .FirstOrDefaultAsync(d => d.CrsID == crsId);

            if (course == null)
            {
                MessageBox.Show("The entered course ID does not exist. Please enter a valid course ID.",
                                "Invalid course",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            int insId;

            if (!int.TryParse(instext.Text, out insId))
            {
                MessageBox.Show("Invalid Instructor Id.");
                return;
            }

            var instructor = await db.Instructors
                                    .FirstOrDefaultAsync(d => d.InsID == insId);

            if (instructor == null)
            {
                MessageBox.Show("The entered Instructor ID does not exist. Please enter a valid Instructor ID.",
                                "Invalid Instructor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var session = db.Crs_Sessions.Find(crsSID);
            session.Title = titletext.Text;
            session.Date = dateTimePicker1.Value;
            session.InsID = insId;
            session.CrsID = crsId;

            db.SaveChanges();

            MessageBox.Show("Session Updated Successfully");
            searchTxt.Clear();
            Loader();

        }
    }
    }

