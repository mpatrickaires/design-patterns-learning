using ChainOfResponsibility.Common.Database;
using ChainOfResponsibility.Common.Models;
using ChainOfResponsibility.Common.User;

/*
 * In our example, we have a system where the user can register employees in their database. However, some validations needs to be done before
 * a new employee is registered, like checking if all required fields are filled in, if there isn't already an employee with the given ID and
 * if the current user (who is doing the registration) is an admin.
 * We can say those are just some simple validation, but it some ugly 'ifs' in our code. And also, if in the future we wish to 
 * add a new piece of validation, it is necessary to alter this class to add this new feature (which per se hurts the Open/Closed Principle).
 * Another point is if we wanted only the required fields validator and duplication verifier routines to be used in another part of our system,
 * besides being hard to provide only those two considering the actual structure of the code, it would be necessary to create a tight coupling
 * with the current class, all that just to get some validation routines.
 */

namespace ChainOfResponsibility.Before
{
    public static class ClientBefore
    {
        private static EmployeeDatabase _employeeDatabase = new();

        public static void Run()
        {
            Console.WriteLine("== Before ==");

            CurrentUser.IsAdm = false;

            var employee = new Employee
            {
                Name = "Bruce Banner",
                Position = "Scientist",
            };
            RegisterEmployee(employee);

            employee = new Employee
            {
                Name = "Clark Kent",
                Position = "Reporter",
                EmployeeId = 2,
            };
            RegisterEmployee(employee);

            employee = new Employee
            {
                Name = "Bruce Wayne",
                Position = "Billionaire",
                EmployeeId = 3,
            };
            RegisterEmployee(employee);

            CurrentUser.IsAdm = true;
            if (RegisterEmployee(employee)) Console.WriteLine($"Employee {employee.Name} successfully registered!\n");

        }

        public static bool RegisterEmployee(Employee employee)
        {
            if (employee == null ||
                string.IsNullOrWhiteSpace(employee.Name) ||
                string.IsNullOrWhiteSpace(employee.Position) ||
                employee.EmployeeId == 0)
            {
                Console.WriteLine("Invalid employee data! Some required fields are not set.\n");
                return false;
            }

            if (_employeeDatabase.GetEmployeeById(employee.EmployeeId) != null)
            {
                Console.WriteLine("There is already an employee registered with this ID!\n");
                return false;
            }

            if (!CurrentUser.IsAdm)
            {
                Console.WriteLine("Only admin users can register new employees!\n");
                return false;
            }

            _employeeDatabase.AddEmployee(employee);
            return true;
        }
    }
}
