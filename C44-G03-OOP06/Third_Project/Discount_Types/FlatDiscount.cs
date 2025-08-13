using C44_G03_OOP06.Third_Project.Abstract_Discount_Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP06.Third_Project
{
    public class FlatDiscount : Discount
    {
        public decimal FlatAmount { get; set; }

        public FlatDiscount(decimal flatAmount)
        {
            FlatAmount = flatAmount;
            Name = $"Flat Discount of {flatAmount:C}";
        }

        public override decimal CalculateDiscount(decimal price, int quantity)
        {
            return FlatAmount * Math.Min(quantity, 1);
        }
    }
}
