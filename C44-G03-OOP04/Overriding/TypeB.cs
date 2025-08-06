using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP04.Overriding
{
    internal class TypeB : TypeA
    {
        //public int A { get; set; }
        public int B { get; set; }

        public TypeB(int a, int b) : base(a)
        {
            //A = a;
            B = b;
        }

        public new void MyFun01()
        {
            Console.WriteLine("I am Derived");
        }

        public override void MyFun02()
        {
            Console.WriteLine($"Type B - A = {A}, B = {B}");
        }
    }
}
