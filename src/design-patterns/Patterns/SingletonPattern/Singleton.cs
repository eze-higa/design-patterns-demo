using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.SingletonPattern
{
    public class Singleton
    {
        private static Singleton _singleton = new Singleton();
        public string Message { get; set; }
        private Singleton() { }

        public static Singleton GetInstance()
        {
            return _singleton;
        }

    }
}
