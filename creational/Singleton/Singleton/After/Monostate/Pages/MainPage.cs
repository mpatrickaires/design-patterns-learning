using Singleton.After.Monostate.Models;
using Singleton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After.Monostate.Pages
{
    public class MainPage : Page
    {
        public MainPage(IUserPreferences userPreferences) : base(userPreferences)
        {
        }
    }
}
