﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOC.ConsoleApp
{
    internal class DalFoctory
    {
        public static IDal GetDal()
        {
            return new Dal();
        }
    }
}
