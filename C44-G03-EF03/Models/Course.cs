using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF03.Models;

    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Duration { get; set; }
        public int TopicId { get; set; }
        public virtual Topic Topic { get; set; }
        public virtual ICollection<StudCourse> StudCourse { get; set; } = new HashSet<StudCourse>();
        public virtual ICollection<InstCourse> InstCourse { get; set; } = new HashSet<InstCourse>();

    }
