using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public override Cheese CreateCheese()
        {
            return new MozzarellaCheese();
        }

        public override Dough CreateDough()
        {
            return new ThickDough();
        }

        public override Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public override Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public override ICollection<Veggie> CreateVeggies()
        {
            return new List<Veggie>() { new Onion(), new RedPepper() };
        }
    }
}
