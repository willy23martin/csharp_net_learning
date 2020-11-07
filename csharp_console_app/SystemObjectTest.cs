using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_console_app
{
    class SystemObjectTest : ITest
    {

        public void Test() 
        {
            Contact contactA = new Contact();
            contactA.id = "90998989";
            contactA.name = "Name A";
            contactA.position = new StructA(2, 1);
            Console.WriteLine(contactA);
        }

    }
}
