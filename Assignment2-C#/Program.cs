using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;
using System;
using System.Collections;

namespace Assignment2_C_
{
    #region Part2-Q3
    public class FixedSizeList<T>
    {
        private T[] items;
        private int count;
        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be greater than zero.");
            }
            items = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= items.Length)
            {
                throw new InvalidOperationException("List is full. Cannot add more elements.");
            }

            items[count] = item;
            count++;
        }

        public T Get(int index)
        {
            if (index < 0 || index >= count)
            {
                throw new IndexOutOfRangeException("Index is out of range.");
            }

            return items[index];
        }

        public int Count => count;

        public int Capacity => items.Length;
    } 
    #endregion
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Report about all Collections  Part01
          /*
           * 1.Arrays
             Structure:
            -Arrays in C# are fixed-size, ordered collections of elements of the same type.
            - Stored in contiguous memory, allowing direct access via indices.
 
            C# Example:
           */
            int[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[2]); // Output: 3

            /*
                2. Linked Lists
                Structure:
                - A linked list in C# is a dynamic data structure consisting of nodes where each node contains data and a reference to the next node.
                - Allows efficient insertion and deletion as it doesn't require contiguous memory.

                C# Example:
            */

            LinkedList<int> list = new LinkedList<int>();
            list.AddLast(1);
            list.AddLast(2);
            list.AddLast(3);
            Console.WriteLine(list.First.Value); // Output: 1

            /*
                3. Stacks
                Structure:
                - A stack is a LIFO (Last In, First Out) collection.
                - Elements are added and removed from the top of the stack.


                C# Example:
            */
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop()); // Output: 3

            /*
                4. Queues
                Structure:
                - A queue is a FIFO (First In, First Out) collection.
                - Elements are added at the rear and removed from the front.

                C# Example:
            */
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Console.WriteLine(queue.Dequeue()); // Output: 1

            #endregion
            #region Part 02
            #region Q1
            ArrayList listQ1 = new ArrayList { 1, 2, 3, 4, 5 };
            ReverseArrayList(listQ1);
            foreach (var item in listQ1)
            {
                Console.Write(item + " ");
            }
            #endregion
            #region Q2
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            List<int> evenNumbers = GetEvenNumbers(numbers);

            foreach (var number in evenNumbers)
            {
                Console.Write(number + " ");  
            }
            #endregion
            #region Q3
            try
            {
                FixedSizeList<int> fixedList = new FixedSizeList<int>(5);

                fixedList.Add(10);
                fixedList.Add(20);
                fixedList.Add(30);

                Console.WriteLine(fixedList.Get(1));
                Console.WriteLine(fixedList.Count);
                Console.WriteLine(fixedList.Capacity);

                fixedList.Add(40);
                fixedList.Add(50);
                fixedList.Add(60);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                FixedSizeList<int> fixedList = new FixedSizeList<int>(3);
                fixedList.Add(1);
                fixedList.Add(2);

                Console.WriteLine(fixedList.Get(5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            } 
            #endregion
            #endregion
        }
        #region Part02-q1
        static void ReverseArrayList(ArrayList arrayList)
        {
            int left = 0;                          
            int right = arrayList.Count - 1;      

            while (left < right)
            {
                var temp = arrayList[left];
                arrayList[left] = arrayList[right];
                arrayList[right] = temp;

                left++;
                right--;
            }
        }
        #endregion
        #region Part02-q2
        static List<int> GetEvenNumbers(List<int> numbers)
        {
            List<int> evenNumbers = new List<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)  
                {
                    evenNumbers.Add(number); 
                }
            }

            return evenNumbers;
        } 
        #endregion
    }
}
