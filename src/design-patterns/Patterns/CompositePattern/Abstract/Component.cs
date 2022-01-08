using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CompositePattern.Abstract
{
    public abstract class Component
    {
        public virtual void AddChild(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void RemoveChild(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual Component GetChildren(int index)
        {
            throw new NotImplementedException();
        }
        public abstract bool IsLeaf();
        

        public abstract void Print();
    }
}
