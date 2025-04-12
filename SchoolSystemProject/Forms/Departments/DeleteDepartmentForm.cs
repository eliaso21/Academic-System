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
    public partial class DeleteDepartmentForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public DeleteDepartmentForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTxt.Text, out id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this Department?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var department = db.Departments.Find(id);
                    if (department != null)
                    {
                        db.Departments.Remove(department);
                        db.SaveChanges();

                        MessageBox.Show("Department deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Departments not found.");
                    }

                }
            }
            else
            {
                MessageBox.Show("Invalid ID.");
            }
        }
    }
    }

