using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string style) => style.ToUpper() switch { 
            "CHEESE" => new CheesePizza("New York Cheese Pizza", new NYPizzaIngredientFactory()),
            "PEPPERONI" => new PepperoniPizza("New York Pepperoni Pizza", new NYPizzaIngredientFactory()),
            _ => throw new NotSupportedException()
        };
    }
}
