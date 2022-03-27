using Singleton.Before.Models;

namespace Singleton.Before.Pages
{
    public class MainPage : Page
    {
        public MainPage() : base(new UserPreferences())
        {
        }
    }
}
