using design_patterns.Patterns.FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Concrete
{
    public class NYStylePepperoniPizza: Pizza
    {
        public NYStylePepperoniPizza(string name, string dough, string sauce, IList<string> toppings): base(name, dough, sauce, toppings)
        {
        }

        public NYStylePepperoniPizza()
        {
            this.Name = "NY Style Sauce and Pepperoni Pizza";
            this.Dough = "Thin Crust Dough";
            this.Sauce = "Marinara Sauce";
            this.Toppings = new List<string> { "Smalls piece of Pepperoni" };
        }
    }
}
