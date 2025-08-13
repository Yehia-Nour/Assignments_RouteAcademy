using C44_G03_OOP06.Third_Project.Abstract_Discount_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP06.Third_Project
{
    public class BuyOneGetOneDiscount : Discount
    {
        public BuyOneGetOneDiscount()
        {
            Name = "Buy One Get One 50% Off";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            if (quantity > 1)
            {
                return (price / 2) * (quantity / 2); 
            }
            return 0;
        }
    }
}
