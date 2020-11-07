using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class OutboundCampaign : ITest
    {
        public ContactList<TelemarketingContact> outboundContactList { get; set; }

        public static string[] dialModes = { "PREVIEW", "PROGRESSIVE", "PREDICTIVE", "MANUAL" };

        public void Test()
        {
            foreach(TelemarketingContact contact in outboundContactList.contacts)
            {
                DialContact(dialModes[2], contact);
            }
        }

        private void DialContact(string dialMode, TelemarketingContact contact)
        {
            Console.WriteLine($"Contact was Dialed in {dialMode} mode: {contact.VoiceCallContact()}");
        }
    }
}
