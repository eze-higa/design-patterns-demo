using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Abstract
{
    public abstract class Sauce
    {
        protected string Name { get; protected private set; }
        public Sauce( string name)
        {
            this.Name = name;
        }
    }
}
