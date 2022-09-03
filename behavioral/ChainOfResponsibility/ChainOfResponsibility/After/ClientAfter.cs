using ChainOfResponsibility.After.ChainOfResponsibility;
using ChainOfResponsibility.After.ChainOfResponsibility.Interfaces;
using ChainOfResponsibility.Common.Models;
using ChainOfResponsibility.Common.User;

/*
 * Now, to our new example: we created a chain of executions to perform some action with the employee. The idea here is to have an interface
 * that represents our handler, and this handler will be linked to another handler that will be called (or not) by the current handler.
 * This creates the mentioned chain of executions, and eliminates from the current class all those 'ifs' we used. This provides a great decoupling,
 * while allowing new steps of validation to be included without altering the current at all. 
 * This routine happens the following way: the client (or some other part of the program) creates the handlers and bond them in the order it is
 * desired for them to be executed. When the execution of a routine that is responsibility of the handler (in our case, the registration of a new 
 * employee) needs to be done, the client will call a created handler (it don't necessarily needs to be the first one) through its execution method
 * (which is exposed through the interface); the handler now will decide if it will pass the execution to the next handler (if it exists) or not.
 * In our case, if the field validator handler checks that some of the required fields are not filled in, it will take care of the process and 
 * will not call the next handler. Basically, for our example, the next handler will only be called if the routine is successful.
 */

namespace ChainOfResponsibility.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            Console.WriteLine("== After ==");

            IHandler fieldValidator = new FieldValidator();
            IHandler duplicationVerifier = new DuplicationVerifier();
            IHandler userVerifier = new UserVerifier();

            fieldValidator
                .SetNext(duplicationVerifier)
                .SetNext(userVerifier);

            CurrentUser.IsAdm = false;

            var employee = new Employee
            {
                Name = "Bruce Banner",
                Position = "Scientist",
            };
            fieldValidator.Handle(employee);

            employee = new Employee
            {
                Name = "Clark Kent",
                Position = "Reporter",
                EmployeeId = 2,
            };
            fieldValidator.Handle(employee);

            employee = new Employee
            {
                Name = "Bruce Wayne",
                Position = "Billionaire",
                EmployeeId = 3,
            };
            fieldValidator.Handle(employee);

            CurrentUser.IsAdm = true;
            if (fieldValidator.Handle(employee)) Console.WriteLine($"Employee {employee.Name} successfully registered!\n");
        }
    }
}
