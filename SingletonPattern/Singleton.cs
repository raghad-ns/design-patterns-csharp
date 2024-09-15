using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

internal class Singleton
{
    private static Singleton _instance;
    private static readonly object _lock = new object();
    public static Singleton Instance
    {
        get { 
            if (_instance == null)
            {
                // Enforcing thread safety using locking
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            return _instance;
        }
    }
    // Using static constructor, the instance will be initialized when we first reference any static member of the class
    // Lazy initialization  
    // If static constructor is used, no need for locks
    static Singleton()
    {

    }
}
