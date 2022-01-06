using design_patterns.Patterns.FacadePattern.Abstract;
using design_patterns.Patterns.FacadePattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FacadePattern
{
    public static class FacadePatternImplementation
    {
        public static void Run() {
            Screen screen = new Screen();
            DvdPlayer dvdPlayer = new DvdPlayer();
            IHomeTheaterFacade homeTheaterFacade = new HomeTheaterFacade(screen, dvdPlayer);

            homeTheaterFacade.WatchMovie("The secret life of Walter Mity");
            homeTheaterFacade.EndMovie();
        }
    }
}
