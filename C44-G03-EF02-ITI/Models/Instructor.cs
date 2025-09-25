using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_ITI.Models
{
    internal class Instructor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Bouns { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public int HourRate { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public Department ManagedDepartment { get; set; }
        public ICollection<InstCourse> InstCourse { get; set; } = new HashSet<InstCourse>();
    }
}
