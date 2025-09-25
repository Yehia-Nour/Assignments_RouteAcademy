using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Models
{
    public class Drug
    {
        public int Id { get; set; } 
        public string Name { get; set; } = null!;
        public string Brand { get; set; } = null!;
        public string Dosage { get; set; } = null!;

        public ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();
    }

}
