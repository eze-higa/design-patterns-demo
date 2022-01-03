using design_patterns.Patterns.DecoratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.DecoratorPattern.Concrete
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this._description = "Espresso";
        }
        public Espresso(string description)
        {
            this._description = description;
        }        
        public override double Cost()
        {
            return 1.99;
        }

        public override string GetDescription()
        {
            return _description;
        }
    }
}
