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
    public partial class GetCoursesForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetCoursesForm()
        {
            InitializeComponent();
            FillCoursesList();
        }

        private void FillCoursesList()
        {
            db.Courses.Load();
            CoursesGrid.DataSource = db.Courses.Local.Select(c => new {c.CrsID,c.CrsName,c.CrsDuration,c.DeptID,c.InsID})
                                                     .ToList();
        }
    }
}
