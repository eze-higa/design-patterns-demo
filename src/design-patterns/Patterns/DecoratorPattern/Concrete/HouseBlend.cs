using design_patterns.Patterns.DecoratorPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.DecoratorPattern.Concrete
{
    public class HouseBlend : Beverage
    {
        public HouseBlend(string description)
        {
            this._description = description;
        }
        public override double Cost()
        {
            return .89;
        }

        public override string GetDescription()
        {
            return _description;
        }
    }
}
