using State.After.Models;

/*
 * And here is our newer and cleaner code! Let's understand it.
 * So, basically, the principle of the State pattern is to create classes that represents a state of another class, where the class will delegate
 * some (or all) calls to those states when there's is some decision making based on the class properties' values. With that, we substitute the 
 * need of multiple 'ifs' by creating classes to represent different states of the object, knowing exactly what it needs to do with the values
 * that are present.
 * In our example, we created states to represent the company based on its balance, where different taxes calculation and employees hiring 
 * restrictions will be easily checked. The Company class will wrap one of those states (which will per se maintain a reference
 * to the Company class) and will delegate the calls to this wrapped state, which will be able to do the routine and, if necessary, change the
 * Company to another state; this will happens when the upper or lower limit of the balance is reached, and the act of this change is by simply
 * wrapping an object of another state's class in the Company object, and then all the calls will be redirected to this new state.
 * The Company class will work with the states through an interface, so it can easily be set at runtime. So, with that, we easily handled the
 * problem of the multiple conditions that are based on the class's properties, with the bonus of respecting the Single Responsibility Principle
 * (classes that will have the only responsibility of doing a routine based on state) and the Open Closed Principle (when a tax change or there
 * is a new restriction, we will not need to change the Company class, and will most likely create a new state class).
 */

namespace State.After
{
    public static class ClientAfter
    {
        public static void Run()
        {
            var company = new Company();

            company.ReceiveEarnings(50);

            company.PayMonthlyTax();

            company.ReceiveEarnings(60);

            company.ReceiveEarnings(45);

            company.PayMonthlyTax();

            company.HireNewEmployee();

            company.ReceiveEarnings(20);

            company.PayMonthlyTax();

            company.HireNewEmployee();

            company.HireNewEmployee();

            company.ReceiveEarnings(30);

            company.ReceiveEarnings(200);

            company.HireNewEmployee();

            company.HireNewEmployee();

            company.PayMonthlyTax();
        }
    }
}
