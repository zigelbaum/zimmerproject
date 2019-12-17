using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal
    {
        #region HostingUnit        
        void addHostingUnit(HostingUnit hostingUnit);
        List<HostingUnit> getAllHostingUnits();
        List<HostingUnit> getHostingUnits(Func<HostingUnit, bool> predicate = null);
        #endregion

        #region GuestRequest

        void addGuestRequest(String id, String name, int age);
        #endregion

        #region Order
        void addOrder(Order order);
        List<Order> getOrders(Func<Order, bool> predicate);
        #endregion


        //bool AddGuestRequest();
        //void SetGuestRequest();
        //bool AddHostingUnit();
        //bool DeleteHostingUnit();
        //void SetHostingUnit();
        //bool addOrder();
        //void setOrder();
        //List< > GetHostingUnitList();
        //List<?guestRequest?> GetCustomerList();
        //List<Order> GetOrdersList();
        //List<BankAccount> GetBankBranches();

    }
}
