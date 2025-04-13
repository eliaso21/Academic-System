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
    public partial class GetSession : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetSession()
        {
            InitializeComponent();
            deptGrid.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int CrsSId))
            {
                if (db.Instructors.Any(s => s.InsID == CrsSId))
                {
                    MessageBox.Show("Course Session ID exists.");
                    deptGrid.DataSource = db.Crs_Sessions.Select(d => new { d.CrsSID, d.Title, d.Date, d.CrsID, d.InsID })
                                                         .Where(c => c.CrsSID == CrsSId)
                                                        .ToList();
                    deptGrid.Visible = true;
                }
                else
                {
                    MessageBox.Show("Course Session ID not found.");
                    deptGrid.Visible = false;
                }
            }
        }
    }
}
