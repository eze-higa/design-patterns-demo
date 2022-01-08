using design_patterns.Patterns.StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern.Concrete
{
    public class SoldOutState : IState
    {
        public GumballMachine GumballMachine { get; private set; }
        public SoldOutState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }

        public void EjectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }

        public void InsertQuearter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is sold out");
        }

        public void TurnCrank()
        {
            Console.WriteLine("You turned, but there is no gumballs");
        }
    }
}
