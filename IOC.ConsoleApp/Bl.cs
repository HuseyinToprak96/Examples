using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    internal class Bl
    {
        //private Dal _dal { get; set; }

        public Bl()
        {
           // _dal = new Dal();
        }

        public List<Product> GetProducts()
        {
            //   return _dal.GetProducts();
            return DalFoctory.GetDal().GetProducts();        }
    }
}
