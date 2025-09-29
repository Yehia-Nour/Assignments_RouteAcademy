using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF03.Models;

internal class StudCourse
{
    public int StudentId { get; set; }
    public virtual Student Student { get; set; }
    public int CourseId { get; set; }
    public virtual Course Course { get; set; }
    public int Grade { get; set; }
}
