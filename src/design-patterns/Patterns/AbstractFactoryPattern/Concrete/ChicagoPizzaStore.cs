using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string style) => style.ToUpper() switch { 
            "CHEESE" => new CheesePizza("Chicago Cheese Pizza", new ChicagoPizzaIngredientFactory()),
            "PEPPERONI" => new PepperoniPizza("Chicago Pepperoni Pizza", new ChicagoPizzaIngredientFactory()),
            _ => throw new NotSupportedException()
        };
    }
}
