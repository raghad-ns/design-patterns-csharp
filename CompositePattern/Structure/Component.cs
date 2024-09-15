using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structure;

internal abstract class Component
{
    public readonly string Name;
    public Component(string name)
    {
        Name = name;
    }

    public abstract void PrimaryOperation(int depth);
    public abstract void Add(Component c);
    public abstract void Remove(Component c);
}
