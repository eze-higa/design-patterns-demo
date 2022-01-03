using design_patterns.Patterns.FactoryMethodPattern.Abstract;
using design_patterns.Patterns.FactoryMethodPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern
{
    public static class FactoryMethodPatternImplementation
    {
        public static void Run() {
            string cheeseType = "cheese";
            string pepperoniType = "pepperoni";

            PizzaStore pizzaStore = new ChicagoStylePizzaStore();

            Pizza pizza = pizzaStore.OrderPizza(cheeseType);
            pizza = pizzaStore.OrderPizza(pepperoniType);

            pizzaStore = new NYStylePizzaStore();

            pizza = pizzaStore.OrderPizza(cheeseType);
            pizza = pizzaStore.OrderPizza(pepperoniType);
        }
    }
}
