using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Hospital.Models
{
    public class Nurse
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string Number { get; set; } = null!;
        public int WardId {  get; set; }
        public Ward Ward { get; set; }
        public Ward WardManage { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; } = new HashSet<Prescription>();
    }
}
