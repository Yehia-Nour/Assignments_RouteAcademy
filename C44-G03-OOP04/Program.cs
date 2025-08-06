namespace C44_G03_OOP04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part01
            #region Q1
            //Calculator calc = new Calculator();

            //Console.WriteLine("Sum of 5 and 10 (int): " + calc.Add(5, 10));

            //Console.WriteLine("Sum of 1, 2, 3 (int): " + calc.Add(1, 2, 3));

            //Console.WriteLine("Sum of 2.5 and 3.7 (double): " + calc.Add(2.5, 3.7));
            #endregion

            #region Q2
            //Rectangle rect1 = new Rectangle();
            //rect1.Display();

            //Rectangle rect2 = new Rectangle(10, 20);
            //rect2.Display();

            //Rectangle rect3 = new Rectangle(15);
            //rect3.Display();
            #endregion

            #region Q3
            //Complex c1 = new Complex(3, 4);
            //Complex c2 = new Complex(1, 2);

            //Complex sum = c1 + c2;
            //Complex diff = c1 - c2;

            //Console.WriteLine("Sum: " + sum);
            //Console.WriteLine("Difference: " + diff);
            #endregion

            #region Q4
            //Manager mgr = new Manager();
            //mgr.Work();
            #endregion

            #region Q5
            //BaseClass obj1 = new DerivedClass1();
            //obj1.DisplayMessage(); 

            //BaseClass obj2 = new DerivedClass2();
            //obj2.DisplayMessage(); 
            //DerivedClass2 obj3 = new DerivedClass2();
            //obj3.DisplayMessage();

            // Overriding: i could to access on the derived class from base class reference on derived class
            // Hiding: i could't to acess on the derived class from base class reference
            #endregion

            ///////////////////////////////////////////////////////

            // Part02

            //Duration D1 = new Duration(1, 10, 15);
            //Console.WriteLine(D1.ToString());

            //Duration D2 = new Duration(3600);
            //Console.WriteLine(D2.ToString());

            //Duration D3 = new Duration(7800);
            //Console.WriteLine(D3.ToString());

            //Duration D4 = new Duration(666);
            //Console.WriteLine(D4.ToString());

            /////////////////////////////////////////////////////////////

            //Duration D1 = new Duration(1, 10, 15);
            //Duration D2 = new Duration(7800);
            //Duration D3;

            //D3 = D1 + D2;
            //Console.WriteLine(D3);

            //D3 = D1 + 7800;
            //Console.WriteLine(D3);

            //D3 = 666 + D3;
            //Console.WriteLine(D3);

            //D3 = ++D1;
            //Console.WriteLine(D3);

            //D3 = --D2;
            //Console.WriteLine(D3);

            //D1 = D1 - D2;
            //Console.WriteLine(D1);

            //if (D1 > D2)
            //    Console.WriteLine("D1 is greater than D2");

            //if (D1 <= D2)
            //    Console.WriteLine("D1 is less than or equal to D2");

            //if (D1)
            //    Console.WriteLine("D1 is not zero");

            //DateTime dt = (DateTime)D1;
            //Console.WriteLine($"DateTime: {dt.ToLongTimeString()}");
        }
    }
}
