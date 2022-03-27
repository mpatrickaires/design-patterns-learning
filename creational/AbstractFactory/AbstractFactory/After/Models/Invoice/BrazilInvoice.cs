namespace AbstractFactory.After.Models.Invoice
{
    public class BrazilInvoice : IInvoice
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Printing Brazilian invoice");
        }
    }
}
