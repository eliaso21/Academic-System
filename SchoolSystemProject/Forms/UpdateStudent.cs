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
    public partial class UpdateStudent : Form
    {
        private DatabaseContext db = new DatabaseContext();
        public UpdateStudent()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            idtext.Visible = false;
            firstntext.Visible = false;
            lastntext.Visible = false;
            phonetext.Visible = false;
            updateBtn.Visible = false;

        }

        void ShowingFnc()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            //label6.Visible = true;
            idtext.Visible = true;
            firstntext.Visible = true;
            lastntext.Visible = true;
            phonetext.Visible = true;
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
            if (int.TryParse(searchTxt.Text, out int studentId))
            {
                if (db.Students.Any(s => s.St_ID == studentId))
                {
                    var target = db.Students.Where(std => std.St_ID == studentId).FirstOrDefault();
                    ShowingFnc();
                    HidingFnc();
                    idtext.Text = target.St_ID.ToString();
                    idtext.Enabled = false;
                    firstntext.Text = target.St_FName.ToString();
                    lastntext.Text = target.St_LName.ToString();
                    phonetext.Text = target.St_Phone.ToString();
                }
                else
                {
                    MessageBox.Show("Student ID not found.");
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
          
            int id;
            if (int.TryParse(idtext.Text, out id))
            {
                
                    var student = db.Students.Find(id);
                    if (student != null)
                    {
                        student.St_FName = firstntext.Text;
                        student.St_LName = lastntext.Text;
                        student.St_Phone = phonetext.Text;

                        db.SaveChanges();
                    label6.Visible = true;
                    }
                    else
                    {
                        MessageBox.Show("Student not found.");
                    }
                
            }
            else
            {
                MessageBox.Show("Invalid ID.");
            }
        

    }
}
}
