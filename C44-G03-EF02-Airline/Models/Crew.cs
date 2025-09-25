using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Airline.Models
{
    internal class Crew
    {
        public int AirCraftId { get; set; }
        public string MajPilot { get; set; }
        public string AssisPilot { get; set; }
        public string Host1 { get; set; }
        public string Host2 { get; set; }
        public AirCraft AirCraft { get; set; }
    }
}
