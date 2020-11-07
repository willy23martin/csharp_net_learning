using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace csharp_console_app
{
    class ReflectionTest : ITest
    {
        public void Test()
        {
            var Contact = Activator.CreateInstance<Contact>();
            CustomAttribute wrapUpCode = (CustomAttribute)Contact.GetType().GetCustomAttributes(false).FirstOrDefault();
            
            PropertyInfo[] properties = Contact.GetType().GetProperties();
            Console.WriteLine(properties[0].GetValue(wrapUpCode));
            properties[0].SetValue(wrapUpCode, "Email Contacted Yet");
            Console.WriteLine(properties[0].GetValue(wrapUpCode));
            Console.WriteLine($"Contact wrapUp: {wrapUpCode}");

            MethodInfo[] methods = wrapUpCode.GetType().GetMethods();
            MethodInfo toString = methods.FirstOrDefault(m => m.Name=="ToString");
            if(toString != null)
            {
                toString.Invoke(wrapUpCode, null);
            }

            // Assembly assembly = Assembly.GetAssembly();

            Console.ReadKey();
        }
    }
}
