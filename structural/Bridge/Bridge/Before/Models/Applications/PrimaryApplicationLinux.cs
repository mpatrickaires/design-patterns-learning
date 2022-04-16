using Bridge.Before.Models.Platforms;

namespace Bridge.Before.Models.Applications
{
    public class PrimaryApplicationLinux : Application
    {
        private readonly Linux _linux = new Linux();

        protected override void Render()
        {
            Console.WriteLine("Rendering Primary Application");
            _linux.DisplayButton();
            _linux.DisplayInput();
        }

        protected override void Notify(string message)
        {
            _linux.DisplayNotification($"[Primary Application] {message}");
        }
    }
}
