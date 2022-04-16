using Bridge.After.Models.Platforms.Interfaces;

namespace Bridge.After.Models.Applications
{
    public class PrimaryApplication : Application
    {
        public PrimaryApplication(IPlatform platform) : base(platform)
        {
        }

        protected override void Render()
        {
            Console.WriteLine("Rendering Primary Application");
            Platform.DisplayButton();
            Platform.DisplayInput();
        }

        protected override void Notify(string message)
        {
            Platform.DisplayNotification($"[Primary Application] {message}");
        }

    }
}
