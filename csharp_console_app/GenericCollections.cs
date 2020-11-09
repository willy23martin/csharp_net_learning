using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_console_app
{
    class GenericCollections : ITest
    {

        public void Test()
        {
            // To prevent boxing-unboxing computational costs.

            TestList();
            TestStack();
            TestQueue();
            TestDictionary();

        }

        private void TestList()
        {
            Console.WriteLine($"Generic List ...");
            List<int> genericList = new List<int>();
            genericList.AddRange(new int[] { 10, 20, 30 });
            genericList.Sort();
            foreach (int number in genericList)
            {
                Console.WriteLine(number);
            }
            Console.ReadKey();

            
        }

        private void TestStack()
        {
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
        }

        private void TestQueue()
        {
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
        }

        private void TestDictionary()
        {
            Console.WriteLine($"Generic Dictionary ...");

            Dictionary<string, Contact> contactList = new Dictionary<string, Contact>();
            contactList.Add("90", new Contact() { id = "90", name = "Name A", position = new StructA(1, 1) });
            contactList.Add("91", new Contact() { id = "91", name = "Name B", position = new StructA(1, 2) });
            contactList.Add("92", new TelemarketingContact() { telemarketing_id = "0092", id = "92", name = "Name C", position = new StructA(1, 3) });
            contactList.Add("93", new NoLocalizedContact() { id = "93", name = "Name D", position = new StructA(1, 4) });

            Console.WriteLine($"Contains contact with id 90? {contactList.ContainsKey("90")}");
            Contact toLookupContact = null;
            Console.WriteLine($"Contains contact with id 91 secure way? {contactList.TryGetValue("91", out toLookupContact)}");
            foreach(Contact contact in contactList.Values)
            {
                Console.WriteLine($"Contact in ContactList: {contact}");
            }    
            Console.ReadKey();
        }

    }
}
