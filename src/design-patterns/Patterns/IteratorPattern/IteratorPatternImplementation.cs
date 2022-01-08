using design_patterns.Patterns.IteratorPattern.Abstract;
using design_patterns.Patterns.IteratorPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.IteratorPattern
{
    public static class IteratorPatternImplementation
    {
        public static void Run()
        {
            DinerMenu dinerMenu = new DinerMenu();
            PancakeHouseMenu pancakeHouseMenu = new PancakeHouseMenu();
            Waitress waitress = new Waitress(new List<IMenu> { dinerMenu, pancakeHouseMenu });
            waitress.PrintMenu();
        }
    }
}
