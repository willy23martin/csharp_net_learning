using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace csharp_console_app
{
    class TelemarketingContact : Contact
    {

        public string telemarketing_id { get; set; }

        public TelemarketingContact()
        {
            telemarketing_id = id;
        }

        public override string VoiceCallContact()
        {
            telemarketing_id = id;
            return $"Calling Telemarketing Contact: {telemarketing_id}";
        }

        public override string ToString()
        {
            return $"Contact TelemarketingId: {telemarketing_id} - Name: {name} - Position: {position}";
        }

    }
}
