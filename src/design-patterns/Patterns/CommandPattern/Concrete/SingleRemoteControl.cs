using design_patterns.Patterns.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class SingleRemoteControl
    {
        private ICommand[] _onCommands = new ICommand[7];
        private ICommand[] _offCommands = new ICommand[7];
        private ICommand _lastCommandExecuted;
        public SingleRemoteControl()
        {            
            for(int i = 0; i < _onCommands.Length; i++)
            {
                _onCommands[i] = new NoCommand();
            }
            for (int i = 0; i < _offCommands.Length; i++)
            {
                _offCommands[i] = new NoCommand();
            }
            
            this._lastCommandExecuted = new NoCommand();
        }
        public void OnButtonWasPressed(int position) 
        {
            this._onCommands[position].Execute();
            _lastCommandExecuted = this._onCommands[position];
        }
        public void OffButtonWasPressed(int position)
        {
            this._offCommands[position].Execute();
            _lastCommandExecuted = this._offCommands[position];
        }
        public void SetCommand(int position, ICommand onCommand, ICommand offCommand) 
        { 
            _onCommands[position] = onCommand;
            _offCommands[position] = offCommand;
        }
        public void Undo() => this._lastCommandExecuted.Undo();
    }
}
