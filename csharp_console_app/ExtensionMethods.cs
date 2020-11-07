using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class ExtensionMethods : ITest
    {
        public void Test()
        {
            Contact contactToExtend = new Contact();
            contactToExtend.id = "99";
            contactToExtend.name = "Name T";
            contactToExtend.position = new StructA(1, 1);
            Console.WriteLine(ScheduleCall.PlaceScheduleCallAnyTime(contactToExtend));
            Console.WriteLine(ScheduleCall.PlaceScheduleCallDefinedTime(contactToExtend, DateTime.Now)); // Extension
            Console.ReadKey();

        }
    }
}
