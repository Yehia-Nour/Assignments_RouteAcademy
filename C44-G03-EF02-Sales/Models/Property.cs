using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Sales.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public int SalesOfficeId { get; set; }
        public SalesOffice SalesOffice { get; set; }
        public ICollection<Owner> Owners { get; set; } = new List<Owner>();
    }

}
