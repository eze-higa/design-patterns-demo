using design_patterns.Patterns.FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Concrete
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string style) => style.ToUpper() switch
        {
            "CHEESE" => new ChicagoStyleCheesePizza(),
            "PEPPERONI" => new ChicagoStylePepperoniPizza(),
            _ => throw new ArgumentException("We only have Cheese and pepperoni")
        };
    }
}
