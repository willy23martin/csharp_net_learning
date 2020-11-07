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
            LinqFirstTest(contactList);
            LinqLastTest(contactList);
            LinqTakeTest(contactList);
            LinqSkipTest(contactList);

            LinqOrderByTest(contactList);
            LinqGroupByTest(contactList);
            LinqOfTypeTest();

        }

        private void LinqOfTypeTest()
        {
            Console.WriteLine("Linq OfType Test...");
            ContactList<Contact> contactList = new ContactList<Contact>();
            Contact contact = new Contact();
            contact.id = "10989";
            contact.name = "WMC";
            contact.position = new StructA(1, 1);
            contactList.contacts.Add(contact);
            Contact contactB = new Contact();
            contactB.id = "989";
            contactB.name = "WMC II";
            contactB.position = new StructA(1, 2);
            contactList.contacts.Add(contactB);

            List<NoLocalizedContact> noLocalizedContacts = contactList.contacts.OfType<NoLocalizedContact>().ToList();
            foreach (NoLocalizedContact noLocalizedContact in noLocalizedContacts)
            {
                Console.WriteLine($"Contact of type TelemarketingContact: ${noLocalizedContact}");
            }

            Console.WriteLine("\n");
            Console.ReadKey();

        }

        private void LinqGroupByTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq GroupBy Test...");
            OutboundCampaign outboundCampaign = new OutboundCampaign();
            outboundCampaign.outboundContactList = contactList;
            outboundCampaign.Test();

            Dictionary<int, IGrouping<int, TelemarketingContact>> contactListGroupedByNumberOfCalls = outboundCampaign.outboundContactList.contacts.OrderByDescending(contact => contact.id).GroupBy(contact => contact.NumberOfVoiceCalls).ToDictionary(contact => contact.Key);
            foreach (IGrouping<int, TelemarketingContact> groupsOfContacts in contactListGroupedByNumberOfCalls.Values)
            {
                foreach (TelemarketingContact telemarketingContact in groupsOfContacts.Take(3))
                {
                    Console.WriteLine($"Contact grouped by {groupsOfContacts.Key} - {telemarketingContact} \n");
                }
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private void LinqOrderByTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq OrderBy Test...");
            OutboundCampaign outboundCampaign = new OutboundCampaign();
            outboundCampaign.outboundContactList = contactList;
            outboundCampaign.Test();

            List<TelemarketingContact> contactListOrderedById = outboundCampaign.outboundContactList.contacts.OrderByDescending(contact => contact.id).ToList();
            foreach (TelemarketingContact contactOrderedById in contactListOrderedById)
            {
                Console.WriteLine($"Contact ordered by Id {contactOrderedById}");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private void LinqWhereTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Where Test...");
            var contacts = contactList.contacts.Where(contact => contact.telemarketing_id.Contains("9"));
            foreach (TelemarketingContact contact in contacts)
            {
                Console.WriteLine($"Telemarketing Contact: {contact}");
            }
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
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
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private void LinqAnyTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Any Test...");
            bool existId = contactList.contacts.Any(contact => contact.id.Contains("7"));
            Console.WriteLine($"Exist any contact with Telemarketing Id with 7?: {existId}");
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private void LinqFirstTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq First Test...");
            TelemarketingContact firstContact = contactList.contacts.First(contact => contact.name.Contains("A"));
            if (firstContact != null)
            {
                Console.WriteLine($"Telemarketing First Contact: {firstContact}");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private void LinqLastTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Last Test...");
            TelemarketingContact lastContact = contactList.contacts.Last(contact => contact.name.Contains("Name"));
            if (lastContact != null)
            {
                Console.WriteLine($"Telemarketing Last Contact: {lastContact}");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }

        private void LinqTakeTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Take Test...");
            List<TelemarketingContact> contactsTaken = contactList.contacts.Take(2).ToList();
            foreach (TelemarketingContact contact in contactsTaken)
            {
                Console.WriteLine($"Telemarketing Contact Taken: {contact}");
            }
            Console.ReadKey();
        }

        private void LinqSkipTest(ContactList<TelemarketingContact> contactList)
        {
            Console.WriteLine("Linq Skip Test...");
            List<TelemarketingContact> contactsTaken = contactList.contacts.Skip(2).ToList();
            foreach (TelemarketingContact contact in contactsTaken)
            {
                Console.WriteLine($"Telemarketing Contact Taken: {contact}");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
