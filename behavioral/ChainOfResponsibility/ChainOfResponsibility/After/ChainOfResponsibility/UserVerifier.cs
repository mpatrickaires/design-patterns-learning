using ChainOfResponsibility.Common.Models;
using ChainOfResponsibility.Common.User;

namespace ChainOfResponsibility.After.ChainOfResponsibility
{
    public class UserVerifier : AbstractHandler
    {
        public override bool Handle(Employee employee)
        {
            if (!CurrentUser.IsAdm)
            {
                Console.WriteLine("Only admin users can register new employees!\n");
                return false;
            }

            return base.Handle(employee);
        }
    }
}
