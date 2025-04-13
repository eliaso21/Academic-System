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

namespace SchoolSystemProject.Forms.Attendance
{
    public partial class AddAttendance : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public AddAttendance()
        {
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            int stdId;
            
            if (!int.TryParse(stdtext.Text, out stdId))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }
            var Student = await db.Students.FirstOrDefaultAsync(i => i.St_ID == stdId);

            if (Student == null)
            {
                MessageBox.Show("The entered Student ID does not exist. Please enter a valid Student ID.",
                                "Invalid Student",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int sId;


            if (!int.TryParse(sstext.Text, out sId))
            {
                MessageBox.Show("Invalid Session ID.");
                return;
            }
            var Session = await db.Crs_Sessions.FirstOrDefaultAsync(i => i.CrsSID == sId);

            if (Session == null)
            {
                MessageBox.Show("The entered Session ID does not exist. Please enter a valid Session ID.",
                                "Invalid Session",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int grade;
            if (!int.TryParse(grdtext.Text, out grade))
            {
                MessageBox.Show("Invalid Grade .");
                return;
            }

            var newAttendance = new SchoolSystemProject.Models.CourseSessionAttendance
            {
                Grade = grade,
                StdID = stdId,
                CrsSessionID=sId,
                Notes=notestext.Text,

            };
            db.CrsSessionAtts.Add(newAttendance);
            db.SaveChanges();

            MessageBox.Show("Attendance Added Successfully!");


            stdtext.Clear();
            sstext.Clear();
            grdtext.Clear();
            notestext.Clear();
        }
    }
}
