using State.After.Models;

namespace State.After.States
{
    public abstract class StateBase
    {
        protected readonly Company Company;

        protected StateBase(Company company)
        {
            Company = company;
        }

        public abstract void ReceiveEarnings(decimal earnings);
        public abstract void PayMonthlyTax();
        public abstract void HireNewEmployee();
    }
}
