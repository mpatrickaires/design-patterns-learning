using Observer.Common;

namespace Observer.After.Observers.Interfaces
{
    public interface IObserver
    {
        void Update(Stock stock, StockStatus stockStatus);
    }
}
