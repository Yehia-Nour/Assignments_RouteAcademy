using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF01.Models
{
    internal class Course
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Description { get; set; }
        public string Duration { get; set; }
        public int Top_Id { get; set; }
    }
}
