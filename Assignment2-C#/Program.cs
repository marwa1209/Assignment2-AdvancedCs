using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Xml.Linq;
using System;

namespace Assignment2_C_
{
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
        }
    }
}
