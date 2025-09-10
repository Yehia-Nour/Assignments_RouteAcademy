using System.Collections.Generic;
using static C44_G03_Linq02.Data.ListGenerator;
namespace C44_G03_Linq02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Aggregate Operators
            // 1. Get the total units in stock for each product category.
            //var res = ProductsList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //    });

            //foreach (var item in res)
            //    Console.WriteLine($"{item.Category} : {item.TotalUnitsInStock}");


            // 2. Get the cheapest price among each category's products
            //var res = ProductsList
            //              .GroupBy(p => p.Category)
            //              .Select(c => new { Category = c.Key, CheapestPrice = c.Min(p => p.UnitPrice) });

            //foreach (var item in res)
            //    Console.WriteLine($"{item.Category} : {item.CheapestPrice}");


            // 3. Get the products with the cheapest price in each category (Use Let)
            //var res = from p in ProductsList
            //          group p by p.Category into g
            //          let minPrice = g.Min(x => x.UnitPrice)
            //          from prod in g
            //          where prod.UnitPrice == minPrice
            //          select new
            //          {
            //              Category = g.Key,
            //              ProductName = prod.ProductName,
            //              CheapestPrice = prod.UnitPrice
            //          };

            //foreach (var item in res)
            //    Console.WriteLine($"{item.Category} : {item.ProductName} ({item.CheapestPrice})");


            // 4. Get the most expensive price among each category's products.
            //var res = ProductsList
            //            .GroupBy(p => p.Category)
            //            .Select(g => new
            //            {
            //                Category = g.Key,
            //                MaxPrice = g.Max(p => p.UnitPrice)
            //            });

            //foreach (var item in res)
            //    Console.WriteLine($"{item.Category} : {item.MaxPrice}");


            // 5. Get the products with the most expensive price in each category
            //var res = from p in ProductsList
            //      group p by p.Category into g
            //      let maxPrice = g.Max(x => x.UnitPrice)
            //      from prod in g
            //      where prod.UnitPrice == maxPrice
            //      select new
            //      {
            //          Category = g.Key,
            //          ProductName = prod.ProductName,
            //          MaxPrice = prod.UnitPrice
            //      };

            //foreach (var item in res)
            //    Console.WriteLine($"{item.Category} : {item.ProductName} ({item.MaxPrice})");


            // 6. Get the average price of each category's products
            //var res = ProductsList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        AveragePrice = g.Average(p => p.UnitPrice)
            //    });

            //foreach (var item in res)
            //    Console.WriteLine($"{item.Category} : {item.AveragePrice:F2}");
            #endregion

            #region LINQ - Set  Operators
            // 1. Find the unique Category names from Product List
            //var res = (from p in ProductsList
            //           select p.Category).Distinct();

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 2. Produce a Sequence containing the unique first letter from both product and customer names
            //var res = (from p in ProductsList
            //       select p.ProductName[0])
            //      .Union(from c in CustomersList
            //             select c.CustomerName[0]);

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 3. Create one sequence that contains the common first letter from both product and customer names
            //var res = (from p in ProductsList
            //       select p.ProductName[0])
            //      .Intersect(from c in CustomersList
            //                 select c.CustomerName[0]);

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 4. Create one sequence that contains the first letters of product names that are not also first letters of customer names
            //var res = (from p in ProductsList
            //       select p.ProductName[0])
            //      .Except(from c in CustomersList
            //              select c.CustomerName[0]);

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 5. Create one sequence that contains the last three characters in each name of all customers and products, including any duplicates
            //var res = (from p in ProductsList
            //       select p.ProductName.Substring(Math.Max(0, p.ProductName.Length - 3)))
            //      .Concat(from c in CustomersList
            //              select c.CustomerName.Substring(Math.Max(0, c.CustomerName.Length - 3)));

            //foreach (var item in res)
            //    Console.WriteLine(item);


            #endregion

            #region LINQ - Partitioning Operators
            // 1. Get the first 3 orders from customers in Washington
            //var res = (from c in CustomersList
            //           where c.City == "Washington"
            //           from o in c.Orders
            //           select o).Take(3);

            //foreach (var item in res)
            //    Console.WriteLine($"{item.OrderID} - {item.Total}");


            // 2. Get all but the first 2 orders from customers in Washington
            //var res = (from c in CustomersList
            //       where c.City == "Washington"
            //       from o in c.Orders
            //       select o).Skip(2);

            //foreach (var item in res)
            //    Console.WriteLine($"{item.OrderID} - {item.Total}");


            // 3. Return elements starting from the beginning of the array 
            //    until a number is hit that is less than its position in the array
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 4. Get the elements of the array starting from the first element divisible by 3
            //var numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 5. Get the elements of the array starting from the first element less than its position
            //var numbers = new int[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var res = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var item in res)
            //    Console.WriteLine(item);

            #endregion

            #region LINQ - Quantifiers Operators
            // 1. Determine if any of the words in dictionary_english.txt contain the substring 'ei'
            //string[] dictionary = File.ReadAllLines("dictionary_english.txt");

            //var res = dictionary.Where(w => w.Contains("ei"));

            //foreach (var item in res)
            //    Console.WriteLine(item);


            // 2. Return a grouped list of products only for categories 
            //    that have at least one product that is out of stock
            //var res = from p in ProductsList
            //      group p by p.Category into g
            //      where g.Any(p => p.UnitsInStock == 0)
            //      select g;

            //foreach (var group in res)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //        Console.WriteLine($"   {product.ProductName} - {product.UnitsInStock}");
            //}


            // 3. Return a grouped list of products only for categories 
            //    that have all of their products in stock
            //var res = from p in ProductsList
            //      group p by p.Category into g
            //      where g.All(p => p.UnitsInStock > 0)
            //      select g;

            //foreach (var group in res)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //        Console.WriteLine($"   {product.ProductName} - {product.UnitsInStock}");
            //}

            #endregion

            #region LINQ – Grouping Operators
            // 1. Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var res = from n in numbers
            //          group n by n % 5;

            //foreach (var group in res)
            //{
            //    Console.WriteLine($"Numbers with a remainder of {group.Key} when divided by 5:");
            //    foreach (var num in group)
            //        Console.WriteLine(num);
            //    Console.WriteLine();
            //}


            // 2. Use group by to partition a list of words by their first letter (dictionary_english.txt)
            //string[] words = File.ReadAllLines("dictionary_english.txt");

            //var res = from w in words
            //      group w by w[0];

            //foreach (var group in res)
            //{
            //    Console.WriteLine($"First letter {group.Key}:");
            //    foreach (var word in group)
            //        Console.WriteLine($"   {word}");
            //}


            // 3. Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };

            //var res = from w in Arr
            //          group w by String.Concat(w.OrderBy(c => c));

            //foreach (var group in res)
            //{
            //    foreach (var word in group)
            //        Console.WriteLine(word);
            //    Console.WriteLine("....");
            //}
                #endregion
        }
    }
}
