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

namespace SchoolSystemProject.Forms
{
    public partial class FirstPage : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public FirstPage()
        {
            InitializeComponent();
            FillStudentsList();
        }

        private void FillStudentsList()
        {
            db.Students.Load();
            StudentsGrid.DataSource = db.Students.Local.Select(std => new { std.St_ID, FullName = std.St_FName + " " + std.St_LName, std.St_Phone})
                                                        .ToList();
        }

       
    }
}
