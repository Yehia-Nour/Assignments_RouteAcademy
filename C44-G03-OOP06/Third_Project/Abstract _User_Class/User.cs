using C44_G03_OOP06.Third_Project.Abstract_Discount_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP06.Third_Project.Abstract__User_Class
{
    public abstract class User
    {
        public string Name { get; set; }
        public abstract Discount GetDiscount();
    }
}
