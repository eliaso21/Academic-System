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
    public partial class UpdateInstructor : Form
    {
        private DatabaseContext db = new DatabaseContext();
        private int insId;

        public UpdateInstructor()
        {
            InitializeComponent();
            Loader();
        }
        private void Loader()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label7.Visible = false;
            fnametext.Visible = false;
            lnametext.Visible = false;
            salarytext.Visible = false;
            phonetext.Visible = false;
            deptext.Visible = false;
            updateBtn.Visible = false;
            label1.Visible = true;
            searchBtn.Visible = true;
            searchTxt.Visible = true;
        }

        void ShowingFnc()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label7.Visible = true;
            fnametext.Visible = true;
            lnametext.Visible = true;
            salarytext.Visible = true;
            phonetext.Visible = true;
            deptext.Visible = true;
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
            if (int.TryParse(searchTxt.Text, out insId))
            {
                if (db.Instructors.Any(c => c.InsID == insId))
                {
                    var target = db.Instructors.Where(c => c.InsID == insId).FirstOrDefault();
                    ShowingFnc();
                    HidingFnc();

                    fnametext.Text = target.InsFName.ToString();
                    lnametext.Text = target.InsLName.ToString(); ;
                    salarytext.Text = target.Salary.ToString();
                    phonetext.Text = target.Phone.ToString(); 
                    deptext.Text = target.Dept_ID.ToString();

                }
                else
                {
                    MessageBox.Show("Department ID not found.");
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            int deptId;
            if (!int.TryParse(deptext.Text, out deptId))
            {
                MessageBox.Show("Invalid Department ID.");
                return;
            }

            var department = await db.Departments
                                    .FirstOrDefaultAsync(d => d.Dept_ID == deptId);

            if (department == null)
            {
                MessageBox.Show("The entered department ID does not exist. Please enter a valid department ID.",
                                "Invalid department",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            decimal salary;

            if (!decimal.TryParse(salarytext.Text, out salary))
            {
                MessageBox.Show("Invalid Salary Format.");
                return;
            }

            var instructor = db.Instructors.Find(insId);
            instructor.InsFName = fnametext.Text;
            instructor.InsLName = lnametext.Text;
            instructor.Phone = phonetext.Text;
            instructor.Salary = salary;
            instructor.Dept_ID = deptId;

            db.SaveChanges();

            MessageBox.Show("Instructor Updated Successfully");
            searchTxt.Clear();
            Loader();

        }
    }
}
