using Mediator.After.Dialogs;

namespace Mediator.After.Components
{
    public abstract class BaseComponent
    {
        private IMediator _mediator;

        public void SetMediator(IMediator mediator) => _mediator = mediator;
        public void Notify()
        {
            if (_mediator != null) _mediator.Update(this);
        }
    }
}
