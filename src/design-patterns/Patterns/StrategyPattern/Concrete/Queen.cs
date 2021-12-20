using design_patterns.Patterns.StrategyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StrategyPattern.Concrete
{
    public class Queen : Character
    {
        public Queen()
        {
            this._weaponBehavoir = new BowAndArrowBehavior();
        }
        public override void UseWeapon()
        {
            this._weaponBehavoir.UseWeapon();
        }
    }
}
