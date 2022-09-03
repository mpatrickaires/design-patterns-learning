using ChainOfResponsibility.Common.Models;

namespace ChainOfResponsibility.After.ChainOfResponsibility
{
    public class FieldValidator : AbstractHandler
    {
        public override bool Handle(Employee employee)
        {
            if (employee == null ||
                string.IsNullOrWhiteSpace(employee.Name) ||
                string.IsNullOrWhiteSpace(employee.Position) ||
                employee.EmployeeId == 0)
            {
                Console.WriteLine("Invalid employee data! Some required fields are not set.\n");
                return false;
            }

            return base.Handle(employee);
        }
    }
}
