using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using design_patterns.Patterns.AbstractFactoryPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern
{
    public static class AbstractFactoryPatternImplementation
    {
        public static void Run()
        {
            string cheeseType = "cheese";
            string pepperoniType = "pepperoni";
            
            PizzaStore pizzaStore = new NYPizzaStore();
            Pizza pizza = pizzaStore.OrderPizza(cheeseType);
            pizza = pizzaStore.OrderPizza(pepperoniType);

            pizzaStore = new ChicagoPizzaStore();
            pizza = pizzaStore.OrderPizza(cheeseType);
            pizza = pizzaStore.OrderPizza(pepperoniType);
        }
    }
}
