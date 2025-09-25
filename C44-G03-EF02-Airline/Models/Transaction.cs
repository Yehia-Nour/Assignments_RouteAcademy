using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Airline.Models
{
    internal class Transaction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateOnly Date {  get; set; }
        public int Amount { get; set; }
        public int AirlineId { get; set; }
        public Airline Airline { get; set; }
    }
}
