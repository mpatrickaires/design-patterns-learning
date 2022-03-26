using Singleton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
