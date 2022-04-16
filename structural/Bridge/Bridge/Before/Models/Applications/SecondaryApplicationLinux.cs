using Bridge.Before.Models.Platforms;

namespace Bridge.Before.Models.Applications
{
    public class SecondaryApplicationLinux : Application
    {
        private readonly Linux _linux = new Linux();
        protected override void Render()
        {
            Console.WriteLine("Rendering Secondary Application");
            _linux.DisplayButton();
            _linux.DisplayButton();
        }

        protected override void Notify(string message)
        {
            _linux.DisplayNotification($"[Secondary Application] {message}");
        }
    }
}
