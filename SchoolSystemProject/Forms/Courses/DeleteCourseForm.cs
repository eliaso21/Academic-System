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

namespace SchoolSystemProject.Forms.Courses
{
    public partial class DeleteCourseForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public DeleteCourseForm()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTxt.Text, out id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this Course?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var course = db.Courses.Find(id);
                    if (course != null)
                    {
                        db.Courses.Remove(course);
                        db.SaveChanges();

                        MessageBox.Show("Course deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Course not found.");
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

