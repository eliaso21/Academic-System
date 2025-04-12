using SchoolSystemProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Repo
{
    public class Data
    {
        public static List<Student> getStuds()
        {
            return new List<Student>()
            {
                new Student {St_ID = 1, St_FName = "Mohamed", St_LName = "Abdelsadek", St_Phone = "01555384156"},
                new Student {St_ID = 2, St_FName = "Ammar", St_LName = "Atef", St_Phone = "01289658512"},
                new Student {St_ID = 3, St_FName = "Ahmed", St_LName = "Nasr", St_Phone = "01123659863"},
                new Student {St_ID = 4, St_FName = "Youssef", St_LName = "Abdelgawad", St_Phone = "010301456852"},
                new Student {St_ID = 5, St_FName = "Abdelrahman", St_LName = "Eletr", St_Phone = "01147845632"},
                new Student {St_ID = 6, St_FName = "Ahmed", St_LName = "Elsakka", St_Phone = "01214568122"},
                new Student {St_ID = 7, St_FName = "Omar", St_LName = "Shanshan", St_Phone = "01010487861"},
                new Student {St_ID = 8, St_FName = "Abdallah", St_LName = "Khaled", St_Phone = "01123659866"},
                new Student {St_ID = 9, St_FName = "Mohamed", St_LName = "Ghareeb", St_Phone = "01155440123"},
                new Student {St_ID = 10, St_FName = "Sayed", St_LName = "Abdelhafiz", St_Phone = "01550507768"},
            };
        }
        public static List<Instructor> getInsts()
        {
            return new List<Instructor>()
            {
                new Instructor {InsID = 1, InsFName = "Mohamed",InsLName = "Elmalaky",Phone = "01016297668", Salary = 6000, Dept_ID = 1},
                new Instructor {InsID = 2, InsFName = "Beshoy",InsLName = "Emad",Phone = "01004190041", Salary = 10000, Dept_ID = 1},
                new Instructor {InsID = 3, InsFName = "Mando",InsLName = "Saad",Phone = "01550507768", Salary = 3000, Dept_ID = 2},
                new Instructor {InsID = 4, InsFName = "Mohamed",InsLName = "Elhadary",Phone = "01010556101", Salary = 2000, Dept_ID = 1},
                new Instructor {InsID = 5, InsFName = "Yasmin",InsLName = "Raeis",Phone = "01004117122", Salary = 6000, Dept_ID = 2},
                new Instructor {InsID = 6, InsFName = "Yaser",InsLName = "Arafat",Phone = "01100488122", Salary = 9000, Dept_ID = 3},
            };
        }
        public static List<Department> getDepts()
        {
            return new List<Department>()
            {
                new Department {Dept_ID = 1, Dept_Name = "SD", Dept_Location = "Ismailia Branch Building, 2nd Floor"},
                new Department {Dept_ID = 2, Dept_Name = "UI", Dept_Location = "Ismailia Branch Building, 2nd Floor"},
                new Department {Dept_ID = 3, Dept_Name = "Cloud", Dept_Location = "Ismailia Branch Building, 2nd Floor"},
            };
        }
        public static List<Course> getCrs()
        {
            return new List<Course>()
            {
                new Course {CrsID = 1, CrsName = "HTML", CrsDuration = 2, InsID = 3, DeptID = 2},
                new Course {CrsID = 2, CrsName = "CSS", CrsDuration = 2, InsID = 3, DeptID = 2},
                new Course {CrsID = 3, CrsName = "JS", CrsDuration = 2, InsID = 1, DeptID = 1},
                new Course {CrsID = 4, CrsName = "OOP", CrsDuration = 2, InsID = 1, DeptID = 1},
                new Course {CrsID = 5, CrsName = "Bootstrap", CrsDuration = 2, InsID = 4, DeptID = 1},
                new Course {CrsID = 6, CrsName = "OS", CrsDuration = 2, InsID = 2, DeptID = 1},
                new Course {CrsID = 7, CrsName = "Network", CrsDuration = 2, InsID = 2, DeptID = 2},
                new Course {CrsID = 8, CrsName = "JAVA", CrsDuration = 2, InsID = 3, DeptID = 2},
                new Course {CrsID = 9, CrsName = ".NET", CrsDuration = 2, InsID = 1, DeptID = 1},
                new Course {CrsID = 10, CrsName = "Kotlin", CrsDuration = 2, InsID = 5, DeptID = 3},
            };
        }
        public static List<CourseSession> getCrsSessions()
        {
            return new List<CourseSession>()
            {
                new CourseSession {CrsSID = 1, CrsID = 1,InsID = 3,Title = "Intro to HTML", Date = new DateTime(2020,5,4)},
                new CourseSession {CrsSID = 2, CrsID = 2,InsID = 3,Title = "Intro to CSS", Date = new DateTime(2023,11,11)},
                new CourseSession {CrsSID = 3, CrsID = 3,InsID = 1,Title = "Intro to JS", Date = new DateTime(2024,1,14)},
                new CourseSession {CrsSID = 4, CrsID = 4,InsID = 1,Title = "Intro to OOP", Date = new DateTime(2025,12,1)},
                new CourseSession {CrsSID = 5, CrsID = 5,InsID = 4,Title = "Intro to Bootstrap", Date = new DateTime(2021,3,5)},
                new CourseSession {CrsSID = 6, CrsID = 10,InsID = 5,Title = "Intro to Kotlin", Date = new DateTime(2025,10,19)},
            };
        }
        public static List<CourseSessionAttendance> getCrsSessionAtts()
        {
            return new List<CourseSessionAttendance>()
            {
                new CourseSessionAttendance {CrsSAID = 1, StdID = 1,CrsSessionID = 1},
                new CourseSessionAttendance {CrsSAID = 2, StdID = 1,CrsSessionID = 2},
                new CourseSessionAttendance {CrsSAID = 3, StdID = 1,CrsSessionID = 3},
                new CourseSessionAttendance {CrsSAID = 4, StdID = 2,CrsSessionID = 5},
                new CourseSessionAttendance {CrsSAID = 5, StdID = 2,CrsSessionID = 4},
                new CourseSessionAttendance {CrsSAID = 6, StdID = 3,CrsSessionID = 1},
                new CourseSessionAttendance {CrsSAID = 7, StdID = 4,CrsSessionID = 2},
                new CourseSessionAttendance {CrsSAID = 8, StdID = 4,CrsSessionID = 6},
                new CourseSessionAttendance {CrsSAID = 9, StdID = 5,CrsSessionID = 6},
                new CourseSessionAttendance {CrsSAID = 10, StdID = 5,CrsSessionID = 3},
                new CourseSessionAttendance {CrsSAID = 11, StdID = 5,CrsSessionID = 2},
                new CourseSessionAttendance {CrsSAID = 12, StdID = 5,CrsSessionID = 1},
            };
        }
        public static List<StdCrs> getStdCrs()
        {
            return new List<StdCrs>()
            {
                new StdCrs {StdID = 1,CrsID = 1},
                new StdCrs {StdID = 1,CrsID = 2},
                new StdCrs {StdID = 1,CrsID = 3},
                new StdCrs {StdID = 2,CrsID = 5},
                new StdCrs {StdID = 2,CrsID = 4},
                new StdCrs {StdID = 3,CrsID = 1},
                new StdCrs {StdID = 4,CrsID = 10},
                new StdCrs {StdID = 4,CrsID = 6},
                new StdCrs {StdID = 5,CrsID = 6},
                new StdCrs {StdID = 5,CrsID = 7},
                new StdCrs {StdID = 5,CrsID = 2},
                new StdCrs {StdID = 5,CrsID = 1},
            };
        }
    }
}
