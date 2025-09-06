using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal class LibraryEngine
    {
        public static void ProcessBooks(List<Book> books, Func<Book, object> fPtr)
        {
            foreach (var b in books)
            {
                Console.WriteLine(fPtr(b));
            }
        }
    }
}
