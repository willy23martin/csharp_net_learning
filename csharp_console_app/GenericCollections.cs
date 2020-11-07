using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class GenericCollections : ITest
    {

        public void Test()
        {
            // To prevent boxing-unboxing computational costs.
            Console.WriteLine($"Generic List ...");
            List<int> genericList = new List<int>();
            genericList.AddRange(new int[] { 10, 20, 30 });
            genericList.Sort();
            foreach (int number in genericList)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

            Console.WriteLine($"Generic Stack ...");
            Stack<string> genericStack = new Stack<string>();
            genericStack.Push("A");
            genericStack.Push("M");
            genericStack.Push("O");
            genericStack.Push("R");
            Console.WriteLine(genericStack.Pop());
            Console.WriteLine(genericStack.Pop());
            Console.WriteLine(genericStack.Pop());
            Console.WriteLine(genericStack.Pop());
            Console.ReadKey();

            Console.WriteLine($"Generic Queue ...");
            Queue<string> genericQueue = new Queue<string>();
            genericQueue.Enqueue("A");
            genericQueue.Enqueue("M");
            genericQueue.Enqueue("O");
            genericQueue.Enqueue("R");
            Console.WriteLine(genericQueue.Dequeue());
            Console.WriteLine(genericQueue.Dequeue());
            Console.WriteLine(genericQueue.Dequeue());
            Console.WriteLine(genericQueue.Dequeue());
            Console.ReadKey();
        }

    }
}
