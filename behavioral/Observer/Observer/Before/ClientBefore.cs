using Observer.Before.Services;
using Observer.Common;

/*
 * Here is our situation: we have an application that communicates directly with the stock market and is constantly monitoring it and 
 * registering the changes that occurs in the stocks. We then have investors, which are interested in the changes that occurs in some specific 
 * stocks, and will perform some action whenever a change occurs.
 * But, here is the thing: to do that, the investor needs to be tightly coupled to the stock market, keep an history of the previous changes and,
 * the worst of all, it needs to constantly check if there is any change to the stocks. In our case, we did that by constantly calling the 
 * investor's 'CheckStocksChanges' method, which we could also have done in a while loop (which would not be any better). So, basically, it is 
 * necessary to call this method for all the investors, and it would be an action performed even when there isn't any changes. We are calling the 
 * method for nothing!
 * 
 * Well, this is where the Observer patterns aims to bring a better solution, so let's take a look!
 */

namespace Observer.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");
            var stockMarket = new StockMarket();

            var investorJordan = new Investor("Jordan", stockMarket, Stock.Apple);
            var investorLucy = new Investor("Lucy", stockMarket, Stock.Google);
            var investorMax = new Investor("Max", stockMarket, Stock.Apple, Stock.Google);

            investorJordan.CheckStocksChanges();
            investorLucy.CheckStocksChanges();
            investorMax.CheckStocksChanges();
            Console.WriteLine();

            stockMarket.UpdateStockStatus(Stock.Apple, new StockStatus(1.5, true));

            investorJordan.CheckStocksChanges();
            investorLucy.CheckStocksChanges();
            investorMax.CheckStocksChanges();
            Console.WriteLine();

            stockMarket.UpdateStockStatus(Stock.Apple, new StockStatus(3, true));
            stockMarket.UpdateStockStatus(Stock.Google, new StockStatus(2, true));

            investorJordan.CheckStocksChanges();
            investorLucy.CheckStocksChanges();
            investorMax.CheckStocksChanges();
            Console.WriteLine();

            investorMax.RemoveObservedStock(Stock.Apple);
            stockMarket.UpdateStockStatus(Stock.Apple, new StockStatus(1.2, false));

            investorJordan.CheckStocksChanges();
            investorLucy.CheckStocksChanges();
            investorMax.CheckStocksChanges();
            Console.WriteLine();
        }
    }
}
