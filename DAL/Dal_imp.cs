using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    class Dal_imp : Idal
    {
        #region Singleton
        private static readonly Dal_imp instance = new Dal_imp();
        private Dal_imp()
        { }
        public static Dal_imp Instance
        {
            get { return instance; }
        }

        static Dal_imp() {}//????????????
        #endregion
        public bool AddGuestRequest()
        {
            //has to be written
            return true;
        }
    }
}
