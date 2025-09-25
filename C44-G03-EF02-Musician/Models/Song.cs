using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Musician.Models
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public int AlbumId { get; set; }
        public Album Album { get; set; }

        public ICollection<Musician> Musicians { get; set; } = new List<Musician>();
    }

}
