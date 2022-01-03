using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace design_patterns.Patterns.SingletonPattern
{
    public static class SingletonPatternImplementation
    {
        public static void Run()
        {
            Singleton singleton = Singleton.GetInstance();
            Singleton secondSingleton = Singleton.GetInstance();

            singleton.Message = "Test";
            Console.WriteLine($"First singleton {singleton.Message}");
            Console.WriteLine($"Second singleton {secondSingleton.Message}");

            secondSingleton.Message = "new test";
            Console.WriteLine($"First singleton {singleton.Message}");
            Console.WriteLine($"Second singleton {secondSingleton.Message}");
        }
    }
}
