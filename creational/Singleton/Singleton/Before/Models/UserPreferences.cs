using Singleton.Enums;

namespace Singleton.Before.Models
{
    public class UserPreferences
    {
        public Theme Theme { get; set; }
        public int FontSize { get; set; }

        public UserPreferences()
        {
            // Sets the default configurations of the application
            Theme = Theme.Light;
            FontSize = 12;
        }

        public void GetPreferences()
        {
            Console.WriteLine($"Theme: {Theme}");
            Console.WriteLine($"Font Size: {FontSize}");
        }
    }
}
