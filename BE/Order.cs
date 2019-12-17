using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Order
    {
        #region fileds

        Int32 _HostingUnitKey;
        Int32 _GuestRequestKey;
        Int32 _OrderKey = Configuration.OrderKey;
        Enums.OrderStatus _Status;
        DateTime CreateDate;
        DateTime OrderDate;
        #endregion

        #region properties
        public int HostingUnitKey { get => _HostingUnitKey; set => _HostingUnitKey = value; }
        public int GuestRequestKey { get => _GuestRequestKey; set => _GuestRequestKey = value; }
        public int OrderKey { get => _OrderKey; set => _OrderKey = value; }
        public Enums.OrderStatus Status { get => _Status; set => _Status = value; }
        public DateTime CreateDate1 { get => CreateDate; set => CreateDate = value; }
        public DateTime OrderDate1 { get => OrderDate; set => OrderDate = value; }
        #endregion

        #region functions
        public override string ToString()
        {
            return base.ToString();
        }
        #endregion
    }
}
