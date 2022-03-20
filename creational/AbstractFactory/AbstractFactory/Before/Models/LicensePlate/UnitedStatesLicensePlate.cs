using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Before.Models.LicensePlate
{
    internal class UnitedStatesLicensePlate : ILicensePlate
    {
        public void InstallLicensePlate()
        {
            Console.WriteLine("Installing United States license plate");
        }
    }
}
