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
    public partial class GetDepartment : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetDepartment()
        {
            InitializeComponent();
            deptGrid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int deptId))
            {
                if (db.Departments.Any(s => s.Dept_ID == deptId))
                {
                    MessageBox.Show("Course ID exists.");
                    deptGrid.DataSource = db.Departments.Select(d => new { d.Dept_ID, d.Dept_Name, d.Dept_Location, d.ManagerID })
                                                         .Where(c => c.Dept_ID == deptId)
                                                        .ToList();
                    deptGrid.Visible = true;
                }
                else
                {
                    MessageBox.Show("Course ID not found.");
                    deptGrid.Visible = false;
                }
            }
        }
    }
}
