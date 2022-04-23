namespace Decorator.Before.Models
{
    public class Notifier
    {
        public virtual void Send(string message)
        {
            Console.WriteLine("Sending default notification...");
        }
    }
}
