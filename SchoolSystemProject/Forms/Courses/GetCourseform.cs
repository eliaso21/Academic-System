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
    public partial class GetCourseform : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetCourseform()
        {
            InitializeComponent();
            courseGrid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int courseId))
            {
                if (db.Courses.Any(s => s.CrsID== courseId))
                {
                    MessageBox.Show("Course ID exists.");
                    courseGrid.DataSource = db.Courses.Select(c => new { c.CrsID, c.CrsName, c.CrsDuration, c.DeptID, c.InsID })
                                                         .Where(c => c.CrsID == courseId)
                                                        .ToList();
                    courseGrid.Visible = true;
                }
                else
                {
                    MessageBox.Show("Course ID not found.");
                    courseGrid.Visible = false;
                }
            }
        }
    }
}
