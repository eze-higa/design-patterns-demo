using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Abstract
{
    public abstract class PizzaIngredientFactory
    {
        public abstract Dough CreateDough();
        public abstract Sauce CreateSauce();
        public abstract Cheese CreateCheese();
        public abstract Pepperoni CreatePepperoni();
        public abstract ICollection<Veggie> CreateVeggies();
    }
}
