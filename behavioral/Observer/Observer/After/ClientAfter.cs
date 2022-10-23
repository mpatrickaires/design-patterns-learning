using Observer.After.Observers;
using Observer.After.Subjects;
using Observer.Common;

/*
 * All right, as we can already see, the code turned out to already be much better and clean. But let's understand what is happening.
 * So, firstly, we created two interfaces: ISubject and IObserver. A subject is an object that has a state or perform actions that is 
 * interesting to other objects; when an interesting change of state or call of an action happens in this object, it will by itself (or by 
 * intermediation of yet another object) notify a group of objects that are interested in what has happened. This group of objects is the 
 * observers; generally, the observers simply exposes a method which can be used to notify about whatever has occured with the subject.
 * To do all this routine, the subject or its intermediate responsible for it needs to expose methods to subscribe or unsubscribe observers; 
 * generally, those methods simply inserts or removes an observer from a list of the type of the observer's interface. Having this list, when 
 * anything interesting for the subscribed observers happens, the list will be iterated and the corresponding method of the observer interface
 * will be called, passing as arguments anything that is necessary about the change/action.
 * 
 * Well, that's basically what we did with our new code. The StockMarket is our subject and, to take this role, it implements the ISubject 
 * interface, which exposes methods to subscribe, unsubscribe, and notify. We took a step further, and made the ability to the subscription be
 * around a specific topic (in this case, the stock). So, when a change happens to a stock, only the observers subscribed to that stock will
 * receive a notification with all the necessary information about the change.
 * This completely removes the need of the investor be calling the check methods, its coupling with the stock market (and even the stocks it 
 * observes) and also the need of a history of the changes. It will only take an action when a change indeed occurs with the stock it is 
 * interested about, while also being totally decoupled from the gears necessary for it.
 */

namespace Observer.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");
            var stockMarket = new StockMarket();

            var investorJordan = new Investor("Jordan");
            var investorLucy = new Investor("Lucy");
            var investorMax = new Investor("Max");

            stockMarket.Subscribe(investorJordan, Stock.Apple);
            stockMarket.Subscribe(investorLucy, Stock.Google);
            stockMarket.Subscribe(investorMax, Stock.Apple, Stock.Google);

            stockMarket.UpdateStockStatus(Stock.Apple, new StockStatus(1.5, true));
            Console.WriteLine();

            stockMarket.UpdateStockStatus(Stock.Apple, new StockStatus(3, true));
            Console.WriteLine();

            stockMarket.UpdateStockStatus(Stock.Google, new StockStatus(2, true));
            Console.WriteLine();

            stockMarket.Unsubscribe(investorMax, Stock.Apple);
            stockMarket.UpdateStockStatus(Stock.Apple, new StockStatus(1.2, false));
            Console.WriteLine();
        }
    }
}
