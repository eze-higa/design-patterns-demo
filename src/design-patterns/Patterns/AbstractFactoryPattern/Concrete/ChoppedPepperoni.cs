﻿using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class ChoppedPepperoni : Pepperoni
    {
        public ChoppedPepperoni() : base("Chopped Pepperoni")
        {

        }
    }
}
