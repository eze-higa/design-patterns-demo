using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public override Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new ChoppedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public override ICollection<Veggie> CreateVeggies()
        {
            return new List<Veggie> { new Garlic(), new Onion(), new Mushroom() };
        }
    }
}
