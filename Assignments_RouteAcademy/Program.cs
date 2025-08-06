
namespace Assignments_RouteAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C44-G03-OOP02
            #region Q1
            //Person[] people = new Person[3];

            //people[0] = new Person("Yehia", 24);
            //people[1] = new Person("Ali", 23);
            //people[2] = new Person("Hassan", 22);

            //foreach (var person in people)
            //{
            //    Console.WriteLine(person);
            //}

            #endregion

            #region Q2
            //Console.WriteLine("Enter coordinates for the first point:");
            //Console.Write("X1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Y1: ");
            //double y1 = double.Parse(Console.ReadLine());

            //Console.WriteLine("Enter coordinates for the second point:");
            //Console.Write("X2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Y2: ");
            //double y2 = double.Parse(Console.ReadLine());

            //Point p1 = new Point(x1, y1);
            //Point p2 = new Point(x2, y2);

            //double distance = p1.DistanceTo(p2);

            //Console.WriteLine($"\nPoint 1: {p1}");
            //Console.WriteLine($"Point 2: {p2}");
            //Console.WriteLine($"Distance between them: {distance:F2}");

            #endregion

            #region Q3 
            //Person2[] peop = new Person2[3];

            //for (int i = 0; i < peop.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");

            //    Console.Write("Name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    peop[i] = new Person2(name, age);
            //    Console.WriteLine();
            //}

            //Person2 oldest = peop[0];

            //for (int i = 1; i < peop.Length; i++)
            //{
            //    if (peop[i].Age > oldest.Age)
            //    {
            //        oldest = peop[i];
            //    }
            //}

            //Console.WriteLine("The oldest person is:");
            //Console.WriteLine(oldest);

            #endregion

            #region Q4 
            //Rectangle rect = new Rectangle();

            //rect.Width = 5;
            //rect.Height = 10;

            //rect.DisplayInfo();

            //Console.WriteLine();

            //rect.Width = -3; 
            //rect.Height = -8;

            //Console.WriteLine();
            //rect.DisplayInfo();

            #endregion


            ////////////////////////////////////////////////////////////////////
            // C44-G03-OOP03

            #region Part 1
            //Employee[] EmpArr = new Employee[3];

            //EmpArr[0] = new Employee(1, "Yehia NourEldin", Gender.Male, SecurityLevel.DBA, 25000, new HiringDate(10, 5, 2019));
            //EmpArr[1] = new Employee(2, "Mostafa Hany", Gender.Male, SecurityLevel.Guest, 18000, new HiringDate(15, 6, 2023));
            //EmpArr[2] = new Employee(3, "Mohamed Tarek", Gender.Male, SecurityLevel.Secretary, 12000, new HiringDate(20, 7, 2021));

            //Console.WriteLine("Before Sorting");

            //foreach (var emp in EmpArr)
            //    Console.WriteLine(emp);

            //Console.WriteLine("After Sorting");

            //InsertionSort(EmpArr);

            //foreach (var emp in EmpArr)
            //    Console.WriteLine(emp);

            #endregion


            //Console.WriteLine("==================================================================================");


            #region Part 2
            //EBook ebook = new EBook("C# in Depth", "Yehia NourEldin", "123456789", 5.6);
            //PrintedBook printedBook = new PrintedBook("Clean Code", "Robert C. Martin", "987654321", 464);

            //Console.WriteLine("EBook Info");
            //ebook.DisplayInfo();

            //Console.WriteLine("\nPrinted Book Info");
            //printedBook.DisplayInfo();
            #endregion



        }



        #region Part 1
        //public static bool Compare(HiringDate d1, HiringDate d2)
        //{
        //    if (d1.Year > d2.Year)
        //        return true;
        //    else if (d1.Year < d2.Year)
        //        return false;
        //    else
        //    {
        //        if (d1.Month > d2.Month)
        //            return true;
        //        else if (d1.Month < d2.Month)
        //            return false;
        //        else
        //            return d1.Day > d2.Day;
        //    }
        //}

        //public static void InsertionSort(Employee[] arr)
        //{
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        Employee key = arr[i];
        //        int j = i - 1;

        //        while (j >= 0 && Compare(arr[j].HireDate, key.HireDate))
        //        {
        //            arr[j + 1] = arr[j];
        //            j--;
        //        }

        //        arr[j + 1] = key;
        //    }
        //}

        #endregion
    }
}
