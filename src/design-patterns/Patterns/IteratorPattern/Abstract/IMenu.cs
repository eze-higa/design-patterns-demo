using design_patterns.Patterns.IteratorPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern.Abstract
{
    public interface IMenu
    {
        public IIterator<MenuItem> CreateIterator();
    }
}
