using design_patterns.Patterns.StrategyPattern.Abstract;
using design_patterns.Patterns.StrategyPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StrategyPattern
{
    public static class StrategyPatternImplementation
    {
        public static void Run() {
            Character character = new King();
            character.UseWeapon();

            character = new Queen();
            character.UseWeapon();

            character = new Troll();
            character.UseWeapon();

            character.SetWeapon(new BowAndArrowBehavior());
            character.UseWeapon();

            character = new Knight();
            character.UseWeapon();
        }
    }
}
