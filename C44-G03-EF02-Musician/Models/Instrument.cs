using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Musician.Models
{
    public class Instrument
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Key { get; set; }
        public ICollection<Musician> Musicians { get; set; } = new List<Musician>();
    }

}
