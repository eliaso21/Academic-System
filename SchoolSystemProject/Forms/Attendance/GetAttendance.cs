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
    public partial class GetAttendance : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public GetAttendance()
        {
            InitializeComponent();
            deptGrid.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int InsId))
            {
                if (db.CrsSessionAtts.Any(s => s.CrsSAID == InsId))
                {
                    MessageBox.Show("Course Attendance ID exists.");
                    deptGrid.DataSource = db.CrsSessionAtts.Select(d => new { d.CrsSAID, d.StdID, d.CrsSessionID, d.Grade ,d.Notes})
                                                         .Where(c => c.CrsSAID == InsId)
                                                        .ToList();
                    deptGrid.Visible = true;
                }
                else
                {
                    MessageBox.Show("Course Attendance ID not found.");
                    deptGrid.Visible = false;
                }
            }
        }
    }
}
