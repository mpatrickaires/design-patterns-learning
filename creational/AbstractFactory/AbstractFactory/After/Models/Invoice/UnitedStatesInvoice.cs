using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.After.Models.Invoice
{
    public class UnitedStatesInvoice : IInvoice
    {
        public void PrintInvoice()
        {
            Console.WriteLine("Printing United States invoice");
        }
    }
}
