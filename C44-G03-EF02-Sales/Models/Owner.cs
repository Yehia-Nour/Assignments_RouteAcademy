using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_EF02_Sales.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Property> Properties { get; set; } = new List<Property>();
    }

}
