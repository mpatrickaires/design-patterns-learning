namespace AbstractFactory.Before.Models.Invoice
{
    public class UnitedStatesInvoice : IInvoice
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Printing United States invoice");
        }
    }
}
