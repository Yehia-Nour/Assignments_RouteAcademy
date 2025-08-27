using System.Collections;

namespace C44_G03_ADV02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1
            //int[] arr = { 11, 5, 3 };
            //int[] queries = { 1, 5, 13 };

            //var res = Assignment.CountGreaterThanX(arr, queries);

            //foreach (var r in res)
            //    Console.WriteLine(r);
            #endregion

            #region Question 2
            //int[] arr = { 1, 3, 2, 3, 1 };

            //string res = Assignment.IsPalindrome(arr);

            //Console.WriteLine(res);
            #endregion

            #region Question 3
            //Queue<int> q = new Queue<int>();
            //q.Enqueue(1);
            //q.Enqueue(2);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(5);

            //Assignment.ReverseQueue(q);

            //Console.WriteLine("reversed queue: " + string.Join(", ", q));

            #endregion

            #region Question 4
            //string input = "[()]{}}";

            //string res = Assignment.IsBalanced(input);

            //Console.WriteLine(res);
            #endregion

            #region Question 5
            //int[] arr = { 1, 2, 2, 3, 4, 4, 5 };
            //int[] unique = Assignment.RemoveDuplicates(arr);
            //Console.WriteLine("Array without duplicates: " + string.Join(", ", unique));
            #endregion

            #region Question 6
            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7 };
            //Assignment.RemoveOddNumbers(list);
            //Console.WriteLine("ArrayList without odd numbers: " + string.Join(", ", list.ToArray()));
            #endregion

            #region Question 7
            //Assignment.MixedQueue();
            #endregion

            #region Question 8
            //Stack<int> stack = new Stack<int>();
            //stack.Push(10);
            //stack.Push(20);
            //stack.Push(30);
            //stack.Push(40);
            //stack.Push(50);

            //int target;
            //Console.Write("enter target to search: ");
            //while (!int.TryParse(Console.ReadLine(), out target))
            //    Console.Write("invalid input, please enter a valid number: ");

            //Assignment.SearchInStack(stack, target);
            #endregion

            #region Question 9
            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };
            //var intersection = Assignment.ArrayIntersection(arr1, arr2);
            //Console.WriteLine("Intersection: [" + string.Join(", ", intersection) + "]");
            #endregion

            #region Question 10
            //ArrayList list = new ArrayList() { 1, 2, 3, 7, 5 };
            //int target = 12;
            //var sublist = Assignment.FindSublistWithSum(list, target);
            //Console.WriteLine("Sublist with sum " + target + ": [" + string.Join(", ", sublist) + "]");
            #endregion

            #region Question 11
            //Queue<int> queue = new Queue<int>(new int[] { 1, 2, 3, 4, 5 });
            //int k = 3;
            //Assignment.ReverseFirstKElements(queue, k);
            //Console.WriteLine("Queue after reversing first " + k + " elements: [" + string.Join(", ", queue) + "]");
            #endregion
        }
    }
}
