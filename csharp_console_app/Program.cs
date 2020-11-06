using System;

namespace csharp_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Hello World!");
        }

        static void Classes()
        {
            Contact contact = new Contact();
            contact.telemarketing_id = "10989";
            contact.name = "WMC";
            contact.position = new StructA(1, 2);
            Console.WriteLine(contact.VoiceCallContact());
            Console.ReadKey();
        }

        static void Declarations()
        {
            // Numbers:
            int number = 0;
            number += 2;
            number -= 2;

            // Comparison operators:
            // == != >= <= > <
            // Logical operators: && ||

            // Conditionals:
            if (number==0)
            {

            }else if (number > 0){       

            } else {

            }

            // Loops:
            for(int i = 0; i < 10; i++)
            {

            }

            while (number < 10)
            {
                number++;
            }

            int[] numbers = {1,2,3,5 };
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }

            // Switch:
            switch (number)
            {
                case 10:
                    Console.WriteLine("10");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            double decimalNumber = 0.0d;
            bool yOrNot = true;
            string str = string.Empty;
        }
    }
}
