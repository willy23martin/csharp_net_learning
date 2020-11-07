using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace csharp_console_app
{
    static class ContactListDownloader
    {
        /**
         * References: 
         * - CSVHelper: https://joshclose.github.io/CsvHelper/getting-started
         * */
        public static string[] Extensions = { ".CSV", ".PDF" };

        public async static void DownloadContactList(string Extension, ContactList<Contact> ContactList)
        {
            switch (Extension)
            {
                case ".CSV":
                    await Task.Run(()=> { DownloadContactListInCSVFormat(ContactList); });
                    break;
                case ".PDF":
                    await Task.Run(() => { DownloadContactListInPDFFormat(ContactList); });
                    break;
                default:
                    await Task.Run(() => { DownloadContactListInCSVFormat(ContactList); });
                    break;
            }
        }

        private async static void DownloadContactListInPDFFormat(ContactList<Contact> contactList)
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Not able yet");
            });
        }

        private async static void DownloadContactListInCSVFormat(ContactList<Contact> contactList)
        {
            Console.WriteLine("Generating the Contact List in a .CSV file in your Desktop...");

            List<Header> header = new List<Header>()
            {
                new Header()
            };

            // Reference: https://stackoverflow.com/questions/634142/how-to-get-a-path-to-the-desktop-for-current-user-in-c
            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            await Task.Run(() =>
            {
                using (var csvGenerator = new StreamWriter(pathToDesktop + @"\" + $"{contactList.Name}.csv"))
                using (var csvWriter = new CsvWriter(csvGenerator, CultureInfo.InvariantCulture))
                {
                    csvWriter.WriteRecords(header);
                    csvWriter.WriteRecords(contactList.contacts);
                }
            });

        }

    }


}
