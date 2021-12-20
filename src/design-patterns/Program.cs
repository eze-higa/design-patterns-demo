
using design_patterns.Patterns.StrategyPattern.Abstract;
using design_patterns.Patterns.StrategyPattern.Concrete;

public class Program
{    
    static void Main() {
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
