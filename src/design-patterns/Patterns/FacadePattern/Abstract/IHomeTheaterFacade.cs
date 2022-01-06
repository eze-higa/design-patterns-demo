using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.FacadePattern.Abstract
{
    public interface IHomeTheaterFacade
    {
        public void WatchMovie(string movieName);
        public void EndMovie();
    }
}
