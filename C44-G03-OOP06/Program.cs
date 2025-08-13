using C44_G03_OOP06.First_Project;
using C44_G03_OOP06.Third_Project.Abstract__User_Class;
using C44_G03_OOP06.Third_Project.Abstract_Discount_Class;
using C44_G03_OOP06.Third_Project.Specific_User_Types;
using static C44_G03_OOP06.Second_Project.Math;

namespace C44_G03_OOP06
{
    internal class Program
    {
        static Point3D ReadPointFromUser(string pointName)
        {
            int x, y, z;

            Console.Write($"Enter X for {pointName}: ");
            while (!int.TryParse(Console.ReadLine(), out x))
                Console.Write("invalid input. enter an integer: ");

            Console.Write($"enter Y for {pointName}: ");
            try
            {
                y = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.Write("invalid input. defaulting Y to 0.\n");
                y = 0;
            }

            Console.Write($"Enter Z for {pointName}: ");
            try
            {
                z = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.Write("invalid input. defaulting Z to 0.\n");
                z = 0;
            }

            return new Point3D(x, y, z);
        }

        static void Main(string[] args)
        {
            #region First Project
            //Point3D P = new Point3D(10, 10, 10);
            //Console.WriteLine(P.ToString());

            //Point3D P1 = ReadPointFromUser("P1");
            //Point3D P2 = ReadPointFromUser("P2");

            //if (P1 == P2)
            //    Console.WriteLine("P1 and P2 are equal");
            //else
            //    Console.WriteLine("P1 and P2 are not equal");

            //Point3D[] points =
            //{
            //    new Point3D(3, 2, 5),
            //    new Point3D(1, 5, 9),
            //    new Point3D(3, 1, 4),
            //    new Point3D(1, 2, 7)
            //};

            //Array.Sort(points);

            //Console.WriteLine("\nsorted points:");
            //foreach (var point in points)
            //    Console.WriteLine(point);

            //Point3D cloned = (Point3D)P1.Clone();
            //Console.WriteLine($"\ncloned point: {cloned}"); 
            #endregion

            /////////////////////////////////////////////////////////

            #region Second Project
            //double num1 = 10;
            //double num2 = 5;

            //Console.WriteLine($"Add: {Maths.Add(num1, num2)}");
            //Console.WriteLine($"Subtract: {Maths.Subtract(num1, num2)}");
            //Console.WriteLine($"Multiply: {Maths.Multiply(num1, num2)}");
            //Console.WriteLine($"Divide: {Maths.Divide(num1, num2)}"); 
            #endregion

            /////////////////////////////////////////////////////////

            #region Third Project
            //Console.WriteLine("Enter your user type (Regular / Premium / Guest):");
            //string userType = Console.ReadLine().Trim().ToLower();

            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();

            //User currentUser;

            //switch (userType)
            //{
            //    case "regular":
            //        currentUser = new RegularUser(userName);
            //        break;
            //    case "premium":
            //        currentUser = new PremiumUser(userName);
            //        break;
            //    case "guest":
            //        currentUser = new GuestUser(userName);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid user type. Defaulting to Guest.");
            //        currentUser = new GuestUser(userName);
            //        break;
            //}

            //Console.Write("Enter product price: ");
            //decimal price = decimal.Parse(Console.ReadLine());

            //Console.Write("Enter quantity: ");
            //int quantity = int.Parse(Console.ReadLine());

            //Discount discount = currentUser.GetDiscount();
            //decimal discountAmount = 0;

            //if (discount != null)
            //{
            //    discountAmount = discount.CalculateDiscount(price, quantity);
            //    Console.WriteLine($"Discount Applied: {discount.Name}");
            //}
            //else
            //{
            //    Console.WriteLine("No discount applied.");
            //}

            //decimal finalPrice = (price * quantity) - discountAmount;

            //Console.WriteLine($"\nTotal Discount: {discountAmount:C}");
            //Console.WriteLine($"Final Price: {finalPrice:C}"); 
            #endregion

        }
    }
}
