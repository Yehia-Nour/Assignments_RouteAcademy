using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_C_06
{
    internal class Assignment
    {
        #region Q1
        // Pass by Value -> When i pass a value type like (int, float, char) a copy of the variable is sent to the method not the original variabl
        // Pass by Reference -> Here is sent refernce of original value 
        public static void Changing(int num1, ref int num2)
        {
            num1 = 10; // not change on the original variable
            num2 = 10; // the original value become = 10 -> because the both are same
        }

        #endregion

        #region Q2
        // Pass by Value -> When i pass a reference type like (string or any class) a copy of the reference for object is sent to the method not the original reference
        // Pass by Reference -> Here is sent the same reference for the same ojbect 
        public static void ChangingReferenceType(string name1, ref string name2)
        {
            name1 = "yehia";
            name2 = "yehia";
            // both are changing
        }

        #endregion

        #region Q3 
        public static void Calculate(int a, int b, int c, int d, out int sum, out int subtract)
        {
            sum = a + b;
            subtract = c - d;
        }

        #endregion

        #region Q4 
        public static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }
        #endregion

        #region Q5 
        public static bool IsPrime(int number)
        {
            if (number <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }

            return true;
        }

        #endregion

        #region Q6 
        public static void MinMaxArray(int[] array, ref int min, ref int max)
        {
            min = array[0];
            max = array[0];

            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                if (left == right)
                {
                    if (array[left] < min) min = array[left];
                    if (array[left] > max) max = array[left];
                    break;
                }

                int small = array[left] < array[right] ? array[left] : array[right];
                int large = array[left] > array[right] ? array[left] : array[right];

                if (small < min) min = small;
                if (large > max) max = large;

                left++;
                right--;
            }
        }

        #endregion

        #region Q7 
        public static long Factorial(int number)
        {
            long result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }


        #endregion

        #region Q8 
        public static string ChangeChar(string str, int position, char newChar)
        {
            char[] chars = str.ToCharArray();
            chars[position] = newChar;
            return new string(chars);
        }
        #endregion

    }
}
