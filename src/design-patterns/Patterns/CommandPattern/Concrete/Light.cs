using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.CommandPattern.Concrete
{
    public class Light
    {
        public bool IsOn { get; set; }

        public void TurnOn() => IsOn = true;
        public void TurnOff() => IsOn = false;
    }
}
