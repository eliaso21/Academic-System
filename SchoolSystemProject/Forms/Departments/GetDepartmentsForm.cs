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

namespace SchoolSystemProject.Forms.Departments
{
    public partial class GetDepartmentsForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetDepartmentsForm()
        {
            InitializeComponent();
            FillDepartmentsList();
        }

        private void FillDepartmentsList()
        {
            db.Departments.Load();
            DepartmentGrid.DataSource = db.Departments.Local.Select(d => new { d.Dept_ID, d.Dept_Name, d.Dept_Location, d.ManagerID })
                                                     .ToList();
        }
    }
}
