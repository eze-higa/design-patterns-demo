using design_patterns.Patterns.StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern.Concrete
{
    public class SoldState : IState
    {
        public GumballMachine GumballMachine { get; private set; }
        public SoldState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            if(GumballMachine.Count > 0)
            {
                this.GumballMachine.DecreaseCount();
                GumballMachine.State = this.GumballMachine.NoQuarterState;
                Console.WriteLine("A gumball comes rolling out the slot");
            }
            else
            {
                this.GumballMachine.State = this.GumballMachine.SoldOutState;
                Console.WriteLine("Sorry, there is no gumball left");
            }
            
        }

        public void EjectQuarter()
        {
            Console.WriteLine("Sorry, you've already turned the crank");
        }

        public void InsertQuearter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }

        public void TurnCrank()
        {
            Console.WriteLine("Turning twice doesn't give you another gumball");
        }
    }
}
