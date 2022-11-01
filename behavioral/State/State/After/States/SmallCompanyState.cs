using State.After.Models;

namespace State.After.States
{
    public class SmallCompanyState : StateBase
    {
        private const decimal UPPER_LIMIT = 100m;

        public SmallCompanyState(Company company) : base(company)
        {
        }

        public override void ReceiveEarnings(decimal earnings)
        {
            Company.Balance += earnings;
            Console.WriteLine($"Received earnings! [ Earnings: {earnings}; Tax: {0}%; Balance: {Company.Balance} ]");

            CheckStateChange();
        }

        public override void PayMonthlyTax()
        {
            Console.WriteLine("Companies with balance less than 100 don't need to pay monthly tax!");
        }

        public override void HireNewEmployee()
        {
            if (Company.NumberOfEmployees > 0)
            {
                Console.WriteLine($"Companies with balance less than {UPPER_LIMIT} can have only 1 employee!");
                Console.WriteLine();
                return;
            }
            Company.NumberOfEmployees++;

            Console.WriteLine($"New employee hired! [ Number of Employees: {Company.NumberOfEmployees} ]");
        }

        private void CheckStateChange()
        {
            if (Company.Balance >= UPPER_LIMIT) Company.SetState(new MediumCompanyState(Company));
        }
    }
}
