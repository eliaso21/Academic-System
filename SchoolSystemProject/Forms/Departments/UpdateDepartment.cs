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
    public partial class UpdateDepartment : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public UpdateDepartment()
        {
            InitializeComponent();
            Loader();
        }
        private void Loader()
        {
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            nametext.Visible = false;
            locationtext.Visible = false;
            mngrtext.Visible = false;
            updateBtn.Visible = false;
            label1.Visible = true;
            searchBtn.Visible = true;
            searchTxt.Visible = true;
        }

        void ShowingFnc()
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            locationtext.Visible = true;
            nametext.Visible = true;
            mngrtext.Visible = true;
            updateBtn.Visible = true;
        }

        void HidingFnc()
        {
            label1.Visible = false;
            searchBtn.Visible = false;
            searchTxt.Visible = false;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int deptId))
            {
                if (db.Departments.Any(c => c.Dept_ID == deptId))
                {
                    var target = db.Departments.Where(c => c.Dept_ID == deptId).FirstOrDefault();
                    ShowingFnc();
                    HidingFnc();

                    nametext.Text = target.Dept_Name.ToString();
                    locationtext.Text = target.Dept_Location.ToString();
                    mngrtext.Text = target.ManagerID.ToString();
                }
                else
                {
                    MessageBox.Show("Department ID not found.");
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            int mngrId;
            if (!int.TryParse(mngrtext.Text, out mngrId))
            {
                MessageBox.Show("Invalid Manager ID.");
                return;
            }

            var manager = await db.Instructors
                                    .FirstOrDefaultAsync(d => d.InsID == mngrId);

            if (manager == null)
            {
                MessageBox.Show("The entered Manager ID does not exist. Please enter a valid Manager ID.",
                                "Invalid Manager",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int deptId;

            if (!int.TryParse(searchTxt.Text, out deptId))
            {
                MessageBox.Show("Invalid Course ID.");
                return;
            }

            var department = db.Departments.Find(deptId);
            department.Dept_Name=nametext.Text;
            department.Dept_Location = locationtext.Text;
            department.ManagerID = mngrId;

            db.SaveChanges();

            MessageBox.Show("Department Updated Successfully");
            searchTxt.Clear();
            Loader();

        }
    }
}
