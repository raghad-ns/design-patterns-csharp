using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structure;

public abstract class Component
{
    public readonly string Name;
    public Component(string name)
    {
        Name = name;
    }

    public abstract void PrimaryOperation(int depth);

}
