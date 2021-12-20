using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StrategyPattern.Abstract
{
    public abstract class Character
    {
        protected IWeaponBehavior _weaponBehavoir;
        public void SetWeapon(IWeaponBehavior weaponBehavoir) => this._weaponBehavoir = weaponBehavoir;

        public abstract void UseWeapon();
    }
}
