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

namespace SchoolSystemProject.Forms.Attendance
{
    public partial class UpdateAttendance : Form
    {
        private DatabaseContext db = new DatabaseContext();
        private int attId;

        public UpdateAttendance()
        {
            InitializeComponent();
            Loader();
        }
        private void Loader()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            stdtext.Visible = false;
            sstext.Visible = false;
            grdtext.Visible = false;
            notestext.Visible = false;
            updateBtn.Visible = false;
            label1.Visible = true;
            searchBtn.Visible = true;
            searchTxt.Visible = true;
        }

        void ShowingFnc()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            stdtext.Visible = true;
            sstext.Visible = true;
            grdtext.Visible = true;
            notestext.Visible = true;
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
            if (int.TryParse(searchTxt.Text, out attId))
            {
                if (db.CrsSessionAtts.Any(c => c.CrsSAID == attId))
                {
                    var target = db.CrsSessionAtts.Where(c => c.CrsSAID == attId).FirstOrDefault();
                    ShowingFnc();
                    HidingFnc();

                    stdtext.Text = target.StdID.ToString();
                    sstext.Text = target.CrsSessionID.ToString(); ;
                    grdtext.Text = target.Grade.ToString();
                    notestext.Text = target.Notes.ToString();

                }
                else
                {
                    MessageBox.Show("Attendance ID not found.");
                }
            }
        }

        private async void updateBtn_Click(object sender, EventArgs e)
        {
            int stdId;
            if (!int.TryParse(stdtext.Text, out stdId))
            {
                MessageBox.Show("Invalid Student ID.");
                return;
            }

            var Student = await db.Students
                                    .FirstOrDefaultAsync(d => d.St_ID == stdId);

            if (Student == null)
            {
                MessageBox.Show("The entered Student ID does not exist. Please enter a valid Student ID.",
                                "Invalid Student",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }


            int sId;

            if (!int.TryParse(sstext.Text, out sId))
            {
                MessageBox.Show("Invalid Session ID.");
                return;
            }

            var Session = await db.Crs_Sessions
                                    .FirstOrDefaultAsync(d => d.CrsSID == sId);

            if (Session == null)
            {
                MessageBox.Show("The entered Session ID does not exist. Please enter a valid Session ID.",
                                "Invalid Session",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            int grade;
            if (!int.TryParse(grdtext.Text, out grade))
            {
                MessageBox.Show("Invalid Grade.");
                return;
            }

            var Attendance = db.CrsSessionAtts.Find(attId);
            Attendance.StdID=stdId;
            Attendance.CrsSessionID = sId;
            Attendance.Grade = grade;
            Attendance.Notes=notestext.Text;

            db.SaveChanges();

            MessageBox.Show("Attendance Updated Successfully");
            searchTxt.Clear();
            Loader();

        }
    }
    }

