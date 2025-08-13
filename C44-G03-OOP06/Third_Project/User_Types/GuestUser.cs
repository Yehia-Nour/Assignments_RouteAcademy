using C44_G03_OOP06.Third_Project.Abstract__User_Class;
using C44_G03_OOP06.Third_Project.Abstract_Discount_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C44_G03_OOP06.Third_Project.Specific_User_Types
{
    public class GuestUser : User
    {
        public GuestUser(string name)
        {
            Name = name;
        }

        public override Discount GetDiscount()
        {
            return null;
        }
    }
}
