using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_C_06
{
    //internal struct Point
    //{
    //    #region Attributes
    //    // Attributes
    //    public int X; // 4 Bytes
    //    public int Y; // 4 Bytes 
    //    #endregion

    //    #region Constructors
    //    public Point()
    //    {
    //        X = default; // 0
    //        Y = default; // 0
    //    }
    //    public Point(int Number)
    //    {
    //        X = Y = Number;
    //    }
    //    public Point(int _X, int _Y)
    //    {
    //        X = _X;
    //        Y = _Y;
    //    }
    //    #endregion

    //    #region Methods
    //    public override string ToString()
    //    {
    //        return $"({/*this.*/X}, {/*this.*/Y})";
    //    }
    //    #endregion
    //}
    /////class Person
    /////{
    /////    public int Id { get; set; }
    /////    public string? Name { get; set; }
    /////    public Gender Gender { get; set; }
    /////}

    //enum Gender : byte
    //{
    //    Male = 1,
    //    Female = 2
    //}

    //enum Grade : byte
    //{
    //    // Labels
    //    A, B, C, D, E, F
    //}


    //enum Branch : byte
    //{
    //    Dokki = 1, NaserCity_Rabaa = 2, NasserCity = 3
    //}

    //enum Permission : byte
    //{
    //    Write = 1, Read = 2, Execute = 4, Delete = 8
    //}

    //class Employee
    //{
    //    public int Id { get; set; }
    //    public string? Name { get; set; }
    //    public decimal Salary { get; set; }
    //    public Permission Permission { get; set; }
    //}
    internal class Demo01
    {
        #region Access Modifiers [private, internal, public]

        //TypeA obj = new TypeA();
        ////obj.X = 10;  invalid ---> due its protection level [X is private]
        ////obj.Y = 20;  invalid ---> due its protection level [Y is internal]
        //obj.Z = 30; // valid   ---> as Z is public

        #endregion

        #region Enum

        #region Example 01
        ////Person person = new Person();
        ////person.Gender = Gender.Male;
        ////Gender X = Gender.Male;

        //Grade G01 = Grade.A;

        ///// if(G01 == Grade.A)
        /////     Console.WriteLine(":)");
        ///// else
        /////     Console.WriteLine(":(");

        //G01 = (Grade)255;


        //Console.WriteLine(G01); // 10 
        #endregion

        #region Example 02
        //Gender myGender;

        //Console.Write("Plese Enter Your Gender:");

        #region Parse Method
        //////myGender = (Gender) Enum.Parse(typeof(Gender), Console.ReadLine() ?? "");
        ////myGender = Enum.Parse<Gender>(Console.ReadLine() ?? "", true); 
        #endregion

        #region TryParse Method
        ////Enum.TryParse(typeof(Gender), Console.ReadLine(), true, out object? obj);
        ////myGender = (Gender?) obj;

        ////Enum.TryParse(Console.ReadLine(), true, out myGender); 
        #endregion

        //Console.WriteLine(myGender); 
        #endregion

        #endregion
    }
}
