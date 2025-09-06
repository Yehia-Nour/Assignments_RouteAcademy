namespace C44_G03_ADV03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> library = new List<Book>
            {
                new Book{Title = "C#", ISBN = "111", PublicationDate = new DateTime(2020,1,1)},
                new Book{Title = "C++", ISBN = "333", PublicationDate = new DateTime(2021,5,15)},
                new Book{Title = "C", ISBN = "555", PublicationDate = new DateTime(2022,10,10)}
            };

            Console.WriteLine("=== Using User Defined Delegate ===");
            BookFunctions.BookDelegate del = new BookFunctions.BookDelegate(BookFunctions.GetTitle);
            foreach (var b in library)
                Console.WriteLine(del(b));

            Console.WriteLine("\n=== Using BCL Delegate (Func<>) ===");
            LibraryEngine.ProcessBooks(library, new Func<Book, object>(BookFunctions.GetTitle));

            Console.WriteLine("\n=== Using Anonymous Method (GetISBN) ===");
            LibraryEngine.ProcessBooks(library, delegate (Book b) { return b.ISBN; });

            Console.WriteLine("\n=== Using Lambda Expression (GetPublicationDate) ===");
            LibraryEngine.ProcessBooks(library, b => b.PublicationDate);
        }
    }
}