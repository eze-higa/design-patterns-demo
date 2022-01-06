using design_patterns.Patterns.FacadePattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FacadePattern.Concrete
{
    public class HomeTheaterFacade : IHomeTheaterFacade
    {
        private Screen _screen;
        private DvdPlayer _dvdPlayer;
        public HomeTheaterFacade(Screen screen, DvdPlayer dvdPlayer)
        {
            _screen = screen;
            _dvdPlayer = dvdPlayer;
        }
        public void EndMovie()
        {
            _screen.TurnOff();
            _dvdPlayer.TurnOff();
        }

        public void WatchMovie(string movieName)
        {
            _screen.TurnOn();
            _dvdPlayer.TurnOn();
            _dvdPlayer.Play(movieName);
        }
    }
}
