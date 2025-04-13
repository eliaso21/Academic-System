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

namespace SchoolSystemProject.Forms.Attendance
{
    public partial class DeleteAttendance : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public DeleteAttendance()
        {
            InitializeComponent();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (int.TryParse(searchTxt.Text, out id))
            {
                var confirm = MessageBox.Show("Are you sure you want to delete this Attendance record?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {

                    var Attendance = db.CrsSessionAtts.Find(id);
                    if (Attendance != null)
                    {
                        db.CrsSessionAtts.Remove(Attendance);
                        db.SaveChanges();

                        MessageBox.Show("Attendance deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Attendance not found.");
                    }

                }
            }
        }
    }
}
