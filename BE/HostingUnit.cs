using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class HostingUnit
    {
        #region fileds

        Int32 _HostingUnitKey = 10000000;
        Host _Owner;
        string _HostingUnitName;
        bool [,] _Diary;
        #endregion

        #region properties
        public int HostingUnitKey { get => _HostingUnitKey; set => _HostingUnitKey = value; }
        public Host Owner { get => _Owner; set => _Owner = value; }
        public string HostingUnitName { get => _HostingUnitName; set => _HostingUnitName = value; }
        public bool[,] Diary { get => _Diary; set => _Diary = value; }
        #endregion

        #region functions
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
