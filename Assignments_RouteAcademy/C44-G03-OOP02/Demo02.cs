using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_OOP02
{
    internal class Demo02
    {
        #region Struct
        #region Example 01
        //Point p1;

        //p1 = new Point(); //(0,0)

        //Console.WriteLine(p1); //(0,0)

        //Point p2 = new Point(1, 2); // (1,2)

        //Console.WriteLine(p2); // (1,2)

        //Point p3 = new Point(3); // (3,3)

        //Console.WriteLine(p3); // (3,3) 
        #endregion

        #region Example 02
        //Point p1 = new Point(); //(0,0)

        //Console.WriteLine($"P1 = {p1}");

        //p1.X = 10;
        //p1.Y = 20;

        //Console.WriteLine($"P1 = {p1}");

        //Point p2 = new(100, 200); //(100,200)

        //Console.WriteLine($"P2 = {p2}");

        //p2 = p1;

        //Console.WriteLine("After P2 = P1");
        //Console.WriteLine($"P1 = {p1}");
        //Console.WriteLine($"P2 = {p2}");

        //p1.X = 1;
        //p2.Y = 2;

        //Console.WriteLine($"P1 = {p1}");
        //Console.WriteLine($"P2 = {p2}"); 
        #endregion
        #endregion

        #region Encapsulation
        //Employee e01 = new Employee(1, "Omar", 1000, 23, "123456789");

        //Console.WriteLine(e01);

        //e01.EmpId = 2; // Set ID Directly
        //Console.WriteLine(e01.EmpId); // Get ID Directly

        //e01.Name = "Hamada";
        //Console.WriteLine(e01.Name);
        //e01.SetName("Ahmed Mohamed"); // Set Name Using Setter Function
        //Console.WriteLine(e01.GetName()); // Get Name Using Getter Function

        //e01.Salary = 5000; // Set Salary Using Property[set]
        //Console.WriteLine(e01.Salary); // Get Salary Using Property[get]

        //e01.SSN = "987654159686";
        //Console.WriteLine(e01.SSN); 
        #endregion

        #region Indexer
        //PhoneNoteBook noteBook = new PhoneNoteBook(3);

        //noteBook.Add(0, "Ali", 123);
        //noteBook.Add(1, "Samy", 456);
        //noteBook.Add(2, "Mona", 789);
        //noteBook.Add(3, "Hamada", 147);
        //noteBook.Add(-3, "Hamada", 147);

        //noteBook.SetNumber("Mona", 999);
        //Console.WriteLine(noteBook.GetNumber("Mona"));

        //noteBook["Mona"] = 999;
        //Console.WriteLine(noteBook["Mona"]);

        //for(int i = 0; i < noteBook.Size; i++)
        //{
        //    Console.WriteLine(noteBook[i]);
        //}

        //string name = "Hamada";
        ////name[2] = 'h';
        //Console.WriteLine(name[2]); 
        #endregion
    }
}
