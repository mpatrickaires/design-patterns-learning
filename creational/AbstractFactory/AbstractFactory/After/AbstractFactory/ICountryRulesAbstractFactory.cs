using AbstractFactory.After.Models.Invoice;
using AbstractFactory.After.Models.LicensePlate;

namespace AbstractFactory.After.AbstractFactory
{
    public interface ICountryRulesAbstractFactory
    {
        IInvoice CreateInvoice();
        ILicensePlate CreateLicensePlate();
    }
}
