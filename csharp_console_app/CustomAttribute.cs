using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    public class CustomAttribute : Attribute
    {
        public string WrapUp { get; set; }

        public override string ToString()
        {
            return $"WrapUpCode - {WrapUp}";
        }
    }
}
