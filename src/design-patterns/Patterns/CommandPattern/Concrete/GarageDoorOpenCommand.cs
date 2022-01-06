using design_patterns.Patterns.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class GarageDoorOpenCommand : ICommand
    {
        private GarageDoor _garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void Execute()
        {
            this._garageDoor.Up();
        }

        public void Undo()
        {
            this._garageDoor.Down();
        }
    }
}
