using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class Contact : ICall
    {
        public string telemarketing_id { get; set; }
        public string name { get; set; }
        public StructA position { get; set; }
        public string VoiceCallContact()
        {
            return $"Calling contact: {telemarketing_id}";
        }
    }
}
