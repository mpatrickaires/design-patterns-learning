using AbstractFactory.After.Models.Invoice;
using AbstractFactory.After.Models.LicensePlate;

namespace AbstractFactory.After.AbstractFactory
{
    internal class UnitedStatesRulesAbstractFactory : ICountryRulesAbstractFactory
    {
        public IInvoice CreateInvoice()
        {
            return new UnitedStatesInvoice();
        }

        public ILicensePlate CreateLicensePlate()
        {
            return new UnitedStatesLicensePlate();
        }
    }
}
