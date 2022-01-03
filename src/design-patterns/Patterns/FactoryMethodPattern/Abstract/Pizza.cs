using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FactoryMethodPattern.Abstract
{
    public abstract class Pizza
    {
        protected string Name { get; protected private set;}
        protected string Dough { get; protected private set; }
        protected string Sauce { get; protected private set; }
        protected IList<string> Toppings { get; protected private set; }
        public Pizza(string name, string dough, string sauce, IList<string> toppings)
        {
            this.Name = name;
            this.Dough = dough;
            this.Sauce = sauce;
            this.Toppings = toppings;
        }
        public Pizza()
        {

        }
        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough..");
            Console.WriteLine("Adding sauce");
            Console.WriteLine("Adding toppings: ");
            foreach(var topping in Toppings)
            {
                Console.WriteLine(topping);
            }
        }

        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 30");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices.");
        }
        public void Box()
        {
            Console.WriteLine("Place the pizza in official PizzaStore box");
        }
    }
}
