using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Abstract
{
    public abstract class Pepperoni
    {
        protected string Name { get; protected private set; }

        public Pepperoni(string name)
        {
            this.Name = name;
        }
    }
}
