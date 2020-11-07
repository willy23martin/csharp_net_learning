using System;

namespace csharp_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals... \n");
            Declarations();
            Classes();
            Inheritance();
            SystemObjectMethodsOverriding();
            GenericsT();
        }

        static void GenericsT()
        {

            ContactList<Contact> contactList = new ContactList<Contact>();

            Contact contactA = new Contact();
            contactA.id = "90998989";
            contactA.name = "Name A";
            contactA.position = new StructA(1, 1);

            Contact contactB = new Contact();
            contactB.id = "10989";
            contactB.name = "Name B";
            contactB.position = new StructA(1, 2);

            contactList.Insert(contactA);
            contactList.Insert(contactB);

            Console.WriteLine($"ContactList: \n {contactList}");

            Console.WriteLine($"ContactA was finded? {contactList.getContactInformation("90998989")}");
            Console.WriteLine($"ContactB was finded? {contactList.getContactInformation("10989")}");
            Console.WriteLine($"Undefined Contact was finded? {contactList.getContactInformation("09")}");

            Console.ReadKey();

            ContactList<TelemarketingContact> telemarketingContactList = new ContactList<TelemarketingContact>();

            Contact contactC = new TelemarketingContact();
            contactC.id = "908";
            contactC.name = "Name A";
            contactC.position = new StructA(1, 1);

            Contact contactD = new TelemarketingContact();
            contactD.id = "909";
            contactD.name = "Name D";
            contactD.position = new StructA(1, 1);

            telemarketingContactList.Insert((TelemarketingContact)contactC);
            telemarketingContactList.Insert((TelemarketingContact)contactD);

            Console.WriteLine($"ContactList: \n {telemarketingContactList}");

            Console.WriteLine($"ContactA was finded? {telemarketingContactList.getContactInformation("908")}");
            Console.WriteLine($"ContactB was finded? {telemarketingContactList.getContactInformation("909")}");

            Console.ReadKey();
        }

        static void SystemObjectMethodsOverriding()
        {
            Contact contactA = new Contact();
            contactA.id = "90998989";
            contactA.name = "Name A";
            contactA.position = new StructA(2, 1);
            Console.WriteLine(contactA);
        }

        static void Classes()
        {
            Contact contact = new Contact();
            contact.id = "10989";
            contact.name = "WMC";
            contact.position = new StructA(1, 1);
            Console.WriteLine(contact.VoiceCallContact());
            Console.ReadKey();
        }

        static void Inheritance()
        {
            TelemarketingContact telemarketingContact = new TelemarketingContact();
            telemarketingContact.id = "235333";
            telemarketingContact.name = "MCW";
            telemarketingContact.position = new StructA(1, 2);
            Console.WriteLine(telemarketingContact.VoiceCallContact());

            NoLocalizedContact noLocalizedContact = new NoLocalizedContact();
            noLocalizedContact.id = "90089";
            noLocalizedContact.name = "NML";
            noLocalizedContact.position = new StructA(1, 3);
            Console.WriteLine(noLocalizedContact.VoiceCallContact());

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
