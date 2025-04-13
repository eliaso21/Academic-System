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
    public partial class AddSession : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public AddSession()
        {
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            int crsId;
            if (!int.TryParse(crstext.Text, out crsId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }
            var course = await db.Courses.FirstOrDefaultAsync(i => i.CrsID == crsId);

            if (course == null)
            {
                MessageBox.Show("The entered Course ID does not exist. Please enter a valid Course ID.",
                                "Invalid Course",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int insId;
            if (!int.TryParse(instext.Text, out insId))
            {
                MessageBox.Show("Invalid instructor ID.");
                return;
            }
            var instructor = await db.Instructors.FirstOrDefaultAsync(i => i.InsID == insId);

            if (instructor == null)
            {
                MessageBox.Show("The entered Instructor ID does not exist. Please enter a valid Instructor ID.",
                                "Invalid Instructor",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            var newSession = new SchoolSystemProject.Models.CourseSession
            {
                InsID = insId,
                CrsID = crsId,
                Date= dateTimePicker1.Value,
                Title=titletext.Text,
            };

            db.Crs_Sessions.Add(newSession);
            db.SaveChanges();

            MessageBox.Show("Session Added");
            crstext.Clear();
            instext.Clear();
            titletext.Clear();
        }
    }
}
