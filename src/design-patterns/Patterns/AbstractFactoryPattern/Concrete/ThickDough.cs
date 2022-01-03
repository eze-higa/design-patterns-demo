﻿using design_patterns.Patterns.AbstractFactoryPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.AbstractFactoryPattern.Concrete
{
    public class ThickDough : Dough
    {
        public ThickDough() : base("Thick Dough")
        {

        }
    }
}