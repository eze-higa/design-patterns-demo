using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class PepperoniPizza : Pizza
    {
        private PizzaIngredientFactory _factory;
        public PepperoniPizza(string name, PizzaIngredientFactory factory)
        {
            this._factory = factory;
            this.Name = name;
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            this.Cheese = _factory.CreateCheese();
            this.Dough = _factory.CreateDough();
            this.Sauce = _factory.CreateSauce();
            this.Veggies = _factory.CreateVeggies();
            this.Pepperoni = _factory.CreatePepperoni();
        }
    }
}
