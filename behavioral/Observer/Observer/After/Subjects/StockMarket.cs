using Observer.After.Observers.Interfaces;
using Observer.After.Subjects.Interfaces;
using Observer.Common;

namespace Observer.After.Subjects
{
    public class StockMarket : ISubject
    {
        private readonly IDictionary<Stock, StockStatus> _stocksStatus = new Dictionary<Stock, StockStatus>();
        private readonly IDictionary<Stock, IList<IObserver>> _observers = new Dictionary<Stock, IList<IObserver>>();

        public StockMarket()
        {
            foreach (var stock in Enum.GetValues<Stock>())
            {
                _observers[stock] = new List<IObserver>();
            }
        }

        public void Subscribe(IObserver observer, params Stock[] stocks)
        {
            foreach (var stock in stocks)
            {
                _observers[stock].Add(observer);
            }
        }

        public void Unsubscribe(IObserver observer, params Stock[] stocks)
        {
            foreach (var stock in stocks)
            {
                _observers[stock].Remove(observer);
            }
        }

        public void UpdateStockStatus(Stock stock, StockStatus stockStatus)
        {
            Console.WriteLine($"Changing status of {stock} stock.");
            _stocksStatus[stock] = stockStatus;
            Notify(stock, stockStatus);
        }

        public void Notify(Stock stock, StockStatus stockStatus)
        {
            foreach (var observer in _observers[stock])
            {
                observer.Update(stock, stockStatus);
            }
        }

    }
}
