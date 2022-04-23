using Decorator.After.Models.Interfaces;

namespace Decorator.After.Models.Decorators
{
    public class SmsDecorator : NotifierDecorator
    {
        public SmsDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending SMS notification...");
        }
    }
}
