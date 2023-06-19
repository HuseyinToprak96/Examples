using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     5. Decorator: Varolan bir nesneye dinamik olarak yeni davranışlar eklemek için kullanılan bir desendir. Nesne etrafına sarmalanarak yeni özellikler veya davranışlar eklenir.
     */
    public interface IComponent
    {
        void Operation();
    }

    public class ConcreteComponent : IComponent
    {
        public void Operation()
        {
            Console.WriteLine("Concrete Component operation");
        }
    }

    public abstract class Decorator : IComponent
    {
        protected IComponent component;

        public Decorator(IComponent component)
        {
            this.component = component;
        }

        public virtual void Operation()
        {
            component.Operation();
        }
    }

    public class ConcreteDecorator : Decorator
    {
        public ConcreteDecorator(IComponent component) : base(component)
        {
        }

        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("Concrete Decorator operation");
        }
    }
    

}
