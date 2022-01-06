using design_patterns.Patterns.TemplatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.TemplatePattern.Concrete
{
    public class TeaWithHook : CaffeineBeverage
    {
        public override void AddCondiment()
        {
            Console.WriteLine("Adding Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Stepping the tea");
        }
        public override bool CustomerWantsCondiments()
        {
            Console.WriteLine("Would you like lemon with your tea? Y/N");
            
            var answer = Console.ReadLine();
            return !string.IsNullOrEmpty(answer) && answer.ToUpper() == "Y";
        }
    }
}
