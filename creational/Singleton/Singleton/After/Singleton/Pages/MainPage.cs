using Singleton.After.Singleton.Models;
using Singleton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After.Singleton.Pages
{
    public class MainPage : Page
    {
        public MainPage() : base(UserPreferences.GetInstance())
        {
        }
    }
}
