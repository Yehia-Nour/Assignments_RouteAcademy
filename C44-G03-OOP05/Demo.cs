using Interface_Example_02;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_OOP05
{
    internal class Demo
    {
        #region Interface Example 02
        //public static void Print10NumberFromSeries(ISeries series)
        //{
        //    if (series == null)
        //        return;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        //public static void Print10NumberFromSeries(SeriesByThree series)
        //{
        //    if (series == null)
        //        return;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //}
        //public static void Print10NumberFromSeries(SeriesByFour series)
        //{
        //    if (series == null)
        //        return;

        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.Write($"{series.Current}\t");
        //        series.GetNext();
        //    }
        //    series.Reset();
        //    Console.WriteLine();
        //} 
        #endregion

        #region Binding
        //TypeA a = new TypeB(1, 2);

        //a.A = 11;
        //a.B = 22; // Invalid

        // Static Binding
        //a.MyFun01(); // I am Base [Parent]
        // Dynamic Binding
        //a.MyFun02(); // Type B

        //TypeA a = new TypeC(1, 2, 3);

        //a.A = 11;
        ////a.B = 22; // Invalid
        ////a.C = 33; // Invalid

        //a.MyFun01(); // I am Base [Parent]
        //a.MyFun02(); // Type C

        //TypeB b = new TypeC(1, 2, 3);

        //b.A = 11;
        //b.B = 22;
        ////b.C = 33; // Invalid

        //b.MyFun01(); // I am Derived [Child]
        //b.MyFun02(); // Type C

        //TypeA a = new TypeD(1, 2, 3, 4);

        //a.MyFun01(); // I am Base [Parent]
        //a.MyFun02(); // Type C

        //TypeA a = new TypeE(1, 2, 3, 4, 5);
        //TypeB b = new TypeE(1, 2, 3, 4, 5);
        //TypeC c = new TypeE(1, 2, 3, 4, 5);

        //a.MyFun02(); // Type C
        //b.MyFun02(); // Type C
        //c.MyFun02(); // Type C

        //TypeD d = new TypeE(1, 2, 3, 4, 5);

        //d.MyFun02(); // Type E 
        #endregion

        #region Interface Example 01
        //IMyType myType;
        // Declare Reference of type "IMyType", refering to null
        // this reference "myType" can refer to an object from
        // class or struct implementing the interface 
        // CLR will allocate 4 Bytes at stack for the reference

        //myType = new IMyType(); // Invalid
        // U can't create object from interface

        //MyType myType = new MyType();

        //myType.Salary = 4_000;
        //myType.MyFun();
        //Console.WriteLine(myType.Salary);
        //myType.Print(); // invalid

        //IMyType myType = new MyType();
        //myType.Salary = 5_000;
        //myType.MyFun();
        //Console.WriteLine(myType.Salary);
        //myType.Print(); 
        #endregion

        #region Interface Example 02
        //SeriesByTwo seriesByTwo = new SeriesByTwo();
        //Print10NumberFromSeries(seriesByTwo);

        //SeriesByThree seriesByThree = new SeriesByThree();
        //Print10NumberFromSeries(seriesByThree);

        //SeriesByFour seriesByFour = new SeriesByFour();
        //Print10NumberFromSeries(seriesByFour); 
        #endregion

        #region Interface Example 03
        //Car car = new Car();
        //car.Forward();
        //car.Backward();
        //car.Right();

        //AirPlane airPlane = new AirPlane();
        //airPlane.Backward();
        //airPlane.Forward();

        //IMoveable moveable = new AirPlane();
        //moveable.Backward();
        //moveable.Forward();
        //moveable.Left();

        //IFlyable flyable = new AirPlane();
        //flyable.Backward();
        //flyable.Forward();
        //flyable.Right(); 
        #endregion
    }
}
