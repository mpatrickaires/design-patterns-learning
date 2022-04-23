using Decorator.After.Models.Interfaces;

namespace Decorator.After.Models.Decorators
{
    public class EmailDecorator : NotifierDecorator
    {
        public EmailDecorator(INotifier notifier) : base(notifier)
        {
        }

        public override void Send(string message)
        {
            base.Send(message);
            Console.WriteLine("Sending e-mail notification");
        }
    }
}
