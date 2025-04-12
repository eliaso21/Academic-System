using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    public class Course
    {
        [Key]
        public int CrsID { get; set; }
        [MaxLength(255)]
        public string? CrsName { get; set; } = string.Empty;
        public int? CrsDuration { get; set; }
        [ForeignKey("Department")]
        public int DeptID { get; set; }

        //[NotMapped]
        public virtual Department Department { get; set; } = null!;
        [ForeignKey("Instructor")]
        public int InsID { get; set; }

        //[NotMapped]
        public virtual Instructor Instructor { get; set; } = null!;
        public virtual ICollection<StdCrs> Std_Courses { get; set; } = new HashSet<StdCrs>();
        public virtual ICollection<CourseSession> CourseSessions { get; set; } = new HashSet<CourseSession>();


    }
}
