using CompositePattern.Structure;

namespace CompositePattern;

internal class Program
{
    // This is the client
    static void Main(string[] args)
    {
        
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
