using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Airline.Models
{
    internal class AirCraft
    {
        public int Id {  get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public Crew Crew { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }
        public ICollection<Route> Routes { get; set; } = new HashSet<Route>();
    }
}
