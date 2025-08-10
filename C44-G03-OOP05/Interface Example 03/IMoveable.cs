using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Example_03
{
    internal interface IMoveable
    {
        public void Forward();
        public void Backward();
        public void Left();
        public void Right();
    }
}
