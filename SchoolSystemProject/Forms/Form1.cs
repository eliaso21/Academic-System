using SchoolSystemProject.Context;
using SchoolSystemProject.Forms;
using SchoolSystemProject.Forms.Courses;
using SchoolSystemProject.Forms.CourseSession;
using SchoolSystemProject.Forms.Departments;
using SchoolSystemProject.Forms.Instructor;
using SchoolSystemProject.Models;

namespace SchoolSystemProject
{
    public partial class StartScreen : Form
    {
        private DatabaseContext db;


        public StartScreen()
        {
            InitializeComponent();
            db = new DatabaseContext();
            studentStrip.Visible = false;

        }


        private void EnterBtn_Click(object sender, EventArgs e)
        {
            EnterBtn.Visible = false;
            label1.Visible = false;
            studentStrip.Visible = true;

        }

        private void allStudentsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FirstPage firstPage = new FirstPage();
            firstPage.ShowDialog();
        }
        private void getStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetStudentForm getStudentForm = new GetStudentForm();
            getStudentForm.ShowDialog();
        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateStudent updateStudent = new UpdateStudent();
            updateStudent.ShowDialog();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteStudent deleteStudent = new DeleteStudent();
            deleteStudent.ShowDialog();
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.ShowDialog();
        }

        private void getCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCoursesForm getCoursesForm = new GetCoursesForm();
            getCoursesForm.ShowDialog();
        }

        private void getCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetCourseform getCourseform = new GetCourseform();
            getCourseform.ShowDialog();
        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCourseForm addCourseForm = new AddCourseForm();
            addCourseForm.ShowDialog();
        }

        private void deleteCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCourseForm deleteCourseForm = new DeleteCourseForm();
            deleteCourseForm.ShowDialog();
        }

        private void updateCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateCourse updateCourse = new UpdateCourse();
            updateCourse.ShowDialog();
        }

        private void getDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDepartmentsForm getDepartmentsForm = new GetDepartmentsForm();
            getDepartmentsForm.ShowDialog();
        }

        private void getDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetDepartment getDepartment = new GetDepartment();
            getDepartment.ShowDialog();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDepartmentForm addDepartmentForm = new AddDepartmentForm();
            addDepartmentForm.ShowDialog();
        }

        private void updateDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateDepartment updateDepartment = new UpdateDepartment();
            updateDepartment.ShowDialog();
        }

        private void deleteDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteDepartmentForm deleteDepartmentForm = new DeleteDepartmentForm();
            deleteDepartmentForm.ShowDialog();
        }

        private void getInstructorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetInstructorsForm getInstructors = new GetInstructorsForm();
            getInstructors.ShowDialog();
        }

        private void getInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetInstructorForm getInstructor = new GetInstructorForm();
            getInstructor.ShowDialog();
        }

        private void addInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInstructor addInstructor = new AddInstructor();
            addInstructor.ShowDialog();
        }

        private void updateInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateInstructor updateInstructor = new UpdateInstructor();
            updateInstructor.ShowDialog();
        }

        private void deleteInstructorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteInstructor deleteInstructor = new DeleteInstructor();
            deleteInstructor.ShowDialog();
        }

        private void getSessionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSessions getSessions = new GetSessions();
            getSessions.ShowDialog();
        }

        private void getSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetSession getSession = new GetSession();
            getSession.ShowDialog();
        }

        private void addSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSession addSession = new AddSession();
            addSession.ShowDialog();
        }

        private void updateSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateSession updateSession = new UpdateSession();
            updateSession.ShowDialog();
        }

        private void deleteSessionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteSession deleteSession = new DeleteSession();
            deleteSession.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }
    }
}
