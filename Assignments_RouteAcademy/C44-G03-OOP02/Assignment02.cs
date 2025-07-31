using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_OOP02
{
    internal class Assignment02
    {
        #region Q1

        public struct Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Person(string name, int age)
            {
                Name = name;
                Age = age;
            }

            public override string ToString()
            {
                return $"Name: {Name}, Age: {Age}";
            }
        }


        #endregion

        #region Q2
        public struct Point
        {
            public double X { get; set; }
            public double Y { get; set; }

            public Point(double x, double y)
            {
                X = x;
                Y = y;
            }
            public double DistanceTo(Point other)
            {
                double dx = X - other.X;
                double dy = Y - other.Y;
                return Math.Sqrt(dx * dx + dy * dy);
            }
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        #endregion

        #region Q3 
        public struct Person2
        {
            public string Name { get; set;}
            public int Age { get; set;}
            public Person2(string? name, int age) 
            {
                Name = name;
                Age = age;
            }
            public override string ToString()
            {
                return $"{Name}";
            }
        }

        #endregion

        #region Q4 
        public struct Rectangle
        {
            private double width;
            private double height;

            public double Width
            {
                get { return width; }
                set
                {
                    if (value < 0)
                        Console.WriteLine("Error: Width cannot be negative.");
                    else
                        width = value;
                }
            }

            public double Height
            {
                get { return height; }
                set
                {
                    if (value < 0)
                        Console.WriteLine("Error: Height cannot be negative.");
                    else
                        height = value;
                }
            }

            public double Area
            {
                get { return width * height; }
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Width: {width}");
                Console.WriteLine($"Height: {height}");
                Console.WriteLine($"Area: {Area}");
            }
        }

        #endregion
    }
}