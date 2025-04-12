using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolSystemProject.Models
{
    public class Department
    {
        [Key]
        public int Dept_ID { get; set; }
        [MaxLength(255)]
        public required string Dept_Name { get; set; }
        [MaxLength(255)]
        public string? Dept_Location { get; set; } = string.Empty;
        [ForeignKey("InstructorsMng")]
        public int? ManagerID { get; set; }
        public virtual Instructor? InstructorsMng { get; set; } = null!;
        public virtual ICollection<Course> Courses { get; set; } = new HashSet<Course>();
        public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        public override string ToString()
        {
            return Dept_Name;
        }
    }
}
