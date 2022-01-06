using design_patterns.Patterns.AdapterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AdapterPattern.Concrete
{
    public class MallardDuck : IDuck
    {
        public void Cuack()
        {
            Console.WriteLine("Cuack cuack");
        }

        public void Fly()
        {
            Console.WriteLine("Flyiiing");
        }
    }
}
