using Bridge.After.Models.Platforms.Interfaces;

namespace Bridge.After.Models.Applications
{
    public class SecondaryApplication : Application
    {
        public SecondaryApplication(IPlatform platform) : base(platform)
        {
        }

        protected override void Render()
        {
            Console.WriteLine("Rendering Secondary Application");
            Platform.DisplayButton();
            Platform.DisplayButton();
        }

        protected override void Notify(string message)
        {
            Platform.DisplayNotification($"[Secondary Application] {message}");
        }

    }
}
