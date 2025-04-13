namespace SchoolSystemProject
{
    partial class StartScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartScreen));
            label1 = new Label();
            EnterBtn = new Button();
            studentStrip = new MenuStrip();
            studentsToolStripMenuItem = new ToolStripMenuItem();
            allStudentsToolStripMenuItem = new ToolStripMenuItem();
            getStudentToolStripMenuItem = new ToolStripMenuItem();
            updateStudentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            deleteStudentToolStripMenuItem = new ToolStripMenuItem();
            coursesToolStripMenuItem = new ToolStripMenuItem();
            getCoursesToolStripMenuItem = new ToolStripMenuItem();
            getCourseToolStripMenuItem = new ToolStripMenuItem();
            addCourseToolStripMenuItem = new ToolStripMenuItem();
            deleteCourseToolStripMenuItem = new ToolStripMenuItem();
            updateCourseToolStripMenuItem = new ToolStripMenuItem();
            departmentToolStripMenuItem = new ToolStripMenuItem();
            getDepartmentToolStripMenuItem = new ToolStripMenuItem();
            getDToolStripMenuItem = new ToolStripMenuItem();
            addDepartmentToolStripMenuItem = new ToolStripMenuItem();
            updateDepartmentToolStripMenuItem = new ToolStripMenuItem();
            deleteDepartmentToolStripMenuItem = new ToolStripMenuItem();
            instructorToolStripMenuItem = new ToolStripMenuItem();
            getInstructorsToolStripMenuItem = new ToolStripMenuItem();
            getInstructorToolStripMenuItem = new ToolStripMenuItem();
            addInstructorToolStripMenuItem = new ToolStripMenuItem();
            updateInstructorToolStripMenuItem = new ToolStripMenuItem();
            deleteInstructorToolStripMenuItem = new ToolStripMenuItem();
            courseSessionToolStripMenuItem = new ToolStripMenuItem();
            getSessionsToolStripMenuItem = new ToolStripMenuItem();
            getSessionToolStripMenuItem = new ToolStripMenuItem();
            addSessionToolStripMenuItem = new ToolStripMenuItem();
            updateSessionToolStripMenuItem = new ToolStripMenuItem();
            deleteSessionToolStripMenuItem = new ToolStripMenuItem();
            courseSessionsAttdToolStripMenuItem = new ToolStripMenuItem();
            getAttendacesToolStripMenuItem = new ToolStripMenuItem();
            getAttendanceToolStripMenuItem = new ToolStripMenuItem();
            addAttendanceToolStripMenuItem = new ToolStripMenuItem();
            updateAttendanceToolStripMenuItem = new ToolStripMenuItem();
            deleteAttendanceToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            studentStrip.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Maroon;
            label1.Location = new Point(166, 40);
            label1.Name = "label1";
            label1.Size = new Size(475, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome To The Academic System";
            // 
            // EnterBtn
            // 
            EnterBtn.Anchor = AnchorStyles.None;
            EnterBtn.BackColor = Color.Maroon;
            EnterBtn.ForeColor = Color.White;
            EnterBtn.Location = new Point(346, 389);
            EnterBtn.Name = "EnterBtn";
            EnterBtn.Size = new Size(94, 29);
            EnterBtn.TabIndex = 1;
            EnterBtn.Text = "Enter";
            EnterBtn.UseVisualStyleBackColor = false;
            EnterBtn.Click += EnterBtn_Click;
            // 
            // studentStrip
            // 
            studentStrip.BackColor = Color.Maroon;
            studentStrip.ImageScalingSize = new Size(20, 20);
            studentStrip.Items.AddRange(new ToolStripItem[] { studentsToolStripMenuItem, coursesToolStripMenuItem, departmentToolStripMenuItem, instructorToolStripMenuItem, courseSessionToolStripMenuItem, courseSessionsAttdToolStripMenuItem, aboutToolStripMenuItem });
            studentStrip.Location = new Point(0, 0);
            studentStrip.Name = "studentStrip";
            studentStrip.Size = new Size(800, 28);
            studentStrip.TabIndex = 2;
            studentStrip.Text = "studentStrip";
            // 
            // studentsToolStripMenuItem
            // 
            studentsToolStripMenuItem.BackColor = Color.Maroon;
            studentsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allStudentsToolStripMenuItem, getStudentToolStripMenuItem, updateStudentToolStripMenuItem, addStudentToolStripMenuItem, deleteStudentToolStripMenuItem });
            studentsToolStripMenuItem.ForeColor = Color.White;
            studentsToolStripMenuItem.Name = "studentsToolStripMenuItem";
            studentsToolStripMenuItem.Size = new Size(80, 24);
            studentsToolStripMenuItem.Text = "Students";
            // 
            // allStudentsToolStripMenuItem
            // 
            allStudentsToolStripMenuItem.Name = "allStudentsToolStripMenuItem";
            allStudentsToolStripMenuItem.Size = new Size(196, 26);
            allStudentsToolStripMenuItem.Text = "All Students";
            allStudentsToolStripMenuItem.Click += allStudentsToolStripMenuItem_Click_1;
            // 
            // getStudentToolStripMenuItem
            // 
            getStudentToolStripMenuItem.Name = "getStudentToolStripMenuItem";
            getStudentToolStripMenuItem.Size = new Size(196, 26);
            getStudentToolStripMenuItem.Text = "Get Student";
            getStudentToolStripMenuItem.Click += getStudentToolStripMenuItem_Click;
            // 
            // updateStudentToolStripMenuItem
            // 
            updateStudentToolStripMenuItem.Name = "updateStudentToolStripMenuItem";
            updateStudentToolStripMenuItem.Size = new Size(196, 26);
            updateStudentToolStripMenuItem.Text = "Update Student";
            updateStudentToolStripMenuItem.Click += updateStudentToolStripMenuItem_Click;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(196, 26);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // deleteStudentToolStripMenuItem
            // 
            deleteStudentToolStripMenuItem.Name = "deleteStudentToolStripMenuItem";
            deleteStudentToolStripMenuItem.Size = new Size(196, 26);
            deleteStudentToolStripMenuItem.Text = "Delete Student";
            deleteStudentToolStripMenuItem.Click += deleteStudentToolStripMenuItem_Click;
            // 
            // coursesToolStripMenuItem
            // 
            coursesToolStripMenuItem.BackColor = Color.Maroon;
            coursesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getCoursesToolStripMenuItem, getCourseToolStripMenuItem, addCourseToolStripMenuItem, deleteCourseToolStripMenuItem, updateCourseToolStripMenuItem });
            coursesToolStripMenuItem.ForeColor = Color.White;
            coursesToolStripMenuItem.Name = "coursesToolStripMenuItem";
            coursesToolStripMenuItem.Size = new Size(74, 24);
            coursesToolStripMenuItem.Text = "Courses";
            // 
            // getCoursesToolStripMenuItem
            // 
            getCoursesToolStripMenuItem.Name = "getCoursesToolStripMenuItem";
            getCoursesToolStripMenuItem.Size = new Size(190, 26);
            getCoursesToolStripMenuItem.Text = "Get Courses";
            getCoursesToolStripMenuItem.Click += getCoursesToolStripMenuItem_Click;
            // 
            // getCourseToolStripMenuItem
            // 
            getCourseToolStripMenuItem.Name = "getCourseToolStripMenuItem";
            getCourseToolStripMenuItem.Size = new Size(190, 26);
            getCourseToolStripMenuItem.Text = "Get Course";
            getCourseToolStripMenuItem.Click += getCourseToolStripMenuItem_Click;
            // 
            // addCourseToolStripMenuItem
            // 
            addCourseToolStripMenuItem.Name = "addCourseToolStripMenuItem";
            addCourseToolStripMenuItem.Size = new Size(190, 26);
            addCourseToolStripMenuItem.Text = "Add Course";
            addCourseToolStripMenuItem.Click += addCourseToolStripMenuItem_Click;
            // 
            // deleteCourseToolStripMenuItem
            // 
            deleteCourseToolStripMenuItem.Name = "deleteCourseToolStripMenuItem";
            deleteCourseToolStripMenuItem.Size = new Size(190, 26);
            deleteCourseToolStripMenuItem.Text = "Delete Course";
            deleteCourseToolStripMenuItem.Click += deleteCourseToolStripMenuItem_Click;
            // 
            // updateCourseToolStripMenuItem
            // 
            updateCourseToolStripMenuItem.Name = "updateCourseToolStripMenuItem";
            updateCourseToolStripMenuItem.Size = new Size(190, 26);
            updateCourseToolStripMenuItem.Text = "Update Course";
            updateCourseToolStripMenuItem.Click += updateCourseToolStripMenuItem_Click;
            // 
            // departmentToolStripMenuItem
            // 
            departmentToolStripMenuItem.BackColor = Color.Maroon;
            departmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getDepartmentToolStripMenuItem, getDToolStripMenuItem, addDepartmentToolStripMenuItem, updateDepartmentToolStripMenuItem, deleteDepartmentToolStripMenuItem });
            departmentToolStripMenuItem.ForeColor = Color.White;
            departmentToolStripMenuItem.Name = "departmentToolStripMenuItem";
            departmentToolStripMenuItem.Size = new Size(103, 24);
            departmentToolStripMenuItem.Text = "Department";
            // 
            // getDepartmentToolStripMenuItem
            // 
            getDepartmentToolStripMenuItem.Name = "getDepartmentToolStripMenuItem";
            getDepartmentToolStripMenuItem.Size = new Size(225, 26);
            getDepartmentToolStripMenuItem.Text = "Get Departments";
            getDepartmentToolStripMenuItem.Click += getDepartmentToolStripMenuItem_Click;
            // 
            // getDToolStripMenuItem
            // 
            getDToolStripMenuItem.Name = "getDToolStripMenuItem";
            getDToolStripMenuItem.Size = new Size(225, 26);
            getDToolStripMenuItem.Text = "Get Department";
            getDToolStripMenuItem.Click += getDToolStripMenuItem_Click;
            // 
            // addDepartmentToolStripMenuItem
            // 
            addDepartmentToolStripMenuItem.Name = "addDepartmentToolStripMenuItem";
            addDepartmentToolStripMenuItem.Size = new Size(225, 26);
            addDepartmentToolStripMenuItem.Text = "Add Department";
            addDepartmentToolStripMenuItem.Click += addDepartmentToolStripMenuItem_Click;
            // 
            // updateDepartmentToolStripMenuItem
            // 
            updateDepartmentToolStripMenuItem.Name = "updateDepartmentToolStripMenuItem";
            updateDepartmentToolStripMenuItem.Size = new Size(225, 26);
            updateDepartmentToolStripMenuItem.Text = "Update Department";
            updateDepartmentToolStripMenuItem.Click += updateDepartmentToolStripMenuItem_Click;
            // 
            // deleteDepartmentToolStripMenuItem
            // 
            deleteDepartmentToolStripMenuItem.Name = "deleteDepartmentToolStripMenuItem";
            deleteDepartmentToolStripMenuItem.Size = new Size(225, 26);
            deleteDepartmentToolStripMenuItem.Text = "Delete Department";
            deleteDepartmentToolStripMenuItem.Click += deleteDepartmentToolStripMenuItem_Click;
            // 
            // instructorToolStripMenuItem
            // 
            instructorToolStripMenuItem.BackColor = Color.Maroon;
            instructorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getInstructorsToolStripMenuItem, getInstructorToolStripMenuItem, addInstructorToolStripMenuItem, updateInstructorToolStripMenuItem, deleteInstructorToolStripMenuItem });
            instructorToolStripMenuItem.ForeColor = Color.White;
            instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            instructorToolStripMenuItem.Size = new Size(85, 24);
            instructorToolStripMenuItem.Text = "Instructor";
            // 
            // getInstructorsToolStripMenuItem
            // 
            getInstructorsToolStripMenuItem.Name = "getInstructorsToolStripMenuItem";
            getInstructorsToolStripMenuItem.Size = new Size(207, 26);
            getInstructorsToolStripMenuItem.Text = "Get Instructors";
            getInstructorsToolStripMenuItem.Click += getInstructorsToolStripMenuItem_Click;
            // 
            // getInstructorToolStripMenuItem
            // 
            getInstructorToolStripMenuItem.Name = "getInstructorToolStripMenuItem";
            getInstructorToolStripMenuItem.Size = new Size(207, 26);
            getInstructorToolStripMenuItem.Text = "Get Instructor";
            getInstructorToolStripMenuItem.Click += getInstructorToolStripMenuItem_Click;
            // 
            // addInstructorToolStripMenuItem
            // 
            addInstructorToolStripMenuItem.Name = "addInstructorToolStripMenuItem";
            addInstructorToolStripMenuItem.Size = new Size(207, 26);
            addInstructorToolStripMenuItem.Text = "Add Instructor";
            addInstructorToolStripMenuItem.Click += addInstructorToolStripMenuItem_Click;
            // 
            // updateInstructorToolStripMenuItem
            // 
            updateInstructorToolStripMenuItem.Name = "updateInstructorToolStripMenuItem";
            updateInstructorToolStripMenuItem.Size = new Size(207, 26);
            updateInstructorToolStripMenuItem.Text = "Update Instructor";
            updateInstructorToolStripMenuItem.Click += updateInstructorToolStripMenuItem_Click;
            // 
            // deleteInstructorToolStripMenuItem
            // 
            deleteInstructorToolStripMenuItem.Name = "deleteInstructorToolStripMenuItem";
            deleteInstructorToolStripMenuItem.Size = new Size(207, 26);
            deleteInstructorToolStripMenuItem.Text = "Delete Instructor";
            deleteInstructorToolStripMenuItem.Click += deleteInstructorToolStripMenuItem_Click;
            // 
            // courseSessionToolStripMenuItem
            // 
            courseSessionToolStripMenuItem.BackColor = Color.Maroon;
            courseSessionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getSessionsToolStripMenuItem, getSessionToolStripMenuItem, addSessionToolStripMenuItem, updateSessionToolStripMenuItem, deleteSessionToolStripMenuItem });
            courseSessionToolStripMenuItem.ForeColor = Color.White;
            courseSessionToolStripMenuItem.Name = "courseSessionToolStripMenuItem";
            courseSessionToolStripMenuItem.Size = new Size(121, 24);
            courseSessionToolStripMenuItem.Text = "Course Session";
            // 
            // getSessionsToolStripMenuItem
            // 
            getSessionsToolStripMenuItem.Name = "getSessionsToolStripMenuItem";
            getSessionsToolStripMenuItem.Size = new Size(194, 26);
            getSessionsToolStripMenuItem.Text = "Get Sessions";
            getSessionsToolStripMenuItem.Click += getSessionsToolStripMenuItem_Click;
            // 
            // getSessionToolStripMenuItem
            // 
            getSessionToolStripMenuItem.Name = "getSessionToolStripMenuItem";
            getSessionToolStripMenuItem.Size = new Size(194, 26);
            getSessionToolStripMenuItem.Text = "Get Session";
            getSessionToolStripMenuItem.Click += getSessionToolStripMenuItem_Click;
            // 
            // addSessionToolStripMenuItem
            // 
            addSessionToolStripMenuItem.Name = "addSessionToolStripMenuItem";
            addSessionToolStripMenuItem.Size = new Size(194, 26);
            addSessionToolStripMenuItem.Text = "Add Session";
            addSessionToolStripMenuItem.Click += addSessionToolStripMenuItem_Click;
            // 
            // updateSessionToolStripMenuItem
            // 
            updateSessionToolStripMenuItem.Name = "updateSessionToolStripMenuItem";
            updateSessionToolStripMenuItem.Size = new Size(194, 26);
            updateSessionToolStripMenuItem.Text = "Update Session";
            updateSessionToolStripMenuItem.Click += updateSessionToolStripMenuItem_Click;
            // 
            // deleteSessionToolStripMenuItem
            // 
            deleteSessionToolStripMenuItem.Name = "deleteSessionToolStripMenuItem";
            deleteSessionToolStripMenuItem.Size = new Size(194, 26);
            deleteSessionToolStripMenuItem.Text = "Delete Session";
            deleteSessionToolStripMenuItem.Click += deleteSessionToolStripMenuItem_Click;
            // 
            // courseSessionsAttdToolStripMenuItem
            // 
            courseSessionsAttdToolStripMenuItem.BackColor = Color.Maroon;
            courseSessionsAttdToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { getAttendacesToolStripMenuItem, getAttendanceToolStripMenuItem, addAttendanceToolStripMenuItem, updateAttendanceToolStripMenuItem, deleteAttendanceToolStripMenuItem });
            courseSessionsAttdToolStripMenuItem.ForeColor = Color.White;
            courseSessionsAttdToolStripMenuItem.Name = "courseSessionsAttdToolStripMenuItem";
            courseSessionsAttdToolStripMenuItem.Size = new Size(207, 24);
            courseSessionsAttdToolStripMenuItem.Text = "Course Sessions Attendance";
            // 
            // getAttendacesToolStripMenuItem
            // 
            getAttendacesToolStripMenuItem.Name = "getAttendacesToolStripMenuItem";
            getAttendacesToolStripMenuItem.Size = new Size(224, 26);
            getAttendacesToolStripMenuItem.Text = "Get Attendaces";
            getAttendacesToolStripMenuItem.Click += getAttendacesToolStripMenuItem_Click;
            // 
            // getAttendanceToolStripMenuItem
            // 
            getAttendanceToolStripMenuItem.Name = "getAttendanceToolStripMenuItem";
            getAttendanceToolStripMenuItem.Size = new Size(224, 26);
            getAttendanceToolStripMenuItem.Text = "Get Attendance";
            getAttendanceToolStripMenuItem.Click += getAttendanceToolStripMenuItem_Click;
            // 
            // addAttendanceToolStripMenuItem
            // 
            addAttendanceToolStripMenuItem.Name = "addAttendanceToolStripMenuItem";
            addAttendanceToolStripMenuItem.Size = new Size(224, 26);
            addAttendanceToolStripMenuItem.Text = "Add Attendance";
            addAttendanceToolStripMenuItem.Click += addAttendanceToolStripMenuItem_Click;
            // 
            // updateAttendanceToolStripMenuItem
            // 
            updateAttendanceToolStripMenuItem.Name = "updateAttendanceToolStripMenuItem";
            updateAttendanceToolStripMenuItem.Size = new Size(224, 26);
            updateAttendanceToolStripMenuItem.Text = "Update Attendance";
            updateAttendanceToolStripMenuItem.Click += updateAttendanceToolStripMenuItem_Click;
            // 
            // deleteAttendanceToolStripMenuItem
            // 
            deleteAttendanceToolStripMenuItem.Name = "deleteAttendanceToolStripMenuItem";
            deleteAttendanceToolStripMenuItem.Size = new Size(224, 26);
            deleteAttendanceToolStripMenuItem.Text = "Delete Attendance";
            deleteAttendanceToolStripMenuItem.Click += deleteAttendanceToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.ForeColor = Color.White;
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(64, 24);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // StartScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(EnterBtn);
            Controls.Add(label1);
            Controls.Add(studentStrip);
            Name = "StartScreen";
            Text = "Form1";
            studentStrip.ResumeLayout(false);
            studentStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button EnterBtn;
        private MenuStrip studentStrip;
        private ToolStripMenuItem studentsToolStripMenuItem;
        private ToolStripMenuItem allStudentsToolStripMenuItem;
        private ToolStripMenuItem getStudentToolStripMenuItem;
        private ToolStripMenuItem updateStudentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem deleteStudentToolStripMenuItem;
        private ToolStripMenuItem coursesToolStripMenuItem;
        private ToolStripMenuItem departmentToolStripMenuItem;
        private ToolStripMenuItem instructorToolStripMenuItem;
        private ToolStripMenuItem courseSessionToolStripMenuItem;
        private ToolStripMenuItem courseSessionsAttdToolStripMenuItem;
        private ToolStripMenuItem getCoursesToolStripMenuItem;
        private ToolStripMenuItem getCourseToolStripMenuItem;
        private ToolStripMenuItem addCourseToolStripMenuItem;
        private ToolStripMenuItem deleteCourseToolStripMenuItem;
        private ToolStripMenuItem updateCourseToolStripMenuItem;
        private ToolStripMenuItem getDepartmentToolStripMenuItem;
        private ToolStripMenuItem getDToolStripMenuItem;
        private ToolStripMenuItem addDepartmentToolStripMenuItem;
        private ToolStripMenuItem updateDepartmentToolStripMenuItem;
        private ToolStripMenuItem deleteDepartmentToolStripMenuItem;
        private ToolStripMenuItem getInstructorsToolStripMenuItem;
        private ToolStripMenuItem getInstructorToolStripMenuItem;
        private ToolStripMenuItem addInstructorToolStripMenuItem;
        private ToolStripMenuItem updateInstructorToolStripMenuItem;
        private ToolStripMenuItem deleteInstructorToolStripMenuItem;
        private ToolStripMenuItem getSessionsToolStripMenuItem;
        private ToolStripMenuItem getSessionToolStripMenuItem;
        private ToolStripMenuItem addSessionToolStripMenuItem;
        private ToolStripMenuItem updateSessionToolStripMenuItem;
        private ToolStripMenuItem deleteSessionToolStripMenuItem;
        private ToolStripMenuItem getAttendacesToolStripMenuItem;
        private ToolStripMenuItem getAttendanceToolStripMenuItem;
        private ToolStripMenuItem addAttendanceToolStripMenuItem;
        private ToolStripMenuItem updateAttendanceToolStripMenuItem;
        private ToolStripMenuItem deleteAttendanceToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
    }
}
