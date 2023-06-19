using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     6. Observer: Nesneler arasında haberleşme sağlayan bir desendir. Bir nesne değiştiğinde, bağımlı olan diğer nesnelerin bu değişiklikten haberdar olmasını sağlar.
     */
    public interface IObserver
    {
        void Update(string message);
    }

    public interface ISubject
    {
        void Attach(IObserver observer);
        void Detach(IObserver observer);
        void Notify(string message);
    }

    public class ConcreteSubject : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void Notify(string message)
        {
            foreach (var observer in observers)
            {
                observer.Update(message);
            }
        }
    }

    public class ConcreteObserver : IObserver
    {
        public void Update(string message)
        {
            Console.WriteLine("Received message: " + message);
        }
    }

}
