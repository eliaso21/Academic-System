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
    public partial class GetStudentForm : Form
    {
        private DatabaseContext db = new DatabaseContext();

        public GetStudentForm()
        {
            InitializeComponent();
            studentGrid.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(searchTxt.Text, out int studentId))
            {
                if (db.Students.Any(s => s.St_ID == studentId))
                {
                    MessageBox.Show("Student ID exists.");
                    studentGrid.DataSource = db.Students.Select(std => new { std.St_ID, FullName = std.St_FName + " " + std.St_LName, std.St_Phone })
                                                         .Where(s => s.St_ID == studentId)
                                                        .ToList();
                    studentGrid.Visible=true;
                }
                else
                {
                    MessageBox.Show("Student ID not found.");
                    studentGrid.Visible = false;
                }
            }
        }
    }
}
