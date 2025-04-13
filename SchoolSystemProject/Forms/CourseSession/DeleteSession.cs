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

namespace SchoolSystemProject.Forms.CourseSession
{
    public partial class DeleteSession : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public DeleteSession()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTxt.Text, out id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this Session?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var session = db.Crs_Sessions.Find(id);
                    if (session != null)
                    {
                        db.Crs_Sessions.Remove(session);
                        db.SaveChanges();

                        MessageBox.Show("session deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("session not found.");
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
