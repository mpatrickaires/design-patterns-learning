using Singleton.Before.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton.Before.Pages
{
    public class FeedPage : Page
    {
        public FeedPage() : base(new UserPreferences())
        {
        }
    }
}
