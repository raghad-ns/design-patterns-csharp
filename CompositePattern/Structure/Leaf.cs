﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern.Structure;

public class Leaf : Component
{
    public Leaf(string name) : base(name) { }

    public override void PrimaryOperation(int depth)
    {
        Console.WriteLine(new String('-', depth) + Name);
    }
}
