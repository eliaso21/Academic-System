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

namespace SchoolSystemProject.Forms.Instructor
{
    public partial class AddInstructor : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public AddInstructor()
        {
            InitializeComponent();
        }

        private async void addBtn_Click(object sender, EventArgs e)
        {
            int deptId;
            int phone;
            decimal salary;
            if (!int.TryParse(depttext.Text, out deptId))
            {
                MessageBox.Show("Invalid Department ID.");
                return;
            }
            var department = await db.Departments.FirstOrDefaultAsync(i => i.Dept_ID == deptId);

            if (department == null)
            {
                MessageBox.Show("The entered Department ID does not exist. Please enter a valid Department ID.",
                                "Invalid Department",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(phonetext.Text, out phone))
            {
                MessageBox.Show("Invalid Phone .");
                return;
            }
            if (!decimal.TryParse(salarytext.Text, out salary))
            {
                MessageBox.Show("Invalid Salary .");
                return;
            }

            var newInstructor = new SchoolSystemProject.Models.Instructor
            {
                InsFName=fnametext.Text,
                InsLName=lnametext.Text,
                Phone=phonetext.Text,
                Salary=salary,
                Dept_ID=deptId
                
            };

            db.Instructors.Add(newInstructor);
            db.SaveChanges();

            MessageBox.Show("Instructor Added Successfully!");
            fnametext.Clear();
            lnametext.Clear();
            salarytext.Clear();
            phonetext.Clear();
            depttext.Clear();




        }
    }
}
