using Microsoft.EntityFrameworkCore;
using SchoolSystemProject.Context;
using SchoolSystemProject.Models;
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
    public partial class AddDepartmentForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            int mngrId;
            if (!int.TryParse(mngrtext.Text, out mngrId))
            {
                MessageBox.Show("Invalid Manager ID.");
                return;
            }
            var manager = await db.Instructors.FirstOrDefaultAsync(i => i.InsID == mngrId);

            if (manager == null)
            {
                MessageBox.Show("The entered Manager ID does not exist. Please enter a valid Manager ID.",
                                "Invalid Manager",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }
            var newDept = new Department
            {
                Dept_Name=nametext.Text,
                Dept_Location=Locationtext.Text,
                ManagerID=mngrId,
            };

            db.Departments.Add(newDept);
            db.SaveChanges();
            MessageBox.Show("Department Added Successfully");
            nametext.Clear();
            Locationtext.Clear();
            mngrtext.Clear();
        }
    }
}
