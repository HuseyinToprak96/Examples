using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    internal interface IDal
    {
        List<Product> GetProducts();
        //Soyut yapılar newlenemez. Abstract class veya interfaceler örnek gösterilebilir.
    }
}
