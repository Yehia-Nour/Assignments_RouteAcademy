using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF01.Models
{
    internal class Department
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        [Required]
        public string? Name { get; set; }
        public int Ins_Id { get; set; }
        public DateTime HiringDate { get; set; }
        public List<Student> Students { get; set; }
    }
}
