using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP04.Overriding
{
    internal class TypeA
    {
        public int A { get; set; }

        public TypeA(int a)
        {
            A = a;
        }

        public void MyFun01()
        {
            Console.WriteLine("I am Base");
        }

        public virtual void MyFun02()
        {
            Console.WriteLine($"Type A - A = {A}");
        }
    }
}
