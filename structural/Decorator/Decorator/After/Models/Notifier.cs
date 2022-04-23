using Decorator.After.Models.Interfaces;

namespace Decorator.After.Models
{
    public class Notifier : INotifier
    {
        public void Send(string message)
        {
            Console.WriteLine("Sending default notification...");
        }
    }
}
