using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C44_G03_ADV02
{
    internal class Assignment
    {
        public static List<int> CountGreaterThanX(int[] arr, int[] queries)
        {
            List<int> results = new List<int>();

            foreach (int x in queries)
            {
                int count = 0;
                foreach (int num in arr)
                {
                    if (num > x) count++;
                }
                results.Add(count);
            }

            return results;
        }

        public static string IsPalindrome(int[] arr)
        {
            int left = 0;
            int right = arr.Length - 1;

            while (left < right)
            {
                if (arr[left] != arr[right]) return "NO";
                left++;
                right--;
            }

            return "YES";
        }

        public static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());
        }
    

        public static string IsBalanced(string str)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in str)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return "Not Balanced";

                    char top = stack.Pop();
                    if ((c == ')' && top != '(') ||
                        (c == '}' && top != '{') ||
                        (c == ']' && top != '['))
                    {
                        return "Not Balanced";
                    }
                }
            }

            return stack.Count == 0 ? "Balanced" : "Not Balanced";
        }

        public static int[] RemoveDuplicates(int[] arr)
        {
            HashSet<int> set = new HashSet<int>(arr);
            int[] result = new int[set.Count];
            set.CopyTo(result);
            return result;
        }

        public static void RemoveOddNumbers(ArrayList list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if ((int)list[i] % 2 != 0)
                    list.RemoveAt(i);
            }
        }

        public static void MixedQueue()
        {
            Queue<object> queue = new Queue<object>();
            queue.Enqueue(1);
            queue.Enqueue("Apple");
            queue.Enqueue(5.28);

            foreach (var item in queue)
                Console.WriteLine(item);
        }

        public static void SearchInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;

            foreach (int item in stack)
            {
                count++;
                if (item == target)
                {
                    Console.WriteLine($"target was found successfully and the count = {count}");
                    found = true;
                    break;
                }
            }

            if (!found)
                Console.WriteLine("target was not found");
        }

        public static List<int> ArrayIntersection(int[] arr1, int[] arr2)
        {
            Dictionary<int, int> freq = new Dictionary<int, int>();
            List<int> result = new List<int>();

            foreach (int num in arr1)
            {
                if (!freq.ContainsKey(num))
                    freq[num] = 0;
                freq[num]++;
            }

            foreach (int num in arr2)
            {
                if (freq.ContainsKey(num) && freq[num] > 0)
                {
                    result.Add(num);
                    freq[num]--;
                }
            }

            return result;
        }

        public static List<int> FindSublistWithSum(ArrayList list, int target)
        {
            int start = 0;
            int currentSum = 0;

            for (int end = 0; end < list.Count; end++)
            {
                currentSum += (int)list[end];

                while (currentSum > target && start <= end)
                {
                    currentSum -= (int)list[start];
                    start++;
                }

                if (currentSum == target)
                {
                    List<int> sublist = new List<int>();
                    for (int i = start; i <= end; i++)
                        sublist.Add((int)list[i]);

                    return sublist;
                }
            }

            return new List<int>(); 
        }

        public static void ReverseFirstKElements(Queue<int> queue, int k)
        {
            if (k <= 0 || k > queue.Count) return;

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < k; i++)
                stack.Push(queue.Dequeue());

            while (stack.Count > 0)
                queue.Enqueue(stack.Pop());

            int remaining = queue.Count - k;
            for (int i = 0; i < remaining; i++)
                queue.Enqueue(queue.Dequeue());
        }
    }
}
