using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Abstract
{
    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string style)
        {
            Pizza pizza = CreatePizza(style);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
        public abstract Pizza CreatePizza(string style);
    }
}
