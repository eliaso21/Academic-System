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
    public partial class GetInstructorForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetInstructorForm()
        {
            InitializeComponent();
            deptGrid.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int InsId))
            {
                if (db.Instructors.Any(s => s.InsID == InsId))
                {
                    MessageBox.Show("Instructor ID exists.");
                    deptGrid.DataSource = db.Instructors.Select(d => new { d.InsID, FullName = d.InsFName + " " + d.InsLName, d.Phone, d.Salary, d.Dept_ID })
                                                         .Where(c => c.InsID == InsId)
                                                        .ToList();
                    deptGrid.Visible = true;
                }
                else
                {
                    MessageBox.Show("Instructor ID not found.");
                    deptGrid.Visible = false;
                }
            }
        }
    }
}
