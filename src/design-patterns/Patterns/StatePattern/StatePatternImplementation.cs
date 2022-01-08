using design_patterns.Patterns.StatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern
{
    public static class StatePatternImplementation
    {
        public static void Run()
        {
            GumballMachine gumballMachine = new GumballMachine(3);
            gumballMachine.InsertQuearter();
            gumballMachine.TurnCrank();

            gumballMachine.TurnCrank();
        }
    }
}
