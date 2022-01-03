using design_patterns.Patterns.DecoratorPattern.Abstract;

namespace design_patterns.Patterns.DecoratorPattern.Concrete
{
    public class Mocha : CondimentDecorator
    {        
        public Mocha(Beverage beverage, string description): base(beverage)
        {            
            _description = description;
        }
        public Mocha(Beverage beverage): base(beverage)
        {
            this._description = "Mocha";
        }
        public override double Cost()
        {
            return _beverage.Cost() + .20;
        }

        public override string GetDescription()
        {
            return $"{_beverage.GetDescription()} {_description}";
        }
    }
}
