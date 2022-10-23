using Observer.Common;

namespace Observer.Before.Services
{
    internal class Investor
    {
        private readonly string _name;
        private readonly StockMarket _stockMarket;
        private readonly List<Stock> _observedStocks = new();
        private readonly IDictionary<Stock, StockStatus> _stockStatusHistory = new Dictionary<Stock, StockStatus>();

        public Investor(string name, StockMarket stockMarket, params Stock[] observedStocks)
        {
            _name = name;
            _stockMarket = stockMarket;
            _observedStocks.AddRange(observedStocks);
        }

        public void CheckStocksChanges()
        {
            bool hasChanges = false;
            var stocksStatus = _stockMarket.GetStocksStatus(_observedStocks.ToArray());
            foreach (var stock in _observedStocks)
            {
                var currentStockStatus = stocksStatus[stock];
                _stockStatusHistory.TryGetValue(stock, out var historyStockStatus);

                if (currentStockStatus == historyStockStatus) continue;

                hasChanges = true;

                if (currentStockStatus.HasRaised)
                {
                    Log($"{stock} stock has raised {currentStockStatus.Percentage}%. Time to sell!");
                }
                else
                {
                    Log($"{stock} stock price has reduced {currentStockStatus.Percentage}%. Time to buy!");

                }
                _stockStatusHistory[stock] = currentStockStatus;
            }
            if (!hasChanges) Log("No changes in the stocks, nothing to do for now...");
        }

        public void RemoveObservedStock(Stock stock)
        {
            _observedStocks.Remove(stock);
        }

        private void Log(string message) => Console.WriteLine($"[{_name}] {message}");
    }
}
