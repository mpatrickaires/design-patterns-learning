﻿namespace AbstractFactory.After.Models.LicensePlate
{
    internal class BrazilLicensePlate : ILicensePlate
    {
        public void InstallLicensePlate()
        {
            Console.WriteLine("Installing Brazilian license plate");
        }
    }
}
