using Singleton.Before.Models;

namespace Singleton.Before.Pages
{
    public abstract class Page
    {
        public UserPreferences UserPreferences { get; set; }

        public Page(UserPreferences userPreferences)
        {
            // Every page needs the UserPreferences to load the style based on it
            UserPreferences = userPreferences;
        }

        public void LoadStyle()
        {
            UserPreferences.GetPreferences();
        }
    }
}
