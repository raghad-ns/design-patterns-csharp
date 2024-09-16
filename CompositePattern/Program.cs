using CompositePattern.OrganizationHierarchy;
using CompositePattern.Structure;

namespace CompositePattern;

internal class Program
{
    // This is the client
    static void Main(string[] args)
    {
        var root = new Branch("Root branch", "USA");
        var sales = new Department("Sales");
        var hr = new Department("HR");
        var socialMedia = new Department("Social media");
        root.Add(sales);
        root.Add(hr);
        sales.Add(socialMedia);
        socialMedia.Add(new Employee("John", 2000));
        hr.Add(new Employee("Dan", 1800));
        hr.Add(new Employee("Sara", 2200));
        socialMedia.Add(new Employee("Tim", 2500));
        Console.WriteLine($"Social media total salaries: {socialMedia.GetTotalSalaries()}");
        Console.WriteLine($"Sales total salaries: {sales.GetTotalSalaries()}");
        Console.WriteLine($"HR total salaries: {hr.GetTotalSalaries()}");
        Console.WriteLine($"Total salaries: {root.GetTotalSalaries()}");
    }

    private static void BuilderExample()
    {
        Builder builder = new("Root");
        builder.AddComposite("comp1");
        builder.AddLeaf("leaf1");
        builder.AddLeaf("leaf2");
        builder.SetCurrentComposite("Root");
        builder.AddLeaf("rootLeaf");
        builder.AddComposite("comp2");
        builder.AddLeaf("Leaf21");
        builder.Root.PrimaryOperation(1);
    }

    private static void StructureExample()
    {
        Composite root = new("Root");
        Composite comp1 = new Composite("comp1");
        Composite comp2 = new Composite("comp2");
        root.Add(comp1);
        comp1.Add(comp2);
        root.Add(new Leaf("Leaf1"));
        comp1.Add(new Leaf("Leaf2"));
        comp2.Add(new Leaf("Leaf3"));
        comp2.Add(new Leaf("Leaf4"));

        root.PrimaryOperation(1);
    }
}
