using design_patterns.Patterns.FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Concrete
{
    public class ChicagoStylePepperoniPizza: Pizza
    {
        public ChicagoStylePepperoniPizza(string name, string dough, string sauce, IList<string> toppings): base(name, dough, sauce, toppings)
        {
        }
        public ChicagoStylePepperoniPizza()
        {
            this.Name = "Chicago Style Pepperoni Pizza";
            this.Dough = "Extra Thick Crust Dough";
            this.Sauce = "Plum Tomato Sauce";
            this.Toppings = new List<string> { "Big Pepperoni Slices" };
        }
    }
}
