﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Factory
    {
        public static Idal GetDal(string typeDAL)
        {
            switch (typeDAL)
            {
                case "List": return Dal_imp.Instance;
                //  case "XML": return DAL_XML.Instance;
                default: return null;
            }
        }
    }
}
