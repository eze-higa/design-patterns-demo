using design_patterns.Patterns.ProxyPattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.ProxyPattern.Concrete
{
    public class RealSubject : ISubject
    {
        public ICollection<string> Request()
        {
            Console.WriteLine("Calling the real request");
            return new List<string>() { "Hello", "World"};
        }
    }
}
