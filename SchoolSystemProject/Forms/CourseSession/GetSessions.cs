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
    public partial class GetSessions : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetSessions()
        {
            InitializeComponent();
            FillSessionsData();
        }

        private void FillSessionsData()
        {
            db.Crs_Sessions.Load();
            DepartmentGrid.DataSource = db.Crs_Sessions.Local.Select(d => new { d.CrsSID,d.Title,d.Date,d.CrsID,d.InsID})
                                                     .ToList();

        }
    }
}
