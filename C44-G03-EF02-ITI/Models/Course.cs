using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_ITI.Models
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int TopicId { get; set; }
        public Topic Topic { get; set; }
        public ICollection<StudCourse> StudCourse { get; set; } = new HashSet<StudCourse>();
        public ICollection<InstCourse> InstCourse { get; set; } = new HashSet<InstCourse>();

    }
}
