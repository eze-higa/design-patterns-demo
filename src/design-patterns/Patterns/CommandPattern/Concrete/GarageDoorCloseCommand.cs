using design_patterns.Patterns.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class GarageDoorCloseCommand : ICommand
    {
        private GarageDoor _garageDoor;
        public GarageDoorCloseCommand(GarageDoor garageDoor)
        {
            this._garageDoor = garageDoor;
        }
        public void Execute()
        {
            _garageDoor.Down();
        }

        public void Undo()
        {
            _garageDoor.Up();
        }
    }
}
