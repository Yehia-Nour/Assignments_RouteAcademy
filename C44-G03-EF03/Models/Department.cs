using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF03.Models;

internal class Department
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int InstructorId { get; set; }
    public virtual Instructor Instructor { get; set; }
    public DateTime HiringDate { get; set; }
    public virtual ICollection<Student> Students { get; set; } = new HashSet<Student>();
    public virtual ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();
}
