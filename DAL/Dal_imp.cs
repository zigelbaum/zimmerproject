using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class Dal_imp : Idal
    {
        #region Singleton
        //private static Dal_imp instance;
        //private Dal_imp() {}
        //public static Dal_imp Instance
        //{
        //    get
        //    {
        //        if (instance == null)
        //            instance = new Dal_imp();
        //        return instance;
        //    }
        //}
        private static readonly Dal_imp instance = new Dal_imp();
        public static Dal_imp Instance
        {
            get { return instance; }
        }
        private Dal_imp(){ }
        static Dal_imp() { }//????????????
        #endregion
        //public bool AddGuestRequest()
        //{
        //    //has to be written
        //    return true;
        //}
    }
}
