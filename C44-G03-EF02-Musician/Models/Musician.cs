using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Musician.Models
{
    public class Musician
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }

        public ICollection<Album> Albums { get; set; } = new List<Album>();
        public ICollection<Song> Songs { get; set; } = new List<Song>();
        public ICollection<Instrument> Instruments { get; set; } = new List<Instrument>();
    }

}
