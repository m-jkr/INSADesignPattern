using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //définir Observer et observable
            Observer.Observer obs = new Observer.Observer();
            Observables.HelloResponse hellorep = new Observables.HelloResponse();


             
            string line;
            Console.WriteLine("");
            Console.WriteLine("     __   __     __  ________  _____");
            Console.WriteLine("    /  / /  |  /  / /  _____/ /  _  |");
            Console.WriteLine("   /  / /   | /  / /  /____  /  /_| |");
            Console.WriteLine("  /  / /    |/  / /____   / /  ___  |");
            Console.WriteLine(" /  / /  /|    / _____/  / /  /   | |");
            Console.WriteLine("/__/ /__/ |___/ /_______/ /__/    |_|");
            Console.WriteLine("Desing Patterns - Anthony Maudry amaudry@gmail.com");
            Console.WriteLine("Hello,");
            Console.WriteLine("Write something (type 'exit' to exit the program).");

            obs.Register("hello", hellorep);

            //le déclenchement des évènements va dépendre de l'ordre dans lequel on les enregistre
            // .Register pour enregistrer évènement 

            while ((line = Console.ReadLine()) != "exit")
            {
                //on déclenche l'évènement line
                //if (line=="hello")
                //    obs.Trigger("hello");
                obs.Trigger(line);


                Console.WriteLine("You wrote : ");
                Console.WriteLine(line);
                

            }

            Console.WriteLine("Goodbye.");
        }
    }
}
