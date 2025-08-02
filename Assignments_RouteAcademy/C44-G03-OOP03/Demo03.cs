using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_OOP03
{
    internal class Demo03
    {
        #region Class
        #region Example 01
        //Car c01;
        // Declare Reference from Type Car
        // This Reference can refer to an object from type Car or 
        // Any type inherit from type Car
        // CLR will allocate 4 bytes At Stack
        // reference referring to NULL

        //c01 = new Car(100, "BMW", 320);
        //c01 = new(100, "BMW", 320);
        // 1. Allocate Required Bytes At Heap
        // 2. Initialize Allocated Bytes At Heap
        // 3. Call User Defined constructor [if exist]
        // 4. Assign Address of Allocated object

        //Console.WriteLine(c01); 
        #endregion

        #region Example 02
        //Car c01 = new Car(100, "BMW", 320);

        //Console.WriteLine(c01);

        //Car c02 = new Car(200, "Lotus");

        //Console.WriteLine(c02);

        //Car c03 = new Car("Ferrari");

        //Console.WriteLine(c03); 
        #endregion
        #endregion

        #region Inheritance

        /// Parent parent = new Parent(1, 3);
        /// parent.X = 11;
        /// parent.Y = 22;
        /// Console.WriteLine(parent);
        /// Console.WriteLine($"Product = {parent.Product()}");

        //Child child = new Child(1, 2, 3);
        ////child.X = 11;
        ////child.Y = 22;
        ////child.Z = 33;

        //Console.WriteLine(child.ToString());
        //Console.WriteLine("------------");
        //Console.WriteLine($"Product = {child.Product()}"); // Product = 6 

        #endregion

        #region Access Modifiers [Private Protected, Protected, Internal Protected]

        //TypeA obj = new TypeA();
        //obj.X = 1; "X is Private"
        //obj.Y = 2; "Y is Private"
        //obj.Z = 3; "Z is Internal" 

        ////TypeB obj = new TypeB();
        ////obj.X = 1; "X is Private"
        ////obj.Y = 2; "Y is Private"
        ////obj.Z = 3; "Z is Internal"


        ////TypeC obj = new TypeC();
        ////obj.X = 10; // Invaild X is not inherited
        ////obj.Y = 20; // Invalid Y [Private]
        ////obj.Z = 30 // Invalid  X [Private] 

        #endregion
    }
}
