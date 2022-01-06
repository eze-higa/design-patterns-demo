using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Abstract
{
    public interface ICommand
    {
        public void Execute();
        public void Undo();
    }
}
