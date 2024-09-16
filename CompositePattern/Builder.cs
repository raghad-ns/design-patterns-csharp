using CompositePattern.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern;

public class Builder
{
    public Composite Root { get; }
    private Composite _currentComposite;

    public Builder(string root)
    {
        Root = new Composite(root);
        _currentComposite = Root;
    }

    public void AddComposite(string name)
    {
        Composite composite = new(name);
        _currentComposite.Add(composite);
        _currentComposite = composite;
    }

    public void AddLeaf(string name)
    {
        Leaf leaf = new(name);
        _currentComposite.Add(leaf);
    }

    public void SetCurrentComposite(string name, Composite? startWith = null)
    {
        startWith ??= Root;

        if (startWith.Name.Equals(name))
        {
            _currentComposite = startWith;
            return;
        }

        foreach (Component component in startWith.Children)
        {
            if (component.Name.Equals(name))
            {
                _currentComposite = (Composite)component;
                return;
            }
            if (component is Composite) SetCurrentComposite(name, component as Composite);
        }
    }
}
