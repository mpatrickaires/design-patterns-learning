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
