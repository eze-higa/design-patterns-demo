using design_patterns.Patterns.StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StrategyPattern.Concrete
{
    public class KnifeBehavior : IWeaponBehavior
    {        
        public void UseWeapon()
        {
            Console.WriteLine("Swinging the knife");
        }
    }
}
