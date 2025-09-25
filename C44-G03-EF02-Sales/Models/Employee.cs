using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Sales.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<SalesOffice> SalesOffices { get; set; } = new List<SalesOffice>();
        public SalesOffice ManagedOffice { get; set; }
    }

}
