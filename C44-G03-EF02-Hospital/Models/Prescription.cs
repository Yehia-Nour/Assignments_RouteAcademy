using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Models
{
    public class Prescription
    {
        public int Id { get; set; }

        public int PatientId { get; set; }
        public int NurseId { get; set; }
        public int DrugId { get; set; }

        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public string Dosage { get; set; } = null!;

        public Patient Patient { get; set; } = null!;
        public Nurse Nurse { get; set; } = null!;
        public Drug Drug { get; set; } = null!;
    }
}
