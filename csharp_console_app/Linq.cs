using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_console_app
{
    class Linq : ITest
    {

        public void Test()
        {
            ContactList<TelemarketingContact> contactList = new ContactList<TelemarketingContact>();
            TelemarketingContact contactA = new TelemarketingContact();
            contactA.id = "10787";
            contactA.telemarketing_id = contactA.id;
            contactA.name = "Name A";
            contactA.position = new StructA(1, 1);
            contactA.CellPhones = new List<CellPhone>() { 
                new CellPhone() { Provider= "ProviderA", Number="313"},
                new CellPhone() { Provider= "ProviderB", Number="314"},
                new CellPhone() { Provider= "ProviderA", Number="315"}
            };

            TelemarketingContact contactB = new TelemarketingContact();
            contactB.id = "909";
            contactB.telemarketing_id = contactB.id;
            contactB.name = "Name B";
            contactB.position = new StructA(1, 2);
            contactB.CellPhones = new List<CellPhone>() {
                new CellPhone() { Provider= "ProviderA", Number="316"},
                new CellPhone() { Provider= "ProviderB", Number="317"},
                new CellPhone() { Provider= "ProviderA", Number="318"}
            };

            TelemarketingContact contactC = new TelemarketingContact();
            contactC.id = "910";
            contactC.telemarketing_id = contactC.id;
            contactC.name = "Name C";
            contactC.position = new StructA(1, 3);
            contactC.CellPhones = new List<CellPhone>() {
                new CellPhone() { Provider= "ProviderA", Number="319"},
                new CellPhone() { Provider= "ProviderB", Number="320"},
                new CellPhone() { Provider= "ProviderA", Number="321"}
            };

            contactList.Insert(contactA);
            contactList.Insert(contactB);
            contactList.Insert(contactC);

            LinqWhereTest(contactList);
            LinqSelectTest(contactList);
            LinqSelectManyTest(contactList);
            LinqAnyTest(contactList);
        }

        private void LinqWhereTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Where Test...");
            var contacts = contactList.contacts.Where(contact => contact.telemarketing_id.Contains("9"));
            foreach(TelemarketingContact contact in contacts)
            {
                Console.WriteLine($"Telemarketing Contact: {contact}");
            }
            Console.ReadKey();
        }

        private void LinqSelectTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Select Test...");
            var contactsDefinitions = contactList.contacts.Select(contact => contact.ToString());
            foreach (string contactDefinition in contactsDefinitions)
            {
                Console.WriteLine($"Telemarketing Contact Definition: {contactDefinition}");
            }
            Console.ReadKey();
        }

        private void LinqSelectManyTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Select Many Test...");
            var contactCellPhones = contactList.contacts.SelectMany(contact => contact.CellPhones).Select(cellPhone => cellPhone.Number);
            foreach (string cellphone in contactCellPhones)
            {
                Console.WriteLine($"Telemarketing Contact's cellphone: {cellphone}");
            }
            Console.ReadKey();
        }

        private void LinqAnyTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Any Test...");
            bool existId = contactList.contacts.Any(contact => contact.id.Contains("7"));
            Console.WriteLine($"Exist any contact with Telemarketing Id with 7?: {existId}");
            Console.ReadKey();
        }
    }
}
