using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class Declarations : ITest
    {

        public void Test()
        {
            // Numbers:
            int number = 0;
            number += 2;
            number -= 2;

            // Comparison operators:
            // == != >= <= > <
            // Logical operators: && ||

            // Conditionals:
            if (number == 0)
            {

            }
            else if (number > 0)
            {

            }
            else
            {

            }

            // Loops:
            for (int i = 0; i < 10; i++)
            {

            }

            while (number < 10)
            {
                number++;
            }

            int[] numbers = { 1, 2, 3, 5 };
            foreach (int num in numbers)
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
            Console.WriteLine($"Decimal Number: {decimalNumber}");
            Console.WriteLine($"Boolean value: {yOrNot}");
            Console.WriteLine($"Empty str: {str}");
        }

    }
}
