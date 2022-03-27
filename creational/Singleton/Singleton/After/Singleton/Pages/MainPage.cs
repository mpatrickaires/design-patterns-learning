using Singleton.After.Singleton.Models;

namespace Singleton.After.Singleton.Pages
{
    public class MainPage : Page
    {
        public MainPage() : base(UserPreferences.GetInstance())
        {
        }
    }
}
