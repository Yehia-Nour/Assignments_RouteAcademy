using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments_RouteAcademy.C44_G03_C_06
{
    internal class Assignment01
    {
        #region Q1
        public enum WeekDays
        {
            Saturday = 0,
            Sunday = 1,
            Monday = 2,
            Tuesday = 3,
            Wednesday = 4,
            Thursday = 5,
            Friday = 6
        }
        public static void PrintDays()
        {
            foreach (WeekDays day in Enum.GetValues(typeof(WeekDays)))
            {
                Console.WriteLine(day);
            }
        }

        #endregion

        #region Q2
        public enum Season
        {
            Spring, Summer, Autumn, Winter
        }

        public static void PrintRangeMonth()
        {
            bool isParse;
            Season selectedSeason;
            do
            {
                Console.Write("Enter a season name (Spring, Summer, Autumn, Winter): ");
                isParse = Enum.TryParse(Console.ReadLine(), true, out selectedSeason);

            } while (!isParse);


                switch (selectedSeason)
            {
                case Season.Spring:
                    Console.WriteLine("Spring: March to May");
                    break;
                case Season.Summer:
                    Console.WriteLine("Summer: June to August");
                    break;
                case Season.Autumn:
                    Console.WriteLine("Autumn: September to November");
                    break;
                case Season.Winter:
                    Console.WriteLine("Winter: December to February");
                    break;
            }
        }

        #endregion

        #region Q3 
        [Flags]
        public enum Permission
        {
            Read = 1,  // 0001
            Write = 2,  // 0010
            Delete = 4,  // 0100
            Execute = 8   // 1000
        }
        public static void Check()
        {
            Permission userPermissions = Permission.Read;

            userPermissions |= Permission.Write;

            if ((userPermissions & Permission.Delete) == Permission.Delete)
            {
                Console.WriteLine("Has Delete");
            }

            userPermissions |= Permission.Delete;

            userPermissions &= ~Permission.Write;

            if ((userPermissions & Permission.Write) == Permission.Write)
            {
                Console.WriteLine("Still has Write");
            }
            else
            {
                Console.WriteLine("Write removed");
            }

            Console.WriteLine("Final Permissions: " + userPermissions);
        }
        #endregion

        #region Q4 
        enum Colors
        {
            Red, Green, Blue
        }
        public static void PrintPrimaryColor()
        {
            Console.Write("Enter a color name: ");
            string input = Console.ReadLine()?.Trim();

            bool isParse = Enum.TryParse(input, true, out Colors selectedColor);

            if (isParse)
                Console.WriteLine($"{selectedColor} is a primary color.");
            else
                Console.WriteLine($"{input} is NOT a primary color.");
        }
        #endregion


    }
}
