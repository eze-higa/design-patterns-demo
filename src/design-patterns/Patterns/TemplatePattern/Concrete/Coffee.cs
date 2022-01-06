using design_patterns.Patterns.TemplatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.TemplatePattern.Concrete
{
    public class Coffee : CaffeineBeverage
    {
        public override void AddCondiment()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void Brew()
        {
            Console.WriteLine("Dripping Coffee through the filter");
        }
    }
}
