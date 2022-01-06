using design_patterns.Patterns.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class NoCommand : ICommand
    {
        public NoCommand()
        {

        }
        public void Execute()
        {
            Console.WriteLine("No Command Execution");
        }

        public void Undo()
        {
            Console.WriteLine("No Command Undo");
        }
    }
}
