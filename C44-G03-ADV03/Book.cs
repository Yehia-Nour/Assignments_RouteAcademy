using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV03
{
    internal class Book
    {

            public string Title { get; set; }
            public string ISBN { get; set; }
            public DateTime PublicationDate { get; set; }

            public override string ToString()
            {
                return $"Title: {Title}, ISBN: {ISBN}, Date: {PublicationDate.ToShortDateString()}";
            }
    }
}
