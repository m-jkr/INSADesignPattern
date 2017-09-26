using INSADesignPattern.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observables
{
    class Smileytriste : IObservable
    {
        public bool Execute()
        {
            Console.WriteLine("Ce n'est pas très gentil :(");
            return true;
        }
    }
}
