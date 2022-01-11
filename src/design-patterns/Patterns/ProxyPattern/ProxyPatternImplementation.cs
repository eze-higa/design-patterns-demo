using design_patterns.Patterns.ProxyPattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.ProxyPattern
{
    public static class ProxyPatternImplementation
    {
        public static void Run() 
        { 
            RealSubject realSubject = new RealSubject();
            CachingProxy proxy = new CachingProxy(realSubject);

            
            Console.WriteLine(string.Join(",", proxy.Request()));
            Console.WriteLine("Second call");
            Console.WriteLine(string.Join(",", proxy.Request()));
        }
    }
}
