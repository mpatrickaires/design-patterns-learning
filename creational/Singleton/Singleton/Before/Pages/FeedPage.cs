using Singleton.Before.Models;

namespace Singleton.Before.Pages
{
    public class FeedPage : Page
    {
        public FeedPage() : base(new UserPreferences())
        {
        }
    }
}
