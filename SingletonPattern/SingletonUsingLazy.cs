using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern;

internal class SingletonUsingLazy
{
    // By default thread safe
    private static readonly Lazy<SingletonUsingLazy> _lazy = new(() => new SingletonUsingLazy());
    public static SingletonUsingLazy Instance
    {
        get
        {
            return _lazy.Value;
        }
    }
}
