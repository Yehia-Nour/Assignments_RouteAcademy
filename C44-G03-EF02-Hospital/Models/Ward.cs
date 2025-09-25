using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Models
{
    public class Ward
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public int NurseId { get; set; }
        public Nurse Nurse { get; set; }
        public ICollection<Patient> Patients { get; set; } = new HashSet<Patient>(); 
        public ICollection<Nurse> Nurses { get; set; } = new HashSet<Nurse>();
    }

}
