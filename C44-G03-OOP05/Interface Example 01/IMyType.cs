using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_01
{
    // Developer 01
    internal interface IMyType
    {
        // 1. Signature for Property
        public int Salary { get; set; } // Compiler will not generate Packing field
        // 2. Signature for method
        public void MyFun();
        // 3. Default Implemented Method => C# 8.0 [.Net Core 3.1(2019)]
        public void Print()
        {
            Console.WriteLine("Hello Default Implemented Method");
        }
        // 4. Default Implemented Property => C# 8.0 [.Net Core 3.1(2019)]
        public string SayHello
        {
            get
            {
                return "Say Hello";
            }
        }
    }
}
