using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_03
{
    internal class AirPlane : Vehicle, IMoveable, IFlyable
    {
        public void Backward() // Implicitly
        {
            Console.WriteLine("AirPlane move Backward");
        }
        void IMoveable.Forward() // Explicitly
        {
            Console.WriteLine("AirPlane move Forward on Ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("AirPlane move Forward on Air");
        }

        void IMoveable.Left()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Left()
        {
            throw new NotImplementedException();
        }

        void IMoveable.Right()
        {
            throw new NotImplementedException();
        }

        void IFlyable.Right()
        {
            throw new NotImplementedException();
        }
    }
}
