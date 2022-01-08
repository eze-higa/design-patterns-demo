using design_patterns.Patterns.StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern.Concrete
{
    public class NoQuarterState : IState
    {
        public GumballMachine GumballMachine { get; private set; }
        public NoQuarterState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("You need to pay first");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }

        public void InsertQuearter()
        {
            Console.WriteLine("You inserted a quarter");
            this.GumballMachine.State = this.GumballMachine.HasQuarterState;
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no quarter");
        }
    }
}
