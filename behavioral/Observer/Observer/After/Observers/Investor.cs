using Observer.After.Observers.Interfaces;
using Observer.Common;

namespace Observer.After.Observers
{
    public class Investor : IObserver
    {
        private readonly string _name;

        public Investor(string name)
        {
            _name = name;
        }

        public void Update(Stock stock, StockStatus stockStatus)
        {
            if (stockStatus.HasRaised)
            {
                Log($"{stock} stock has raised {stockStatus.Percentage}%. Time to sell!");
            }
            else
            {
                Log($"{stock} stock price has reduced {stockStatus.Percentage}%. Time to buy!");
            }
        }

        private void Log(string message) => Console.WriteLine($"[{_name}] {message}");
    }
}
