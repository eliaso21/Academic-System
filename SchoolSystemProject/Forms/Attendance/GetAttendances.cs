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
    public partial class GetAttendances : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetAttendances()
        {
            InitializeComponent();
            FillAttendancesData();
        }

        private void FillAttendancesData()
        {
            db.CrsSessionAtts.Load();
            DepartmentGrid.DataSource = db.CrsSessionAtts.Local.Select(d => new { d.CrsSAID,d.StdID,d.CrsSessionID,d.Grade, d.Notes })
                                                    .ToList();

        }
    }
}
