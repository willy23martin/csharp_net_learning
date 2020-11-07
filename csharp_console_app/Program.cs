using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Numerics;
using System.Reflection;

namespace csharp_console_app
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("C# Fundamentals... \n");
            Declarations();
            Classes();
            Inheritance();
            SystemObjectMethodsOverriding();
            GenericsT();
            GenericCollections();
            ExtensionMethods();
            Linq();
            BigProcessesAsyncAwait();
            Reflection();
        }

        private static void Reflection()
        {
            ReflectionTest reflectionTest = new ReflectionTest();
            reflectionTest.Test();
        }

        private static void BigProcessesAsyncAwait()
        {
            BigProcessesAsyncAwait bigProcessesAsyncAwait = new BigProcessesAsyncAwait();
            bigProcessesAsyncAwait.Test();
        }

        static void Linq()
        {
            Linq linq = new Linq();
            linq.Test();
        }

        static void ExtensionMethods()
        {
            ExtensionMethods extensionMethods = new ExtensionMethods();
            extensionMethods.Test();
        }

        static void GenericCollections()
        {
            GenericCollections genericCollections = new GenericCollections();
            genericCollections.Test();
        }

        static void GenericsT()
        {
            GenericT genericT = new GenericT();
            genericT.Test();
        }

        static void SystemObjectMethodsOverriding()
        {
            SystemObjectTest systemObjectTest = new SystemObjectTest();
            systemObjectTest.Test();
        }

        static void Classes()
        {
            Classes classes = new Classes();
            classes.Test();
        }

        static void Inheritance()
        {
            Inheritance inheritance = new Inheritance();
            inheritance.Test();
        }

        static void Declarations()
        {
            Declarations declarations = new Declarations();
            declarations.Test();
        }
    }
}
