using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    public class Student
    {
        [Key]
        public int St_ID { get; set; }
        [MaxLength(255)]
        public string? St_FName { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? St_LName { get; set; } = string.Empty;
        [MaxLength(255)]
        public string? St_Phone { get; set; } = string.Empty;
        public virtual ICollection<StdCrs> Std_Courses { get; set; } = new HashSet<StdCrs>();
        public virtual ICollection<CourseSessionAttendance> CrsSAs { get; set; } = new HashSet<CourseSessionAttendance>();

        public override string ToString()
        {
            return $"ID: {St_ID} | Name: {St_FName} {St_LName} | Phone: {St_Phone}";
        }
    }
}
