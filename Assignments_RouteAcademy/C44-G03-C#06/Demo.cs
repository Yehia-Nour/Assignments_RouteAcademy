using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_C_06
{
    internal class Demo
    {
        #region Function ProtoTyping & Calling
        //static void PrintShapes(int count = 5, string pattern = ":)")
        //{
        //    for (int i = 1; i <= count; i++)
        //        Console.WriteLine(pattern);
        //}
        #endregion

        #region Passing Value Type Parameters

        #region 1. Passing By Value
        //static void Swap(int X, int Y) // Swap(9, 4)
        //{
        //	Console.WriteLine("======== SWAP ========");
        //	int Temp = X;
        //	X = Y;
        //	Y = Temp;
        //} 
        #endregion

        #region 2. Passing By Ref

        //static void Swap(ref int X, ref int Y) // Swap(A, B)
        //{
        //    Console.WriteLine("======== SWAP ========");
        //    int Temp = X;
        //    X = Y;
        //    Y = Temp;
        //}

        #endregion

        #endregion

        #region Passing Reference Type Parameters

        #region 1. Passing By Value
        //static int SumArray(int[] Arr) 
        //{
        //	int Sum = 0;


        //	for (int i = 0; i < Arr.Length; i++)
        //	{
        //		Arr = [4, 5, 6];
        //		// Arr[0] = 100;
        //		Sum += Arr[i];
        //	}

        //	return Sum;
        //}
        #endregion

        #region 2. Passing By Ref

        //static int SumArray(ref int[] Arr) // Arr = Numbers  = {1, 2, 3} => Unreachable Object
        //{
        //	int Sum = 0;


        //	for (int i = 0; i < Arr.Length; i++)
        //	{
        //		Arr = [4, 5, 6];
        //		// Arr[0] = 100;
        //		Sum += Arr[i];
        //	}


        //	return Sum;
        //}

        #endregion

        #endregion

        #region Passing By Out

        //static void SumMul(int X, int Y, out int Sum, out int Mul)
        //{
        //    Sum = X + Y;
        //    Mul = X * Y;

        //}

        #endregion

        #region Params

        /// static int SumArray(params int[] Arr)
        /// {
        /// 	int Sum = 0;
        /// 
        /// 	for (int i = 0; i < Arr.Length; i++)
        /// 		Sum += Arr[i];
        /// 
        /// 	return Sum;
        /// }


        #endregion

        ////////////////////////////////////////////////////////
        #region Function ProtoTyping & Calling

        // PrintShapes(12, "#_#");
        // PrintShapes(pattern: "-_-", count: 10);
        // PrintShapes(pattern: "$_$");


        #endregion

        #region Passing Value Type Parameters
        //int A = 9, B = 4;

        ////Console.WriteLine($"A: {A}");
        ////Console.WriteLine($"B: {B}");

        //// Swap(A, B);

        //Swap(ref A, ref B);
        //Console.WriteLine($"A: {A}");
        //Console.WriteLine($"B: {B}"); 
        #endregion

        #region Passing Reference Type Parameters
        //int[] Numbers = { 1, 2, 3 };

        //Console.WriteLine(Numbers[0]);


        //// int Result = SumArray(Numbers); 

        //int Result = SumArray(ref Numbers);
        //Console.WriteLine(Result);
        //Console.WriteLine(Numbers[0]); // 4 
        #endregion

        #region Passing By Out
        //int A = 3, B = 4, SumResult, MulResult;

        //SumMul(A, B, out  SumResult, out  MulResult);

        //Console.WriteLine($"Sum: {SumResult}");
        //Console.WriteLine($"Mul: {MulResult}");

        //int.TryParse("yehia", out int Result);
        //Console.WriteLine(Result); 
        #endregion

        #region Params
        //// int[] arrayOfNumbers = { 1, 2, 3, 4, 5, 6, 7 };
        ////List<int> listOfNumbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };

        ////int Result = SumArray(listOfNumbers);

        ////Console.WriteLine(Result);

        #endregion

        #region Exception Handling & Protective Code
        //try
        //{
        //	DoSomeProtectiveCode();
        //	throw new Exception();	
        //}
        //catch (Exception ex)
        //{

        //	Console.WriteLine(ex.Message);
        //}
        //finally
        //{
        //	// DeAllocate | Release | Free | Close | Delete UnManaged Resources [DB Connection | File]
        //	Console.WriteLine("Finally");
        //} 

        /*Exception
        //// 1. SystemException
        ////////// 1. FormatException
        ////////// 2. IndexOutOfRangeException
        ////////// 3. NullRefernceException
        ////////// 4. NInvalidOperationException
        ////////// 5. ArithmeticException
        //////////////// 5.1. DivideByZeroException
        //////////////// 5.2. OverflowException
        //// 2. ApplicationException
        */
        #endregion
        /////////////////////////////////////////////////////////

        #region Arrays - One D Array

        //Numbers = new int[3];


        //Console.WriteLine(Numbers[0]);	// 0
        //Console.WriteLine(Numbers[1]);	// 0
        //Console.WriteLine(Numbers[2]);  // 0


        //Numbers[0] = 1;
        //Numbers[1] = 2;
        //Numbers[2] = 3;

        //Console.WriteLine(Numbers[0]);
        //Console.WriteLine(Numbers[1]);
        //Console.WriteLine(Numbers[2]);

        #region Array Intitlization Ways
        //int[] Numbers02 = new int[3] { 1, 2, 3 };
        //int[] Numbers03 = new int[] { 1, 2, 3 };
        //int[] Numbers04 = { 1, 2, 3 };
        //int[] Numbers05 = [ 1, 2, 3 ]; 
        #endregion

        //Numbers = new int[] { 1, 2, 3 };

        ///// Numbers[4] = 5; // Invalid

        ////Console.WriteLine(Numbers[0]);
        ////Console.WriteLine(Numbers[1]);
        ////Console.WriteLine(Numbers[2]);

        //// Length & Dimenssion

        ////Console.WriteLine($"The Length Of Numbers: {Numbers.Length}");
        ////Console.WriteLine($"The Dimenssion Of Numbers: {Numbers.Rank}");


        //for(int i = 0; i < Numbers.Length; i++)
        //	Console.WriteLine(Numbers[i]);

        //Console.WriteLine("__________________________");

        //foreach(int number in Numbers)
        //	Console.WriteLine(number);

        #endregion

        #region Arrays - Two D Array [Rectangular]

        #region Itterate On 2D Array Using Two Nested Loop

        //for(int i = 0; i < Marks.GetLength(0) /*3*/; i++)
        //{
        //	Console.WriteLine($"Please Enter Grades Of Student Number {i + 1}");

        //	for(int j = 0; j < Marks.GetLength(1)/* 5*/; /*j++*/)
        //	{
        //		Console.Write($"The Grade Of Subject Number {j + 1}: ");
        //		//isParsed =  int.TryParse(Console.ReadLine(), out Marks[i, j])

        //		//if (isParsed)
        //		//	j++;

        //		j = int.TryParse(Console.ReadLine(), out Marks[i, j]) ? ++j : j;
        //	}

        //	Console.WriteLine("=====================================");

        //}

        //Console.Clear();

        ///// Print Array [Marks]
        ///// 

        //for (int i = 0; i < Marks.GetLength(0); i++)
        //{
        //	Console.WriteLine($"The Grade Of Student No: {i + 1}");

        //	for(int j = 0; j < Marks.GetLength(1); j++)
        //	{
        //		Console.WriteLine($"The Grade Of Subject No({j +1}): {Marks[i, j]}");
        //	}

        //	Console.WriteLine("=====================================");
        //} // n^2 
        #endregion

        #region Itterate On 2D Array Using One Loop

        //int[,] Marks = new int[3, 5];

        //for(int i = 0; i <Marks.Length; /*i++*/)
        //{
        //	bool isParsed= int.TryParse(Console.ReadLine(), out int mark);

        //	Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)] = mark;

        //	//if (isParsed)
        //	//	i++;

        //	i = isParsed ? ++i : i;
        //}

        //Console.Clear();
        //Console.Beep(323, 2000);

        //for (int i = 0; i < Marks.Length; i++)
        //	Console.WriteLine(Marks[i / Marks.GetLength(1), i % Marks.GetLength(1)]); // n 
        #endregion

        #endregion

        #region Arrays - Two D Array [Judged Array]

        //int[][] Marks = new int[3][];

        //Marks[0] = new int[3] { 9, 8, 2 };
        //Marks[1] = new int[2] { 7, 2 };
        //Marks[2] = new int[1] { 5 };

        #endregion

        #region Array Methods

        //int[] Numbers = { 9, 10, 7, 8, 6, 5, 4, 1, 2, 3, 10 };
        //int[] Arr01 = { 1, 2, 3 };
        //int[] Arr02 = new int[5] ;

        #region 1. Class Memeber Methods [Static Method] 

        //Array.Sort(Numbers);

        //Array.Clear(Numbers);

        // Array.Copy(Arr01, Arr02, 4);

        // Array.ConstrainedCopy(Arr01, 1, Arr02, 0, 2);

        //Arr02 = (int[]) Array.CreateInstance(typeof(int), 10); // new int[10]
        //int[,] Arr03 = (int[,]) Array.CreateInstance(typeof(int), 2, 4);
        //int[,,] Arr04 = (int[,,]) Array.CreateInstance(typeof(int), 2, 4, 5);

        //foreach (int number in Arr02)
        //	Console.WriteLine(number);

        //int index= Array.IndexOf(Numbers, 10);
        //int index= Array.LastIndexOf(Numbers, 10);
        //Console.WriteLine(index);


        #endregion

        #region 2. Object Memeber Method [Non Static Methods]

        //Arr01.CopyTo(Arr02, 1);

        //foreach(int number in Arr02)
        //	Console.WriteLine(number);

        //Arr01.GetLength(0);
        //Arr01.GetValue(1); // Arr01[1]
        //Arr01.SetValue(100, 1); // Arr01[1] = 100

        #endregion

        #endregion

        #region Boxing & UnBoxing

        #region Boxing

        //object obj;
        //obj = new object();
        //obj = new string("yehia");
        //obj = "yehia";             /// Refernce Type

        //// Casting Implicitly == > Boxing[Safe Casting]

        //Console.WriteLine(obj); 
        #endregion

        #region UnBoxing
        //obj = 5;
        //obj = "yehia";

        //int number;

        //// number = obj.GetType() == typeof(int) ? (int) obj : 0;
        //number = obj is int ? (int)obj : 0;
        //Console.WriteLine(number); 
        #endregion


        #endregion

        #region Nullable ValueTypes

        #region Part 01

        //int? Age; // Nullable<int> Age

        //Age = 22;

        //Age = null;

        ////Console.WriteLine(Age is not null ? Age : 0);
        //Console.WriteLine(Age.HasValue ? Age.Value : 0 );

        //decimal? Salary;

        //Salary = 8_000;

        //Salary = null;

        //Console.WriteLine(Salary is not null ? Salary : 0);
        //Console.WriteLine(Salary.HasValue ? Salary.Value : 0); 
        #endregion

        #region Part 02
        #region Casting From Value Type To Nullable<ValueType>

        //int X = 10;

        //// X is int : Allows Integers Only
        //// Y is int?: Allows Integers + NULL

        //int? Y = /*(int?)*/ X;
        //// Casting From Value Type [int] To Nullable<Int> [Nullable Value Type] Implicitly
        //// Safe Casting
        //Console.WriteLine(Y);

        #endregion

        #region Casting From Nullable<ValueType> To Value Type

        //int? X = 10;

        //X = null;

        //// X is int? Nullable<int> : Allow integers + NULL
        //// Y is int                : Allow integers Only

        //int Y;
        //// int Y = (int) X;
        //// Casting From Nullable<ValueType> [int?] To Value Type [int] Explicitly
        //// Unsafe Casting 

        ///*********** Protective Code*******************/

        //if (X is not null)
        //	Y = (int)X;
        //else
        //	Y = 0;

        ///******************************/

        //if (X.HasValue)
        //	Y = X.Value;
        //else
        //	Y = 0;

        ///******************************/

        //Y = X.HasValue ? X.Value : 0;

        ///******************************/

        //// Null Coalecsing Operator

        //Y = X ?? 0;  // Syntax Sugar For ---> Y = X.HasValue ? X.Value : 0;


        //Console.WriteLine(Y);

        #endregion
        #endregion

        #endregion

        #region Nullable ReferenceTypes

        // NULL Is Valid Value For Varibales Of DataType: Reference Types [Class, Interface]
        // Compiler Enhancement

        //string? Mesaage01 = null;

        //Console.WriteLine(Mesaage01);

        #endregion

        #region NULL Propagation Operator | Conditional Operator
        //int[]? Numbers = { 1, 2, 3 };

        //Numbers = null;

        #region Example 01

        //if (Numbers is not null)
        //{
        //	for (int i = 0; i < Numbers.Length; i++)
        //	{
        //		Console.WriteLine(Numbers[i]);
        //	} 
        //}

        ////for (int i = 0;(Numbers is not null) && i < Numbers.Length; i++)
        ////{
        ////	Console.WriteLine(Numbers[i]);
        ////}

        //for (int i = 0; i < Numbers?.Length /*(Numbers is not null) */; i++)
        //{
        //	Console.WriteLine(Numbers[i]); 
        //}
        #endregion

        #region Example 02
        //int Length;

        //if (Numbers is not null)
        //	Length = Numbers.Length;
        //else
        //	Length = 0;

        //Length = Numbers?.Length ?? 0;

        //// Numbers?.Length 
        //// Numbers is not null ? Numbers.Length : 0;

        #endregion

        #endregion
    }
}
