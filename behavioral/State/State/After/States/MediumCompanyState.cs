using State.After.Models;

namespace State.After.States
{
    public class MediumCompanyState : StateBase
    {
        private const decimal UPPER_LIMIT = 200m;
        private const decimal LOWER_LIMIT = 100m;

        public MediumCompanyState(Company company) : base(company)
        {
        }

        public override void ReceiveEarnings(decimal earnings)
        {
            decimal tax;

            if (Company.NumberOfEmployees > 0)
            {
                tax = 0.05m;
            }
            else
            {
                tax = 0.1m;
            }

            Company.Balance += earnings - earnings * tax;
            Console.WriteLine($"Received earnings! [ Earnings: {earnings}; Tax: {tax * 100}%; Balance: {Company.Balance} ]");

            CheckStateChange();
        }

        public override void PayMonthlyTax()
        {
            decimal tax;
            if (Company.NumberOfEmployees > 0)
            {
                tax = 0m;
            }
            else
            {
                tax = 0.05m;
            }

            Company.Balance -= Company.Balance * tax;

            Console.WriteLine($"Paid monthly tax! [ Tax: {tax * 100}%; Balance: {Company.Balance} ]");
        }

        public override void HireNewEmployee()
        {
            if (Company.NumberOfEmployees > 1)
            {
                Console.WriteLine($"Companies with balance less than 200 can have only 2 employees!");
                Console.WriteLine();
                return;
            }
            Company.NumberOfEmployees++;

            Console.WriteLine($"New employee hired! [ Number of Employees: {Company.NumberOfEmployees} ]");
        }

        private void CheckStateChange()
        {
            if (Company.Balance >= UPPER_LIMIT) Company.SetState(new BigCompanyState(Company));
            else if (Company.Balance < LOWER_LIMIT) Company.SetState(new SmallCompanyState(Company));
        }
    }
}
