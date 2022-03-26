using Singleton.Before.Models;
using Singleton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Before.Pages
{
    public class MainPage : Page
    {
        public MainPage() : base(new UserPreferences())
        {
        }
    }
}
