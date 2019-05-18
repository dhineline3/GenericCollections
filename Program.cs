using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("List");
            List<string> Animals = new List<string>();
            Animals.Add("Lion");
            Animals.Add("Tiger");
            Animals.Add("Elephant");
            Animals.Add("Giraffe");
            Animals.Add("Zebra");
            for (var i = 0; i < Animals.Count; i++)
            {
                string ListValue = Animals[i];
                Console.WriteLine($"Animal {i}: {ListValue}");
            }
            Console.WriteLine();

            Console.WriteLine("Linked List");
            LinkedList<string> linked = new LinkedList<string>();

            linked.AddLast("cat");
            linked.AddLast("dog");
            linked.AddLast("man");
            linked.AddFirst("first");
            foreach (var item in linked)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            Console.WriteLine("Queue");
            Queue<string> collection = new Queue<string>();
            collection.Enqueue("cat");
            collection.Enqueue("dog");
            collection.Enqueue("elephant");
            collection.Enqueue("lion");
            collection.Enqueue("tiger");
            foreach (string QueueValues in collection)
            {
                Console.WriteLine(QueueValues);
            }
            Console.WriteLine();

            Console.WriteLine("Stack");
            Stack<int> GetStack()
            {
                Stack<int> stack1 = new Stack<int>();
                stack1.Push(100);
                stack1.Push(1000);
                stack1.Push(10000);
                stack1.Push(100000);
                stack1.Push(1000000);
                return stack1;
            }
            var stack = GetStack();
            Console.WriteLine("--- Stack contents ---");
            foreach (int i in stack)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            Console.WriteLine("Dictionary<TKey, TValue>");
            var data = new Dictionary<string, int>()
            {
            {"cat", 2},
            {"dog", 1},
            {"llama", 0},
            {"iguana", -1}
            };
            // Store keys in a List.
            var list = new List<string>(data.Keys);
            // Loop through the List.
            foreach (string key in list)
            {
                Console.WriteLine("KEY FROM LIST: " + key);
            }
            Console.WriteLine();

            Console.WriteLine("SortedList");
            SortedList<string, int> sorted = new SortedList<string, int>();
            sorted.Add("lion", 1);
            sorted.Add("tiger", 2);
            sorted.Add("bear", 3);
            sorted.Add("giraffe", 4);
            sorted.Add("elephant", 5);
            foreach (var pair in sorted)
            {
                Console.WriteLine(pair);
            }
            Console.WriteLine();

            Console.WriteLine("HashSet<T>");
            string[] array1 =
            {
            "cat",
            "dog",
            "cat",
            "leopard",
            "tiger",
            "cat"
            };
            Console.WriteLine(string.Join(",", array1));
            var hash = new HashSet<string>(array1);
            string[] array2 = hash.ToArray();
            Console.WriteLine(string.Join(",", array2));
        }

    }
}
