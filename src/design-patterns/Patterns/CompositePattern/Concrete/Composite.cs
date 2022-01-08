using design_patterns.Patterns.CompositePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CompositePattern.Concrete
{
    public class Composite : Component
    {
        private ICollection<Component> _components;
        public Composite(ICollection<Component> components)
        {
            this._components = components;
        }
        public override void AddChild(Component component)
        {
            this._components.Add(component);
        }
        public override Component GetChildren(int index)
        {
            return this._components.ElementAt(index);           
        }
        public override void RemoveChild(Component component)
        {
            this._components.Remove(component);
        }

        public override bool IsLeaf()
        {
            return false;
        }

        public override void Print()
        {
            Console.WriteLine("I'm a composite");
            foreach(var component in this._components)
            {
                component.Print();
            }
        }
    }
}
