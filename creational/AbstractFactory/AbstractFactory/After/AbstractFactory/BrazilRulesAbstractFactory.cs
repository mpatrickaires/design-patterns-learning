using AbstractFactory.After.Models.Invoice;
using AbstractFactory.After.Models.LicensePlate;

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
