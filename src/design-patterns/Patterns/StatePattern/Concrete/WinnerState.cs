using design_patterns.Patterns.StatePattern.Abstract;

namespace design_patterns.Patterns.StatePattern.Concrete
{
    public class WinnerState : IState
    {
        public GumballMachine GumballMachine { get; private set; }
        public WinnerState(GumballMachine gumballMachine)
        {
            this.GumballMachine = gumballMachine;
        }
        public void Dispense()
        {
            throw new NotImplementedException();
        }

        public void EjectQuarter()
        {
            throw new NotImplementedException();
        }

        public void InsertQuearter()
        {
            throw new NotImplementedException();
        }

        public void TurnCrank()
        {
            throw new NotImplementedException();
        }
    }
}
