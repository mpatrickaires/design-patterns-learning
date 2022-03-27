using Singleton.After.Singleton.Models;

namespace Singleton.After.Singleton.Pages
{
    public class FeedPage : Page
    {
        public FeedPage() : base(UserPreferences.GetInstance())
        {
        }
    }
}
