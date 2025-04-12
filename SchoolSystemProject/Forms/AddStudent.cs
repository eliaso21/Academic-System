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

namespace SchoolSystemProject.Forms
{
    public partial class AddStudent : Form
    {
        DatabaseContext db = new DatabaseContext();
        public AddStudent()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            int id;
            if (!int.TryParse(idtext.Text, out id))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }

            if (db.Students.Any(s => s.St_ID == id))
            {
                MessageBox.Show("A student with this ID already exists.");
                return;
            }

            var newStudent = new Student
            {
                //St_ID = id,
                St_FName = firstntext.Text.Trim(),
                St_LName = lastntext.Text.Trim(),
                St_Phone = phonetext.Text.Trim()
            };

            db.Students.Add(newStudent);
            db.SaveChanges();
            MessageBox.Show($"Student added successfully! Assigned ID: {newStudent.St_ID}");

            idtext.Clear();
            firstntext.Clear();
            lastntext.Clear();
            phonetext.Clear();
        }

    }
    }
    

