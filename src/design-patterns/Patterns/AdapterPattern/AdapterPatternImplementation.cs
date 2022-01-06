using design_patterns.Patterns.AdapterPattern.Abstract;
using design_patterns.Patterns.AdapterPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AdapterPattern
{
    public static class AdapterPatternImplementation
    {
        public static void Run()
        {
            ITurkey turkey = new WildTurkey();
            IDuck duck = new MallardDuck();

            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            turkey.Fly();
            turkey.Gobble();

            duck.Fly();
            duck.Cuack();

            turkeyAdapter.Fly();
            turkeyAdapter.Cuack();

        }
    }
}
