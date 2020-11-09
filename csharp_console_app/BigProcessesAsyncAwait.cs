using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class BigProcessesAsyncAwait : ITest
    {

        public void Test()
        {
            // The Big Process need to be moved to the main Thread to be executed.
            ContactList<Contact> contactList = new ContactList<Contact>();
            contactList.Name = "BigContactListProcessed";
            Contact contactA = new Contact();
            contactA.id = "10787";
            contactA.name = "Name A";
            contactA.position = new StructA(1, 1);
            contactA.CellPhones = new List<CellPhone>() {
                new CellPhone() { Provider= "ProviderA", Number="313"},
                new CellPhone() { Provider= "ProviderB", Number="314"},
                new CellPhone() { Provider= "ProviderA", Number="315"}
            };

            NoLocalizedContact contactB = new NoLocalizedContact();
            contactB.id = "909";
            contactB.name = "Name B";
            contactB.position = new StructA(1, 2);
            contactB.CellPhones = new List<CellPhone>() {
                new CellPhone() { Provider= "ProviderA", Number="316"},
                new CellPhone() { Provider= "ProviderB", Number="317"},
                new CellPhone() { Provider= "ProviderA", Number="318"}
            };
     
            Contact contactC = new Contact();
            contactC.id = "910";
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

            ContactListDownloader.DownloadContactList(".CSV", contactList);
            Console.WriteLine("\n");
            Console.ReadKey();
        }

    }
}
