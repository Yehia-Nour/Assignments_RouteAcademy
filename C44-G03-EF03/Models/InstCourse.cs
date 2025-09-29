using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF03.Models;

internal class InstCourse
{
    public int InstructorId { get; set; }
    public virtual Instructor Instructor { get; set; }
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }
    public int Evaluate {  get; set; }
}
