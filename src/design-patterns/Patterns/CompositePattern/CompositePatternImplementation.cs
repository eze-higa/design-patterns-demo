using design_patterns.Patterns.CompositePattern.Abstract;
using design_patterns.Patterns.CompositePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CompositePattern
{
    public static class CompositePatternImplementation
    {
        public static void Run()
        {
            Component leaf = new Leaf();
            ICollection<Component> childs = new List<Component>() { new Leaf(), new Leaf() };
            Component composite = new Composite(childs);
            Component root = new Composite(new List<Component>() { leaf, composite});

            root.Print();
        }
    }
}
