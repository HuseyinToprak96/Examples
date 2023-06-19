using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Patterns
{
    /*
     4. Prototype: Varolan bir nesnenin kopyasını oluşturmak için kullanılan bir desendir. Kopyalama işlemiyle yeni bir nesne oluşturulur.
     */
    public abstract class Shape
    {
        public abstract Shape Clone();
    }

    public class Circle : Shape
    {
        public int Radius { get; set; }

        public override Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }
    }

    public class Rectangle : Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override Shape Clone()
        {
            return (Shape)MemberwiseClone();
        }
    }

}
