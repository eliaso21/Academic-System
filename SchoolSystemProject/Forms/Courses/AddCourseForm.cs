using Microsoft.EntityFrameworkCore;
using SchoolSystemProject.Context;
using SchoolSystemProject.Models;
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

    public partial class AddCourseForm : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public AddCourseForm()
        {
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
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

            if (db.Courses.Any(s => s.CrsID == crsId))
            {
                MessageBox.Show("A course with this ID already exists.");
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

            var newCourse = new Course
            {
                CrsName = nametext.Text,
                CrsDuration = duration,
                DeptID=deptId,
                InsID=insId,
            };

            db.Courses.Add(newCourse);
            db.SaveChanges();
            MessageBox.Show($"Course added successfully! Assigned ID: {newCourse.CrsID}");

            idtext.Clear();
            nametext.Clear();
            durationtext.Clear();
            deptext.Clear();
            instext.Clear();
            
        }
    }
    }

