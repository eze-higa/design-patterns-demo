using design_patterns.Patterns.StatePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.StatePattern.Abstract
{
    public interface IState
    {        
        public void InsertQuearter();
        public void EjectQuarter();
        public void TurnCrank();
        public void Dispense();
    }
}
