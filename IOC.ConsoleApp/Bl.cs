﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    internal class Bl
    {
        //private Dal _dal { get; set; }
        private IDal _dal { get; set; }
        public Bl()
        {
            _dal = DalFoctory.GetDal();
        }

        public List<Product> GetProducts()
        {
            //   return _dal.GetProducts();
            return _dal.GetProducts();        }
    }
}
