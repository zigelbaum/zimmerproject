﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    class FactoryBL
    {
        public static IBL GetBL()
        {
            return new MyBL();
        }
    }
}
