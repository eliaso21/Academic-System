using SchoolSystemProject.Context;
using SchoolSystemProject.Forms;
using SchoolSystemProject.Forms.Courses;
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
    }
}
