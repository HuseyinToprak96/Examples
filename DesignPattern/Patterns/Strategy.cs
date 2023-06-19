using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     7. Strategy: Farklı algoritmaları bir arayüz üzerinden değiştirilebilir hale getiren bir desendir. Bir nesne, çalışacak algoritmayı dinamik olarak değiştirebilir.
     */
    public interface IStrategy
    {
        void Execute();
    }

    public class ConcreteStrategyA : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy A execution");
        }
    }

    public class ConcreteStrategyB : IStrategy
    {
        public void Execute()
        {
            Console.WriteLine("Strategy B execution");
        }
    }

    public class StrategyContext
    {
        private IStrategy strategy;

        public StrategyContext(IStrategy strategy)
        {
            this.strategy = strategy;
        }

        public void ExecuteStrategy()
        {
            strategy.Execute();
        }
    }

}
