using design_patterns.Patterns.CommandPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class LightOnCommand : ICommand
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            this._light = light;
        }
        public void Execute()
        {
            Console.WriteLine("Ligh was turned on");
            this._light.TurnOn();
        }

        public void Undo()
        {
            Console.WriteLine("Ligh was turned off");
            this._light.TurnOff();
        }
    }
}
