using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FacadePattern.Concrete
{
    public class DvdPlayer
    {
        public void TurnOn()
        {
            Console.WriteLine("Turning On the DVD");
        }
        public void TurnOff()
        {
            Console.WriteLine("Turning Off the DVD");
        }
        public void Play(string movie)
        {
            Console.WriteLine($"Playing {movie}");
        }
    }
}
