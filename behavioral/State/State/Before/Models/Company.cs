namespace State.Before.Models
{
    public class Company
    {
        private decimal _balance;
        private int _numberOfEmployees;

        public void ReceiveEarnings(decimal earnings)
        {
            Console.WriteLine("Receiving earnings...");

            decimal tax;
            if (_balance < 100)
            {
                tax = 0;
            }
            else if (_balance < 200)
            {
                if (_numberOfEmployees > 0)
                {
                    tax = 0.05M;
                }
                else
                {
                    tax = 0.1M;
                }
            }
            else
            {
                if (_numberOfEmployees > 1)
                {
                    tax = 0.1M;
                }
                else
                {
                    tax = 0.2M;
                }
            }

            _balance += earnings - earnings * tax;

            Console.WriteLine($"Received earnings! [ Earnings: {earnings}; Tax: {tax * 100}%; Balance: {_balance} ]");
            Console.WriteLine();
        }

        public void PayMonthlyTax()
        {
            Console.WriteLine("Paying monthly tax...");

            decimal tax;
            if (_balance < 100)
            {
                Console.WriteLine("Companies with balance less than 100 don't need to pay monthly tax!");
                Console.WriteLine();
                return;
            }
            else if (_balance < 200)
            {
                if (_numberOfEmployees > 0)
                {
                    tax = 0M;
                }
                else
                {
                    tax = 0.05M;
                }
            }
            else
            {
                if (_numberOfEmployees > 1)
                {
                    tax = 0.15M;
                }
                else
                {
                    tax = 0.25M;
                }
            }

            _balance -= _balance * tax;

            Console.WriteLine($"Paid monthly tax! [ Tax: {tax * 100}%; Balance: {_balance} ]");
            Console.WriteLine();
        }

        public void HireNewEmployee()
        {
            Console.WriteLine("Hiring new employee...");

            if (_balance < 100)
            {
                if (_numberOfEmployees > 0)
                {
                    Console.WriteLine($"Companies with balance less than 100 can have only 1 employee!");
                    Console.WriteLine();
                    return;
                }
                _numberOfEmployees++;
            }
            else if (_balance < 200)
            {
                if (_numberOfEmployees > 1)
                {
                    Console.WriteLine($"Companies with balance less than 200 can have only 2 employees!");
                    Console.WriteLine();
                    return;
                }
                _numberOfEmployees++;
            }
            else
            {
                _numberOfEmployees++;
            }

            Console.WriteLine($"New employee hired! [Number of Employees: {_numberOfEmployees}]");
            Console.WriteLine();
        }
    }
}
