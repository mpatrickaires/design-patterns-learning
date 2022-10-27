using State.Before.Models;

namespace State.Before
{
    public static class ClientBefore
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
        }
    }
}
