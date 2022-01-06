using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FacadePattern.Concrete
{
    public class Screen
    {
        public void TurnOn() => Console.WriteLine("Turning on the screen.");
        public void TurnOff() => Console.WriteLine("Turning Off the screen.");
    }
}
