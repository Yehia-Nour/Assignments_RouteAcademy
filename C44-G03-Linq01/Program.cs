using System.Collections.Generic;
using static C44_G03_Linq01.Data.ListGenerator;
namespace C44_G03_Linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            // 1.  Find all products that are out of stock.
            //var list = ProductsList.Where(p => p.UnitsInStock == 0);

            // 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var list = ProductsList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);

            // 3. Returns digits whose name is shorter than their value.
            //string[] Arr = { "zero", "one", "two", "three", "four",
            //     "five", "six", "seven", "eight", "nine" };
            //var list = Arr.Where((name, index) => name.Length < index);

            //foreach (var item in list)
            //    Console.WriteLine(item);
            #endregion

            #region LINQ - Element Operators
            // 1. Get first Product out of Stock 
            //var product = ProductsList
            //    .FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(product);

            // 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var product = ProductsList
            //    .FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(product);

            // 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var number = Arr
            //    .Where(n => n > 5)
            //    .Skip(1)
            //    .FirstOrDefault();
            //Console.WriteLine(number);

            #endregion

            #region LINQ - Aggregate Operators
            // 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var count = Arr.Count(n => n % 2 != 0);

            //Console.WriteLine($"odd numbers count = {count}");


            // 2. Return a list of customers and how many orders each has.
            //var query = CustomersList
            //    .Select(c => new { c.CustomerName, OrdersCount = c.Orders.Length });

            //foreach (var item in query)
            //    Console.WriteLine($"{item.CustomerName} has {item.OrdersCount} orders");


            // 3. Return a list of categories and how many products each has
            //var query = ProductsList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, Count = g.Count() });

            //foreach (var item in query)
            //    Console.WriteLine($"{item.Category} has {item.Count} products");


            // 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var total = Arr.Sum();

            //Console.WriteLine($"Total = {total}");


            // 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var totalChars = words.Sum(w => w.Length);

            //Console.WriteLine($"Total Chars = {totalChars}");


            // 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var minLen = words.Min(w => w.Length);

            //Console.WriteLine($"min length = {minLen}");


            // 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var maxLen = words.Max(w => w.Length);

            //Console.WriteLine($"max length = {maxLen}");


            // 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var avgLen = words.Average(w => w.Length);
            //Console.WriteLine($"average length = {avgLen}");
            #endregion

            #region LINQ - Ordering Operators
            // 1. Sort a list of products by name
            //var query = ProductsList.OrderBy(p => p.ProductName);

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sorted = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sorted)
            //    Console.WriteLine(word);


            // 3. Sort a list of products by units in stock from highest to lowest.
            //var query = ProductsList.OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var query = Arr.OrderBy(w => w.Length).ThenBy(w => w);

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var query = Arr
            //    .OrderBy(w => w.Length) 
            //    .ThenBy(w => w, StringComparer.OrdinalIgnoreCase); 

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var query = ProductsList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var query = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in query)
            //    Console.WriteLine(item);

            // 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var query = Arr
            //    .Where(w => w.Length > 1 && w[1] == 'i')
            //    .Reverse();

            //foreach (var item in query)
            //    Console.WriteLine(item);
            #endregion

            #region LINQ – Transformation Operators
            // 1. Return a sequence of just the names of a list of products.
            //var names = ProductsList.Select(p => p.ProductName);


            // 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var query = words.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });

            //foreach (var item in query)
            //    Console.WriteLine(item);

            // 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var query = ProductsList
            //    .Select(p => new { p.ProductName, Price = p.UnitPrice });

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var query = Arr.Where((num, index) => num == index);

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { a, b };



            // 6. Select all orders where the order total is less than 500.00.
            //var query = OrdersList.Where(o => o.Total < 500);

            //foreach (var item in query)
            //    Console.WriteLine(item);


            // 7. Select all orders where the order was made in 1998 or later.
            //var query = OrdersList.Where(o => o.OrderDate.Year >= 1998);

            //foreach (var item in query)
            //    Console.WriteLine(item);
            #endregion
        }
    }
}
