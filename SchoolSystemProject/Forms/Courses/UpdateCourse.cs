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

namespace SchoolSystemProject.Forms.Courses
{
    public partial class UpdateCourse : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public UpdateCourse()
        {
            InitializeComponent();
            UpdateCourse_Load();

        }
        void ShowingFnc()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            idtext.Visible = true;
            nametext.Visible = true;
            durationtext.Visible = true;
            deptext.Visible = true;
            instext.Visible = true;
            updateBtn.Visible = true;
        }

        void HidingFnc()
        {
            label1.Visible = false;
            searchBtn.Visible = false;
            searchTxt.Visible = false;
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            label6.Visible = false;
            if (int.TryParse(searchTxt.Text, out int courseId))
            {
                if (db.Courses.Any(c => c.CrsID == courseId))
                {
                    var target = db.Courses.Where(c => c.CrsID == courseId).FirstOrDefault();
                    ShowingFnc();
                    HidingFnc();
                    idtext.Text = target.CrsID.ToString();
                    idtext.Enabled = false;
                    nametext.Text = target.CrsName.ToString();
                    durationtext.Text = target.CrsDuration.ToString();
                    deptext.Text = target.DeptID.ToString();
                    instext.Text = target.InsID.ToString();
                }
                else
                {
                    MessageBox.Show("Course ID not found.");
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            int crsId;
            int deptId;
            int insId;
            int duration;

            if (!int.TryParse(idtext.Text, out crsId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            if (!int.TryParse(deptext.Text, out deptId))
            {
                MessageBox.Show("Invalid Department ID.");
                return;
            }

            var department = await db.Departments
                                    .FirstOrDefaultAsync(d => d.Dept_ID == deptId);

            if (department == null)
            {
                MessageBox.Show("The entered Department ID does not exist. Please enter a valid Department ID.",
                                "Invalid Department",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(instext.Text, out insId))
            {
                MessageBox.Show("Invalid Instructor ID.");
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

            if (!int.TryParse(durationtext.Text, out duration))
            {
                MessageBox.Show("Invalid Duration Format, Only numbers allowed.");
                return;
            }

            var course = db.Courses.Find(crsId);
            course.CrsName = nametext.Text;
            course.CrsDuration = duration;
            course.DeptID = deptId;
            course.InsID = insId;
            db.SaveChanges();

            MessageBox.Show("Course Updated Successfully");
            searchTxt.Clear();
            UpdateCourse_Load();
        }

        private void UpdateCourse_Load()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            idtext.Visible = false;
            nametext.Visible = false;
            durationtext.Visible = false;
            deptext.Visible = false;
            instext.Visible = false;
            updateBtn.Visible = false;
            label1.Visible = true;
            searchBtn.Visible = true;
            searchTxt.Visible = true;
        }



        
    }
}
