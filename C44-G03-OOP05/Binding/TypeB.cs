﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binding
{
    internal class TypeB : TypeA
    {
        public int B { get; set; }
        public TypeB(int a, int b) : base(a)
        {
            B = b;
        }
        public new void MyFun01()
        {
            Console.WriteLine("I am Derived [Child]");
        }
        public override void MyFun02()
        {
            Console.WriteLine($"Type B - A = {A}, B = {B}");
        }
    }
}
