using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class NoLocalizedContact : Contact
    {

        public override string VoiceCallContact()
        {
            return $"Calling NoLocalized Contact: {id}";
        }

    }
}
