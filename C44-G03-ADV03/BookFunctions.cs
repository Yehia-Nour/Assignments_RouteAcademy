using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal class BookFunctions
    {
        public delegate string BookDelegate(Book b);

        public static string GetTitle(Book b)
        {
            return b.Title;
        }

        public static string GetISBN(Book b)
        {
            return b.ISBN;
        }

        public static DateTime GetPublicationDate(Book b)
        {
            return b.PublicationDate;
        }
    }
}
