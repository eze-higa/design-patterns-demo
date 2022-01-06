using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class GarageDoor
    {
        public void Up() => Console.WriteLine("Garage Door is Up");
        public void Down() => Console.WriteLine("Garage Door is Down");
        public void Stop() => Console.WriteLine("Garage Door was stopped");
        public void LightOn() => Console.WriteLine("Garage Door Light is On");
        public void LightOff() => Console.WriteLine("Garage Door Light is Off");
    }
}
