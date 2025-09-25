using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Airline.Models
{
    internal class Route
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Distance { get; set; }
        public string Destination { get; set; }
        public string Orgin { get; set; }
        public string Classification { get; set; }
        public ICollection<AirCraft> AirCrafts { get; set; } = new HashSet<AirCraft>();
    }
}
