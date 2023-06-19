using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     8. Template Method: Bir sürecin iskeletini belirleyen ancak bazı adımların alt sınıflar tarafından uygulanmasını sağlayan bir desendir.
     */
    public abstract class AbstractClass
    {
        public void TemplateMethod()
        {
            Step1();
            Step2();
            Step3();
        }

        protected abstract void Step1();
        protected abstract void Step2();
        protected abstract void Step3();
    }

    public class ConcreteClass : AbstractClass
    {
        protected override void Step1()
        {
            Console.WriteLine("Step 1 - ConcreteClass");
        }

        protected override void Step2()
        {
            Console.WriteLine("Step 2 - ConcreteClass");
        }

        protected override void Step3()
        {
            Console.WriteLine("Step 3 - ConcreteClass");
        }
    }

}
