using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF01.Models
{
    [PrimaryKey("Inst_Id", "Course_Id")]
    internal class Course_Inst
    {
        public int Inst_Id { get; set; }
        public int Course_Id { get; set; }
        public int Evaluate {  get; set; }
    }
}
