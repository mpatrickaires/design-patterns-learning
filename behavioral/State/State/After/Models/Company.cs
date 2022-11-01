using State.After.States;

namespace State.After.Models
{
    public class Company
    {
        private StateBase _state;
        public decimal Balance { get; set; }
        public int NumberOfEmployees { get; set; }

        public Company()
        {
            SetState(new SmallCompanyState(this));
        }

        public void SetState(StateBase state)
        {
            Console.WriteLine($"Changing to state {state.GetType().Name}");
            _state = state;
        }

        public void ReceiveEarnings(decimal earnings)
        {
            Console.WriteLine("Receiving earnings...");
            _state.ReceiveEarnings(earnings);
            Console.WriteLine();
        }

        public void PayMonthlyTax()
        {
            Console.WriteLine("Paying monthly tax...");
            _state.PayMonthlyTax();
            Console.WriteLine();
        }

        public void HireNewEmployee()
        {
            Console.WriteLine("Hiring new employee...");
            _state.HireNewEmployee();
            Console.WriteLine();
        }
    }
}
