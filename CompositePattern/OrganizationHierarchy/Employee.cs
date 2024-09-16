using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.OrganizationHierarchy;

public class Employee: Component
{
    public double Salary { get; set; }

    public Employee(string name, double salary): base(name)
    {
        this.Salary = salary;
    }

    public override double GetTotalSalaries()
    {
        return this.Salary;
    }
}
