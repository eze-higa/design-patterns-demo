using design_patterns.Patterns.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class MacroCommand : ICommand
    {
        private IList<ICommand> _commands;
        public MacroCommand(IList<ICommand> commands)
        {
            this._commands = commands;
        }
        public void Execute()
        {
            Console.WriteLine("Macro command!");
            foreach(var command in _commands)
            {
                command.Execute();
            }
        }

        public void Undo()
        {
            foreach (var command in _commands)
            {
                command.Undo();
            }
        }
    }
}
