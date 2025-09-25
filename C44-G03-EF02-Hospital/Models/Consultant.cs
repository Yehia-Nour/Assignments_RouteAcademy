using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Models
{
    public class Consultant
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public ICollection<Patient> PatientsExamine { get; set; } = new HashSet<Patient>();
        public ICollection<Patient> PatientsAssigne { get; set; } = new HashSet<Patient>();

    }

}
