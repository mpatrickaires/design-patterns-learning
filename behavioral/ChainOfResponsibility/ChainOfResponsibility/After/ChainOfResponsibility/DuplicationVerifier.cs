using ChainOfResponsibility.Common.Database;
using ChainOfResponsibility.Common.Models;

namespace ChainOfResponsibility.After.ChainOfResponsibility
{
    public class DuplicationVerifier : AbstractHandler
    {
        private static EmployeeDatabase _employeeDatabase = new();

        public override bool Handle(Employee employee)
        {
            if (_employeeDatabase.GetEmployeeById(employee.EmployeeId) != null)
            {
                Console.WriteLine("There is already an employee registered with this ID!\n");
                return false;
            }

            return base.Handle(employee);
        }
    }
}
