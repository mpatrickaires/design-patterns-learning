using Observer.After.Observers.Interfaces;
using Observer.Common;

namespace Observer.After.Subjects.Interfaces
{
    public interface ISubject
    {
        void Subscribe(IObserver observer, params Stock[] stocks);
        void Unsubscribe(IObserver observer, params Stock[] stocks);
        void Notify(Stock stock, StockStatus stockStatus);
    }
}
