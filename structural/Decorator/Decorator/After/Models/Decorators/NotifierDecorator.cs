using Decorator.After.Models.Interfaces;

namespace Decorator.After.Models.Decorators
{
    public abstract class NotifierDecorator : INotifier
    {
        private INotifier _notifier;

        protected NotifierDecorator(INotifier notifier)
        {
            _notifier = notifier;
        }

        public virtual void Send(string message)
        {
            _notifier.Send(message);
        }
    }
}
