using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_01
{
    // Developer 02
    internal class MyType : IMyType /*: => Implements*/
    {
        private int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }
        public void MyFun()
        {
            Console.WriteLine("Hello World");
        }
    }
}
