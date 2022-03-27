using Singleton.Enums;

namespace Singleton.After.Singleton.Models
{
    public class UserPreferences
    {
        private static UserPreferences _instance;

        // It can also be created like that if the language supports:
        // private static UserPreferences _instance = new UserPreferences(); 

        public Theme Theme { get; set; }
        public int FontSize { get; set; }

        private UserPreferences()
        {
            // Sets the default configurations of the application
            Theme = Theme.Light;
            FontSize = 12;
        }

        public static UserPreferences GetInstance()
        {
            if (_instance == null)
            {
                _instance = new UserPreferences();
            }

            return _instance;
        }

        public void GetPreferences()
        {
            Console.WriteLine($"Theme: {Theme}");
            Console.WriteLine($"Font Size: {FontSize}");
        }
    }
}
