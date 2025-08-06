using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_OOP04
{
    internal class Complex
    {
        #region Properties
        public int Real { get; set; }
        public int Imag { get; set; }
        #endregion

        #region Binary Operators
        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) + (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) + (right?.Imag ?? 0)
            };
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex()
            {
                Real = (left?.Real ?? 0) - (right?.Real ?? 0),
                Imag = (left?.Imag ?? 0) - (right?.Imag ?? 0)
            };
        }
        #endregion

        #region Unary Operators
        public static Complex operator ++(Complex c)
        {
            if (c is not null)
            {
                c.Real++;
            }

            return c;
            //return new Complex()
            //{
            //    Real = (c?.Real ?? 0) + 1,
            //    Imag = c?.Imag ?? 0
            //};
        }

        public static Complex operator --(Complex c)
        {
            if (c is not null)
            {
                c.Real--;
            }

            return c;
            //return new Complex()
            //{
            //    Real = (c?.Real ?? 0) - 1,
            //    Imag = c?.Imag ?? 0
            //};
        }
        #endregion

        #region Relational Operators
        public static bool operator >(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
            {
                return left?.Imag > right?.Imag;
            }
            return left?.Real > right?.Real;
        }

        public static bool operator <(Complex left, Complex right)
        {
            if (left?.Real == right?.Real)
            {
                return left?.Imag < right?.Imag;
            }
            return left?.Real < right?.Real;
        }
        #endregion

        #region Casting Operators
        public static /*int*/ explicit operator int(Complex c)
        {
            return c?.Real ?? 0;
        }

        public static /*string*/ implicit operator string(Complex c)
        {
            return c?.ToString() ?? string.Empty;
        } 
        #endregion
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }
}
