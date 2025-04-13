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
    public partial class DeleteInstructor : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public DeleteInstructor()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTxt.Text, out id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this Instructor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var instructor = db.Instructors.Find(id);
                    if (instructor != null)
                    {
                        db.Instructors.Remove(instructor);
                        db.SaveChanges();

                        MessageBox.Show("Instructor deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Instructor not found.");
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
