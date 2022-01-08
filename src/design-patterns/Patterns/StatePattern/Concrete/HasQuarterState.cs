using design_patterns.Patterns.StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern.Concrete
{
    public class HasQuarterState : IState
    {
        public GumballMachine GumballMachine { get; private set; }
        public HasQuarterState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispense");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Quarter returned");
            GumballMachine.State = this.GumballMachine.NoQuarterState;
        }

        public void InsertQuearter()
        {
            Console.WriteLine("You can't insert another quarter");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned...");
            GumballMachine.State = this.GumballMachine.SoldState;
        }
    }
}
