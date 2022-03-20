using AbstractFactory.After.Models.Invoice;
using AbstractFactory.After.Models.LicensePlate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.After.AbstractFactory
{
    public interface ICountryRulesAbstractFactory
    {
        IInvoice CreateInvoice();
        ILicensePlate CreateLicensePlate();
    }
}
