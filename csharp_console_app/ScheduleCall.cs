using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    static class ScheduleCall
    {
        public static string PlaceScheduleCallAnyTime(Contact contact)
        {
            return $"Scheduling callback to contact: {contact.id} at any time.";
        }

        public static string PlaceScheduleCallDefinedTime(this Contact contact, DateTime dateTime)
        {
            return $"Calling contact: {contact.id} at {dateTime.Day}-{dateTime.Month}-{dateTime.Year}";
        }

    }
}
