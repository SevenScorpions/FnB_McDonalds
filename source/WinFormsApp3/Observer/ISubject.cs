using LogInDemo.DTO;

namespace LogInDemo.Observer
{
    public interface ISubject
    {
        public void RegisterObserver(IBillObserver observer);
        public void UnregisterObserver(IBillObserver observer);
        protected void NotifyObservers(Bill bill);
    }
}