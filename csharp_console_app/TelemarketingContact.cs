using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class TelemarketingContact : Contact
    {

        public string telemarketing_id { get; set; }

        public override string VoiceCallContact()
        {
            telemarketing_id = id;
            return $"Calling Telemarketing Contact: {telemarketing_id}";
        }

    }
}
