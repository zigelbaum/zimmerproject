using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public interface Idal
    {
        bool AddGuestRequest();
        void SetGuestRequest();
        bool AddHostingUnit();
        bool DeleteHostingUnit();
        void SetHostingUnit();
        bool addOrder();
        void setOrder();
        List<hostingUnit> GetHostingUnitList();
        List<?guestRequest?> GetCustomerList();
        List<Order> GetOrdersList();
        List<BankAccount> GetBankBranches();

    }
}
