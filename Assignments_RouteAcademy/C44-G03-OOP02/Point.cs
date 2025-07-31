using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02G03
{
    internal struct Point
    {
        #region Attributes
        public int X;
        public int Y;
        #endregion

        #region Constructor
        // Constructor is A special Function
        // 1. Named As Type(Struct, Class)
        // 2. Has No Return Type
        #region Constructor Overloading
        public Point()
        {
            X = default;
            Y = default;
        }

        public Point(int n)
        {
            X = n;
            Y = n;
            //X = Y = n;
        }

        public Point(int x, int y)
        {
            X = x;
            this.Y = y;
        }
        #endregion 
        #endregion

        #region Methods
        public override string ToString()
        {
            // Day02G03.Point
            return $"({X},{Y})";
        } 
        #endregion
    }
}
