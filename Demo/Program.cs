using System.Collections;

namespace Demo
{
    internal class Program
    {
        #region NonGeneric Collections
        public int SumArrayList(ArrayList array)
        {
            int Sum = 0;
            if (array is not null)
            {
                for (int i = 0; i < array.Count; i++)
                {
                    Sum += (int)array[i];//return object
                                         //unboxing :from object to int
                                         //unSafe Casting
                }
            }
            return -1;
        }
        #endregion
        #region Generic Collection [List]
        public static int SumList(List<int> list)
        {
            int sum = 0;
            if (list != null)
            {
                for (int i = 0; i < list.Count; i++)
                {
                    sum = sum + list[i];
                }
            }
            return sum;
        }
        #endregion
        static void Main(string[] args)
        {
            #region NonGeneric Collections
            ArrayList arrayList = new ArrayList();
            //arraylist=>Size=0
            Console.WriteLine(arrayList.Count); //actual numbers of elements in arrayList
            Console.WriteLine(arrayList.Capacity); //Numbers Of Elements that can be hold
            arrayList.Add(5);//casting (5) value type to object refrence type //boxing
            arrayList.Add(5);
            arrayList.Add("ALiaa");//heterogeneoues List //invalidCastingException
            arrayList.AddRange(new int[] {3,4,5});
            arrayList.TrimToSize();//old array naw it is not reachable
            //create new array in heap with default size 4 and the first array will be not reachable
            Console.WriteLine(arrayList.Count); //actual numbers of elements in arrayList
            Console.WriteLine(arrayList.Capacity); //Numbers Of Elements that can be hold //default capacity =4
            #endregion        
            #region Generic Collection [List]
            List<int> list = new List<int>();
            Console.WriteLine(list.Count);//0
            Console.WriteLine(list.Capacity);//0
            list.Add(0);
            //upon adding the first element to the list the capacity is set default capacity 4
            //ad the count is 1
            //create new array in heap with size 4
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            list.AddRange(new int[] { 1, 2, 3, 4 });//the Count is 5 and the capacity is doubled it is 8
            //create  new array in heap with double size =>8
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            //8-5=3*4[int]=12 unused bytes
            list.TrimExcess(); //create  new array with size = count of elemnts 
            //now i have unreached object
            Console.WriteLine("after trim");
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);


            //********define the number of capacity and count
            Console.WriteLine("better way");
            List<int> Numbers = new List<int>(5) { 1, 2, 3, 4, 5 };
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.WriteLine("print numbers with foreach ");
            foreach (var item in Numbers)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("print numbers with for loop ");

            for (int i = 0; i < Numbers.Count; i++)
            {
                //use the indexer to get the value
                Console.WriteLine(Numbers[i]);

            }
            //we can use the idexer to set the value
            Numbers[2] = 200;
            Console.WriteLine(Numbers[2]);
            //Numbers[20] = 200;
            //Console.WriteLine(Numbers[20]);//Unhandled exception. // you can not use the indexer to add new element
            int sumList = SumList(Numbers);
            Console.WriteLine(sumList);
            #endregion

            #region Generic Collection [List-Methods]
            Console.WriteLine("______List Methods____");
            List<int> Numbers02 = new List<int>();
            Numbers02.Add(1);
            Numbers02.AddRange(new int[] { 1, 2 });
            foreach (var item in Numbers02) { Console.WriteLine(item); }
            Console.WriteLine("___after insert____");
            Numbers02.Insert(0, 20);
            Numbers02.InsertRange(4, new int[] { 9, 10, 12, 13 });
            foreach (var item in Numbers02) { Console.WriteLine(item); }
            int index = Numbers02.BinarySearch(9);
            int index2 = Numbers02.BinarySearch(4500);
            Console.WriteLine($"index of number 9 is {index}");
            //Numbers02.Clear();
            Console.WriteLine(Numbers02.Contains(13));//TRUE
            Console.WriteLine(Numbers02.Contains(103));//false
            int[] array = new int[40];
            // Numbers02.CopyTo(array);
            //Numbers02.CopyTo(array,0);
            Numbers02.CopyTo(3, array, 0, 2);
            #endregion

            #region Generic Collection [Linked List]
            Console.WriteLine("*******LinkedList*******");
            LinkedList<int> linkedList = new LinkedList<int>();
            Console.WriteLine(linkedList.Count);
            linkedList.AddFirst(1);
            linkedList.AddLast(3);
            LinkedListNode<int> AfterNode = linkedList.Find(1);
            linkedList.AddBefore(AfterNode, 4);
            Console.WriteLine(linkedList.Count);
            #endregion
            #region Generic Collection [Stalk]
            #endregion
            #region Generic Collection [Queue]
            #endregion
        }
    }
}