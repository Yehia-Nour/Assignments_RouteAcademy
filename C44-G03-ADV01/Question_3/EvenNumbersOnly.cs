using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV01.Question_3
{
    internal class EvenNumbersOnly
    {
        public static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evens = new List<int>();

            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    evens.Add(num);
                }
            }

            return evens;
        }
    }
}
