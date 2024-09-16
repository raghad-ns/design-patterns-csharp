using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.OrganizationHierarchy;

public interface IComposite
{
    public void Add(Component c);
    public void Remove(Component c);
}
