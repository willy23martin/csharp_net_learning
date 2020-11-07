using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class Inheritance : ITest
    {

        public void Test()
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

    }
}
