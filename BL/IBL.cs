using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

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
        List<HostingUnit> AvailableHostingUnits(DateTime entry, Int32 vactiondays);
        Int32 NumDays(DateTime start, DateTime end);
        Int32 NumDays(DateTime start);


    }
}
