using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.ProxyPattern.Abstract
{
    public  interface ISubject
    {
        public ICollection<string> Request();
    }
}
