using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Musician.Models
{
    public class Album
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Date { get; set; }
        public int MusicianId { get; set; }
        public Musician Musician { get; set; }

        public ICollection<Song> Songs { get; set; } = new List<Song>();
    }

}
