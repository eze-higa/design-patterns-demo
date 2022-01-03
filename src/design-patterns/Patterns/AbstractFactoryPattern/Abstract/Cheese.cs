using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Abstract
{
    public abstract class Cheese
    {
        protected string Name { get; private protected set; }
        public Cheese(string name)
        {
            this.Name = name;
        }
    }
}
