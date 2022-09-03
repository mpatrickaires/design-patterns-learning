using ChainOfResponsibility.Common.Models;

namespace ChainOfResponsibility.After.ChainOfResponsibility.Interfaces
{
    public interface IHandler
    {
        IHandler SetNext(IHandler handler);
        bool Handle(Employee employee);
    }
}
