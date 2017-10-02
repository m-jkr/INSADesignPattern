using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INSADesignPattern.Observer
{
     
    class Observer            // implemente l'interface IObservable
    {

        //le deuxième type du dictionnaire est le type de n'importe quelle classe qui implémente l'interface
        Dictionary<string, List<IObservable>> observables;
        

        public Observer()
        {
            observables = new Dictionary<string, List<IObservable>>();

        }
   

        //méthode pour déclencher le trigger de l'observer
        public bool Trigger(string input)
        {
            //va boucler sur chaque clé valeur et va récupérer paire clé valeur et va comparer la clé a ce qui a été rentré, et renvoie la liste
            //d'observables qui correspond
            List<IObservable> inputListeners = observables.SingleOrDefault(p => p.Key == input).Value;

            if (inputListeners == null || inputListeners.Count == 0)
                return false;

            // test pour que si un observable est déjà lié à une clé & qu'il ne s'execute pas, alors on renvoie faux
            foreach( IObservable observable in inputListeners)
            {
                if (!observable.Execute())
                    return false;
            }

            return true;

            
        }

        //méthode pour enregistrer un évènement
        public bool Register(string key, IObservable observable)
        {
            //si liste existe pas, on crée liste vide, 
            if (!observables.ContainsKey(key))
            {
                observables.Add(key, new List<IObservable>());
                
            }
            //On ajoute a la liste de valeurs
            observables.Single(p => p.Key == key).Value.Add(observable);

            return true;
        }
    }

}
