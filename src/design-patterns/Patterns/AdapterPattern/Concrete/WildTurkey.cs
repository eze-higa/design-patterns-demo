using design_patterns.Patterns.AdapterPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AdapterPattern.Concrete
{
    public class WildTurkey : ITurkey
    {
        public void Fly()
        {
            Console.WriteLine("Flying");
        }

        public void Gobble()
        {
            Console.WriteLine("gobble gobble");
        }
    }
}
