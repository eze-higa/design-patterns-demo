using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Abstract
{
    public abstract class Dough
    {
        protected string Name { get; private protected set; }
        public Dough(string name)
        {
            this.Name = name;
        }
    }
}
