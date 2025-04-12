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

namespace SchoolSystemProject.Forms
{
    public partial class DeleteStudent : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public DeleteStudent()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTxt.Text, out id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this student?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var student = db.Students.Find(id);
                    if (student != null)
                    {
                        db.Students.Remove(student);
                        db.SaveChanges();

                        MessageBox.Show("Student deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
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

