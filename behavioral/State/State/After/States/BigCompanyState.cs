using State.After.Models;

namespace State.After.States
{
    public class BigCompanyState : StateBase
    {
        private const decimal LOWER_LIMIT = 200m;

        public BigCompanyState(Company company) : base(company)
        {
        }

        public override void ReceiveEarnings(decimal earnings)
        {
            decimal tax;

            if (Company.NumberOfEmployees > 1)
            {
                tax = 0.1m;
            }
            else
            {
                tax = 0.2m;
            }

            Company.Balance += earnings - earnings * tax;
            Console.WriteLine($"Received earnings! [ Earnings: {earnings}; Tax: {tax * 100}%; Balance: {Company.Balance} ]");

            CheckStateChange();
        }

        public override void PayMonthlyTax()
        {
            decimal tax;

            if (Company.NumberOfEmployees > 1)
            {
                tax = 0.15m;
            }
            else
            {
                tax = 0.25m;
            }

            Company.Balance -= Company.Balance * tax;
            Console.WriteLine($"Paid monthly tax! [ Tax: {tax * 100}%; Balance: {Company.Balance} ]");

            CheckStateChange();
        }

        public override void HireNewEmployee()
        {
            Company.NumberOfEmployees++;

            Console.WriteLine($"New employee hired! [ Number of Employees: {Company.NumberOfEmployees} ]");
        }

        private void CheckStateChange()
        {
            if (Company.Balance < LOWER_LIMIT) Company.SetState(new MediumCompanyState(Company));
        }
    }
}
