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

        // System.Object (Equals, ToString, GetHash):
        public override bool Equals(object obj)
        {
            Contact contact = (Contact)obj;
            return contact.id == id;
        }

        public override string ToString()
        {
            return $"Contact Id: {id} - Name: {name} - Position: {position.ToString()}";
        }

        // Always are different in the memory stack.
        // NOT RECOMMENDED TO MODIFY IT.
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
