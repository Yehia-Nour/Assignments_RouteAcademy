using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP04
{
    internal class Demo
    {
        #region Method Overloading
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sum(int x, int y, int z)
        {
            return x + y + z;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Sum(int x, double y)
        {
            return x + y;
        }
        //public static int Sum(int x, double y)
        //{
        //    return x + (int)y;
        //}
        public static double Sum(double x, int y)
        {
            return x + y;
        }
        #endregion

        #region Method Overloading
        ////Console.WriteLine(13);

        //int result = Sum(1,2);
        //result = Sum(1, 2, 3);
        //result = (int)Sum(1.5, 9.3);
        //result = (int)Sum(7, 9.3);
        //result = (int)Sum(9.3, 7);
        ////Sum(1, 5.8); 
        #endregion

        #region Operators Overloading
        //int x = 1 + 2;
        //Complex c1 = new Complex()
        //{
        //    Real = 2,
        //    Imag = 3
        //};

        //Complex c2 = new Complex()
        //{
        //    Real = 4,
        //    Imag = 5
        //};

        //Console.WriteLine($"C1 = {c1}");
        //Console.WriteLine($"C2 = {c2}");

        //Complex c3 = default;

        #region Binary Operators [+, -]
        //c1 = null;
        //c3 = c1 + c2;
        //c3 += c1;

        //Complex c4 = c1 + c2 + c3;

        //c3 = c2 - c1;
        //c3 -= c1;

        //Complex c4 = c1 - c2 - c3;

        //Console.WriteLine($"C3 = {c3}"); 
        #endregion

        #region Unary Operators [++, --]
        //c3 = ++c1;
        //c1++;

        //c3 = c1--;
        //--c1;

        //Console.WriteLine($"C1 = {c1}");
        //Console.WriteLine($"C3 = {c3}"); 
        #endregion

        #region Relational Operators [>, <]
        //if(c1 > c2)
        //{
        //    Console.WriteLine("C1 is Greate Than C2");
        //}
        //else if(c1 < c2)
        //{
        //    Console.WriteLine("C2 is Greate Than C1");
        //}
        //else
        //{
        //    Console.WriteLine("C1 Equals C2");
        //} 
        #endregion

        #region Casting Operators
        //int number = (int)c1; // Recommended
        //number = c1; // Invalid

        //string s = c1;
        //s = (string)c1;

        //Console.WriteLine(number);
        //Console.WriteLine(s); 
        #endregion

        #region User Defined Data Types Casting Operators [Business Need]
        //Employee employee = new Employee()
        //{
        //    Id = 123456,
        //    Name = "yehia",
        //    Email = "yehia@ex.com",
        //    Password = "P@ssw0rd",
        //    SecurityStamp = Guid.NewGuid()
        //};

        ////Console.WriteLine(employee.Id);
        ////Console.WriteLine(employee.Name);
        ////Console.WriteLine(employee.Password);

        //// Manual Mapping
        //EmployeeViewModel employeeViewModel = (EmployeeViewModel)employee;

        //Console.WriteLine(employeeViewModel.Id);
        //Console.WriteLine(employeeViewModel.FName);
        //Console.WriteLine(employeeViewModel.LName);
        //Console.WriteLine(employeeViewModel.Email); 
        #endregion
        #endregion

        #region Overriding
        //TypeA a;

        //a = new TypeA(1);

        //Console.WriteLine(a.A);
        //a.MyFun01();
        //a.MyFun02();

        //TypeB b;

        //b = new TypeB(1, 2);

        //Console.WriteLine(b.A);
        //Console.WriteLine(b.B);
        //b.MyFun01();
        //b.MyFun02(); 
        #endregion
    }
}
