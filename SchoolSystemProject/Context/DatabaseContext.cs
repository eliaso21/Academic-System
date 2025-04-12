using Microsoft.EntityFrameworkCore;
using SchoolSystemProject.Models;
using SchoolSystemProject.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SchoolSystemProject.Context
{
    public class DatabaseContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=ELIASO\\MO;DataBase=AcademySystem;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<StdCrs>().HasKey(sc => new { sc.StdID, sc.CrsID });

            modelBuilder.Entity<Department>()
                .HasMany(d => d.Instructors)
                .WithOne(i => i.Department)
                .HasForeignKey(i => i.Dept_ID);

            modelBuilder.Entity<Department>()
                .HasOne(d => d.InstructorsMng)
                .WithOne(i => i.ManagedAt)
                .HasForeignKey<Department>(d => d.ManagerID);



            modelBuilder.Entity<Student>().HasData(Data.getStuds());
            modelBuilder.Entity<Instructor>().HasData(Data.getInsts());
            modelBuilder.Entity<Department>().HasData(Data.getDepts());
            modelBuilder.Entity<Course>().HasData(Data.getCrs());
            modelBuilder.Entity<CourseSession>().HasData(Data.getCrsSessions());
            modelBuilder.Entity<CourseSessionAttendance>().HasData(Data.getCrsSessionAtts());
            modelBuilder.Entity<StdCrs>().HasData(Data.getStdCrs());

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<CourseSession> Crs_Sessions { get; set; }
        public virtual DbSet<Instructor> Instructors { get; set; }
        public virtual DbSet<StdCrs> Std_Courses { get; set; }
        public virtual DbSet<CourseSessionAttendance> CrsSessionAtts { get; set; }
    
}
}
