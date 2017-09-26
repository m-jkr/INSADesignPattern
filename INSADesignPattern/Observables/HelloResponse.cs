using INSADesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observables
{
    class HelloResponse : IObservable
    {
        string name;
        
        public bool Execute()
        {
            Console.WriteLine("Hello, what's your name ?");
            name = Console.ReadLine();
            Console.WriteLine("Hello " + name + ", nice to meet you.");
            return true;
        }
    }
}
