using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class CheesePizza : Pizza
    {
        private PizzaIngredientFactory _factory;
        public CheesePizza(string name, PizzaIngredientFactory factory)
        {
            this.Name = name;
            this._factory = factory;            
        }
        public override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            this.Cheese = _factory.CreateCheese();
            this.Dough = _factory.CreateDough();
            this.Sauce = _factory.CreateSauce();
            this.Veggies = _factory.CreateVeggies();
        }
    }
}
