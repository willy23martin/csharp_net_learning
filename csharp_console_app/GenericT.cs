using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class GenericT : ITest
    {
        public void Test()
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

            Console.ReadKey();

            ContactList<TelemarketingContact> telemarketingContactList = new ContactList<TelemarketingContact>();

            TelemarketingContact contactC = new TelemarketingContact();
            contactC.telemarketing_id = "908";
            contactC.name = "Name A";
            contactC.position = new StructA(1, 1);

            TelemarketingContact contactD = new TelemarketingContact();
            contactD.telemarketing_id = "909";
            contactD.name = "Name D";
            contactD.position = new StructA(1, 2);

            telemarketingContactList.Insert(contactC);
            telemarketingContactList.Insert(contactD);

            Console.WriteLine($"ContactList: \n {telemarketingContactList}");

            Console.WriteLine($"ContactC was finded? {telemarketingContactList.getContactInformation("908")}");
            Console.WriteLine($"ContactD was finded? {telemarketingContactList.getContactInformation("909")}");

            Console.ReadKey();
        }

    }
}
