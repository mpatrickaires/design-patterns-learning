using Singleton.After.Monostate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.After.Monostate.Pages
{
    public class FeedPage : Page
    {
        public FeedPage(IUserPreferences userPreferences) : base(userPreferences)
        {
        }
    }
}
