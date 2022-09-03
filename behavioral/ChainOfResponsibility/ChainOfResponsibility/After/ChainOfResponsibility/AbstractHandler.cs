using ChainOfResponsibility.After.ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Common.Models;

namespace ChainOfResponsibility.After.ChainOfResponsibility
{
    public class AbstractHandler : IHandler
    {
        protected IHandler Next;

        public virtual bool Handle(Employee employee)
        {
            return Next != null
                ? Next.Handle(employee)
                : true;
        }

        public IHandler SetNext(IHandler handler)
        {
            Next = handler;
            return handler;
        }
    }
}
