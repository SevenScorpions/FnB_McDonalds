using LogInDemo.DAO;
using LogInDemo.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogInDemo.Observer
{
    public class HistorySubject : ISubject
    {
        private List<IBillObserver> observers = new List<IBillObserver>();
        private List<Bill> bills;
        public List<Bill> Bills { get { return bills; } }
        public HistorySubject(User user) { 
            bills = BillDAO.Instance.getUserBill(user.Username);
        }

        public void RegisterObserver(IBillObserver observer)
        {
            observers.Add(observer);
        }

        public void UnregisterObserver(IBillObserver observer)
        {
            observers.Remove(observer);
        }

        //notify Observer
        

        public void UpdateHistory(Bill bill)
        {
            bills.Add(bill);
            NotifyObservers(bill);
        }

        public void NotifyObservers(Bill bill)
        {
            foreach (IBillObserver observer in observers)
            {
                observer.OnBillAdded(bill);
            }
        }
    }
}
