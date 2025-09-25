using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public DateTime DOB { get; set; }
        public int ConsultantId { get; set; }
        public Consultant Consultant { get; set; }
        public ICollection<Consultant> Consultants { get; set; } = new HashSet<Consultant>(); 
        public int WardId { get; set; }
        public Ward Ward { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();

    }

}
