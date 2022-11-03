using State.Before.Models;

/*
 * Let's say you are developing an application which will manage some aspects of a company. In this management, you'll have a routine for
 * the company to receive earnings while applying the necessary taxes. However, there are some taxes that need to be paid over the earning; the
 * percentage of those taxes will vary based on the company's balance and number of employees; and that's not all, there is still a monthly tax
 * that needs to be paid, also varying its value based on the same previous factors, having one case where it may not even need to be paid. 
 * Hang on, there's more! The company can also hire new employees, however, it also has limitations in the quantity it can have hired
 * while in the range of a balance.
 * Whew, that's a lot, right? How do we even manage to fit all those restrictions and conditions in the code? The most obvious and easy way 
 * surely is using a lot of 'ifs', and that's exactly what was done at the Company class. Those 'ifs' need to check the internal properties
 * of the Company class and take decisions based on their values, however there is too many conditions to keep track of and there is the 
 * possibility of more properties coming to play or for new taxes changes or inclusion to appear.
 * 
 * We can aim to solve this scenario by taking advantage of the State pattern, so let's take a look!
 */

namespace State.Before
{
    public static class ClientBefore
    {
        public static void Run()
        {
            Console.WriteLine("== Before ==");

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
