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

namespace SchoolSystemProject.Forms.Instructor
{
    public partial class GetInstructorsForm : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public GetInstructorsForm()
        {
            InitializeComponent();
            FillInstructorsList();
        }

        private void FillInstructorsList()
        {
            db.Instructors.Load();
            DepartmentGrid.DataSource = db.Instructors.Local.Select(d => new { d.InsID, FullName= d.InsFName+" "+ d.InsLName  , d.Phone,d.Salary,d.Dept_ID })
                                                     .ToList();
        }
    }
}
