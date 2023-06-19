using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     2. Factory: Nesne oluşturma sürecini soyutlamak için kullanılan bir desendir. İstemciye uygun nesneyi oluşturmak için bir fabrika sınıfı kullanılır.
     */
    public interface IProduct
    {
        void Display();
    }

    public class ConcreteProductA : IProduct
    {
        public void Display()
        {
            Console.WriteLine("Concrete Product A");
        }
    }

    public class ConcreteProductB : IProduct
    {
        public void Display()
        {
            Console.WriteLine("Concrete Product B");
        }
    }

    public class ProductFactory
    {
        public IProduct CreateProduct(string type)
        {
            switch (type)
            {
                case "A":
                    return new ConcreteProductA();
                case "B":
                    return new ConcreteProductB();
                default:
                    throw new ArgumentException("Invalid product type");
            }
        }
    }

}
