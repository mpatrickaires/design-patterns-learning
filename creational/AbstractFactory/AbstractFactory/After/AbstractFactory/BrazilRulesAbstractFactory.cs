using AbstractFactory.After.Models.Invoice;
using AbstractFactory.After.Models.LicensePlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.After.AbstractFactory
{
    internal class BrazilRulesAbstractFactory : ICountryRulesAbstractFactory
    {
        public IInvoice CreateInvoice()
        {
            return new BrazilInvoice();
        }

        public ILicensePlate CreateLicensePlate()
        {
            return new BrazilLicensePlate();
        }
    }
}
