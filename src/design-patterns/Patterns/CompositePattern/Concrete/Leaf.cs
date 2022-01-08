using design_patterns.Patterns.CompositePattern.Abstract;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CompositePattern.Concrete
{
    public class Leaf : Component
    {
        public override bool IsLeaf()
        {
            return true;
        }

        public override void Print()
        {
            Console.WriteLine("I'm a Leaf!");
        }
    }
}
