using design_patterns.Patterns.DecoratorPattern.Abstract;
using design_patterns.Patterns.DecoratorPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.DecoratorPattern
{
    public static class DecoratorPatternImplementation
    {
        public static void Run() {
            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");

            beverage = new Mocha(beverage);

            Console.WriteLine($"{beverage.GetDescription()} ${beverage.Cost()}");
        }
    }
}
