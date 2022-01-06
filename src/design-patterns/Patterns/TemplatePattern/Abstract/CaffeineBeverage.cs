using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.TemplatePattern.Abstract
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
                AddCondiment();
        }
        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring in the cup");
        }

        //hook method
        public virtual bool CustomerWantsCondiments() => true;
        public abstract void Brew();
        public abstract void AddCondiment();
    }
}
