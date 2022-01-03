using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Abstract
{
    public abstract class Pizza
    {
        protected string Name { get; protected private set; }
        protected Cheese Cheese { get; protected private set; }
        protected Dough Dough { get;  protected private set; }
        protected Sauce Sauce { get; protected private set; }
        protected Pepperoni Pepperoni { get; protected private set;}
        protected ICollection<Veggie> Veggies { get; protected private set; }
        public abstract void Prepare();
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
