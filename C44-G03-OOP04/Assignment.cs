using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP04
{
    // Part01
    #region Q1
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    #endregion

    #region Q2
    public class Rectangle
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public Rectangle(int size)
        {
            Width = size;
            Height = size;
        }

        public void Display()
        {
            Console.WriteLine($"Width: {Width}, Height: {Height}");
        }
    }


    #endregion

    #region Q3 
    public class Complex
    {
        public int Real { get; set; }
        public int Imag { get; set; }

        public Complex(int real, int imag)
        {
            Real = real;
            Imag = imag;
        }

        public static Complex operator +(Complex left, Complex right)
        {
            return new Complex((left?.Real ?? 0) + (right?.Real ?? 0),
                (left?.Imag ?? 0) + (right?.Imag ?? 0));
        }

        public static Complex operator -(Complex left, Complex right)
        {
            return new Complex((left?.Real ?? 0) - (right?.Real ?? 0),
                (left?.Imag ?? 0) - (right?.Imag ?? 0));
        }
        public override string ToString()
        {
            return $"{Real} + {Imag}i";
        }
    }

    #endregion

    #region Q4 
    public class Employee
    {
        public virtual void Work()
        {
            Console.WriteLine("Employee is working");
        }
    }

    public class Manager : Employee
    {
        public override void Work()
        {
            Console.WriteLine("Manager is managing");

            base.Work();
        }
    }
    #endregion

    #region Q5 
    public class BaseClass
    {
        public virtual void DisplayMessage()
        {
            Console.WriteLine("Message from BaseClass");
        }
    }

    public class DerivedClass1 : BaseClass
    {
        public override void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass1");
        }
    }

    public class DerivedClass2 : BaseClass
    {
        public new void DisplayMessage()
        {
            Console.WriteLine("Message from DerivedClass2");
        }
    }

    #endregion

    // Part02
    // Existing Duration class code (as is)
    public class Duration
    {
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

        public Duration(int hours, int minutes, int seconds)
        {
            Hours = hours;
            Minutes = minutes;
            Seconds = seconds;
            Normalize();
        }

        public Duration(int totalSeconds)
        {
            Hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;
            Minutes = remainingSeconds / 60;
            Seconds = remainingSeconds % 60;
        }

        private void Normalize()
        {
            int totalSeconds = ToTotalSeconds();
            Hours = totalSeconds / 3600;
            int remainingSeconds = totalSeconds % 3600;
            Minutes = remainingSeconds / 60;
            Seconds = remainingSeconds % 60;
        }

        public int ToTotalSeconds()
        {
            return Hours * 3600 + Minutes * 60 + Seconds;
        }

        public override string ToString()
        {
            string result = "";
            if (Hours > 0)
                result += $"Hours: {Hours}, ";
            if (Hours > 0 || Minutes > 0)
                result += $"Minutes: {Minutes}, ";
            result += $"Seconds: {Seconds}";
            return result;
        }

        public static Duration operator +(Duration d1, Duration d2)
        {
            return new Duration(d1.ToTotalSeconds() + d2.ToTotalSeconds());
        }

        public static Duration operator +(Duration d, int seconds)
        {
            return new Duration(d.ToTotalSeconds() + seconds);
        }

        public static Duration operator +(int seconds, Duration d)
        {
            return d + seconds;
        }

        public static Duration operator -(Duration d1, Duration d2)
        {
            int resultSeconds = d1.ToTotalSeconds() - d2.ToTotalSeconds();
            if (resultSeconds < 0) resultSeconds = 0;
            return new Duration(resultSeconds);
        }

        public static Duration operator ++(Duration d)
        {
            return new Duration(d.ToTotalSeconds() + 60);
        }

        public static Duration operator --(Duration d)
        {
            int resultSeconds = d.ToTotalSeconds() - 60;
            if (resultSeconds < 0) resultSeconds = 0;
            return new Duration(resultSeconds);
        }

        public static bool operator >(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() > d2.ToTotalSeconds();
        }

        public static bool operator <(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() < d2.ToTotalSeconds();
        }

        public static bool operator >=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() >= d2.ToTotalSeconds();
        }

        public static bool operator <=(Duration d1, Duration d2)
        {
            return d1.ToTotalSeconds() <= d2.ToTotalSeconds();
        }

        public static bool operator true(Duration d)
        {
            return d.ToTotalSeconds() != 0;
        }

        public static bool operator false(Duration d)
        {
            return d.ToTotalSeconds() == 0;
        }

        public static explicit operator DateTime(Duration d)
        {
            return new DateTime(1, 1, 1, d.Hours, d.Minutes, d.Seconds);
        }
    }  

    internal class Assignment
    {

    }
}
