using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structure;

public class Composite : Component
{
    public Composite(string name) : base(name) { }
    public List<Component> Children { get; set; } = new();

    public void Add(Component c)
    {
        Children.Add(c);
    }

    public override void PrimaryOperation(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
        foreach (Component c in Children)
        {
            c.PrimaryOperation(depth + 1);
        }
    }

    public void Remove(Component c)
    {
        Children.Remove(c);
    }
}
