using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_03
{
    internal class Car : Vehicle, IMoveable
    {
        public void Backward()
        {
            Console.WriteLine("Car Move Backward on Ground");
        }

        public void Forward()
        {
            Console.WriteLine("Car Move Forward on Ground");
        }

        public void Left()
        {
            throw new NotImplementedException();
        }

        public void Right()
        {
            throw new NotImplementedException();
        }
    }
}
