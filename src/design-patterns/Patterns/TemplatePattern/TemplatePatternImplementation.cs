using design_patterns.Patterns.TemplatePattern.Abstract;
using design_patterns.Patterns.TemplatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.TemplatePattern
{
    public static class TemplatePatternImplementation
    {
        public static void Run()
        {
            CaffeineBeverage caffeineBeverage = new Coffee();
            caffeineBeverage.PrepareRecipe();

            caffeineBeverage = new TeaWithHook();
            caffeineBeverage.PrepareRecipe();
        }
    }
}
