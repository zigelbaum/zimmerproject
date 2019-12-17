using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BL
{
    public interface IBL
    {
        bool AddGuestRequest();
        void SetGuestRequest();
        bool AddHostingUnit();
        bool DeleteHostingUnit();
        void SetHostingUnit();
        bool AddOrder();
        void SetOrder();
        List<BE.HostingUnit> AvailableHostingUnits(DateTime entry, Int32 vactiondays);
        Int32 NumDays(DateTime start, DateTime end);
        Int32 NumDays(DateTime start);
        List<BE.Order> OrderExistenceEqualsDays(Int32 days);
        Int32 NumOfInvetations(BE.GuestRequest costumer);//??????????????
        Int32 NumOfSuccessfullOrders(BE.HostingUnit hostingunit);

    }
}
