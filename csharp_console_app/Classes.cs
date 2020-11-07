using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class Classes : ITest
    {

        public void Test()
        {
            Contact contact = new Contact();
            contact.id = "10989";
            contact.name = "WMC";
            contact.position = new StructA(1, 1);
            Console.WriteLine(contact.VoiceCallContact());
            Console.ReadKey();
        }

    }
}
