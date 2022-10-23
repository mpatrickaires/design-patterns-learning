using Observer.Common;

namespace Observer.Before.Services
{
    public class StockMarket
    {
        private readonly IDictionary<Stock, StockStatus> _stocksStatus = new Dictionary<Stock, StockStatus>();

        public void UpdateStockStatus(Stock stock, StockStatus stockStatus)
        {
            Console.WriteLine($"Changing status of {stock} stock.");
            _stocksStatus[stock] = stockStatus;
        }

        public IDictionary<Stock, StockStatus> GetStocksStatus(params Stock[] stocks)
        {
            var stocksStatus = new Dictionary<Stock, StockStatus>();
            foreach (var stock in stocks)
            {
                _stocksStatus.TryGetValue(stock, out var status);
                stocksStatus[stock] = status;
            }
            return stocksStatus;
        }
    }
}
