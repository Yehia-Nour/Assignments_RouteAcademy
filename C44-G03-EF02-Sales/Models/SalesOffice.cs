using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Sales.Models
{
    public class SalesOffice
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Location { get; set; }

        public ICollection<Property> Properties { get; set; } = new List<Property>();
        public ICollection<Employee> Employees { get; set; } = new List<Employee>();
        public int? ManagerId { get; set; }
        public Employee Manager { get; set; }
    }

}
