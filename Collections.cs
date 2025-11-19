using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // for list
            Console.WriteLine("------------For List---------- ");
            List<string> name = new List<string>();
            name.Add("Suryansh");
            name.Add("Sumit");
            name.Add("Nandini");
            Console.WriteLine("List items:");

            foreach (string names in name)
            {
                Console.WriteLine(names);
            }

            // for dictionary
            Console.WriteLine("----------- For Dictionary-----------");
            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Suryansh");
            dict.Add(2, "Khushi");
            dict.Add(3, "Nandini");
            Console.WriteLine("Dictionary items:");

            foreach (var s in dict)
            {
                Console.WriteLine(s);
            }

            // for queue
            Console.WriteLine("----------- For Queue-----------");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Suryansh");
            queue.Enqueue("Ayushi");
            queue.Enqueue("Nandini");

            foreach (var q in queue)
            {
                Console.WriteLine(q);
            }

            // for stack
            Console.WriteLine("----------- For Stack-----------");
            Stack<string> stack = new Stack<string>();
            stack.Push("Suryansh");
            stack.Push("Nandini");
            stack.Push("Ankit");

            Console.WriteLine("peek: " + stack.Peek());
            Console.WriteLine("popped: " + stack.Pop());

            foreach (var s in stack)
            {
                Console.WriteLine(s);
            }

            // for hashset
            Console.WriteLine("----------- For HashSet-----------");

            HashSet<string> set = new HashSet<string>();
            set.Add("Suryansh");
            set.Add("Nandini");
            set.Add("Aman");
            foreach (var hash in set)
            {
                Console.WriteLine(hash);
            }

            // for linkedlist
            Console.WriteLine("----------- For LinkedList-----------");
            LinkedList<string> List = new LinkedList<string>();
            List.AddLast("Nandini");
            List.AddLast("Rohit");
            List.AddLast("Suryansh");
            foreach (var linked in List)
            {
                Console.WriteLine(linked);
            }
        }
    }
}
