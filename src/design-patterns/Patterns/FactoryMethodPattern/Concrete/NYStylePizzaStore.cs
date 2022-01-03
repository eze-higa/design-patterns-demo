using design_patterns.Patterns.FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Concrete
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string style) => style.ToUpper() switch
        {
            "CHEESE" => new NYStyleCheesePizza(),
            "PEPPERONI" => new NYStylePepperoniPizza(),
            _ => throw new ArgumentException("We only have Cheese and pepperoni")
        };
    }
}
