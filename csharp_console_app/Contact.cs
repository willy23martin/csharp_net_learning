using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class Contact : ICall
    {
        public string id { get; set; }
        public string name { get; set; }
        public StructA position { get; set; }
        public virtual string VoiceCallContact()
        {
            return $"Calling contact: {id}";
        }
    }
}
