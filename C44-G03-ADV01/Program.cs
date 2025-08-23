using C44_G03_ADV01.Question_1;
using C44_G03_ADV01.Question_2;
using C44_G03_ADV01.Question_3;
using C44_G03_ADV01.Question_4;
using C44_G03_ADV01.Question_5;
using System.Collections;

namespace C44_G03_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question_1
            //var intRange = new Range<int>(10, 20);
            //Console.WriteLine(intRange.IsInRange(15));
            //Console.WriteLine(intRange.Length());
            #endregion


            #region Question_2
            //ArrayList arr = new ArrayList() { 1, 2, 3, 4, 5, 6 };

            //Console.WriteLine("Before: " + string.Join(", ", arr.ToArray()));

            //ReverseArrayList.Reverse(arr);

            //Console.WriteLine("After: " + string.Join(", ", arr.ToArray()));
            #endregion


            #region Question_3
            //List<int> nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

            //List<int> result = EvenNumbersOnly.GetEvenNumbers(nums);

            //Console.WriteLine("Even numbers: " + string.Join(", ", result));
            #endregion


            #region Question_4
            //FixedSizeList<int> list = new FixedSizeList<int>(3);

            //list.Add(10);
            //list.Add(20);
            //list.Add(30);

            //Console.WriteLine("Element at index 1: " + list.Get(4));
            #endregion


            #region Question_5
            //string str = "aabbcddhbbz";

            //int index = NonRepeatedCharacter.FirstNonRepeatedCharIndex(str);

            //Console.WriteLine("First non-repeated char index: " + index);
            #endregion

        }
    }
}
