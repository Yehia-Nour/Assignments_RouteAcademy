﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP06.Second_Project
{
    internal class Math
    {
        public class Maths
        {
            public static double Add(double a, double b)
            {
                return a + b;
            }

            public static double Subtract(double a, double b)
            {
                return a - b;
            }

            public static double Multiply(double a, double b)
            {
                return a * b;
            }

            public static double Divide(double a, double b)
            {
                if (b == 0)
                {
                    Console.WriteLine("Error: Division by zero!");
                    return double.NaN;
                }
                return a / b;
            }
        }
    }
}
