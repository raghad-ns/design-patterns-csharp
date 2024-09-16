using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.OrganizationHierarchy;

public class Branch : Component
{
    public string Location { get; }
    public List<Component> Children { get; set; } = new();

    public Branch(string name, string location) : base(name)
    {
        Location = location;
    }

    public override double GetTotalSalaries()
    {
        double total = 0;
        foreach (var component in Children)
        {
            total += component.GetTotalSalaries();
        }
        return total;
    }

    public void Add(Component comp)
    {
        Children.Add(comp);
    }

    public void Remove(Component comp)
    {
        Children.Remove(comp);
    }
}
