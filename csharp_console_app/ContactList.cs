﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp_console_app
{
    // C# Generics:
    class ContactList<T>
    {
        public HashSet<T> contacts = new HashSet<T>();

        public void Insert(T contact)
        {
            if(contact != null)
            {
                contacts.Add(contact);
            }
            else
            {
                throw new Exception("The contact must be defined");
            }
        }

        public String getContactInformation(String contactId)
        {
            return contacts.Where(c => c.ToString().Contains(contactId)).First().ToString();
        }

        public override string ToString()
        {
            string toString = "";

            foreach(T element in contacts)
            {
                toString += element.ToString()+"; \n";
            }

            return toString;
        }

    }
}