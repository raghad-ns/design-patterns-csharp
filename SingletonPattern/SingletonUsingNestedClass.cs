using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

// Singleton, nested class approach
internal class SingletonUsingNestedClass
{
    public static SingletonUsingNestedClass Instance
    {
        get
        {
            return Nested._instance;
        }
    }

    private class Nested
    {
        internal static readonly SingletonUsingNestedClass _instance;

        // Creating static constructor, so that the singleton instance is initialized once we called any static member of the class
        static Nested ()
        {

        }
    }
}
