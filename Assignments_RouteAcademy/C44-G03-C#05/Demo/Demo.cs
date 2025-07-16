using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_C_05.Demo
{
    public class Demo
    {
        #region Control Statements 2. Loop Statments [for, foreach]


        ////// 1. For

        /// Collection [Array, List, Dictionary]

        //int[] Numbers = { 1, 2, 3, 4, 5 };

        //for (int i = 0; i < Numbers.Length /*5*/; i++)
        //{
        //    //if (i == 2)
        //    //    //continue;
        //    //    break;

        //    Numbers[i] += 10;

        //    Console.WriteLine(Numbers[i]);
        //}

        //Console.WriteLine("***********************");

        //// 2. Foreach
        //foreach (int number in Numbers)
        //{
        //    //number += 10; //Invalid  Take Copy From Collection XXXXX

        //    Console.WriteLine(number);
        //}


        #endregion

        #region Control Statements 2. Loop Statments [while, do..while]

        /// Not Definsive Code
        ///int Number;
        ///do
        ///{
        ///    // 1
        ///    Console.Write("Please Enter An Even Number: ");
        ///    Number = int.Parse(Console.ReadLine());
        ///} while (Number % 2 == 1);


        ///int Number;
        ///bool flag = false;
        ///do
        ///{
        ///    Console.Write("Please Enter An Even Number: ");
        ///    //Number = int.Parse(Console.ReadLine());
        ///    //flag = int.TryParse(Console.ReadLine() , out Number);
        ///} while (!int.TryParse(Console.ReadLine(), out Number) || Number % 2 == 1);

        /*

         SQLReader reader = new SQLReader();

          while(reader.Read())
          {
              // Code
          }

         */



        //int i = 1;

        //while(i <= 10)
        //{
        //    Console.WriteLine(i);
        //    i++;
        //}
        #endregion

        #region String

        // String is a Class [Reference Type], Internally is an Array of Chars
        // String is an Imutable Type --> Can't be Change [Internally is an Array of Chars; Array is Fixed Length]

        #region Example 01

        //Name = "ahmed"; // Stntax Sugar

        //Console.WriteLine(Name);
        //Console.WriteLine($"HashCode = {Name.GetHashCode()}");

        //string Name02 = "yehia";

        //Console.WriteLine("------------");
        //Console.WriteLine(Name02);
        //Console.WriteLine($"HashCode = {Name02.GetHashCode()}"); 
        #endregion

        #region Example 02

        //string Name01 = "Ahmed"; /*Has 2 References*/
        //string Name02 = "Omar" /*Unreachable Object*/;

        ////Console.WriteLine($"Name01 = {Name01}");
        ////Console.WriteLine($"HashCode Of Name01 =  {Name01.GetHashCode()}");
        ////Console.WriteLine($"Name02 = {Name02}");
        ////Console.WriteLine($"HashCode Of Name02 =  {Name02.GetHashCode()}");

        //Name02 = Name01;
        ////Console.WriteLine($"Name01 = {Name01}");
        ////Console.WriteLine($"HashCode Of Name01 =  {Name01.GetHashCode()}");
        ////Console.WriteLine($"Name02 = {Name02}");
        ////Console.WriteLine($"HashCode Of Name02 =  {Name02.GetHashCode()}");

        //Name01 = "yehia";

        //Console.WriteLine(Name02);
        #endregion


        #region Example 03
        //string Message = "Hello" ;
        //Console.WriteLine($"Message: {Message}");
        //Console.WriteLine($"HashCode Of Message: {Message.GetHashCode()}");

        //Message += " Route"; Console.WriteLine("********* After Change Message *********");

        //Console.WriteLine($"Message: {Message}");
        //Console.WriteLine($"HashCode Of Message: {Message.GetHashCode()}"); 
        #endregion

        #endregion

        #region string Methods

        //string message = "  Hello Route  ";
        //Console.WriteLine(message.Length); // 15
        //Console.WriteLine(message.ToUpper()); //  HELLO ROUTE
        //Console.WriteLine(message.ToLower());//   hello route
        //Console.WriteLine(message.Trim());//Hello Route
        //Console.WriteLine(message.TrimEnd());//  Hello Route
        //Console.WriteLine(message.TrimStart());//Hello Route
        //Console.WriteLine(message.Substring(0 , 5));//  Hel
        //Console.WriteLine(message.Replace('e' , 'T'));//  HTllo RoutT
        //Console.WriteLine(message.Contains('o'));//true

        #endregion

        #region StringBuilder

        ///StringBuilder is a Class [Reference Type]

        //Message = new StringBuilder("Hello");

        //Console.WriteLine($"Message = {Message}");
        //Console.WriteLine($"HashCode of Message = {Message.GetHashCode()}");

        //Message.Append(" Ahmed");  Console.WriteLine("Message After Appending ");

        //Console.WriteLine($"Message = {Message}");
        //Console.WriteLine($"HashCode of Message = {Message.GetHashCode()}");


        #endregion

        #region StringBuilder Methods

        //StringBuilder Message = new StringBuilder("Hello");

        //Message.Append(" ali");
        //Message.AppendLine(" omar");
        //Message.AppendLine("Your Age Is 24");

        //Message.Remove(0, 5);
        //Message.Insert(0, "Hi");
        ////Message.Clear();
        ////Message.AppendFormat("{0} : {1}" , true, 'A');
        ////Message.AppendJoin(';' , "Hamda" , "Hambozo");



        //Console.WriteLine(Message);

        #endregion
    }
}
