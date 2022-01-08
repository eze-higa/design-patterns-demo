using design_patterns.Patterns.StatePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern.Concrete
{
    public class GumballMachine
    {
        public SoldOutState SoldOutState {get; private set;}
        public NoQuarterState NoQuarterState { get; private set; }
        public HasQuarterState HasQuarterState { get; private set; }
        public SoldState SoldState { get; private set; }

        public IState State { get; set; }
        public int Count { get; private set; } = 0;
        public GumballMachine(int count)
        {
            this.SoldOutState = new SoldOutState(this);
            this.NoQuarterState = new NoQuarterState(this);
            this.HasQuarterState = new HasQuarterState(this);
            this.SoldState = new SoldState(this);

            this.Count = count;

            if(count > 0)
            {
                this.State = this.NoQuarterState;
            }
            else
            {
                this.State = this.SoldOutState;
            }
        }
        public void IncreaseCount() => Count++;
        public void DecreaseCount() => Count--;

        public void InsertQuearter()
        {
            this.State.InsertQuearter();
        }

        public void EjectQuarter()
        {
            this.State.EjectQuarter();
        }

        public void TurnCrank()
        {
            this.State.TurnCrank();
            this.State.Dispense();
        }

    }
}
