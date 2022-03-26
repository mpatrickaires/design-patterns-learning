using Singleton.After.Monostate.Models;
using Singleton.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After.Monostate.Pages
{
    public abstract class Page
    {
        public IUserPreferences UserPreferences { get; set; }

        public Page(IUserPreferences userPreferences)
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
