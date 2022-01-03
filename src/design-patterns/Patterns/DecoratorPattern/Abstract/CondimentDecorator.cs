using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.DecoratorPattern.Abstract
{
    public abstract class CondimentDecorator: Beverage
    {
        protected Beverage _beverage;
        public CondimentDecorator(Beverage beverage)
        {
            this._beverage = beverage;
        }

        public override double Cost() => _beverage.Cost();

        public override string GetDescription() => _beverage.GetDescription();
    }
}
