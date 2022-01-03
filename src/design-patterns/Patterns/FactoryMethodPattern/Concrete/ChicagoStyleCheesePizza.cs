using design_patterns.Patterns.FactoryMethodPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Concrete
{
    public class ChicagoStyleCheesePizza: Pizza
    {
        public ChicagoStyleCheesePizza(string name, string dough, string sauce, IList<string> toppings) : base(name, dough, sauce, toppings)
        {

        }
        public ChicagoStyleCheesePizza()
        {
            this.Name = "Chicago Style Deep Dish Cheese Pizza";
            this.Dough = "Extra Thick Crust Dough";
            this.Sauce = "Plum Tomato Sauce";
            this.Toppings = new List<string> { "Shredded Mozzarella Cheese" };
        }

        public new void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
        }
    }
}
